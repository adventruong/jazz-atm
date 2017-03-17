Public Class withdrawPage

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        displayWithdraw("1")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        displayWithdraw("2")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        displayWithdraw("3")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        displayWithdraw("4")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        displayWithdraw("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        displayWithdraw("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        displayWithdraw("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        displayWithdraw("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        displayWithdraw("9")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        displayWithdraw("0")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        displayWithdraw("a")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        informationPage.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If ((Not currentAcc) And withNum <= chequeing) Then
            chequeing = chequeing - withNum
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        ElseIf (currentAcc And withNum <= chequeing) Then
            saving = saving - withNum
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        Else
            MsgBox("You cannot withdraw more than you have in your account",, "Insufficient Funds")
            withdrawDisplay.Text = "$"
        End If

        withNum = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((Not currentAcc) And 20 <= chequeing) Then
            chequeing = chequeing - 20
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        ElseIf (currentAcc And 20 <= chequeing) Then
            saving = saving - 20
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        Else
            MsgBox("You cannot withdraw more than you have in your account",, "Insufficient Funds")
            withNum = ""
            withdrawDisplay.Text = "$"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ((Not currentAcc) And 40 <= chequeing) Then
            chequeing = chequeing - 40
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        ElseIf (currentAcc And 40 <= chequeing) Then
            saving = saving - 40
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        Else
            MsgBox("You cannot withdraw more than you have in your account",, "Insufficient Funds")
            withNum = ""
            withdrawDisplay.Text = "$"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ((Not currentAcc) And 60 <= chequeing) Then
            chequeing = chequeing - 60
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        ElseIf (currentAcc And 60 <= chequeing) Then
            saving = saving - 60
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        Else
            MsgBox("You cannot withdraw more than you have in your account",, "Insufficient Funds")
            withNum = ""
            withdrawDisplay.Text = "$"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ((Not currentAcc) And 100 <= chequeing) Then
            chequeing = chequeing - 100
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        ElseIf (currentAcc And 100 <= chequeing) Then
            saving = saving - 100
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        Else
            MsgBox("You cannot withdraw more than you have in your account",, "Insufficient Funds")
            withNum = ""
            withdrawDisplay.Text = "$"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ((Not currentAcc) And 200 <= chequeing) Then
            chequeing = chequeing - 200
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        ElseIf (currentAcc And 200 <= chequeing) Then
            saving = saving - 200
            updateInformationPage()
            updateReceipt()
            receiptPage.Show()
            Me.Close()
        Else
            MsgBox("You cannot withdraw more than you have in your account",, "Insufficient Funds")
            withNum = ""
            withdrawDisplay.Text = "$"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Close()
        Main.Show()
    End Sub
End Class