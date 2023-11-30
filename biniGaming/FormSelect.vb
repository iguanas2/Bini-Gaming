Public Class FormSelect
    Public AdmMark As Boolean
    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        FormLoc.cmbComputer.Text = ""
        FormLoc.cmbTempo.Text = ""
        FormLoc.lblPrecoTrue.Text = "R$0,00"
        Me.Hide()
        FormLoc.Show()
    End Sub

    Private Sub btnAdm_Click(sender As Object, e As EventArgs) Handles btnAdm.Click
        Me.Hide()
        AdmMark = True
        FormLogin.txtUser.Clear()
        FormLogin.txtPsw.Clear()
        FormLogin.Show()
    End Sub

    Private Sub btnXer_Click(sender As Object, e As EventArgs) Handles btnXer.Click
        FormXerox.cmbNCopias.Text = ""
        FormXerox.lblPrecoXerox.Text = "R$0,00"
        Me.Hide()
        FormXerox.Show()
    End Sub

    Private Sub FormSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pcExc As String = "ExcelPC"
        Dim pcCas As String = "CasualPC"
        Dim pcBini As String = "BiniGaming"
        FormXerox.XeroxMark = False
        Dim Resultado As Integer()
        Resultado = AlocCheck(pcExc)
        If Resultado.Length > 0 Then
            For Each valor As Integer In Resultado
                boolPc0(valor) = True
            Next
        End If
        Resultado = AlocCheck(pcCas)
        If Resultado.Length > 0 Then
            For Each valor As Integer In Resultado
                boolPc1(valor) = True
            Next
        End If
        Resultado = AlocCheck(pcBini)
        If Resultado.Length > 0 Then
            For Each valor As Integer In Resultado
                boolPc2(valor) = True
            Next
        End If
    End Sub
End Class
