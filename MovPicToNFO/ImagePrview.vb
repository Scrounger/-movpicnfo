Public Class ImagePrview

    Private Sub ImagePreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ImageBox.Image.Dispose()
        Me.Close()
    End Sub


    Private Sub ImagePreview_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageBox.Click
        Me.ImageBox.Image.Dispose()
        Me.Close()
    End Sub

    Private Sub ImagePrview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.Hand
    End Sub
End Class