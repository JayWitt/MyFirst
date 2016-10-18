Public Class Menu
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        TextBox1.Text = "Now this works out great!" & vbCrLf & Now()
    End Sub
End Class
