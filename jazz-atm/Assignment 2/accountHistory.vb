Public Class accountHistory
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        informationPage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub accountHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class