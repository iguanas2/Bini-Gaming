<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelect))
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnXer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoc
        '
        Me.btnLoc.Location = New System.Drawing.Point(42, 250)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(118, 55)
        Me.btnLoc.TabIndex = 1
        Me.btnLoc.Text = "Locação de Máquinas"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnAdm
        '
        Me.btnAdm.Location = New System.Drawing.Point(233, 250)
        Me.btnAdm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(118, 55)
        Me.btnAdm.TabIndex = 2
        Me.btnAdm.Text = "Página do Admin"
        Me.btnAdm.UseVisualStyleBackColor = True
        '
        'btnXer
        '
        Me.btnXer.Location = New System.Drawing.Point(427, 250)
        Me.btnXer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnXer.Name = "btnXer"
        Me.btnXer.Size = New System.Drawing.Size(118, 55)
        Me.btnXer.TabIndex = 3
        Me.btnXer.Text = "Xerox"
        Me.btnXer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.biniGaming.My.Resources.Resources.bini_gaming
        Me.PictureBox1.Location = New System.Drawing.Point(184, 60)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnXer)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnLoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "FormSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleção de Páginas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnAdm As Button
    Friend WithEvents btnXer As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
