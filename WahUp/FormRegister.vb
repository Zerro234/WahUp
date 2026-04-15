Public Class FormRegister
    Private Rand As New Random()
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim id_user, nama, nohp, password, passwordUlang As String
        id_user = Rand.Next(0, 99999).ToString("00000")
        nama = txtNama.Text.Trim()
        nohp = txtNoHp.Text.Trim()
        password = txtPassword.Text.Trim()
        passwordUlang = txtUlangPassword.Text.Trim()

        If (nama = "") Then
            txtNama.Focus()
            Return
        ElseIf (nohp = "") Then
            txtNoHp.Focus()
            Return
        ElseIf (password = "") Then
            txtPassword.Focus()
            Return
        ElseIf (passwordulang = "") Then
            txtUlangPassword.Focus()
            Return
        ElseIf (password <> passwordulang) Then
            MessageBox.Show("Password tidak valid!!!")
            txtUlangPassword.Focus()
            Return
        ElseIf (pbProfile.Image Is Nothing) Then
            pbProfile_Click(Nothing, Nothing)
            Return
        End If

        Dim text As String
        text = $"INSERT INTO TBL_USER (ID_USER, NAMA, NOHP, PASSWORD)" +
               $"VALUES ('{id_user}','{nama}','{nohp}','{password}')"

        Dim sql As SQL
        sql = New SQL
        sql.Execute(text)

        MessageBox.Show("Register Berhasil !!!")
    End Sub

    Private Sub pbProfile_Click(sender As Object, e As EventArgs) Handles pbProfile.Click

    End Sub
End Class