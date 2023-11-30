Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Diagnostics.Eventing

'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
'HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS HUMBERTO LOVERS 
Module Connection
    Public connection As SqlConnection = New SqlConnection("Data Source=VINICIUS-LAPTOP\SQLEXPRESS; Initial Catalog=Cadastrovb; Integrated Security=True")
    Sub Open()
        If connection.State = 0 Then
            connection.Open()
        End If
    End Sub
    Sub Close()
        If connection.State = 1 Then
            connection.Close()
        End If
    End Sub
    ' Create
    Public Sub Command(usr As String, email As String, phone As String, psw As String)
        Try
            Open()
            Dim cmdRegistro As New SqlCommand("
                                           INSERT INTO [dbo].[clientes]
                                                ([usr]
                                                ,[email]
                                                ,[phone]
                                                ,[psw])
                                           VALUES
                                                ('" + usr + "',
                                                 '" + email + "',
                                                 '" + phone + "',
                                                 '" + psw + "')", connection)
            cmdRegistro.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(connection.State)
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Sub
    ' Read
    Public Function Login(usr As String, psw As String)
        Try
            Open()
            Dim cmdRegistro As New SqlCommand("select * from [dbo].[clientes] where usr = ('" + usr + "') and psw = ('" + psw + "')", connection)
            Dim reader As SqlDataReader = cmdRegistro.ExecuteReader()
            If reader.HasRows Then
                ' Usuário válido, credenciais corretas
                Return True
            Else
                ' Usuário inválido, credenciais incorretas
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Read
    Public Function Adm(usr As String, psw As String)
        Try
            Open()
            Dim cmdRegistro As New SqlCommand("select * from [dbo].[clientes] where usr = ('" + usr + "') and psw = ('" + psw + "') and adm = 1", Connection)
            Dim reader As SqlDataReader = cmdRegistro.ExecuteReader()
            If reader.HasRows Then
                ' Usuário válido, credenciais corretas
                MessageBox.Show("Adm logado!")
                Return True
            Else
                ' Usuário inválido, credenciais incorretas
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Read
    Public Function PopulateLogin()
        Try
            Open()
            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter("select * from [dbo].[clientes]", connection)

            adapter.Fill(table)
            FormADM.dgvClientes.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Read
    Public Function PopulateCompras()
        Try
            Open()
            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter("select * from [dbo].[compras]", connection)

            adapter.Fill(table)
            FormADM.dgvCompras.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Read
    Public Function PopulateXerox()
        Try
            Open()
            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter("select * from [dbo].[xerox]", connection)

            adapter.Fill(table)
            FormADM.dgvXerox.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Update
    Public Sub UpdateChanges(dataGridView As DataGridView, tableName As String)
        Try
            Open()
            Dim changes As DataTable = DirectCast(dataGridView.DataSource, DataTable)
            Dim adapter As New SqlDataAdapter($"select * from [dbo].[{tableName}]", connection)

            Dim builder As New SqlCommandBuilder(adapter)
            adapter.UpdateCommand = builder.GetUpdateCommand()

            adapter.Update(changes)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Sub
    'Delete

    ' Read
    Public Function Existe(usr As String)
        Try
            Open()
            Dim cmdExiste As New SqlCommand("select * from [dbo].[clientes] where usr = ('" + usr + "')", connection)
            Dim reader As SqlDataReader = cmdExiste.ExecuteReader()
            If reader.HasRows Then
                ' Existe Usuário
                Return True
            Else
                ' Não Existe Usuário
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Read
    Public Function Fill(usr As String)
        Try
            Open()
            Dim cmdExiste As New SqlCommand("select * from [dbo].[clientes] where usr = ('" + usr + "')", connection)
            Dim adapter As New SqlDataAdapter("select * from [dbo].[clientes]", connection)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Create
    Public Function RegisterCompras(usr As String, pc As String, pcNum As Integer, time As String, datetime As String, tempoAlocado As String, preco As Decimal)
        Try
            Open()
            Dim cmdRegistro As New SqlCommand("
            INSERT INTO [dbo].[compras] ([usr], [pc], [pcNum], [tempo], [tempoDataAlocado], [tempoAlocado], [preco])
            VALUES (@usr, @pc, @pcNum, @time,@datetime, @tempoAlocado, @preco)", connection)

            ' Adicionar parametros
            cmdRegistro.Parameters.AddWithValue("@usr", usr)
            cmdRegistro.Parameters.AddWithValue("@pc", pc)
            cmdRegistro.Parameters.AddWithValue("@pcNum", pcNum)
            cmdRegistro.Parameters.AddWithValue("@time", time)
            cmdRegistro.Parameters.AddWithValue("@datetime", datetime)
            cmdRegistro.Parameters.AddWithValue("@tempoAlocado", tempoAlocado)
            cmdRegistro.Parameters.AddWithValue("@preco", preco)

            cmdRegistro.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Read
    Public Function AlocCheck(pc As String) As Integer()
        Try
            Open()
            Dim numeroPC As New List(Of Integer)
            Dim query As New SqlCommand("SELECT pcNum FROM [dbo].[compras] WHERE tempoDataAlocado >= @DataAtual AND pc = @PC", connection)
            query.Parameters.AddWithValue("@DataAtual", DateTime.Now)
            query.Parameters.AddWithValue("@PC", pc)

            Dim rdr = query.ExecuteReader

            While rdr.Read()
                numeroPC.Add(rdr.GetInt32(0))
            End While

            Return numeroPC.ToArray()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
    ' Create
    Public Function RegisterXerox(usr As String, nCopias As Integer, tempo As String, preco As Decimal)
        Try
            Open()
            Dim cmdXerox As New SqlCommand("
            INSERT INTO [dbo].[xerox] ([usr], [nCopias], [tempo], [preco])
            VALUES (@usr, @nCopias, @tempo, @preco)", connection)

            ' Adicionar parametros
            cmdXerox.Parameters.AddWithValue("@usr", usr)
            cmdXerox.Parameters.AddWithValue("@nCopias", nCopias)
            cmdXerox.Parameters.AddWithValue("@tempo", tempo)
            cmdXerox.Parameters.AddWithValue("@preco", preco)

            cmdXerox.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Close()
        End Try
    End Function
End Module

