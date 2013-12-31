#Region "Copyright (C) 2005-2011 Team MediaPortal"

' Copyright (C) 2005-2011 Team MediaPortal
' http://www.team-mediaportal.com
' 
' MediaPortal is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 2 of the License, or
' (at your option) any later version.
' 
' MediaPortal is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#End Region

Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading

Imports MediaPortal.Database
Imports SQLite.NET

Public Class MovingPicturesDB
    Implements IDisposable

#Region "Members"
    Private disposed As Boolean = False
    Private Shared m_db As SQLiteClient = Nothing
    Private Shared _MovingPicturesInfos As SQLiteResultSet
    Private Shared _MovingPicturesWatchStatus As SQLiteResultSet
    Private _MovingPicturesID As Integer
    Private Shared _Index As Integer
#End Region

#Region "Constructors"
    Public Sub New()
        OpenMovingPicturesDB()
    End Sub

    <MethodImpl(MethodImplOptions.Synchronized)> _
    Private Sub OpenMovingPicturesDB()
        Try
            ' Maybe called by an exception
            If m_db IsNot Nothing Then
                Try
                    m_db.Close()
                    m_db.Dispose()
                    MyLog.Debug("[OpenMovingPicturesDB]: Disposing current instance..")
                Catch generatedExceptionName As Exception
                End Try
            End If


            ' Open database
            If File.Exists(Settings.MovingPicturesDB) = True Then

                m_db = New SQLiteClient(Settings.MovingPicturesDB)
                ' Retry 10 times on busy (DB in use or system resources exhausted)
                m_db.BusyRetries = 20
                ' Wait 100 ms between each try (default 10)
                m_db.BusyRetryDelay = 1000

                DatabaseUtility.SetPragmas(m_db)
            Else
                MyLog.[Error]("[OpenMovingPicturesDB]: MovingPictures Database not found: {0}", Settings.MovingPicturesDB)
            End If


        Catch ex As Exception
            MyLog.[Error]("[OpenMovingPicturesDB]: MovingPictures Database exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
            OpenMovingPicturesDB()
        End Try
        'Mylog.Info("picture database opened")
    End Sub

    Public Sub LoadAllMovingPicturesFilms()

        Try
            _MovingPicturesInfos = m_db.Execute("SELECT * FROM movie_info ORDER BY title ASC")
        Catch ex As Exception
            MyLog.[Error]("[LoadAllMovingPicturesFilms]: exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
            OpenMovingPicturesDB()
        End Try

    End Sub

    Public Sub LoadMovieInfos(ByVal idMovPic As Integer)

        Try
            _MovingPicturesInfos = m_db.Execute("SELECT * FROM movie_info WHERE id = " & idMovPic)

        Catch ex As Exception
            MyLog.[Error]("[LoadMovieInfos]: exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
            OpenMovingPicturesDB()
        End Try

    End Sub

    Public Sub UpdateWatchStatus(ByVal idMovie As Integer, ByVal watched As Boolean)
        Try
            Dim _user_movie_settings_id As Integer
            Dim value As Integer = 0

            _MovingPicturesWatchStatus = m_db.Execute("Select * FROM movie_info__user_movie_settings WHERE movie_info_id = " & idMovie)

            If _MovingPicturesWatchStatus IsNot Nothing AndAlso _MovingPicturesWatchStatus.Rows.Count > 0 Then
                _user_movie_settings_id = DatabaseUtility.[Get](_MovingPicturesWatchStatus, 0, "user_movie_settings_id")
            Else
                Exit Sub
            End If

            If watched = True Then
                value = 1
            End If

            m_db.Execute("UPDATE user_movie_settings SET watched = " & value & " WHERE id = " & _user_movie_settings_id)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Properties"
    Public ReadOnly Property Count() As Integer
        Get
            If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                Return _MovingPicturesInfos.Rows.Count
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property WatchStatus(ByVal idMovPic As Integer) As Boolean
        Get
            Try
                _MovingPicturesWatchStatus = m_db.Execute("SELECT * FROM movie_info__user_movie_settings INNER JOIN user_movie_settings ON movie_info__user_movie_settings.user_movie_settings_id = user_movie_settings.id WHERE movie_info__user_movie_settings.movie_info_id = " & idMovPic)
            Catch ex As Exception
                MyLog.[Error]("[LoadMovieWatchStatus]: exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
                MsgBox(ex.Message)
                OpenMovingPicturesDB()
            End Try

            If _MovingPicturesWatchStatus IsNot Nothing AndAlso _MovingPicturesWatchStatus.Rows.Count > 0 Then
                Return CBool(DatabaseUtility.[Get](_MovingPicturesWatchStatus, 0, "watched"))
            Else
                Return False
            End If

        End Get
    End Property

    'Get DBFields over Index
    Private _Item As New MovingPicturesItem
    Default Public ReadOnly Property MovingPictures(ByVal Index As Integer) As MovingPicturesItem
        Get
            _Index = Index
            Return _Item
        End Get
    End Property
    Public Class MovingPicturesItem
        Public ReadOnly Property MovingPicturesID() As Integer
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return CInt(DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "id"))
                Else
                    Return 0
                End If
            End Get
        End Property
        Public ReadOnly Property Title() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "title")
                Else
                    Return String.Empty
                End If
            End Get
        End Property

        Public ReadOnly Property Cover() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then

                    Dim _Cover As String = DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "coverfullpath")
                    If _Cover.Length > 0 Then
                        Return _Cover
                    Else
                        Return String.Empty
                    End If

                Else
                    Return String.Empty
                End If
            End Get
        End Property

        Public ReadOnly Property FanArt() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Dim _FanArt As String = DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "backdropfullpath")
                    If _FanArt.Length > 0 Then
                        Return _FanArt
                    Else
                        Return String.Empty
                    End If
                Else
                    Return String.Empty
                End If
            End Get
        End Property

        Public ReadOnly Property AlternateTitle() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return Replace(DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "alternate_titles"), "|", "")
                Else
                    Return String.Empty
                End If
            End Get
        End Property

        Public ReadOnly Property TitlebyFilename() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Dim _idMovie_Info As Integer = CInt(DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "id"))
                    Dim _MovingPicturesTitleOverFilename As SQLiteResultSet


                    _MovingPicturesTitleOverFilename = m_db.Execute("SELECT * FROM local_media INNER JOIN local_media__movie_info ON local_media.id = local_media__movie_info.local_media_id WHERE movie_info_id = " & _idMovie_Info)
                    If _MovingPicturesTitleOverFilename IsNot Nothing AndAlso _MovingPicturesTitleOverFilename.Rows.Count > 0 Then
                        Return IO.Path.GetFileNameWithoutExtension(DatabaseUtility.[Get](_MovingPicturesTitleOverFilename, 0, "fullpath"))
                    Else
                        Return String.Empty
                    End If
                Else
                    Return String.Empty
                End If
            End Get
        End Property

        Public ReadOnly Property Rating() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "score")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property sortby() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "sortby")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property year() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "year")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property summary() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "summary")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property tagline() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "tagline")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property runtime() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "runtime")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property certification() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "certification")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property language() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "language")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property imdb_id() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "imdb_id")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property genre() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "genres")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property directors() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "directors")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property Actors() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "actors")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property studios() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "studios")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property writers() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "writers")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property originaltitle() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "alternate_titles")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property popularity() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Return DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "popularity")
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property MovieFolder() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Dim _idMovie_Info As Integer = CInt(DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "id"))
                    Dim _MovingPicturesTitleOverFilename As SQLiteResultSet


                    _MovingPicturesTitleOverFilename = m_db.Execute("SELECT * FROM local_media INNER JOIN local_media__movie_info ON local_media.id = local_media__movie_info.local_media_id WHERE movie_info_id = " & _idMovie_Info)
                    If _MovingPicturesTitleOverFilename IsNot Nothing AndAlso _MovingPicturesTitleOverFilename.Rows.Count > 0 Then
                        Return IO.Path.GetDirectoryName(DatabaseUtility.[Get](_MovingPicturesTitleOverFilename, 0, "fullpath"))
                    Else
                        Return String.Empty
                    End If
                Else
                    Return String.Empty
                End If
            End Get
        End Property
        Public ReadOnly Property MovieFileName() As String
            Get
                If _MovingPicturesInfos IsNot Nothing AndAlso _MovingPicturesInfos.Rows.Count > 0 Then
                    Dim _idMovie_Info As Integer = CInt(DatabaseUtility.[Get](_MovingPicturesInfos, _Index, "id"))
                    Dim _MovingPicturesTitleOverFilename As SQLiteResultSet


                    _MovingPicturesTitleOverFilename = m_db.Execute("SELECT * FROM local_media INNER JOIN local_media__movie_info ON local_media.id = local_media__movie_info.local_media_id WHERE movie_info_id = " & _idMovie_Info)
                    If _MovingPicturesTitleOverFilename IsNot Nothing AndAlso _MovingPicturesTitleOverFilename.Rows.Count > 0 Then
                        Return IO.Path.GetFileName(DatabaseUtility.[Get](_MovingPicturesTitleOverFilename, 0, "fullpath"))
                    Else
                        Return String.Empty
                    End If
                Else
                    Return String.Empty
                End If
            End Get
        End Property


    End Class


#End Region

#Region "IDisposable Members"

    Public Sub Dispose() Implements IDisposable.Dispose
        If Not disposed Then
            disposed = True
            If m_db IsNot Nothing Then
                Try
                    m_db.Close()
                    m_db.Dispose()
                Catch generatedExceptionName As Exception
                End Try
                m_db = Nothing
            End If
        End If
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

#End Region

End Class
