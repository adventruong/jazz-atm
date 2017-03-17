Public Class interacPage
    Private Sub interacAmountDisplay_Click(sender As Object, e As EventArgs) Handles interacAmountDisplay.Click
        interacType = False
        interacAmountDisplay.Text = "$"
    End Sub

    Private Sub interactPinDisplay_Click(sender As Object, e As EventArgs) Handles interacPinDisplay.Click
        interacType = True
        interacPinDisplay.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (interacType = False) Then
            displayInteracAmount("1")
        Else
            displayInteracPin("*")
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (interacType = False) Then
            displayInteracAmount("2")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (interacType = False) Then
            displayInteracAmount("3")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (interacType = False) Then
            displayInteracAmount("4")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (interacType = False) Then
            displayInteracAmount("5")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (interacType = False) Then
            displayInteracAmount("6")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (interacType = False) Then
            displayInteracAmount("7")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (interacType = False) Then
            displayInteracAmount("8")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (interacType = False) Then
            displayInteracAmount("9")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (interacType = False) Then
            displayInteracAmount("0")
        Else
            displayInteracPin("*")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (interacType = False) Then
            displayInteracAmount("a")
        Else
            displayInteracPin("a")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        informationPage.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (Not (currentContact = "" Or interacNum = "" Or interacPin = "")) Then
            If (currentAcc) Then
                If (saving < interacNum Or Len(interacPin) < 4) Then
                    If (saving < interacNum) Then
                        MsgBox("Insufficient Funds to complete transaction",, "Insufficent Funds")
                    ElseIf (Len(interacPin) < 4) Then
                        MsgBox("Pin must be a minimum of 4 digits",, "Pin too short")
                    End If
                Else
                    saving = saving - interacNum
                    updateInformationPage()
                    updateReceipt()
                    Me.Close()
                    receiptPage.Show()
                End If
            Else
                If (chequeing < interacNum Or Len(interacPin) < 4) Then
                    If (chequeing < interacNum) Then
                        MsgBox("Insufficient Funds to complete transaction",, "Insufficent Funds")
                    ElseIf (Len(interacPin) < 4) Then
                        MsgBox("Pin must be a minimum of 4 digits",, "Pin too short")
                    End If
                Else
                    chequeing = chequeing - interacNum
                    updateInformationPage()
                    updateReceipt()
                    Me.Close()
                    receiptPage.Show()
                End If
            End If
        Else
            If (currentContact = "") Then
                MsgBox("Please Select a Contact",, "Select Contact")
            ElseIf (interacNum = "") Then
                MsgBox("Please Enter an Amount",, "Please Enter Amount")
            ElseIf (interacPin = "") Then
                MsgBox("Please Enter a password",, "Please Enter Pin")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        contactPage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        informationPage.Show()
    End Sub


End Class