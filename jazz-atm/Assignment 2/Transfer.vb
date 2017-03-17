Public Class transferSelectionPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transferType = False
        Me.Close()
        transferAmountPage.topChequing.Text = "$" + CStr(chequeing)
        transferAmountPage.topSaving.Text = "$" + CStr(saving)
        transferAmountPage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        transferType = True
        Me.Close()
        transferAmountPage.topChequing.Text = "$" + CStr(chequeing)
        transferAmountPage.topSaving.Text = "$" + CStr(saving)
        transferAmountPage.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        informationPage.Show()
    End Sub
End Class