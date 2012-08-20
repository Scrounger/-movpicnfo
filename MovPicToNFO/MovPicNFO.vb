Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Drawing

Imports MediaPortal.Database
Imports MediaPortal.Configuration
Imports SQLite.NET
Imports System.Xml


Public Class MovPicNFO

#Region "Members"
    Private _MovieDict As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MyLog.Info("------- MovPicNFO started -------")

            LabelVersion.Text = "Version: " & Application.ProductVersion

            LoadSettings()


        Catch ex As Exception

        End Try
    End Sub


#Region "Functions"
    Private Sub CreateNfoFile(ByVal filename As String, ByVal idMovie As Integer)
        Try

            If File.Exists(filename) Then
                File.Delete(filename)
            End If

            Dim XmlDoc As New XmlDocument

            'Write down the XML declaration
            Dim XmlDeclaration As XmlDeclaration = XmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)

            'Create the root element
            Dim RootNode As XmlElement = XmlDoc.CreateElement("movie")
            XmlDoc.InsertBefore(XmlDeclaration, XmlDoc.DocumentElement)
            XmlDoc.AppendChild(RootNode)

            'Create the required nodes
            Dim title As XmlElement = XmlDoc.CreateElement("title")
            Dim sorttitle As XmlElement = XmlDoc.CreateElement("sorttitle")
            Dim studios As XmlElement = XmlDoc.CreateElement("studios")
            Dim rating As XmlElement = XmlDoc.CreateElement("rating")
            Dim year As XmlElement = XmlDoc.CreateElement("year")
            Dim plot As XmlElement = XmlDoc.CreateElement("plot")
            Dim tagline As XmlElement = XmlDoc.CreateElement("tagline")
            Dim runtime As XmlElement = XmlDoc.CreateElement("runtime")
            Dim mpaa As XmlElement = XmlDoc.CreateElement("mpaa")
            Dim language As XmlElement = XmlDoc.CreateElement("language")
            Dim id As XmlElement = XmlDoc.CreateElement("id")
            Dim genre As XmlElement = XmlDoc.CreateElement("genre")
            Dim director As XmlElement = XmlDoc.CreateElement("director")
            Dim originaltitle As XmlElement = XmlDoc.CreateElement("originaltitle")
            'Dim popularity As XmlElement = XmlDoc.CreateElement("popularity")

            'append the nodes to the parentNode without the value
            RootNode.AppendChild(title)
            RootNode.AppendChild(sorttitle)
            RootNode.AppendChild(originaltitle)
            RootNode.AppendChild(rating)
            RootNode.AppendChild(year)
            RootNode.AppendChild(plot)
            RootNode.AppendChild(tagline)
            RootNode.AppendChild(runtime)
            RootNode.AppendChild(mpaa)
            RootNode.AppendChild(language)
            RootNode.AppendChild(id)
            RootNode.AppendChild(genre)
            RootNode.AppendChild(director)
            RootNode.AppendChild(studios)
            'RootNode.AppendChild(popularity)

            'save the value of the fields into the nodes
            Dim _MovPicDb As New MovingPicturesDB
            _MovPicDb.LoadMovieInfos(idMovie)



            title.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).Title))
            sorttitle.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).sortby))
            originaltitle.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).originaltitle))
            rating.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).Rating))
            year.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).year))
            plot.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).summary))
            tagline.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).tagline))
            runtime.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).runtime))
            mpaa.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).certification))
            language.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).language))
            id.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).imdb_id))
            genre.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).genre))
            director.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).directors))
            studios.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).studios))
            'popularity.AppendChild(XmlDoc.CreateTextNode(_MovPicDb(0).popularity))

            'Schauspieler übertragen
            Dim arrList As New ArrayList(_MovPicDb(0).Actors.Split("|"))

            For i = 0 To arrList.Count - 1
                If Not String.IsNullOrEmpty(arrList(i).ToString) Then
                    'Create a new <Category> element and add it to the root node
                    Dim ParentNode As XmlElement = XmlDoc.CreateElement("actor")

                    'Set attribute name and value!
                    'ParentNode.SetAttribute("actor", "")

                    XmlDoc.DocumentElement.AppendChild(ParentNode)

                    'Create the required nodes
                    Dim Actor As XmlElement = XmlDoc.CreateElement("name")

                    'append the nodes to the parentNode without the value
                    ParentNode.AppendChild(Actor)
                    Actor.AppendChild(XmlDoc.CreateTextNode(arrList(i).ToString))
                End If
            Next

            arrList.Clear()
            arrList.AddRange(_MovPicDb(0).writers.Split("|"))

            For i = 0 To arrList.Count - 1
                If Not String.IsNullOrEmpty(arrList(i).ToString) Then
                    'Create a new <Category> element and add it to the root node
                    Dim ParentNode As XmlElement = XmlDoc.CreateElement("writer")

                    'Set attribute name and value!
                    'ParentNode.SetAttribute("actor", "")

                    XmlDoc.DocumentElement.AppendChild(ParentNode)

                    'Create the required nodes
                    Dim Actor As XmlElement = XmlDoc.CreateElement("name")

                    'append the nodes to the parentNode without the value
                    ParentNode.AppendChild(Actor)
                    Actor.AppendChild(XmlDoc.CreateTextNode(arrList(i).ToString))
                End If
            Next

            'Save to the XML file
            XmlDoc.Save(filename)

            MyLog.Debug("Movie Info file created-> {0}", filename)
            _MovPicDb.Dispose()

            Dim _File As New FileInfo(filename)

            If _File.Length < 500 Then
                MyLog.Warn("{0} < 500 byte: {1}", Path.GetFileName(filename), filename)
            End If
        Catch ex As Exception
            MyLog.Error("[CreateNfoFile] Exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub CreateImDbTextFile(ByVal filename As String, ByVal idMovie As Integer)
        Try
            If File.Exists(filename) Then
                File.Delete(filename)
            End If

            Dim _MovPicDb As New MovingPicturesDB
            _MovPicDb.LoadMovieInfos(idMovie)

            File.AppendAllText(filename, _MovPicDb(0).imdb_id)

            MyLog.Debug("imdb Info file created -> {0}", filename)
            _MovPicDb.Dispose()
        Catch ex As Exception
            MyLog.Error("[CreateImDbTextFile] Exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub CreateWatchStatusFile(ByVal filename As String, ByVal idMovie As Integer)
        Try

            Dim XmlDoc As New XmlDocument

            'Write down the XML declaration
            Dim XmlDeclaration As XmlDeclaration = XmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)

            'Create the root element
            Dim RootNode As XmlElement = XmlDoc.CreateElement("movie")
            XmlDoc.InsertBefore(XmlDeclaration, XmlDoc.DocumentElement)
            XmlDoc.AppendChild(RootNode)

            'Create the required nodes
            Dim watched As XmlElement = XmlDoc.CreateElement("watched")

            'append the nodes to the parentNode without the value
            RootNode.AppendChild(watched)

            'save the value of the fields into the nodes
            Dim _MovPicDb As New MovingPicturesDB

            watched.AppendChild(XmlDoc.CreateTextNode(_MovPicDb.WatchStatus(idMovie)))

            'Save to the XML file
            XmlDoc.Save(filename)

            MyLog.Debug("watch status file created -> {0}", filename)
            _MovPicDb.Dispose()

        Catch ex As Exception
            MyLog.Error("[CreateWatchStatusFile] Exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
        End Try

    End Sub
    Private Sub CopyCover(ByVal filename As String, ByVal idMovie As Integer)
        Try

            If File.Exists(filename) Then
                File.Delete(filename)
            End If

            'save the value of the fields into the nodes
            Dim _MovPicDb As New MovingPicturesDB

            File.Copy(_MovPicDb(0).Cover, filename, True)

            MyLog.Debug("Cover copied -> {0}", filename)
            _MovPicDb.Dispose()
        Catch ex As Exception
            MyLog.Error("[CopyCover] Exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub CopyFanArt(ByVal filename As String, ByVal idMovie As Integer)
        Try

            If File.Exists(filename) Then
                File.Delete(filename)
            End If

            'save the value of the fields into the nodes
            Dim _MovPicDb As New MovingPicturesDB

            File.Copy(_MovPicDb(0).FanArt, filename, True)

            MyLog.Debug("Cover copied -> {0}", filename)
            _MovPicDb.Dispose()
        Catch ex As Exception
            MyLog.Error("[CopyFanArt] Exception err:{0} stack:{1}", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub getImagesFromMovieFolder(ByVal CoverFileName As String, ByVal FanArtFileName As String)

        If File.Exists(MovieFolder.Text & "\" & CoverFileName) Then
            'Cover Stream übergeben
            Dim CoverImgStream As New IO.MemoryStream
            Helper.CreateCloneImage(MovieFolder.Text & "\" & CoverFileName).Save(CoverImgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.CoverImageMovieFolder.Image = System.Drawing.Image.FromStream(CoverImgStream)
            CoverImgStream.Dispose()
            'Formatierung + Tag
            Me.CoverImageMovieFolder.Tag = MovieFolder.Text & "\" & CoverFileName
            Me.CoverImageMovieFolder.SizeMode = PictureBoxSizeMode.CenterImage
            Me.CoverImageMovieFolder.SizeMode = PictureBoxSizeMode.Zoom
            Me.MovieCoverMovieFolderSize.Text = Me.CoverImageMovieFolder.Image.Width & "x" & Me.CoverImageMovieFolder.Image.Height
        Else
            Me.CoverImageMovieFolder.Image = Nothing
            Me.CoverImageMovieFolder.Tag = ""
            Me.MovieCoverMovieFolderSize.Text = ""
        End If

        If File.Exists(MovieFolder.Text & "\" & FanArtFileName) Then
            'FanArt Stream übergeben
            Dim BackdropImgStream As New IO.MemoryStream
            Helper.CreateCloneImage(MovieFolder.Text & "\" & FanArtFileName).Save(BackdropImgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.BackdropMovieFolder.Image = System.Drawing.Image.FromStream(BackdropImgStream)
            BackdropImgStream.Dispose()

            'Formatierung + Tag
            Me.BackdropMovieFolder.Tag = MovieFolder.Text & "\" & FanArtFileName
            Me.BackdropMovieFolder.SizeMode = PictureBoxSizeMode.CenterImage
            Me.BackdropMovieFolder.SizeMode = PictureBoxSizeMode.Zoom
            Me.MovieBackdropMovieFolderSize.Text = Me.BackdropMovieFolder.Image.Width & "x" & Me.BackdropMovieFolder.Image.Height
        Else
            Me.BackdropMovieFolder.Image = Nothing
            Me.BackdropMovieFolder.Tag = ""
            Me.MovieBackdropMovieFolderSize.Text = ""
        End If

    End Sub

    Private Sub getMovieInformations(ByVal idMovie As Integer)
        Dim _MovPicDb As New MovingPicturesDB
        _MovPicDb.LoadMovieInfos(idMovie)


        MovieId.Text = idMovie
        MovieTitleLabel.Text = _MovPicDb(0).Title
        MovieFileName.Text = _MovPicDb(0).MovieFileName
        MovieFolder.Text = _MovPicDb(0).MovieFolder
        MovieCoverPath.Text = _MovPicDb(0).Cover
        MovieBackdropPath.Text = _MovPicDb(0).FanArt

        If File.Exists(_MovPicDb(0).Cover) Then
            'Cover Stream, LargeImage + übergeben
            Dim CoverImgStream As New IO.MemoryStream
            Helper.CreateCloneImage(_MovPicDb(0).Cover).Save(CoverImgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.CoverImage.Image = System.Drawing.Image.FromStream(CoverImgStream)
            'LargeImage.ImagePreview.Image = System.Drawing.Image.FromStream(CoverImgStream)
            CoverImgStream.Dispose()

            Me.CoverImage.Tag = _MovPicDb(0).Cover
            Me.CoverImage.SizeMode = PictureBoxSizeMode.CenterImage
            Me.CoverImage.SizeMode = PictureBoxSizeMode.Zoom

            'LargeImage.ImagePreview.SizeMode = PictureBoxSizeMode.CenterImage
            'LargeImage.ImagePreview.SizeMode = PictureBoxSizeMode.Zoom

            MovieImageSize.Text = Me.CoverImage.Image.Width & "x" & Me.CoverImage.Image.Height
        Else
            Me.CoverImage.Image = Nothing
            Me.CoverImage.Tag = ""
            Me.MovieImageSize.Text = ""
        End If

        If File.Exists(_MovPicDb(0).FanArt) Then
            Dim BackdropImgStream As New IO.MemoryStream
            Helper.CreateCloneImage(_MovPicDb(0).FanArt).Save(BackdropImgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.BackdropImage.Image = System.Drawing.Image.FromStream(BackdropImgStream)
            'FanArtImage.FanArtImagePreview.Image = System.Drawing.Image.FromStream(BackdropImgStream)
            BackdropImgStream.Dispose()

            Me.BackdropImage.Tag = _MovPicDb(0).FanArt
            Me.BackdropImage.SizeMode = PictureBoxSizeMode.CenterImage
            Me.BackdropImage.SizeMode = PictureBoxSizeMode.Zoom

            'FanArtImage.FanArtImagePreview.SizeMode = PictureBoxSizeMode.CenterImage
            'FanArtImage.FanArtImagePreview.SizeMode = PictureBoxSizeMode.Zoom

            MovieBackdropSize.Text = Me.BackdropImage.Image.Width & "x" & Me.BackdropImage.Image.Height
        Else
            Me.BackdropImage.Image = Nothing
            Me.BackdropImage.Tag = ""
            Me.MovieBackdropSize.Text = ""
        End If

        getImagesFromMovieFolder(Replace(Settings.CoverFilename, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDb(0).MovieFileName)), Replace(Settings.FanArtFilename, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDb(0).MovieFileName)))
        _MovPicDb.Dispose()

    End Sub

    Private Sub ImportWatchStatus(ByVal filename As String, ByVal idMovie As Integer)
        Try

            If File.Exists(filename) Then

                Dim reader As XmlReader

                Dim myXMLDoc As New XmlDocument
                reader = XmlReader.Create(filename)

                myXMLDoc.Load(reader)
                Dim myNode As XmlNode = myXMLDoc.SelectSingleNode("/movie/watched")

                myNode = myNode.FirstChild

                Dim _MovPicDb As New MovingPicturesDB
                _MovPicDb.UpdateWatchStatus(idMovie, CBool(myNode.Value.ToString))

                MyLog.Debug("watch status imported -> Status: {0} ({1})", CBool(myNode.Value.ToString), filename)

                _MovPicDb.Dispose()
                reader.Close()

            Else
                MyLog.Error("File not found: {0}", filename)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LoadSettings()

        TBMocPicDB.Text = Settings.MovingPicturesDB

        CheckNFO.Checked = Settings.ExportNfoFile
        tbNFO.Enabled = Settings.ExportNfoFile
        tbNFO.Text = Settings.ExportNfoFileName

        CheckImDb.Checked = Settings.ExportImDbFile
        tbImDb.Enabled = Settings.ExportImDbFile
        tbImDb.Text = Settings.ExportImDbFileName

        CheckWatched.Checked = Settings.ExportWatchStatus
        tbWatched.Enabled = Settings.ExportWatchStatus
        tbWatched.Text = Settings.ExportWatchedStatusFileName

        CheckImportWatch.Checked = Settings.ImportWatchStatus
        tbImportWatch.Enabled = Settings.ImportWatchStatus
        tbImportWatch.Text = Settings.ImportWatchedStatusFileName

        CheckCover.Checked = Settings.ExportCoverFile
        tbCover.Enabled = Settings.ExportCoverFile
        tbCover.Text = Settings.ExportCoverFileName

        CheckFanArt.Checked = Settings.ExportFanArtFile
        tbFanArt.Enabled = Settings.ExportFanArtFile
        tbFanArt.Text = Settings.ExportFanArtFileName

        tbWorkingPath1.Text = Settings.WorkingPath1
        tbWorkingPath2.Text = Settings.WorkingPath2
        tbWorkingPath3.Text = Settings.WorkingPath3

        tbCoverFilename.Text = Settings.CoverFilename
        tbFanArtFilename.Text = Settings.FanArtFilename

        Settings.WorkingPath = ""

    End Sub
    Private Sub SaveSettings()
        Settings.ExportNfoFileName = tbNFO.Text
        Settings.ExportImDbFileName = tbImDb.Text
        Settings.ExportWatchedStatusFileName = tbWatched.Text
        Settings.ImportWatchedStatusFileName = tbImportWatch.Text
        Settings.WorkingPath1 = tbWorkingPath1.Text
        Settings.WorkingPath2 = tbWorkingPath2.Text
        Settings.WorkingPath3 = tbWorkingPath3.Text
        Settings.CoverFilename = tbCoverFilename.Text
        Settings.FanArtFilename = tbFanArtFilename.Text
        Settings.ExportCoverFileName = tbCover.Text
        Settings.ExportFanArtFileName = tbFanArt.Text
    End Sub

    Private Sub ShowImagePreview(ByVal ImagePath As String)
        'Cover Stream, LargeImage + übergeben
        Dim PrviewImgStream As New IO.MemoryStream
        Helper.CreateCloneImage(ImagePath).Save(PrviewImgStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        ImagePrview.ImageBox.Image = System.Drawing.Image.FromStream(PrviewImgStream)
        PrviewImgStream.Dispose()

        ImagePrview.ImageBox.SizeMode = PictureBoxSizeMode.CenterImage
        ImagePrview.ImageBox.SizeMode = PictureBoxSizeMode.Zoom

        ImagePrview.Size = New System.Drawing.Size(ImagePrview.ImageBox.Image.Width, ImagePrview.ImageBox.Image.Height)
        ImagePrview.ShowDialog()
    End Sub

#End Region

#Region "Click Events"

    Private Sub BTMovPicCover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMovPicCover.Click
        Try
            File.Copy(Me.MovieCoverPath.Text, Me.MovieFolder.Text & "\" & Settings.CoverFilename, True)
            getMovieInformations(Me.MovieId.Text)
            CBMovies.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTMovieFolderCover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMovieFolderCover.Click
        Try
            File.Copy(Me.MovieFolder.Text & "\" & Settings.CoverFilename, Me.MovieCoverPath.Text, True)

            Dim ThumbStream As New IO.MemoryStream
            Helper.CreateCloneImage(Me.MovieFolder.Text & "\" & Settings.CoverFilename).Save(ThumbStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim _Thumb As New Bitmap(System.Drawing.Image.FromStream(ThumbStream), 175, 242)
            _Thumb.Save(Replace(Me.MovieCoverPath.Text, "\FullSize", "\Thumbs"))

            ThumbStream.Dispose()

            getMovieInformations(Me.MovieId.Text)
            CBMovies.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTMovPicFanArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMovPicFanArt.Click
        Try
            File.Copy(Me.MovieBackdropPath.Text, Me.MovieFolder.Text & "\" & Settings.FanArtFilename, True)
            getMovieInformations(Me.MovieId.Text)
            CBMovies.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTMovieFolderBackdrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMovieFolderBackdrop.Click
        Try
            File.Copy(Me.MovieFolder.Text & "\" & Settings.FanArtFilename, Me.MovieBackdropPath.Text, True)
            getMovieInformations(Me.MovieId.Text)
            CBMovies.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTCoverFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCoverFromFile.Click
        Dim _openFileDialog As New System.Windows.Forms.OpenFileDialog

        _openFileDialog.Filter = "Image|*.jpeg; *.jpg; *.png; *.bmp; *.gif"

        If _openFileDialog.ShowDialog() = DialogResult.OK Then
            File.Copy(_openFileDialog.FileName, Me.MovieFolder.Text & "\" & Settings.CoverFilename, True)
            File.Copy(_openFileDialog.FileName, Me.MovieCoverPath.Text, True)

            Dim ThumbStream As New IO.MemoryStream
            Helper.CreateCloneImage(_openFileDialog.FileName).Save(ThumbStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim _Thumb As New Bitmap(System.Drawing.Image.FromStream(ThumbStream), 175, 242)
            _Thumb.Save(Replace(Me.MovieCoverPath.Text, "\FullSize", "\Thumbs"))

            ThumbStream.Dispose()

            getMovieInformations(Me.MovieId.Text)
            CBMovies.Focus()
        Else
            CBMovies.Focus()
        End If

    End Sub
    Private Sub BTFanArtFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTFanArtFromFile.Click
        Dim _openFileDialog As New System.Windows.Forms.OpenFileDialog

        _openFileDialog.Filter = "Image|*.jpeg; *.jpg; *.png; *.bmp; *.gif"

        If _openFileDialog.ShowDialog() = DialogResult.OK Then

            File.Copy(_openFileDialog.FileName, Me.MovieFolder.Text & "\" & Settings.FanArtFilename, True)
            File.Copy(_openFileDialog.FileName, Me.MovieBackdropPath.Text, True)
            getMovieInformations(Me.MovieId.Text)
            CBMovies.Focus()
        Else
            CBMovies.Focus()
        End If
    End Sub

    Private Sub BTopenDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTopenDB.Click



        MyLog.Info("")
        MyLog.Info("Opening Moving Pictures Database...")
        MyLog.Info("Working directory: {0}", Settings.WorkingPath)

        Settings.MovingPicturesDB = TBMocPicDB.Text
        CBMovies.Items.Clear()
        _MovieDict.Clear()

        SaveSettings()

        Dim counter As Integer = 0

        If File.Exists(Settings.MovingPicturesDB) Then
            MyLog.Info("MovingPicturesDatabase exist: {0}", Settings.MovingPicturesDB)

            ProgressBarOpen.Value = 0
            ProgressBarOpen.Visible = True

            Dim _MovPicDb As New MovingPicturesDB
            _MovPicDb.LoadAllMovingPicturesFilms()

            ProgressBarOpen.Maximum = _MovPicDb.Count

            For i = 0 To _MovPicDb.Count - 1

                ProgressBarOpen.PerformStep()

                If String.IsNullOrEmpty(Settings.WorkingPath) = False Then
                    If InStr(_MovPicDb(i).MovieFolder, Settings.WorkingPath) > 0 Then
                        CBMovies.Items.Add(_MovPicDb(i).Title)
                        _MovieDict.Add(counter, _MovPicDb(i).MovingPicturesID)
                        counter = counter + 1
                    End If
                Else
                    CBMovies.Items.Add(_MovPicDb(i).Title)
                    _MovieDict.Add(counter, _MovPicDb(i).MovingPicturesID)
                    counter = counter + 1
                    Settings.WorkingPath = ""
                End If

            Next

            If CBMovies.Items.Count > 0 Then
                CBMovies.Text = CBMovies.Items(0)
                LabelMovieCounter.Text = "/ " & counter
                MyLog.Info("Data successful read: {0} movies found", counter)
                MyLog.Info("")
            Else
                MsgBox("Nothing found in this working directory !", MsgBoxStyle.Information, "Info ...")
                MyLog.Warn("Nothing found in this working directory !")
                MyLog.Info("")
            End If

            _MovPicDb.Dispose()

            GroupMovieInfoBox.Enabled = True
            GroupExport.Enabled = True

            CBMovies.Focus()
            ProgressBarOpen.Visible = False
        Else
            MyLog.Error("MovingPicturesDatabase not exist -> {0}", Settings.MovingPicturesDB)
            MsgBox("Moving Pictures Database not found!", MsgBoxStyle.Critical, "Error ...")
            TBMocPicDB.Text = Settings.MovingPicturesDB
            TBMocPicDB.Focus()

            GroupMovieInfoBox.Enabled = False
            GroupExport.Enabled = False
        End If



    End Sub
    Private Sub CoverImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoverImage.Click
        ShowImagePreview(Me.CoverImage.Tag)
    End Sub
    Private Sub BackdropImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackdropImage.Click
        ShowImagePreview(Me.BackdropImage.Tag)
    End Sub
    Private Sub BackdropMovieFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackdropMovieFolder.Click
        ShowImagePreview(Me.BackdropMovieFolder.Tag)
    End Sub
    Private Sub CoverImageMovieFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoverImageMovieFolder.Click
        ShowImagePreview(Me.CoverImageMovieFolder.Tag)
    End Sub
    Private Sub BTExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTExport.Click

        ProgressBar.Value = 0
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 3

        MyLog.Info("")
        MyLog.Info("Exporting Data...")
        MyLog.Info("Export Movie info file: {0}, {1}", Settings.ExportNfoFile, Settings.ExportNfoFileName)
        MyLog.Info("Export imdb info file: {0}, {1}", Settings.ExportImDbFile, Settings.ExportImDbFileName)
        MyLog.Info("Export watch status file: {0}, {1}", Settings.ExportWatchStatus, Settings.ExportWatchedStatusFileName)

        MyLog.Debug("")
        MyLog.Debug("Title: {0}", MovieTitleLabel.Text)

        ProgressBar.PerformStep()
        Thread.Sleep(100)
        If CheckNFO.Checked = True Then
            Dim _filename As String = MovieFolder.Text & "\" & Replace(tbNFO.Text, "%Filename%", Path.GetFileNameWithoutExtension(MovieFileName.Text))
            CreateNfoFile(_filename, CInt(MovieId.Text))
        End If
        ProgressBar.PerformStep()
        Thread.Sleep(100)
        If CheckImDb.Checked = True Then
            Dim _filename As String = MovieFolder.Text & "\" & Replace(tbImDb.Text, "%Filename%", Path.GetFileNameWithoutExtension(MovieFileName.Text))
            CreateImDbTextFile(_filename, CInt(MovieId.Text))
        End If
        ProgressBar.PerformStep()
        Thread.Sleep(100)
        If CheckWatched.Checked = True Then
            Dim _filename As String = MovieFolder.Text & "\" & Replace(tbWatched.Text, "%Filename%", Path.GetFileNameWithoutExtension(MovieFileName.Text))
            CreateWatchStatusFile(_filename, CInt(MovieId.Text))
        End If

        If CheckCover.Checked = True Then
            Dim _filename As String = MovieFolder.Text & "\" & Replace(tbCover.Text, "%Filename%", Path.GetFileNameWithoutExtension(MovieFileName.Text))
            CopyCover(_filename, CInt(MovieId.Text))
        End If

        If CheckFanArt.Checked = True Then
            Dim _filename As String = MovieFolder.Text & "\" & Replace(tbFanArt.Text, "%Filename%", Path.GetFileNameWithoutExtension(MovieFileName.Text))
            CopyFanArt(_filename, CInt(MovieId.Text))
        End If

        ProgressBar.PerformStep()
        Thread.Sleep(100)

        SaveSettings()
        'CreateImDbTextFile()
        MyLog.Info("Export successful ...")

        CBMovies.Focus()

    End Sub

    Private Sub BTImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTImport.Click
        ProgressBar.Value = 0
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 3

        MyLog.Info("")
        MyLog.Info("Importing Data...")
        'MyLog.Info("Import Movie info file: {0}, {1}", Settings.ExportNfoFile, Settings.ExportNfoFileName)
        'MyLog.Info("Import imdb info file: {0}, {1}", Settings.ExportImDbFile, Settings.ExportImDbFileName)
        MyLog.Info("Import watch status file: {0}, {1}", Settings.ImportWatchStatus, Settings.ImportWatchedStatusFileName)
        ProgressBar.PerformStep()
        Thread.Sleep(100)

        MyLog.Debug("")
        MyLog.Debug("Title: {0}", MovieTitleLabel.Text)

        ProgressBar.PerformStep()
        Thread.Sleep(100)

        If CheckImportWatch.Checked = True Then
            Dim _filename As String = MovieFolder.Text & "\" & Replace(tbImportWatch.Text, "%Filename%", Path.GetFileNameWithoutExtension(MovieFileName.Text))
            ImportWatchStatus(_filename, CInt(MovieId.Text))
        End If

        ProgressBar.PerformStep()
        Thread.Sleep(100)

        SaveSettings()
        'CreateImDbTextFile()
        MyLog.Info("Import successful ...")

        CBMovies.Focus()
        ProgressBar.PerformStep()
        Thread.Sleep(100)
    End Sub

    Private Sub BTExportSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTExportSelection.Click

        Dim NFOCounter As Integer = 0
        Dim ImDbCounter As Integer = 0
        Dim WatchCounter As Integer = 0
        Dim CoverCounter As Integer = 0
        Dim FanArtCounter As Integer = 0

        MyLog.Info("")
        MyLog.Info("Exporting Data for all movies in current working directory...")
        MyLog.Info("Working directory: {0}", Settings.WorkingPath)
        MyLog.Info("Export Movie info file: {0}, {1}", Settings.ExportNfoFile, Settings.ExportNfoFileName)
        MyLog.Info("Export imdb info file: {0}, {1}", Settings.ExportImDbFile, Settings.ExportImDbFileName)
        MyLog.Info("Export watch status file: {0}, {1}", Settings.ExportWatchStatus, Settings.ExportWatchedStatusFileName)

        ProgressBar.Value = 0
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = _MovieDict.Count - 1

        For i = 0 To _MovieDict.Count - 1
            ProgressBar.PerformStep()

            Dim _MovieLogInfo As New MovingPicturesDB
            _MovieLogInfo.LoadMovieInfos(_MovieDict(i))
            MyLog.Debug("")
            MyLog.Debug("Title: {0}", _MovieLogInfo(0).Title)
            _MovieLogInfo.Dispose()

            If CheckNFO.Checked = True Then
                Dim _MovPicDB As New MovingPicturesDB
                _MovPicDB.LoadMovieInfos(_MovieDict(i))

                Dim _filename As String = _MovPicDB(0).MovieFolder & "\" & Replace(tbNFO.Text, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDB(0).MovieFileName))
                Dim _idMovie As String = _MovPicDB(0).MovingPicturesID

                _MovPicDB.Dispose()
                CreateNfoFile(_filename, _idMovie)
                NFOCounter = NFOCounter + 1
            End If
            If CheckImDb.Checked = True Then
                Dim _MovPicDB As New MovingPicturesDB
                _MovPicDB.LoadMovieInfos(_MovieDict(i))

                Dim _filename As String = _MovPicDB(0).MovieFolder & "\" & Replace(tbImDb.Text, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDB(0).MovieFileName))
                Dim _idMovie As String = _MovPicDB(0).MovingPicturesID

                _MovPicDB.Dispose()
                CreateImDbTextFile(_filename, _idMovie)
                ImDbCounter = ImDbCounter + 1
            End If
            If CheckWatched.Checked = True Then
                Dim _MovPicDB As New MovingPicturesDB
                _MovPicDB.LoadMovieInfos(_MovieDict(i))

                Dim _filename As String = _MovPicDB(0).MovieFolder & "\" & Replace(tbWatched.Text, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDB(0).MovieFileName))
                Dim _idMovie As String = _MovPicDB(0).MovingPicturesID

                _MovPicDB.Dispose()
                CreateWatchStatusFile(_filename, _idMovie)
                WatchCounter = WatchCounter + 1
            End If
            If CheckCover.Checked = True Then
                Dim _MovPicDB As New MovingPicturesDB
                _MovPicDB.LoadMovieInfos(_MovieDict(i))

                Dim _filename As String = _MovPicDB(0).MovieFolder & "\" & Replace(tbCover.Text, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDB(0).MovieFileName))
                Dim _idMovie As String = _MovPicDB(0).MovingPicturesID

                _MovPicDB.Dispose()
                CopyCover(_filename, _idMovie)
                CoverCounter = CoverCounter + 1
            End If
            If CheckFanArt.Checked = True Then
                Dim _MovPicDB As New MovingPicturesDB
                _MovPicDB.LoadMovieInfos(_MovieDict(i))

                Dim _filename As String = _MovPicDB(0).MovieFolder & "\" & Replace(tbFanArt.Text, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDB(0).MovieFileName))
                Dim _idMovie As String = _MovPicDB(0).MovingPicturesID

                _MovPicDB.Dispose()
                CopyFanArt(_filename, _idMovie)
                FanArtCounter = CoverCounter + 1
            End If


        Next

        MyLog.Info("")

        If _MovieDict.Count > 0 Then
            MsgBox(_MovieDict.Count & " Movie informations exported!" & vbNewLine & vbNewLine & _
                   "movie info files: " & NFOCounter & vbNewLine & _
                   "imdb info files: " & ImDbCounter & vbNewLine & _
                   "watch status files: " & WatchCounter & vbNewLine & _
                   "cover copied: " & CoverCounter & vbNewLine & _
                   "fanart copied: " & CoverCounter, MsgBoxStyle.Information, "Info ...")

            MyLog.Info(_MovieDict.Count & " Movie informations exported!")
            MyLog.Info("movie info files: " & NFOCounter)
            MyLog.Info("imdb info files: " & ImDbCounter)
            MyLog.Info("watch status files: " & WatchCounter)
            MyLog.Info("cover copied: " & CoverCounter)
            MyLog.Info("fanart copied: " & CoverCounter)
            MyLog.Info("Export successful ...")
            MyLog.Info("")
        Else
            MsgBox("No Data exported!", MsgBoxStyle.Critical, "Warning ...")
            MyLog.Warn("No Data exported!")
            MyLog.Info("")
        End If

        SaveSettings()

        CBMovies.Focus()

    End Sub
    Private Sub BTImportSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTImportSelection.Click
        Dim NFOCounter As Integer = 0
        Dim ImDbCounter As Integer = 0
        Dim WatchCounter As Integer = 0

        MyLog.Info("")
        MyLog.Info("Importing Data for all movies in current working directory...")
        MyLog.Info("Working directory: {0}", Settings.WorkingPath)
        'MyLog.Info("Export Movie info file: {0}, {1}", Settings.ExportNfoFile, Settings.ExportNfoFileName)
        'MyLog.Info("Export imdb info file: {0}, {1}", Settings.ExportImDbFile, Settings.ExportImDbFileName)
        MyLog.Info("Import watch status file: {0}, {1}", Settings.ImportWatchStatus, Settings.ImportWatchedStatusFileName)

        ProgressBar.Value = 0
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = _MovieDict.Count - 1

        For i = 0 To _MovieDict.Count - 1
            ProgressBar.PerformStep()

            Dim _MovieLogInfo As New MovingPicturesDB
            _MovieLogInfo.LoadMovieInfos(_MovieDict(i))
            MyLog.Debug("")
            MyLog.Debug("Title: {0}", _MovieLogInfo(0).Title)
            _MovieLogInfo.Dispose()


            If CheckImportWatch.Checked = True Then
                Dim _MovPicDB As New MovingPicturesDB
                _MovPicDB.LoadMovieInfos(_MovieDict(i))

                Dim _filename As String = _MovPicDB(0).MovieFolder & "\" & Replace(tbImportWatch.Text, "%Filename%", Path.GetFileNameWithoutExtension(_MovPicDB(0).MovieFileName))
                Dim _idMovie As String = _MovPicDB(0).MovingPicturesID

                _MovPicDB.Dispose()
                ImportWatchStatus(_filename, _idMovie)
                WatchCounter = WatchCounter + 1
            End If

        Next

        MyLog.Info("")

        If _MovieDict.Count > 0 Then
            MsgBox(_MovieDict.Count & " Movie informations imported!" & vbNewLine & vbNewLine & _
                   "watch status files: " & WatchCounter _
                   , MsgBoxStyle.Information, "Info ...")

            MyLog.Info(_MovieDict.Count & " Movie informations imported!")
            'MyLog.Info("movie info files: " & NFOCounter)
            'MyLog.Info("imdb info files: " & ImDbCounter)
            MyLog.Info("watch status files: " & WatchCounter)
            MyLog.Info("Import successful ...")
            MyLog.Info("")
        Else
            MsgBox("No Data exported!", MsgBoxStyle.Critical, "Warning ...")
            MyLog.Warn("No Data exported!")
            MyLog.Info("")
        End If

        SaveSettings()

        CBMovies.Focus()
    End Sub

    Private Sub BTopenMovieFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTopenMovieFolder.Click
        Process.Start(Me.MovieFolder.Text)
    End Sub

#End Region

#Region "Change Events"
    Private Sub CBMovies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMovies.SelectedIndexChanged
        getMovieInformations(_MovieDict(CBMovies.SelectedIndex))
        LabelSelectedIndex.Text = CBMovies.SelectedIndex + 1
    End Sub

    Private Sub CheckNFO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckNFO.CheckedChanged
        Settings.ExportNfoFile = CheckNFO.Checked
        tbNFO.Enabled = CheckNFO.Checked
        CBMovies.Focus()
    End Sub
    Private Sub CheckImDb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImDb.CheckedChanged
        Settings.ExportImDbFile = CheckImDb.Checked
        tbImDb.Enabled = CheckImDb.Checked
        CBMovies.Focus()
    End Sub
    Private Sub CheckWatched_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckWatched.CheckedChanged
        Settings.ExportWatchStatus = CheckWatched.Checked
        tbWatched.Enabled = CheckWatched.Checked
        CBMovies.Focus()
    End Sub
    Private Sub CheckImportWatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckImportWatch.CheckedChanged
        Settings.ImportWatchStatus = CheckImportWatch.Checked
        tbImportWatch.Enabled = CheckImportWatch.Checked
        CBMovies.Focus()
    End Sub
    Private Sub CheckCover_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCover.CheckedChanged
        Settings.ExportCoverFile = CheckCover.Checked
        tbCover.Enabled = CheckCover.Checked
        CBMovies.Focus()
    End Sub
    Private Sub CheckFanArt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFanArt.CheckedChanged
        Settings.ExportFanArtFile = CheckFanArt.Checked
        tbFanArt.Enabled = CheckFanArt.Checked
        CBMovies.Focus()
    End Sub
    Private Sub RBnone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBnone.CheckedChanged
        Settings.WorkingPath = ""
        CBMovies.Focus()
    End Sub
    Private Sub rbWorkingPath1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWorkingPath1.CheckedChanged
        Settings.WorkingPath = tbWorkingPath1.Text
        CBMovies.Focus()
    End Sub
    Private Sub rbWorkingPath2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWorkingPath2.CheckedChanged
        Settings.WorkingPath = tbWorkingPath2.Text
        CBMovies.Focus()
    End Sub
    Private Sub rbWorkingPath3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWorkingPath3.CheckedChanged
        Settings.WorkingPath = tbWorkingPath3.Text
        CBMovies.Focus()
    End Sub
    Private Sub BackdropMovieFolder_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackdropMovieFolder.MouseHover
        Me.BackdropMovieFolder.Cursor = Cursors.Hand
    End Sub
    Private Sub CoverImageMovieFolder_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CoverImageMovieFolder.MouseHover
        Me.CoverImageMovieFolder.Cursor = Cursors.Hand
    End Sub
    Private Sub CoverImage_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CoverImage.MouseHover
        Me.CoverImage.Cursor = Cursors.Hand
    End Sub
    Private Sub BackdropImage_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackdropImage.MouseHover
        Me.BackdropImage.Cursor = Cursors.Hand
    End Sub

#End Region


End Class
