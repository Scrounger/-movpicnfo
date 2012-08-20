Public Class Helper
    Public Shared Function CreateCloneImage(ByVal path As String) As Bitmap

        Dim bmpClone As Bitmap = Nothing 'the clone to be loaded to a PictureBox

        Try
            'Work around: ImageClone erstellen, weil sonst löschen net funzt -> verhindert (... used by other process)

            Dim bmpOriginal As System.Drawing.Image = System.Drawing.Image.FromFile(path)
            bmpClone = New Bitmap(bmpOriginal.Width, bmpOriginal.Height)
            Dim gr As Graphics = Graphics.FromImage(bmpClone) 'get object representing clone's currently empty drawing surface
            gr.SmoothingMode = Drawing2D.SmoothingMode.None
            gr.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
            gr.DrawImage(bmpOriginal, 0, 0, bmpOriginal.Width, bmpOriginal.Height) 'copy original image onto this surface
            gr.Dispose()

            bmpOriginal.Dispose()

        Catch ex As Exception
            MsgBox("[CreateCloneImage] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return bmpClone
    End Function

End Class
