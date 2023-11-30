
Imports System.Security.Cryptography.X509Certificates

Public Class FormLoc
    Public LocMark As Boolean
    Public pcCont, pcSelect As Integer
    Public excPC, casPC, biniPC As Integer
    Public decPreco, decMult, decPoggers As Decimal
    Dim stSelectComputador As String
    Dim todosOsPcsOcupados As Boolean = True

    Sub Main()

    End Sub

    Private Sub cmbTempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTempo.SelectedIndexChanged

    End Sub

    Private Sub FormLoc_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed
        FormSelect.Show()
        Me.Close()
    End Sub


    Private Sub cmbComputer_DropDownClosed(sender As Object, e As EventArgs) Handles cmbComputer.DropDownClosed

        If cmbComputer.SelectedIndex = 0 Then
            decPreco = 5
        ElseIf cmbComputer.SelectedIndex = 1 Then
            decPreco = 10
        ElseIf cmbComputer.SelectedIndex = 2 Then
            decPreco = 20
        End If

        decPoggers = decPreco * decMult
        lblPrecoTrue.Text = "R$" & decPoggers
    End Sub

    Private Sub cmbTempo_DropDownClosed(sender As Object, e As EventArgs) Handles cmbTempo.DropDownClosed

        If cmbTempo.SelectedIndex = 0 Then
            decMult = 0.5
        ElseIf cmbTempo.SelectedIndex = 1 Then
            decMult = 1.0
        ElseIf cmbTempo.SelectedIndex = 2 Then
            decMult = 1.5
        ElseIf cmbTempo.SelectedIndex = 3 Then
            decMult = 2.0
        ElseIf cmbTempo.SelectedIndex = 4 Then
            decMult = 2.5
        ElseIf cmbTempo.SelectedIndex = 5 Then
            decMult = 3.0
        ElseIf cmbTempo.SelectedIndex = 6 Then
            decMult = 0.01
        End If

        decPoggers = decPreco * decMult
        lblPrecoTrue.Text = "R$" & decPoggers

    End Sub


    Private Sub FormLoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblExcelP.Text = "R$" & 5 & "/h"
        lblCasualP.Text = "R$" & 10 & "/h"
        lblBiniP.Text = "R$" & 20 & "/h"
        Dim pcExc As String = "ExcelPC"
        Dim pcCas As String = "CasualPC"
        Dim pcBini As String = "BiniGaming"
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

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click

        FormLogin.txtUser.Clear()
        FormLogin.txtPsw.Clear()
        If lblPrecoTrue.Text = "R$0,00" Or lblPrecoTrue.Text = "R$0" Then
            MessageBox.Show("Defina um Computador e o Tempo de operação!!")
            Exit Sub
        End If
        If cmbComputer.SelectedIndex = 0 Then
            For excPC = 0 To 7
                If boolPc0(excPC) = False Then
                    ' Se encontrar pelo menos um computador livre, atualiza a flag e sai do loop
                    todosOsPcsOcupados = False
                    Exit For
                End If
            Next
        ElseIf cmbComputer.SelectedIndex = 1 Then
            For casPC = 0 To 5
                If boolPc0(casPC) = False Then
                    ' Se encontrar pelo menos um computador livre, atualiza a flag e sai do loop
                    todosOsPcsOcupados = False
                    Exit For
                End If
            Next
        ElseIf cmbComputer.SelectedIndex = 2 Then
            For biniPC = 0 To 5
                If boolPc0(biniPC) = False Then
                    ' Se encontrar pelo menos um computador livre, atualiza a flag e sai do loop
                    todosOsPcsOcupados = False
                    Exit For
                End If
            Next
        End If
        If todosOsPcsOcupados Then
            MessageBox.Show("Todos os computadores estão ocupados no momento.")
        Else
            ' Encontrou um computador livre, realiza as ações necessárias
            Select Case cmbComputer.SelectedIndex
                Case 0
                    pcCont = excPC
                Case 1
                    pcCont = casPC
                Case 2
                    pcCont = biniPC
            End Select
            pcSelect = cmbComputer.SelectedIndex
            FormLogin.Show()
            Me.Hide()
            LocMark = True
        End If
    End Sub

End Class