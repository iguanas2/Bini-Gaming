
Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormRegistrar
    Private Sub FormRegistrar_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed
        FormLogin.Show()
        Me.Close()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If Connection.Existe(txtUser.Text) = False Then
                Call Connection.Command(txtUser.Text, txtEmail.Text, txtTelefone.Text, txtPsw.Text)
                MessageBox.Show("Cadastro bem Sucedido!!!")
                FormLogin.Show()
                Me.Close()
            Else
                MessageBox.Show("Usuário existente")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub FormRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = ""
        txtEmail.Text = ""
        txtTelefone.Text = ""
        txtPsw.Text = ""
        btnDelete.Hide()
        lblDelete.Hide()
        btnSave.Hide()
        lblSave.Hide()
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        Try
            If Connection.Existe(txtUser.Text) = True Then
                txtPsw.Focus()
            Else
                txtEmail.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        txtTelefone.Focus()
    End Sub

    Private Sub txtTelefone_Leave(sender As Object, e As EventArgs) Handles txtTelefone.Leave
        txtPsw.Focus()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub chkSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkSenha.CheckedChanged
        txtPsw.UseSystemPasswordChar = Not chkSenha.Checked
    End Sub
    ' Delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem certeza que deseja deletar sua conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Dim userNameToDelete As String = txtUser.Text.Trim()
            If Not String.IsNullOrEmpty(userNameToDelete) Then
                Dim query As String = "delete from [dbo].[clientes] where usr = @User"
                Using command As New SqlCommand(query, Connection.connection)
                    command.Parameters.AddWithValue("@User", userNameToDelete)
                    Try
                        Connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected & " row(s) deleted successfully.")
                    Catch ex As Exception
                        MessageBox.Show("Error deleting data: " & ex.Message)
                    End Try
                End Using
                Me.Close()
                FormLogin.Show()
            Else
                MessageBox.Show("Please enter a valid User Name.")
            End If
        End If
    End Sub
    ' Update
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Connection.Open()
            Using command As New SqlCommand("update [dbo].[clientes] set email = @Email, phone = @Phone, psw = @Psw where usr = ('" + txtUser.Text + "')", Connection.connection)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.Parameters.AddWithValue("@Phone", txtTelefone.Text)
                command.Parameters.AddWithValue("@Psw", txtPsw.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                MessageBox.Show(rowsAffected & "Alterações salvas com sucesso!")
            End Using
            Me.Close()
            FormLogin.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtPsw_Leave(sender As Object, e As EventArgs) Handles txtPsw.Leave
        Try
            If Connection.Login(txtUser.Text, txtPsw.Text) = True Then
                Try
                    btnDelete.Show()
                    lblDelete.Show()
                    btnSave.Show()
                    lblSave.Show()
                    Connection.Open()
                    Dim cmdExiste As New SqlCommand("select * from [dbo].[clientes] where usr = ('" + txtUser.Text + "')", Connection.connection)
            Using reader As SqlDataReader = cmdExiste.ExecuteReader()
                        If reader.Read() Then
                            Dim email As String = reader.GetString(2)
                            Dim telefone As String = reader.GetString(3)
                            Dim psw As String = reader.GetString(4)
                            txtEmail.Text = email
                            txtTelefone.Text = telefone
                            txtPsw.Text = psw
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    Connection.Open()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class