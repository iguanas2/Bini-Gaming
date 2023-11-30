Public Class FormXerox
    Public decPreco As Decimal
    Public iCopias As Decimal
    Public XeroxMark As Boolean
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblCopias_Click(sender As Object, e As EventArgs) Handles lblCopias.Click

    End Sub

    Private Sub cmbNCopias_DropDownClosed(sender As Object, e As EventArgs) Handles cmbNCopias.DropDownClosed
        Select Case cmbNCopias.SelectedIndex
            Case 0
                decPreco = 0.25
                iCopias = 1
            Case 1
                decPreco = 0.5
                iCopias = 2
            Case 2
                decPreco = 0.75
                iCopias = 3
            Case 3
                decPreco = 1.0
                iCopias = 4
            Case 4
                decPreco = 1.25
                iCopias = 5
            Case 5
                decPreco = 1.5
                iCopias = 6
            Case 6
                decPreco = 1.75
                iCopias = 7
            Case 7
                decPreco = 2.0
                iCopias = 8
            Case 8
                decPreco = 2.25
                iCopias = 9
            Case 9
                decPreco = 2.5
                iCopias = 10
        End Select

        lblPrecoXerox.Text = "R$" & decPreco
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        FormLogin.txtUser.Clear()
        FormLogin.txtPsw.Clear()
        If lblPrecoXerox.Text = "R$0,00" Or lblPrecoXerox.Text = "R$0" Then
            MessageBox.Show("Defina um Número de cópias!!")
            Exit Sub
        End If
        FormLogin.Show()
        Me.Hide()
    End Sub
    Private Sub FormXerox_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed
        FormSelect.Show()
        Me.Close()
    End Sub

    Private Sub FormXerox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XeroxMark = True
    End Sub
End Class