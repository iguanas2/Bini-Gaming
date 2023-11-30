<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoc
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoc))
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.cmbComputer = New System.Windows.Forms.ComboBox()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.cmbTempo = New System.Windows.Forms.ComboBox()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.lblPrecoTrue = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBiniP = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCasualP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblExcelP = New System.Windows.Forms.Label()
        Me.lblExcel = New System.Windows.Forms.Label()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Font = New System.Drawing.Font("Arial", 9.8!)
        Me.lblComputer.Location = New System.Drawing.Point(67, 108)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(202, 19)
        Me.lblComputer.TabIndex = 2
        Me.lblComputer.Text = "Seleção de Computadores"
        '
        'cmbComputer
        '
        Me.cmbComputer.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComputer.FormattingEnabled = True
        Me.cmbComputer.Items.AddRange(New Object() {"Excel Gamer (Serviço mais simples para uso básico)", "Casual Gamer (Serviço capaz de executar a maioria dos jogos)", "Bini Gamer (Serviço oferecendo a maior performance possível)"})
        Me.cmbComputer.Location = New System.Drawing.Point(337, 103)
        Me.cmbComputer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbComputer.Name = "cmbComputer"
        Me.cmbComputer.Size = New System.Drawing.Size(447, 24)
        Me.cmbComputer.TabIndex = 3
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Font = New System.Drawing.Font("Arial", 9.8!)
        Me.lblTempo.Location = New System.Drawing.Point(212, 167)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(56, 19)
        Me.lblTempo.TabIndex = 4
        Me.lblTempo.Text = "Tempo"
        Me.lblTempo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbTempo
        '
        Me.cmbTempo.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTempo.FormattingEnabled = True
        Me.cmbTempo.Items.AddRange(New Object() {"30 Min", "1 Hora", "1:30 Min", "2 Horas", "2:30 Min", "3 Horas", "1 Minuto (teste)"})
        Me.cmbTempo.Location = New System.Drawing.Point(417, 166)
        Me.cmbTempo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTempo.Name = "cmbTempo"
        Me.cmbTempo.Size = New System.Drawing.Size(111, 24)
        Me.cmbTempo.TabIndex = 5
        Me.cmbTempo.Text = "Tempo"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Font = New System.Drawing.Font("Arial", 9.8!)
        Me.lblPreco.Location = New System.Drawing.Point(216, 230)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(53, 19)
        Me.lblPreco.TabIndex = 6
        Me.lblPreco.Text = "Preço"
        Me.lblPreco.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrecoTrue
        '
        Me.lblPrecoTrue.AutoSize = True
        Me.lblPrecoTrue.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPrecoTrue.Font = New System.Drawing.Font("Arial", 9.8!)
        Me.lblPrecoTrue.Location = New System.Drawing.Point(431, 230)
        Me.lblPrecoTrue.Name = "lblPrecoTrue"
        Me.lblPrecoTrue.Size = New System.Drawing.Size(61, 19)
        Me.lblPrecoTrue.TabIndex = 7
        Me.lblPrecoTrue.Text = "R$0,00"
        Me.lblPrecoTrue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.lblBiniP)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblCasualP)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblExcelP)
        Me.Panel1.Controls.Add(Me.lblExcel)
        Me.Panel1.Location = New System.Drawing.Point(-4, 281)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 175)
        Me.Panel1.TabIndex = 8
        '
        'lblBiniP
        '
        Me.lblBiniP.AutoSize = True
        Me.lblBiniP.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiniP.Location = New System.Drawing.Point(680, 117)
        Me.lblBiniP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBiniP.Name = "lblBiniP"
        Me.lblBiniP.Size = New System.Drawing.Size(63, 19)
        Me.lblBiniP.TabIndex = 5
        Me.lblBiniP.Text = "R$20/H"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(472, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Bini Gamer (Serviço oferecendo a maior performance possível)"
        '
        'lblCasualP
        '
        Me.lblCasualP.AutoSize = True
        Me.lblCasualP.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasualP.Location = New System.Drawing.Point(680, 76)
        Me.lblCasualP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCasualP.Name = "lblCasualP"
        Me.lblCasualP.Size = New System.Drawing.Size(63, 19)
        Me.lblCasualP.TabIndex = 3
        Me.lblCasualP.Text = "R$10/H"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(471, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Casual Gamer (Serviço capaz de executar a maioria dos jogos)"
        '
        'lblExcelP
        '
        Me.lblExcelP.AutoSize = True
        Me.lblExcelP.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcelP.Location = New System.Drawing.Point(680, 34)
        Me.lblExcelP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExcelP.Name = "lblExcelP"
        Me.lblExcelP.Size = New System.Drawing.Size(54, 19)
        Me.lblExcelP.TabIndex = 1
        Me.lblExcelP.Text = "R$5/H"
        '
        'lblExcel
        '
        Me.lblExcel.AutoSize = True
        Me.lblExcel.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcel.Location = New System.Drawing.Point(51, 34)
        Me.lblExcel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExcel.Name = "lblExcel"
        Me.lblExcel.Size = New System.Drawing.Size(394, 19)
        Me.lblExcel.TabIndex = 0
        Me.lblExcel.Text = "Excel Gamer (Serviço mais simples para uso básico)"
        '
        'btnCompra
        '
        Me.btnCompra.Location = New System.Drawing.Point(681, 230)
        Me.btnCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(100, 28)
        Me.btnCompra.TabIndex = 9
        Me.btnCompra.Text = "Comprar"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FormLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCompra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPrecoTrue)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.cmbTempo)
        Me.Controls.Add(Me.lblTempo)
        Me.Controls.Add(Me.cmbComputer)
        Me.Controls.Add(Me.lblComputer)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormLoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locação"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblComputer As Label
    Friend WithEvents cmbComputer As ComboBox
    Friend WithEvents lblTempo As Label
    Friend WithEvents cmbTempo As ComboBox
    Friend WithEvents lblPreco As Label
    Friend WithEvents lblPrecoTrue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblExcel As Label
    Friend WithEvents lblBiniP As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCasualP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblExcelP As Label
    Friend WithEvents btnCompra As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
