<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPsw = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.chkSenha = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(119, 151)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(54, 16)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Usuário"
        '
        'lblPsw
        '
        Me.lblPsw.AutoSize = True
        Me.lblPsw.Location = New System.Drawing.Point(119, 198)
        Me.lblPsw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPsw.Name = "lblPsw"
        Me.lblPsw.Size = New System.Drawing.Size(46, 16)
        Me.lblPsw.TabIndex = 1
        Me.lblPsw.Text = "Senha"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(257, 146)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(180, 22)
        Me.txtUser.TabIndex = 2
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(256, 198)
        Me.txtPsw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.Size = New System.Drawing.Size(180, 22)
        Me.txtPsw.TabIndex = 3
        Me.txtPsw.UseSystemPasswordChar = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(205, 260)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 28)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(205, 310)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(100, 28)
        Me.BtnRegistrar.TabIndex = 5
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'chkSenha
        '
        Me.chkSenha.AutoSize = True
        Me.chkSenha.Location = New System.Drawing.Point(273, 230)
        Me.chkSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSenha.Name = "chkSenha"
        Me.chkSenha.Size = New System.Drawing.Size(116, 20)
        Me.chkSenha.TabIndex = 6
        Me.chkSenha.Text = "Mostrar Senha"
        Me.chkSenha.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.biniGaming.My.Resources.Resources.bini_gaming_nole
        Me.PictureBox1.Location = New System.Drawing.Point(161, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 372)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkSenha)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPsw)
        Me.Controls.Add(Me.lblUser)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblPsw As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents chkSenha As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
