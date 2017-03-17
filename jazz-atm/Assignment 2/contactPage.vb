Public Class contactPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentContact = "Jesse Truong"
        interacPage.contactDisplay.Text = currentContact
        interacPage.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentContact = "Jasman Gill"
        interacPage.contactDisplay.Text = currentContact
        interacPage.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        currentContact = "Barack Obama"
        interacPage.contactDisplay.Text = currentContact
        interacPage.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        currentContact = "Hillary Clinton"
        interacPage.contactDisplay.Text = currentContact
        interacPage.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        currentContact = "Donald Trump"
        interacPage.contactDisplay.Text = currentContact
        interacPage.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        interacPage.Show()
    End Sub
End Class