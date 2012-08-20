'http://www.tek-tips.com/faqs.cfm?fid=6320

Imports System.Data
Imports System.IO
Imports MediaPortal.Configuration



Public Class Settings
    Public Shared Property MovingPicturesDB() As String
        Get
            Dim _MovPicDB As String = Config.GetFile(Config.Dir.Database, "movingpictures.db3")

            If String.IsNullOrEmpty(Settings.GetSetting("MovingPicturesDatabase")) Then
                MyLog.Warn("MovingPicturesDatabase not found in settings.xml -> {0}", _MovPicDB)
                Settings.SetSetting("MovingPicturesDatabase", _MovPicDB)
                Return _MovPicDB
            Else
                If File.Exists(Settings.GetSetting("MovingPicturesDatabase")) Then
                    Return Settings.GetSetting("MovingPicturesDatabase")
                Else
                    Settings.SetSetting("MovingPicturesDatabase", _MovPicDB)
                    Return _MovPicDB
                End If
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("MovingPicturesDatabase", value)
        End Set
    End Property
    Public Shared Property CoverFilename() As String
        Get
            Dim _standardCoverFilename As String = "folder.jpg"

            If String.IsNullOrEmpty(Settings.GetSetting("CoverFilename")) Then
                Settings.SetSetting("CoverFilename", _standardCoverFilename)
                Return _standardCoverFilename
            Else
                Return Settings.GetSetting("CoverFilename")
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("CoverFilename", value)
        End Set
    End Property
    Public Shared Property FanArtFilename() As String
        Get
            Dim _standardFanArtFilename As String = "backdrop.jpg"

            If String.IsNullOrEmpty(Settings.GetSetting("FanArtFilename")) Then
                Settings.SetSetting("FanArtFilename", _standardFanArtFilename)
                Return _standardFanArtFilename
            Else
                Return Settings.GetSetting("FanArtFilename")
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("FanArtFilename", value)
        End Set
    End Property
    Public Shared Property WorkingPath() As String
        Get
            Dim _standardFanArtFilename As String = "backdrop.jpg"

            If String.IsNullOrEmpty(Settings.GetSetting("WorkingPath")) = True Then
                Return ""
            Else
                Return Settings.GetSetting("WorkingPath")
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("WorkingPath", value)
        End Set
    End Property

    Public Shared Property ExportNfoFile() As Boolean
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportNfoFile")) = True Then
                Return False
            Else
                Return CBool(Settings.GetSetting("ExportNfoFile"))
            End If

        End Get
        Set(ByVal value As Boolean)
            Settings.SetSetting("ExportNfoFile", CStr(value))
        End Set
    End Property
    Public Shared Property ExportNfoFileName() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportNfoFileName")) = True Then
                Return "%Filename%.nfo"
            Else
                Return Settings.GetSetting("ExportNfoFileName")
            End If
        End Get
        Set(ByVal value As String)
            Settings.SetSetting("ExportNfoFileName", value)
        End Set
    End Property

    Public Shared Property ExportWatchStatus() As Boolean
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportWatchStatus")) = True Then
                Return False
            Else
                Return CBool(Settings.GetSetting("ExportWatchStatus"))
            End If

        End Get
        Set(ByVal value As Boolean)
            Settings.SetSetting("ExportWatchStatus", CStr(value))
        End Set
    End Property
    Public Shared Property ExportWatchedStatusFileName() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportWatchedStatusFileName")) = True Then
                Return "%Filename%.WatchStatus.xml"
            Else
                Return Settings.GetSetting("ExportWatchedStatusFileName")
            End If
        End Get
        Set(ByVal value As String)
            Settings.SetSetting("ExportWatchedStatusFileName", value)
        End Set
    End Property

    Public Shared Property ExportCoverFile() As Boolean
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportCoverFile")) = True Then
                Return False
            Else
                Return CBool(Settings.GetSetting("ExportCoverFile"))
            End If

        End Get
        Set(ByVal value As Boolean)
            Settings.SetSetting("ExportCoverFile", CStr(value))
        End Set
    End Property
    Public Shared Property ExportCoverFileName() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportCoverFileName")) = True Then
                Return "folder.jpg"
            Else
                Return Settings.GetSetting("ExportCoverFileName")
            End If
        End Get
        Set(ByVal value As String)
            Settings.SetSetting("ExportCoverFileName", value)
        End Set
    End Property

    Public Shared Property ExportFanArtFile() As Boolean
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportFanArtFile")) = True Then
                Return False
            Else
                Return CBool(Settings.GetSetting("ExportFanArtFile"))
            End If

        End Get
        Set(ByVal value As Boolean)
            Settings.SetSetting("ExportFanArtFile", CStr(value))
        End Set
    End Property
    Public Shared Property ExportFanArtFileName() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportFanArtFileName")) = True Then
                Return "backdrop.jpg"
            Else
                Return Settings.GetSetting("ExportFanArtFileName")
            End If
        End Get
        Set(ByVal value As String)
            Settings.SetSetting("ExportFanArtFileName", value)
        End Set
    End Property

    Public Shared Property ImportWatchStatus() As Boolean
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ImportWatchStatus")) = True Then
                Return False
            Else
                Return CBool(Settings.GetSetting("ImportWatchStatus"))
            End If

        End Get
        Set(ByVal value As Boolean)
            Settings.SetSetting("ImportWatchStatus", CStr(value))
        End Set
    End Property
    Public Shared Property ImportWatchedStatusFileName() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ImportWatchedStatusFileName")) = True Then
                Return "%Filename%.WatchStatus.xml"
            Else
                Return Settings.GetSetting("ImportWatchedStatusFileName")
            End If
        End Get
        Set(ByVal value As String)
            Settings.SetSetting("ImportWatchedStatusFileName", value)
        End Set
    End Property


    Public Shared Property ExportImDbFile() As Boolean
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportImDbFile")) = True Then
                Return False
            Else
                Return CBool(Settings.GetSetting("ExportImDbFile"))
            End If

        End Get
        Set(ByVal value As Boolean)
            Settings.SetSetting("ExportImDbFile", CStr(value))
        End Set
    End Property

    Public Shared Property ExportImDbFileName() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("ExportImDbFileName")) = True Then
                Return "imdbid.txt"
            Else
                Return Settings.GetSetting("ExportImDbFileName")
            End If
        End Get
        Set(ByVal value As String)
            Settings.SetSetting("ExportImDbFileName", value)
        End Set
    End Property

    Public Shared Function GetSetting(ByVal Key As String) As String

        Dim sReturn As String = String.Empty
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.StartupPath & "\MovPicNFO.Settings.xml") Then
            dsSettings.ReadXml(Application.StartupPath & "\MovPicNFO.Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("Settings").Select("Key = '" & Key & "'")
        If dr.Length = 1 Then sReturn = dr(0)("Value").ToString

        Return sReturn
    End Function
    Public Shared Sub SetSetting(ByVal Key As String, ByVal Value As String)
        Dim dsSettings As New DataSet
        If System.IO.File.Exists(Application.StartupPath & "\MovPicNFO.Settings.xml") Then
            dsSettings.ReadXml(Application.StartupPath & "\MovPicNFO.Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables(0).Select("Key = '" & Key & "'")
        If dr.Length = 1 Then
            dr(0)("Value") = Value
        Else
            Dim drSetting As DataRow = dsSettings.Tables("Settings").NewRow
            drSetting("Key") = Key
            drSetting("Value") = Value
            dsSettings.Tables("Settings").Rows.Add(drSetting)
        End If
        dsSettings.WriteXml(Application.StartupPath & "\MovPicNFO.Settings.xml")
    End Sub

    Public Shared Property WorkingPath1() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("WorkingPath1")) = True Then
                Return ""
            Else
                Return Settings.GetSetting("WorkingPath1")
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("WorkingPath1", value)
        End Set
    End Property
    Public Shared Property WorkingPath2() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("WorkingPath2")) = True Then
                Return ""
            Else
                Return Settings.GetSetting("WorkingPath2")
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("WorkingPath2", value)
        End Set
    End Property
    Public Shared Property WorkingPath3() As String
        Get
            If String.IsNullOrEmpty(Settings.GetSetting("WorkingPath3")) = True Then
                Return ""
            Else
                Return Settings.GetSetting("WorkingPath3")
            End If

        End Get
        Set(ByVal value As String)
            Settings.SetSetting("WorkingPath3", value)
        End Set
    End Property


End Class