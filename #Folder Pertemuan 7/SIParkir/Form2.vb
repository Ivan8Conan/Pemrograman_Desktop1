Imports MySql.Data.MySqlClient
Public Class frmProfil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim FormSimpanProfil As New FormUtama()
        FormSimpanProfil.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim FormCloseProfil As New FormUtama()
        FormCloseProfil.Show()
        Me.Hide()
    End Sub

    Private Sub frmProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = pengguna
        txtPassword.Text = ppassword
    End Sub

    Private Sub frmProfil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtRetype.Text Then
            Dim sql As String = "update users set password='" & txtPassword.Text & "' where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                frmLogin.txtPassword.Clear()
                frmLogin.txtUsername.Clear()
                Me.Close()
                FormUtama.Close()
                frmLogin.txtUsername.Focus()
                frmLogin.ShowDialog()
                Me.Hide()
            End If
        ElseIf txtRetype.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class