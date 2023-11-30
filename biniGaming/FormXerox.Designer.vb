<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormXerox
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbNCopias = New System.Windows.Forms.ComboBox()
        Me.lblCopias = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gboxCasual = New System.Windows.Forms.GroupBox()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.lblPrecoXerox = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxCasual.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbNCopias
        '
        Me.cmbNCopias.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNCopias.FormattingEnabled = True
        Me.cmbNCopias.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbNCopias.Location = New System.Drawing.Point(322, 19)
        Me.cmbNCopias.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbNCopias.Name = "cmbNCopias"
        Me.cmbNCopias.Size = New System.Drawing.Size(55, 21)
        Me.cmbNCopias.TabIndex = 4
        '
        'lblCopias
        '
        Me.lblCopias.AutoSize = True
        Me.lblCopias.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopias.Location = New System.Drawing.Point(171, 20)
        Me.lblCopias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCopias.Name = "lblCopias"
        Me.lblCopias.Size = New System.Drawing.Size(112, 15)
        Me.lblCopias.TabIndex = 5
        Me.lblCopias.Text = "Número de Cópias"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.biniGaming.My.Resources.Resources.textura_parede
        Me.PictureBox1.Image = Global.biniGaming.My.Resources.Resources.xerox1
        Me.PictureBox1.Location = New System.Drawing.Point(75, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'gboxCasual
        '
        Me.gboxCasual.Controls.Add(Me.btnCompra)
        Me.gboxCasual.Controls.Add(Me.lblPrecoXerox)
        Me.gboxCasual.Controls.Add(Me.lblPreco)
        Me.gboxCasual.Controls.Add(Me.lblCopias)
        Me.gboxCasual.Controls.Add(Me.cmbNCopias)
        Me.gboxCasual.Location = New System.Drawing.Point(9, 132)
        Me.gboxCasual.Margin = New System.Windows.Forms.Padding(2)
        Me.gboxCasual.Name = "gboxCasual"
        Me.gboxCasual.Padding = New System.Windows.Forms.Padding(2)
        Me.gboxCasual.Size = New System.Drawing.Size(582, 171)
        Me.gboxCasual.TabIndex = 15
        Me.gboxCasual.TabStop = False
        '
        'btnCompra
        '
        Me.btnCompra.Location = New System.Drawing.Point(256, 115)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(75, 23)
        Me.btnCompra.TabIndex = 10
        Me.btnCompra.Text = "Comprar"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'lblPrecoXerox
        '
        Me.lblPrecoXerox.AutoSize = True
        Me.lblPrecoXerox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPrecoXerox.Font = New System.Drawing.Font("Arial", 9.8!)
        Me.lblPrecoXerox.Location = New System.Drawing.Point(322, 64)
        Me.lblPrecoXerox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecoXerox.Name = "lblPrecoXerox"
        Me.lblPrecoXerox.Size = New System.Drawing.Size(53, 16)
        Me.lblPrecoXerox.TabIndex = 9
        Me.lblPrecoXerox.Text = "R$0,00"
        Me.lblPrecoXerox.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Font = New System.Drawing.Font("Arial", 9.8!)
        Me.lblPreco.Location = New System.Drawing.Point(196, 64)
        Me.lblPreco.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(44, 16)
        Me.lblPreco.TabIndex = 8
        Me.lblPreco.Text = "Preço"
        Me.lblPreco.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormXerox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.biniGaming.My.Resources.Resources.brick_wall_texture1
        Me.ClientSize = New System.Drawing.Size(600, 315)
        Me.Controls.Add(Me.gboxCasual)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FormXerox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xerox"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxCasual.ResumeLayout(False)
        Me.gboxCasual.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbNCopias As ComboBox
    Friend WithEvents lblCopias As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gboxCasual As GroupBox
    Friend WithEvents lblPrecoXerox As Label
    Friend WithEvents lblPreco As Label
    Friend WithEvents btnCompra As Button
End Class
