Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormADM
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Private Sub FormAdm_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed
        FormLogin.txtUser.Clear()
        FormLogin.txtPsw.Clear()
        FormLogin.Show()
        Me.Close()
    End Sub
    Private Sub FormADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        If boolPc0(0) = True Then
            imgPc01.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(1) = True Then
            imgPc02.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(2) = True Then
            imgPc03.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(3) = True Then
            imgPc04.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(4) = True Then
            imgPc05.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(5) = True Then
            imgPc06.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(6) = True Then
            imgPc07.Image = My.Resources.pc_indisponivel
        End If
        If boolPc0(7) = True Then
            imgPc08.Image = My.Resources.pc_indisponivel
        End If
        '----------------------------------------------------------------------------------------
        If boolPc1(0) = True Then
            imgPc11.Image = My.Resources.pc_indisponivel
        End If
        If boolPc1(1) = True Then
            imgPc12.Image = My.Resources.pc_indisponivel
        End If
        If boolPc1(2) = True Then
            imgPc13.Image = My.Resources.pc_indisponivel
        End If
        If boolPc1(3) = True Then
            imgPc14.Image = My.Resources.pc_indisponivel
        End If
        If boolPc1(4) = True Then
            imgPc15.Image = My.Resources.pc_indisponivel
        End If
        If boolPc1(5) = True Then
            imgPc16.Image = My.Resources.pc_indisponivel
        End If
        '----------------------------------------------------------------------------------------
        If boolPc2(0) = True Then
            imgPc21.Image = My.Resources.pc_indisponivel
        End If
        If boolPc2(1) = True Then
            imgPc22.Image = My.Resources.pc_indisponivel
        End If
        If boolPc2(2) = True Then
            imgPc23.Image = My.Resources.pc_indisponivel
        End If
        If boolPc2(3) = True Then
            imgPc24.Image = My.Resources.pc_indisponivel
        End If
    End Sub


    Private Sub btnLoadLogin_Click(sender As Object, e As EventArgs) Handles btnLoadLogin.Click
        Try
            Call Connection.PopulateLogin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            btnLoadLogin.Hide()
        End Try
    End Sub

    Private Sub btnLoadCompras_Click(sender As Object, e As EventArgs) Handles btnLoadCompras.Click
        Try
            Call Connection.PopulateCompras()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            btnLoadCompras.Hide()
        End Try
    End Sub
    Private Sub btnLoadXerox_Click(sender As Object, e As EventArgs) Handles btnLoadXerox.Click
        Try
            Call Connection.PopulateXerox()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            btnLoadXerox.Hide()
        End Try
    End Sub


    Private Sub txtSearchComprasChanged(sender As Object, e As EventArgs) Handles txtSearchCompras.TextChanged
        sql = "select * from [dbo].[compras] where "
        searchData(sql, dgvCompras)
    End Sub
    Private Sub searchData(sql As String, dtg As DataGridView)
        Try
            Connection.Open()
            cmd = New SqlCommand()
            da = New SqlDataAdapter
            dt = New DataTable

            With cmd
                .Connection = Connection.connection
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub btnSearchClientes_Click(sender As Object, e As EventArgs) Handles btnSearchClientes.Click
        Try
            sql = "select * from [dbo].[clientes] where usr LIKE '%" & txtSearchClientes.Text & "%' OR email LIKE '%" & txtSearchClientes.Text & "%'"
            searchData(sql, dgvClientes)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSearchCompras_Click(sender As Object, e As EventArgs) Handles btnSearchCompras.Click
        Try
            sql = "select * from [dbo].[compras] where usr LIKE '%" & txtSearchCompras.Text & "%' OR pc LIKE '%" & txtSearchCompras.Text & "%'"
            searchData(sql, dgvCompras)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSearchXerox_Click(sender As Object, e As EventArgs) Handles btnSearchXerox.Click
        Try
            sql = "select * from [dbo].[xerox] where usr LIKE '%" & txtSearchXerox.Text & "%' OR nCopias LIKE '%" & txtSearchXerox.Text & "%'"
            searchData(sql, dgvXerox)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalvarLogin_Click(sender As Object, e As EventArgs) Handles btnSalvarLogin.Click
        Try
            UpdateChanges(dgvClientes, "clientes")
            MessageBox.Show("Alterações Salvas!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalvarCompras_Click(sender As Object, e As EventArgs) Handles btnSalvarCompras.Click
        Try
            UpdateChanges(dgvCompras, "compras")
            MessageBox.Show("Alterações Salvas!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalvarXerox_Click(sender As Object, e As EventArgs) Handles btnSalvarXerox.Click
        Try
            UpdateChanges(dgvXerox, "xerox")
            MessageBox.Show("Alterações Salvas!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class