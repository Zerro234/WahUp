Public Class FormLogin
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Frm As Form
        Frm = New FormRegister()
        Frm.ShowDialog()

    End Sub
End Class