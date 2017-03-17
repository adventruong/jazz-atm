Public Class selectionPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentAcc = False

        If (currentTransfer = False) Then
            If (currentOp = False) Then
                withdrawPage.topChequing.Text = "$" + CStr(chequeing)
                withdrawPage.topSaving.Text = "$" + CStr(saving)
                withdrawPage.Show()
                Me.Close()
            Else
                depositPage.topChequing.Text = "$" + CStr(chequeing)
                depositPage.topSaving.Text = "$" + CStr(saving)
                depositPage.Show()
                Me.Close()
            End If
        Else
            interacPage.topChequing.Text = "$" + CStr(chequeing)
            interacPage.topSaving.Text = "$" + CStr(saving)
            interacPage.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentAcc = True
        If (currentTransfer = False) Then
            If (currentOp = False) Then
                withdrawPage.topChequing.Text = "$" + CStr(chequeing)
                withdrawPage.topSaving.Text = "$" + CStr(saving)
                withdrawPage.Show()
                Me.Close()
            Else
                depositPage.topChequing.Text = "$" + CStr(chequeing)
                depositPage.topSaving.Text = "$" + CStr(saving)
                depositPage.Show()
                Me.Close()
            End If
        Else
            interacPage.topChequing.Text = "$" + CStr(chequeing)
            interacPage.topSaving.Text = "$" + CStr(saving)
            interacPage.Show()
            Me.Close()
        End If
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