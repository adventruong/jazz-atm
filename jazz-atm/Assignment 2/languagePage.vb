Public Class languagePage
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        languageDisplay.Text = "Current Language: English"
        Button7.Text = "Back"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        languageDisplay.Text = "Idioma actual: Español"
        Button7.Text = "Espalda"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        languageDisplay.Text = "現在の言語: 日本語"
        Button7.Text = "バック"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        languageDisplay.Text = "Langue courante: Français"
        Button7.Text = "Arrière"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        languageDisplay.Text = "当前语言: 中文"
        Button7.Text = "背部"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        languageDisplay.Text = "اللغة الحالية: العربية"
        Button7.Text = "الى الخلف"
    End Sub
End Class