Public Class Menu
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        TextBox1.Text = "Now this works out great!" & vbCrLf & Now()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox.Show()
    End Sub
End Class
