Imports System.CodeDom.Compiler
Imports System.IO

Public Class FormLogin
    Dim stPC As String
    Dim iPC, pcAloc As Integer
    Public timeHoraDeSair As DateTime
    Public timeHoraContratada As TimeSpan
    Private Sub FormLogin_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed
        FormLoc.LocMark = False
        FormSelect.AdmMark = False
        FormSelect.Show()
        Me.Close()
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Me.Hide()
        FormRegistrar.Show()
    End Sub

    Private Sub chkSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkSenha.CheckedChanged
        txtPsw.UseSystemPasswordChar = Not chkSenha.Checked
    End Sub

    Private Sub txtPsw_TextChanged(sender As Object, e As EventArgs) Handles txtPsw.TextChanged

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim conectado As Boolean = Connection.Login(txtUser.Text, txtPsw.Text)
            Dim adm As Boolean = Connection.Adm(txtUser.Text, txtPsw.Text)
            If adm = True And FormLoc.LocMark = False Then
                FormADM.Show()
                Me.Hide()
                Exit Sub
            ElseIf conectado = True And FormSelect.AdmMark = False And FormXerox.XeroxMark = False Then
                Try
                    Select Case FormLoc.decMult
                        Case 0.01
                            timeHoraContratada = New TimeSpan(0, 1, 0)
                        Case 0.5
                            timeHoraContratada = New TimeSpan(0, 35, 0)
                        Case 1.0
                            timeHoraContratada = New TimeSpan(1, 5, 0)
                        Case 1.5
                            timeHoraContratada = New TimeSpan(1, 35, 0)
                        Case 2.0
                            timeHoraContratada = New TimeSpan(2, 5, 0)
                        Case 2.5
                            timeHoraContratada = New TimeSpan(2, 35, 0)
                        Case 3.0
                            timeHoraContratada = New TimeSpan(3, 5, 0)
                    End Select
                    Select Case FormLoc.cmbComputer.SelectedIndex
                        Case 0
                            stPC = "ExcelPC"
                        Case 1
                            stPC = "CasualPC"
                        Case 2
                            stPC = "BiniGaming"
                    End Select
                    timeHoraDeSair = DateTime.Now + timeHoraContratada
                    Connection.RegisterCompras(txtUser.Text, stPC, FormLoc.pcCont, DateTime.Now, DateTime.Now + timeHoraContratada, timeHoraDeSair, FormLoc.decPoggers)
                    MessageBox.Show("Obrigado pela compra, você foi alocado ao computador " + stPC + " " + FormLoc.pcCont.ToString + " !")
                Catch ex As Exception
                    MessageBox.Show("Deu Error \n" & ex.ToString)
                Finally
                    FormSelect.Show()
                    Me.Close()
                End Try
                Exit Sub
            ElseIf conectado = True And FormXerox.XeroxMark = True And FormSelect.AdmMark = False Then
                Try
                    Connection.RegisterXerox(txtUser.Text, FormXerox.iCopias, DateTime.Now, FormXerox.decPreco)
                    MessageBox.Show("Obrigado pela compra, você solicitou " + FormXerox.iCopias.ToString + " Copias!!!" & ControlChars.NewLine & "O preço ficou R$" & FormXerox.decPreco.ToString)
                Catch ex As Exception
                    MessageBox.Show("Deu Error \n" & ex.ToString)
                Finally
                    FormSelect.Show()
                    Me.Close()
                End Try
            Else
                MessageBox.Show("Credenciais Invalidas")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class