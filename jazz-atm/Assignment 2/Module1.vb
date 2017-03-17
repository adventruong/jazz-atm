Module Module1
    Public accountNum As String = ""
    Public chequeing As Integer = 20000
    Public saving As Integer = 10000
    Public pin As String = ""
    Public withNum As String = ""
    Public depNum As String = ""
    Public transNum As String = ""
    Public interacNum As String = ""
    Public interacPin As String = ""
    Public currentContact As String = ""
    Public currentAcc As Boolean = False 'false is chequeing and true is savings
    Public currentTransfer As Boolean = False 'false is withdraw/deposit, true is interac
    Public currentOp As Boolean = False 'false is withdraw and true is deposit
    Public transferType As Boolean = False 'false is chequeing to saving and true is saving to chequeing
    Public interacType As Boolean = False 'false is amount, true is pin

    Public Sub displayLanguage(ByVal num1 As String)
        languagePage.languageDisplay.Text = num1
    End Sub

    Public Sub displayAccount(ByVal num1 As String)
        If (num1 = "a" And Len(accountNum) > 0) Then
            accountNum = Left(accountNum, Len(accountNum) - 1)
        ElseIf (Not num1 = "a") Then
            If (accountNum.Length < 16) Then
                accountNum = accountNum + num1
            End If
        End If

        Account.accountDisplay.Text = accountNum
    End Sub

    Public Sub displayPin(ByVal num1 As String)
        If (num1 = "a" And Len(pin) > 0) Then
            pin = Left(pin, Len(pin) - 1)
        ElseIf (Not num1 = "a") Then
            If (pin.Length < 8) Then
                pin = pin + num1
            End If
        End If

        pinPage.pinDisplay.Text = pin
    End Sub

    Public Sub displayInteracAmount(ByVal num1 As String)
        If (num1 = "a" And Len(interacNum) > 0) Then
            interacNum = Left(pin, Len(interacNum) - 1)
        ElseIf (Not num1 = "a") Then
            interacNum = interacNum + num1
        End If

        interacPage.interacAmountDisplay.Text = "$" + interacNum
    End Sub

    Public Sub displayInteracPin(ByVal num1 As String)
        If (num1 = "a" And Len(interacPin) > 0) Then
            interacPin = Left(interacPin, Len(interacPin) - 1)
        ElseIf (Not num1 = "a") Then
            If (interacPin.Length < 8) Then
                interacPin = interacPin + num1
            End If
        End If

        interacPage.interacPinDisplay.Text = interacPin
    End Sub

    Public Sub displayWithdraw(ByVal num1 As String)
        If (num1 = "a" And Len(withNum) > 0) Then
            withNum = Left(withNum, Len(withNum) - 1)
        ElseIf (Not num1 = "a") Then
            withNum = withNum + num1
        End If

        withdrawPage.withdrawDisplay.Text = "$" + withNum
    End Sub

    Public Sub displayTransfer(ByVal num1 As String)
        If (num1 = "a" And Len(transNum) > 0) Then
            transNum = Left(transNum, Len(transNum) - 1)
        ElseIf (Not num1 = "a") Then
            transNum = transNum + num1
        End If

        transferAmountPage.transferDisplay.Text = "$" + transNum
    End Sub

    Public Sub updateInformationPage()
        informationPage.chequeingDisplay.Text = "$" + CStr(chequeing)
        informationPage.savingDisplay.Text = "$" + CStr(saving)
    End Sub

    Public Sub updateReceipt()
        receiptPage.receiptChequeing.Text = "$" + CStr(chequeing)
        receiptPage.receiptSaving.Text = "$" + CStr(saving)
    End Sub

    Public Sub displayDeposit(ByVal num1 As String)
        If (num1 = "a" And Len(depNum) > 0) Then
            depNum = Left(depNum, Len(depNum) - 1)
        ElseIf (Not num1 = "a") Then
            depNum = depNum + num1
        End If

        depositPage.depositDisplay.Text = "$" + depNum
    End Sub
End Module
