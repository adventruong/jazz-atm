Public Class transferAmountPage
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        displayTransfer("1")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        displayTransfer("2")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        displayTransfer("3")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        displayTransfer("4")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        displayTransfer("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        displayTransfer("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        displayTransfer("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        displayTransfer("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        displayTransfer("9")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        displayTransfer("0")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        displayTransfer("a")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        informationPage.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (transferType = False) Then
            If (transNum <= chequeing) Then
                chequeing = chequeing - transNum
                saving = saving + transNum
                updateReceipt()
                receiptPage.Show()
                Me.Close()
            Else
                MsgBox("You have insufficient funds to transfer",, "Insufficient Funds")
            End If
        Else
            If (transNum <= saving) Then
                chequeing = chequeing + transNum
                saving = saving - transNum
                updateReceipt()
                receiptPage.Show()
                Me.Close()
            Else
                MsgBox("You have insufficient funds to transfer",, "Insufficient Funds")
            End If
        End If

        transNum = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        transferSelectionPage.Show()
    End Sub
End Class