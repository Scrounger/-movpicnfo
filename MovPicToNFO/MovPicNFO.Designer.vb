<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovPicNFO
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovPicNFO))
        Me.TBMocPicDB = New System.Windows.Forms.TextBox
        Me.BTopenDB = New System.Windows.Forms.Button
        Me.GroupMovieInfoBox = New System.Windows.Forms.GroupBox
        Me.BTopenMovieFolder = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabCoverFanArt = New System.Windows.Forms.TabPage
        Me.BTFanArtFromFile = New System.Windows.Forms.Button
        Me.BTCoverFromFile = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTMovieFolderCover = New System.Windows.Forms.Button
        Me.BTMovieFolderBackdrop = New System.Windows.Forms.Button
        Me.MovieCoverMovieFolderSize = New System.Windows.Forms.Label
        Me.CoverImageMovieFolder = New System.Windows.Forms.PictureBox
        Me.BackdropMovieFolder = New System.Windows.Forms.PictureBox
        Me.MovieBackdropMovieFolderSize = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTMovPicFanArt = New System.Windows.Forms.Button
        Me.BTMovPicCover = New System.Windows.Forms.Button
        Me.BackdropImage = New System.Windows.Forms.PictureBox
        Me.MovieBackdropSize = New System.Windows.Forms.Label
        Me.CoverImage = New System.Windows.Forms.PictureBox
        Me.MovieImageSize = New System.Windows.Forms.Label
        Me.TabMovieInfo = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.MovieBackdropPath = New System.Windows.Forms.Label
        Me.MovieId = New System.Windows.Forms.Label
        Me.MovieCoverPath = New System.Windows.Forms.Label
        Me.MovieFolder = New System.Windows.Forms.Label
        Me.MovieFileName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MovieTitleLabel = New System.Windows.Forms.Label
        Me.CBMovies = New System.Windows.Forms.ComboBox
        Me.BTExport = New System.Windows.Forms.Button
        Me.LabelMovieCounter = New System.Windows.Forms.Label
        Me.LabelSelectedIndex = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupExport = New System.Windows.Forms.GroupBox
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabExport = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.CheckFanArt = New System.Windows.Forms.CheckBox
        Me.tbFanArt = New System.Windows.Forms.TextBox
        Me.CheckCover = New System.Windows.Forms.CheckBox
        Me.tbCover = New System.Windows.Forms.TextBox
        Me.tbImDb = New System.Windows.Forms.TextBox
        Me.tbWatched = New System.Windows.Forms.TextBox
        Me.CheckImDb = New System.Windows.Forms.CheckBox
        Me.BTExportSelection = New System.Windows.Forms.Button
        Me.CheckNFO = New System.Windows.Forms.CheckBox
        Me.CheckWatched = New System.Windows.Forms.CheckBox
        Me.tbNFO = New System.Windows.Forms.TextBox
        Me.TabImport = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tbImportWatch = New System.Windows.Forms.TextBox
        Me.BTImportSelection = New System.Windows.Forms.Button
        Me.BTImport = New System.Windows.Forms.Button
        Me.CheckImportWatch = New System.Windows.Forms.CheckBox
        Me.tbWorkingPath1 = New System.Windows.Forms.TextBox
        Me.tbWorkingPath2 = New System.Windows.Forms.TextBox
        Me.tbWorkingPath3 = New System.Windows.Forms.TextBox
        Me.rbWorkingPath2 = New System.Windows.Forms.RadioButton
        Me.rbWorkingPath3 = New System.Windows.Forms.RadioButton
        Me.rbWorkingPath1 = New System.Windows.Forms.RadioButton
        Me.RBnone = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.LogBox = New System.Windows.Forms.ListBox
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbCoverFilename = New System.Windows.Forms.TextBox
        Me.tbFanArtFilename = New System.Windows.Forms.TextBox
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBarOpen = New System.Windows.Forms.ProgressBar
        Me.GroupMovieInfoBox.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabCoverFanArt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CoverImageMovieFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackdropMovieFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BackdropImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoverImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMovieInfo.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupExport.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabExport.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabImport.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBMocPicDB
        '
        Me.TBMocPicDB.Location = New System.Drawing.Point(13, 22)
        Me.TBMocPicDB.Name = "TBMocPicDB"
        Me.TBMocPicDB.Size = New System.Drawing.Size(384, 20)
        Me.TBMocPicDB.TabIndex = 35
        '
        'BTopenDB
        '
        Me.BTopenDB.Location = New System.Drawing.Point(13, 48)
        Me.BTopenDB.Name = "BTopenDB"
        Me.BTopenDB.Size = New System.Drawing.Size(59, 29)
        Me.BTopenDB.TabIndex = 36
        Me.BTopenDB.TabStop = False
        Me.BTopenDB.Text = "open"
        Me.BTopenDB.UseVisualStyleBackColor = True
        '
        'GroupMovieInfoBox
        '
        Me.GroupMovieInfoBox.Controls.Add(Me.BTopenMovieFolder)
        Me.GroupMovieInfoBox.Controls.Add(Me.TabControl1)
        Me.GroupMovieInfoBox.Controls.Add(Me.MovieTitleLabel)
        Me.GroupMovieInfoBox.Enabled = False
        Me.GroupMovieInfoBox.Location = New System.Drawing.Point(12, 110)
        Me.GroupMovieInfoBox.Name = "GroupMovieInfoBox"
        Me.GroupMovieInfoBox.Size = New System.Drawing.Size(990, 357)
        Me.GroupMovieInfoBox.TabIndex = 38
        Me.GroupMovieInfoBox.TabStop = False
        '
        'BTopenMovieFolder
        '
        Me.BTopenMovieFolder.Location = New System.Drawing.Point(829, 17)
        Me.BTopenMovieFolder.Name = "BTopenMovieFolder"
        Me.BTopenMovieFolder.Size = New System.Drawing.Size(142, 32)
        Me.BTopenMovieFolder.TabIndex = 59
        Me.BTopenMovieFolder.Text = "open Movie Folder"
        Me.BTopenMovieFolder.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCoverFanArt)
        Me.TabControl1.Controls.Add(Me.TabMovieInfo)
        Me.TabControl1.Location = New System.Drawing.Point(13, 45)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(962, 301)
        Me.TabControl1.TabIndex = 58
        '
        'TabCoverFanArt
        '
        Me.TabCoverFanArt.Controls.Add(Me.BTFanArtFromFile)
        Me.TabCoverFanArt.Controls.Add(Me.BTCoverFromFile)
        Me.TabCoverFanArt.Controls.Add(Me.GroupBox2)
        Me.TabCoverFanArt.Controls.Add(Me.GroupBox1)
        Me.TabCoverFanArt.Location = New System.Drawing.Point(4, 22)
        Me.TabCoverFanArt.Name = "TabCoverFanArt"
        Me.TabCoverFanArt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCoverFanArt.Size = New System.Drawing.Size(954, 275)
        Me.TabCoverFanArt.TabIndex = 0
        Me.TabCoverFanArt.Text = "Cover and FanArt"
        Me.TabCoverFanArt.UseVisualStyleBackColor = True
        '
        'BTFanArtFromFile
        '
        Me.BTFanArtFromFile.Location = New System.Drawing.Point(838, 235)
        Me.BTFanArtFromFile.Name = "BTFanArtFromFile"
        Me.BTFanArtFromFile.Size = New System.Drawing.Size(103, 31)
        Me.BTFanArtFromFile.TabIndex = 45
        Me.BTFanArtFromFile.TabStop = False
        Me.BTFanArtFromFile.Text = "FanArt from file..."
        Me.BTFanArtFromFile.UseVisualStyleBackColor = True
        '
        'BTCoverFromFile
        '
        Me.BTCoverFromFile.Location = New System.Drawing.Point(709, 235)
        Me.BTCoverFromFile.Name = "BTCoverFromFile"
        Me.BTCoverFromFile.Size = New System.Drawing.Size(103, 31)
        Me.BTCoverFromFile.TabIndex = 44
        Me.BTCoverFromFile.TabStop = False
        Me.BTCoverFromFile.Text = "Cover from file..."
        Me.BTCoverFromFile.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTMovieFolderCover)
        Me.GroupBox2.Controls.Add(Me.BTMovieFolderBackdrop)
        Me.GroupBox2.Controls.Add(Me.MovieCoverMovieFolderSize)
        Me.GroupBox2.Controls.Add(Me.CoverImageMovieFolder)
        Me.GroupBox2.Controls.Add(Me.BackdropMovieFolder)
        Me.GroupBox2.Controls.Add(Me.MovieBackdropMovieFolderSize)
        Me.GroupBox2.Location = New System.Drawing.Point(489, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 208)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Images found in movie folder"
        '
        'BTMovieFolderCover
        '
        Me.BTMovieFolderCover.Location = New System.Drawing.Point(428, 187)
        Me.BTMovieFolderCover.Name = "BTMovieFolderCover"
        Me.BTMovieFolderCover.Size = New System.Drawing.Size(16, 16)
        Me.BTMovieFolderCover.TabIndex = 49
        Me.BTMovieFolderCover.TabStop = False
        Me.BTMovieFolderCover.Text = "."
        Me.BTMovieFolderCover.UseVisualStyleBackColor = True
        '
        'BTMovieFolderBackdrop
        '
        Me.BTMovieFolderBackdrop.Location = New System.Drawing.Point(287, 185)
        Me.BTMovieFolderBackdrop.Name = "BTMovieFolderBackdrop"
        Me.BTMovieFolderBackdrop.Size = New System.Drawing.Size(16, 16)
        Me.BTMovieFolderBackdrop.TabIndex = 48
        Me.BTMovieFolderBackdrop.TabStop = False
        Me.BTMovieFolderBackdrop.Text = "."
        Me.BTMovieFolderBackdrop.UseVisualStyleBackColor = True
        '
        'MovieCoverMovieFolderSize
        '
        Me.MovieCoverMovieFolderSize.Location = New System.Drawing.Point(326, 185)
        Me.MovieCoverMovieFolderSize.Name = "MovieCoverMovieFolderSize"
        Me.MovieCoverMovieFolderSize.Size = New System.Drawing.Size(96, 18)
        Me.MovieCoverMovieFolderSize.TabIndex = 43
        Me.MovieCoverMovieFolderSize.Text = "#MovieImageSize"
        Me.MovieCoverMovieFolderSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CoverImageMovieFolder
        '
        Me.CoverImageMovieFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CoverImageMovieFolder.Location = New System.Drawing.Point(329, 19)
        Me.CoverImageMovieFolder.Name = "CoverImageMovieFolder"
        Me.CoverImageMovieFolder.Size = New System.Drawing.Size(115, 162)
        Me.CoverImageMovieFolder.TabIndex = 42
        Me.CoverImageMovieFolder.TabStop = False
        '
        'BackdropMovieFolder
        '
        Me.BackdropMovieFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackdropMovieFolder.Location = New System.Drawing.Point(17, 19)
        Me.BackdropMovieFolder.Name = "BackdropMovieFolder"
        Me.BackdropMovieFolder.Size = New System.Drawing.Size(286, 162)
        Me.BackdropMovieFolder.TabIndex = 40
        Me.BackdropMovieFolder.TabStop = False
        '
        'MovieBackdropMovieFolderSize
        '
        Me.MovieBackdropMovieFolderSize.Location = New System.Drawing.Point(174, 185)
        Me.MovieBackdropMovieFolderSize.Name = "MovieBackdropMovieFolderSize"
        Me.MovieBackdropMovieFolderSize.Size = New System.Drawing.Size(107, 18)
        Me.MovieBackdropMovieFolderSize.TabIndex = 41
        Me.MovieBackdropMovieFolderSize.Text = "#MovieImageSize"
        Me.MovieBackdropMovieFolderSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTMovPicFanArt)
        Me.GroupBox1.Controls.Add(Me.BTMovPicCover)
        Me.GroupBox1.Controls.Add(Me.BackdropImage)
        Me.GroupBox1.Controls.Add(Me.MovieBackdropSize)
        Me.GroupBox1.Controls.Add(Me.CoverImage)
        Me.GroupBox1.Controls.Add(Me.MovieImageSize)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 208)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Moving Pictures Cover and FanArt"
        '
        'BTMovPicFanArt
        '
        Me.BTMovPicFanArt.Location = New System.Drawing.Point(432, 184)
        Me.BTMovPicFanArt.Name = "BTMovPicFanArt"
        Me.BTMovPicFanArt.Size = New System.Drawing.Size(16, 16)
        Me.BTMovPicFanArt.TabIndex = 47
        Me.BTMovPicFanArt.TabStop = False
        Me.BTMovPicFanArt.Text = "."
        Me.BTMovPicFanArt.UseVisualStyleBackColor = True
        '
        'BTMovPicCover
        '
        Me.BTMovPicCover.Location = New System.Drawing.Point(115, 184)
        Me.BTMovPicCover.Name = "BTMovPicCover"
        Me.BTMovPicCover.Size = New System.Drawing.Size(16, 16)
        Me.BTMovPicCover.TabIndex = 46
        Me.BTMovPicCover.TabStop = False
        Me.BTMovPicCover.Text = "."
        Me.BTMovPicCover.UseVisualStyleBackColor = True
        '
        'BackdropImage
        '
        Me.BackdropImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackdropImage.Location = New System.Drawing.Point(162, 19)
        Me.BackdropImage.Name = "BackdropImage"
        Me.BackdropImage.Size = New System.Drawing.Size(286, 162)
        Me.BackdropImage.TabIndex = 40
        Me.BackdropImage.TabStop = False
        '
        'MovieBackdropSize
        '
        Me.MovieBackdropSize.Location = New System.Drawing.Point(319, 184)
        Me.MovieBackdropSize.Name = "MovieBackdropSize"
        Me.MovieBackdropSize.Size = New System.Drawing.Size(107, 18)
        Me.MovieBackdropSize.TabIndex = 41
        Me.MovieBackdropSize.Text = "#MovieImageSize"
        Me.MovieBackdropSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CoverImage
        '
        Me.CoverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CoverImage.Location = New System.Drawing.Point(16, 19)
        Me.CoverImage.Name = "CoverImage"
        Me.CoverImage.Size = New System.Drawing.Size(115, 162)
        Me.CoverImage.TabIndex = 0
        Me.CoverImage.TabStop = False
        '
        'MovieImageSize
        '
        Me.MovieImageSize.Location = New System.Drawing.Point(23, 184)
        Me.MovieImageSize.Name = "MovieImageSize"
        Me.MovieImageSize.Size = New System.Drawing.Size(86, 18)
        Me.MovieImageSize.TabIndex = 12
        Me.MovieImageSize.Text = "#MovieImageSize"
        Me.MovieImageSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabMovieInfo
        '
        Me.TabMovieInfo.Controls.Add(Me.GroupBox9)
        Me.TabMovieInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabMovieInfo.Name = "TabMovieInfo"
        Me.TabMovieInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMovieInfo.Size = New System.Drawing.Size(954, 275)
        Me.TabMovieInfo.TabIndex = 1
        Me.TabMovieInfo.Text = "Movie info"
        Me.TabMovieInfo.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.MovieBackdropPath)
        Me.GroupBox9.Controls.Add(Me.MovieId)
        Me.GroupBox9.Controls.Add(Me.MovieCoverPath)
        Me.GroupBox9.Controls.Add(Me.MovieFolder)
        Me.GroupBox9.Controls.Add(Me.MovieFileName)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(931, 259)
        Me.GroupBox9.TabIndex = 22
        Me.GroupBox9.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Movie Id:"
        '
        'MovieBackdropPath
        '
        Me.MovieBackdropPath.AutoSize = True
        Me.MovieBackdropPath.Location = New System.Drawing.Point(99, 138)
        Me.MovieBackdropPath.Name = "MovieBackdropPath"
        Me.MovieBackdropPath.Size = New System.Drawing.Size(82, 13)
        Me.MovieBackdropPath.TabIndex = 21
        Me.MovieBackdropPath.Text = "#BackdropPath"
        '
        'MovieId
        '
        Me.MovieId.AutoSize = True
        Me.MovieId.Location = New System.Drawing.Point(99, 18)
        Me.MovieId.Name = "MovieId"
        Me.MovieId.Size = New System.Drawing.Size(52, 13)
        Me.MovieId.TabIndex = 12
        Me.MovieId.Text = "#MovieId"
        '
        'MovieCoverPath
        '
        Me.MovieCoverPath.AutoSize = True
        Me.MovieCoverPath.Location = New System.Drawing.Point(99, 108)
        Me.MovieCoverPath.Name = "MovieCoverPath"
        Me.MovieCoverPath.Size = New System.Drawing.Size(64, 13)
        Me.MovieCoverPath.TabIndex = 20
        Me.MovieCoverPath.Text = "#CoverPath"
        '
        'MovieFolder
        '
        Me.MovieFolder.AutoSize = True
        Me.MovieFolder.Location = New System.Drawing.Point(99, 78)
        Me.MovieFolder.Name = "MovieFolder"
        Me.MovieFolder.Size = New System.Drawing.Size(72, 13)
        Me.MovieFolder.TabIndex = 13
        Me.MovieFolder.Text = "#MovieFolder"
        '
        'MovieFileName
        '
        Me.MovieFileName.AutoSize = True
        Me.MovieFileName.Location = New System.Drawing.Point(99, 48)
        Me.MovieFileName.Name = "MovieFileName"
        Me.MovieFileName.Size = New System.Drawing.Size(58, 13)
        Me.MovieFileName.TabIndex = 19
        Me.MovieFileName.Text = "#FileName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Filename:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Backdrop path:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Movie path:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cover path:"
        '
        'MovieTitleLabel
        '
        Me.MovieTitleLabel.AutoSize = True
        Me.MovieTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieTitleLabel.Location = New System.Drawing.Point(11, 17)
        Me.MovieTitleLabel.Name = "MovieTitleLabel"
        Me.MovieTitleLabel.Size = New System.Drawing.Size(143, 20)
        Me.MovieTitleLabel.TabIndex = 1
        Me.MovieTitleLabel.Text = "#MovieTitleLabel"
        '
        'CBMovies
        '
        Me.CBMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMovies.FormattingEnabled = True
        Me.CBMovies.Items.AddRange(New Object() {""})
        Me.CBMovies.Location = New System.Drawing.Point(78, 51)
        Me.CBMovies.Name = "CBMovies"
        Me.CBMovies.Size = New System.Drawing.Size(319, 24)
        Me.CBMovies.TabIndex = 34
        Me.CBMovies.TabStop = False
        '
        'BTExport
        '
        Me.BTExport.Location = New System.Drawing.Point(788, 36)
        Me.BTExport.Name = "BTExport"
        Me.BTExport.Size = New System.Drawing.Size(131, 31)
        Me.BTExport.TabIndex = 39
        Me.BTExport.Text = "Export"
        Me.ToolTip1.SetToolTip(Me.BTExport, "Export data for selected movie")
        Me.BTExport.UseVisualStyleBackColor = True
        '
        'LabelMovieCounter
        '
        Me.LabelMovieCounter.AutoSize = True
        Me.LabelMovieCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMovieCounter.Location = New System.Drawing.Point(46, 37)
        Me.LabelMovieCounter.Name = "LabelMovieCounter"
        Me.LabelMovieCounter.Size = New System.Drawing.Size(49, 20)
        Me.LabelMovieCounter.TabIndex = 48
        Me.LabelMovieCounter.Text = "/ ###"
        Me.LabelMovieCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSelectedIndex
        '
        Me.LabelSelectedIndex.AutoSize = True
        Me.LabelSelectedIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectedIndex.Location = New System.Drawing.Point(14, 37)
        Me.LabelSelectedIndex.Name = "LabelSelectedIndex"
        Me.LabelSelectedIndex.Size = New System.Drawing.Size(39, 20)
        Me.LabelSelectedIndex.TabIndex = 49
        Me.LabelSelectedIndex.Text = "###"
        Me.LabelSelectedIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelMovieCounter)
        Me.GroupBox4.Controls.Add(Me.LabelSelectedIndex)
        Me.GroupBox4.Location = New System.Drawing.Point(888, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(114, 91)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Movie Counter"
        '
        'GroupExport
        '
        Me.GroupExport.Controls.Add(Me.ProgressBar)
        Me.GroupExport.Controls.Add(Me.TabControl2)
        Me.GroupExport.Enabled = False
        Me.GroupExport.Location = New System.Drawing.Point(12, 473)
        Me.GroupExport.Name = "GroupExport"
        Me.GroupExport.Size = New System.Drawing.Size(992, 182)
        Me.GroupExport.TabIndex = 51
        Me.GroupExport.TabStop = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(771, 14)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(200, 14)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 44
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabExport)
        Me.TabControl2.Controls.Add(Me.TabImport)
        Me.TabControl2.Location = New System.Drawing.Point(11, 18)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(964, 151)
        Me.TabControl2.TabIndex = 43
        '
        'TabExport
        '
        Me.TabExport.Controls.Add(Me.GroupBox6)
        Me.TabExport.Location = New System.Drawing.Point(4, 22)
        Me.TabExport.Name = "TabExport"
        Me.TabExport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabExport.Size = New System.Drawing.Size(956, 125)
        Me.TabExport.TabIndex = 0
        Me.TabExport.Text = "Export"
        Me.TabExport.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckFanArt)
        Me.GroupBox6.Controls.Add(Me.tbFanArt)
        Me.GroupBox6.Controls.Add(Me.CheckCover)
        Me.GroupBox6.Controls.Add(Me.tbCover)
        Me.GroupBox6.Controls.Add(Me.tbImDb)
        Me.GroupBox6.Controls.Add(Me.tbWatched)
        Me.GroupBox6.Controls.Add(Me.CheckImDb)
        Me.GroupBox6.Controls.Add(Me.BTExportSelection)
        Me.GroupBox6.Controls.Add(Me.BTExport)
        Me.GroupBox6.Controls.Add(Me.CheckNFO)
        Me.GroupBox6.Controls.Add(Me.CheckWatched)
        Me.GroupBox6.Controls.Add(Me.tbNFO)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(931, 109)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        '
        'CheckFanArt
        '
        Me.CheckFanArt.AutoSize = True
        Me.CheckFanArt.Location = New System.Drawing.Point(434, 50)
        Me.CheckFanArt.Name = "CheckFanArt"
        Me.CheckFanArt.Size = New System.Drawing.Size(76, 17)
        Me.CheckFanArt.TabIndex = 43
        Me.CheckFanArt.Text = "FanArt file:"
        Me.CheckFanArt.UseVisualStyleBackColor = True
        '
        'tbFanArt
        '
        Me.tbFanArt.Enabled = False
        Me.tbFanArt.Location = New System.Drawing.Point(516, 48)
        Me.tbFanArt.Name = "tbFanArt"
        Me.tbFanArt.Size = New System.Drawing.Size(256, 20)
        Me.tbFanArt.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.tbFanArt, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'CheckCover
        '
        Me.CheckCover.AutoSize = True
        Me.CheckCover.Location = New System.Drawing.Point(434, 22)
        Me.CheckCover.Name = "CheckCover"
        Me.CheckCover.Size = New System.Drawing.Size(73, 17)
        Me.CheckCover.TabIndex = 41
        Me.CheckCover.Text = "Cover file:"
        Me.CheckCover.UseVisualStyleBackColor = True
        '
        'tbCover
        '
        Me.tbCover.Enabled = False
        Me.tbCover.Location = New System.Drawing.Point(516, 20)
        Me.tbCover.Name = "tbCover"
        Me.tbCover.Size = New System.Drawing.Size(256, 20)
        Me.tbCover.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.tbCover, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'tbImDb
        '
        Me.tbImDb.Enabled = False
        Me.tbImDb.Location = New System.Drawing.Point(142, 48)
        Me.tbImDb.Name = "tbImDb"
        Me.tbImDb.Size = New System.Drawing.Size(272, 20)
        Me.tbImDb.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbImDb, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'tbWatched
        '
        Me.tbWatched.Enabled = False
        Me.tbWatched.Location = New System.Drawing.Point(142, 76)
        Me.tbWatched.Name = "tbWatched"
        Me.tbWatched.Size = New System.Drawing.Size(272, 20)
        Me.tbWatched.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbWatched, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'CheckImDb
        '
        Me.CheckImDb.AutoSize = True
        Me.CheckImDb.Location = New System.Drawing.Point(14, 50)
        Me.CheckImDb.Name = "CheckImDb"
        Me.CheckImDb.Size = New System.Drawing.Size(87, 17)
        Me.CheckImDb.TabIndex = 1
        Me.CheckImDb.Text = "imdb info file:"
        Me.CheckImDb.UseVisualStyleBackColor = True
        '
        'BTExportSelection
        '
        Me.BTExportSelection.Location = New System.Drawing.Point(788, 72)
        Me.BTExportSelection.Name = "BTExportSelection"
        Me.BTExportSelection.Size = New System.Drawing.Size(131, 31)
        Me.BTExportSelection.TabIndex = 40
        Me.BTExportSelection.Text = "Export working directory"
        Me.ToolTip1.SetToolTip(Me.BTExportSelection, "Export data for all movies in selected working directory")
        Me.BTExportSelection.UseVisualStyleBackColor = True
        '
        'CheckNFO
        '
        Me.CheckNFO.AutoSize = True
        Me.CheckNFO.Location = New System.Drawing.Point(14, 22)
        Me.CheckNFO.Name = "CheckNFO"
        Me.CheckNFO.Size = New System.Drawing.Size(93, 17)
        Me.CheckNFO.TabIndex = 0
        Me.CheckNFO.Text = "movie info file:"
        Me.CheckNFO.UseVisualStyleBackColor = True
        '
        'CheckWatched
        '
        Me.CheckWatched.AutoSize = True
        Me.CheckWatched.Location = New System.Drawing.Point(14, 78)
        Me.CheckWatched.Name = "CheckWatched"
        Me.CheckWatched.Size = New System.Drawing.Size(105, 17)
        Me.CheckWatched.TabIndex = 1
        Me.CheckWatched.Text = "watch status file:"
        Me.CheckWatched.UseVisualStyleBackColor = True
        '
        'tbNFO
        '
        Me.tbNFO.Enabled = False
        Me.tbNFO.Location = New System.Drawing.Point(142, 20)
        Me.tbNFO.Name = "tbNFO"
        Me.tbNFO.Size = New System.Drawing.Size(272, 20)
        Me.tbNFO.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbNFO, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'TabImport
        '
        Me.TabImport.Controls.Add(Me.GroupBox3)
        Me.TabImport.Location = New System.Drawing.Point(4, 22)
        Me.TabImport.Name = "TabImport"
        Me.TabImport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabImport.Size = New System.Drawing.Size(956, 125)
        Me.TabImport.TabIndex = 1
        Me.TabImport.Text = "Import"
        Me.TabImport.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbImportWatch)
        Me.GroupBox3.Controls.Add(Me.BTImportSelection)
        Me.GroupBox3.Controls.Add(Me.BTImport)
        Me.GroupBox3.Controls.Add(Me.CheckImportWatch)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(931, 109)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'tbImportWatch
        '
        Me.tbImportWatch.Enabled = False
        Me.tbImportWatch.Location = New System.Drawing.Point(141, 19)
        Me.tbImportWatch.Name = "tbImportWatch"
        Me.tbImportWatch.Size = New System.Drawing.Size(272, 20)
        Me.tbImportWatch.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbImportWatch, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'BTImportSelection
        '
        Me.BTImportSelection.Location = New System.Drawing.Point(792, 72)
        Me.BTImportSelection.Name = "BTImportSelection"
        Me.BTImportSelection.Size = New System.Drawing.Size(131, 31)
        Me.BTImportSelection.TabIndex = 40
        Me.BTImportSelection.Text = "Import working directory"
        Me.BTImportSelection.UseVisualStyleBackColor = True
        '
        'BTImport
        '
        Me.BTImport.Location = New System.Drawing.Point(655, 72)
        Me.BTImport.Name = "BTImport"
        Me.BTImport.Size = New System.Drawing.Size(131, 31)
        Me.BTImport.TabIndex = 39
        Me.BTImport.Text = "Import"
        Me.BTImport.UseVisualStyleBackColor = True
        '
        'CheckImportWatch
        '
        Me.CheckImportWatch.AutoSize = True
        Me.CheckImportWatch.Location = New System.Drawing.Point(13, 21)
        Me.CheckImportWatch.Name = "CheckImportWatch"
        Me.CheckImportWatch.Size = New System.Drawing.Size(105, 17)
        Me.CheckImportWatch.TabIndex = 1
        Me.CheckImportWatch.Text = "watch status file:"
        Me.CheckImportWatch.UseVisualStyleBackColor = True
        '
        'tbWorkingPath1
        '
        Me.tbWorkingPath1.Location = New System.Drawing.Point(31, 35)
        Me.tbWorkingPath1.Name = "tbWorkingPath1"
        Me.tbWorkingPath1.Size = New System.Drawing.Size(178, 20)
        Me.tbWorkingPath1.TabIndex = 53
        '
        'tbWorkingPath2
        '
        Me.tbWorkingPath2.Location = New System.Drawing.Point(240, 8)
        Me.tbWorkingPath2.Name = "tbWorkingPath2"
        Me.tbWorkingPath2.Size = New System.Drawing.Size(178, 20)
        Me.tbWorkingPath2.TabIndex = 54
        '
        'tbWorkingPath3
        '
        Me.tbWorkingPath3.Location = New System.Drawing.Point(240, 35)
        Me.tbWorkingPath3.Name = "tbWorkingPath3"
        Me.tbWorkingPath3.Size = New System.Drawing.Size(178, 20)
        Me.tbWorkingPath3.TabIndex = 55
        '
        'rbWorkingPath2
        '
        Me.rbWorkingPath2.AutoSize = True
        Me.rbWorkingPath2.Location = New System.Drawing.Point(220, 11)
        Me.rbWorkingPath2.Name = "rbWorkingPath2"
        Me.rbWorkingPath2.Size = New System.Drawing.Size(14, 13)
        Me.rbWorkingPath2.TabIndex = 58
        Me.rbWorkingPath2.TabStop = True
        Me.rbWorkingPath2.UseVisualStyleBackColor = True
        '
        'rbWorkingPath3
        '
        Me.rbWorkingPath3.AutoSize = True
        Me.rbWorkingPath3.Location = New System.Drawing.Point(220, 37)
        Me.rbWorkingPath3.Name = "rbWorkingPath3"
        Me.rbWorkingPath3.Size = New System.Drawing.Size(14, 13)
        Me.rbWorkingPath3.TabIndex = 57
        Me.rbWorkingPath3.TabStop = True
        Me.rbWorkingPath3.UseVisualStyleBackColor = True
        '
        'rbWorkingPath1
        '
        Me.rbWorkingPath1.AutoSize = True
        Me.rbWorkingPath1.Location = New System.Drawing.Point(11, 40)
        Me.rbWorkingPath1.Name = "rbWorkingPath1"
        Me.rbWorkingPath1.Size = New System.Drawing.Size(14, 13)
        Me.rbWorkingPath1.TabIndex = 56
        Me.rbWorkingPath1.TabStop = True
        Me.rbWorkingPath1.UseVisualStyleBackColor = True
        '
        'RBnone
        '
        Me.RBnone.AutoSize = True
        Me.RBnone.Location = New System.Drawing.Point(11, 11)
        Me.RBnone.Name = "RBnone"
        Me.RBnone.Size = New System.Drawing.Size(52, 17)
        Me.RBnone.TabIndex = 60
        Me.RBnone.TabStop = True
        Me.RBnone.Text = " none"
        Me.RBnone.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ProgressBarOpen)
        Me.GroupBox8.Controls.Add(Me.TBMocPicDB)
        Me.GroupBox8.Controls.Add(Me.BTopenDB)
        Me.GroupBox8.Controls.Add(Me.CBMovies)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(413, 92)
        Me.GroupBox8.TabIndex = 53
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Moving Pictures Database:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(142, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 78)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "watch status file:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(142, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 3
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(14, 50)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "imdb info file:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 31)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Export selection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 28)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Export"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(14, 22)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "movie info file:"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(142, 20)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 20)
        Me.TextBox3.TabIndex = 2
        '
        'LogBox
        '
        Me.LogBox.FormattingEnabled = True
        Me.LogBox.Location = New System.Drawing.Point(23, 661)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(964, 69)
        Me.LogBox.TabIndex = 57
        '
        'LabelVersion
        '
        Me.LabelVersion.Location = New System.Drawing.Point(488, 733)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(499, 12)
        Me.LabelVersion.TabIndex = 58
        Me.LabelVersion.Text = "#Version"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'tbCoverFilename
        '
        Me.tbCoverFilename.Location = New System.Drawing.Point(90, 12)
        Me.tbCoverFilename.Name = "tbCoverFilename"
        Me.tbCoverFilename.Size = New System.Drawing.Size(332, 20)
        Me.tbCoverFilename.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbCoverFilename, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'tbFanArtFilename
        '
        Me.tbFanArtFilename.Location = New System.Drawing.Point(90, 37)
        Me.tbFanArtFilename.Name = "tbFanArtFilename"
        Me.tbFanArtFilename.Size = New System.Drawing.Size(332, 20)
        Me.tbFanArtFilename.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbFanArtFilename, "Available tags:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Filename% = Movie Filename")
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Location = New System.Drawing.Point(441, 12)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(436, 92)
        Me.TabControl3.TabIndex = 60
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rbWorkingPath2)
        Me.TabPage1.Controls.Add(Me.rbWorkingPath3)
        Me.TabPage1.Controls.Add(Me.tbWorkingPath1)
        Me.TabPage1.Controls.Add(Me.rbWorkingPath1)
        Me.TabPage1.Controls.Add(Me.RBnone)
        Me.TabPage1.Controls.Add(Me.tbWorkingPath2)
        Me.TabPage1.Controls.Add(Me.tbWorkingPath3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(428, 66)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Working Directory"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tbFanArtFilename)
        Me.TabPage2.Controls.Add(Me.tbCoverFilename)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(428, 66)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cover & FanArt filename in movie folder"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "FanArt filename:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cover filename:"
        '
        'ProgressBarOpen
        '
        Me.ProgressBarOpen.Location = New System.Drawing.Point(78, 78)
        Me.ProgressBarOpen.Name = "ProgressBarOpen"
        Me.ProgressBarOpen.Size = New System.Drawing.Size(319, 10)
        Me.ProgressBarOpen.Step = 1
        Me.ProgressBarOpen.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarOpen.TabIndex = 60
        Me.ProgressBarOpen.Visible = False
        '
        'MovPicNFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 752)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.GroupMovieInfoBox)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupExport)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MovPicNFO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovPicNFO"
        Me.GroupMovieInfoBox.ResumeLayout(False)
        Me.GroupMovieInfoBox.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabCoverFanArt.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CoverImageMovieFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackdropMovieFolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BackdropImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoverImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMovieInfo.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupExport.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabExport.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabImport.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TBMocPicDB As System.Windows.Forms.TextBox
    Friend WithEvents BTopenDB As System.Windows.Forms.Button
    Friend WithEvents GroupMovieInfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents MovieTitleLabel As System.Windows.Forms.Label
    Friend WithEvents CBMovies As System.Windows.Forms.ComboBox
    Friend WithEvents BTExport As System.Windows.Forms.Button
    Friend WithEvents LabelMovieCounter As System.Windows.Forms.Label
    Friend WithEvents LabelSelectedIndex As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupExport As System.Windows.Forms.GroupBox
    Friend WithEvents CheckNFO As System.Windows.Forms.CheckBox
    Friend WithEvents CheckImDb As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNFO As System.Windows.Forms.TextBox
    Friend WithEvents tbImDb As System.Windows.Forms.TextBox
    Friend WithEvents BTExportSelection As System.Windows.Forms.Button
    Friend WithEvents tbWatched As System.Windows.Forms.TextBox
    Friend WithEvents CheckWatched As System.Windows.Forms.CheckBox
    Friend WithEvents tbWorkingPath1 As System.Windows.Forms.TextBox
    Friend WithEvents tbWorkingPath2 As System.Windows.Forms.TextBox
    Friend WithEvents tbWorkingPath3 As System.Windows.Forms.TextBox
    Friend WithEvents rbWorkingPath2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbWorkingPath3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbWorkingPath1 As System.Windows.Forms.RadioButton
    Friend WithEvents RBnone As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabCoverFanArt As System.Windows.Forms.TabPage
    Friend WithEvents BTFanArtFromFile As System.Windows.Forms.Button
    Friend WithEvents BTCoverFromFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTMovieFolderCover As System.Windows.Forms.Button
    Friend WithEvents BTMovieFolderBackdrop As System.Windows.Forms.Button
    Friend WithEvents MovieCoverMovieFolderSize As System.Windows.Forms.Label
    Friend WithEvents CoverImageMovieFolder As System.Windows.Forms.PictureBox
    Friend WithEvents BackdropMovieFolder As System.Windows.Forms.PictureBox
    Friend WithEvents MovieBackdropMovieFolderSize As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTMovPicFanArt As System.Windows.Forms.Button
    Friend WithEvents BTMovPicCover As System.Windows.Forms.Button
    Friend WithEvents BackdropImage As System.Windows.Forms.PictureBox
    Friend WithEvents MovieBackdropSize As System.Windows.Forms.Label
    Friend WithEvents CoverImage As System.Windows.Forms.PictureBox
    Friend WithEvents MovieImageSize As System.Windows.Forms.Label
    Friend WithEvents TabMovieInfo As System.Windows.Forms.TabPage
    Friend WithEvents MovieBackdropPath As System.Windows.Forms.Label
    Friend WithEvents MovieCoverPath As System.Windows.Forms.Label
    Friend WithEvents MovieFileName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MovieFolder As System.Windows.Forms.Label
    Friend WithEvents MovieId As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabExport As System.Windows.Forms.TabPage
    Friend WithEvents TabImport As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents BTopenMovieFolder As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbImportWatch As System.Windows.Forms.TextBox
    Friend WithEvents BTImportSelection As System.Windows.Forms.Button
    Friend WithEvents BTImport As System.Windows.Forms.Button
    Friend WithEvents CheckImportWatch As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents LogBox As System.Windows.Forms.ListBox
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbFanArtFilename As System.Windows.Forms.TextBox
    Friend WithEvents tbCoverFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckFanArt As System.Windows.Forms.CheckBox
    Friend WithEvents tbFanArt As System.Windows.Forms.TextBox
    Friend WithEvents CheckCover As System.Windows.Forms.CheckBox
    Friend WithEvents tbCover As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBarOpen As System.Windows.Forms.ProgressBar

End Class
