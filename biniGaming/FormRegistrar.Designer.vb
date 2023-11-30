<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrar
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
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPsw = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.chkSenha = New System.Windows.Forms.CheckBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(193, 277)
        Me.txtPsw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.Size = New System.Drawing.Size(180, 22)
        Me.txtPsw.TabIndex = 7
        Me.txtPsw.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(193, 138)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(180, 22)
        Me.txtUser.TabIndex = 6
        '
        'lblPsw
        '
        Me.lblPsw.AutoSize = True
        Me.lblPsw.Location = New System.Drawing.Point(56, 277)
        Me.lblPsw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPsw.Name = "lblPsw"
        Me.lblPsw.Size = New System.Drawing.Size(51, 16)
        Me.lblPsw.TabIndex = 5
        Me.lblPsw.Text = "Senha*"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(55, 142)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(59, 16)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "Usuário*"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(193, 185)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 22)
        Me.txtEmail.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(55, 188)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(55, 235)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefone.TabIndex = 10
        Me.lblTelefone.Text = "Telefone"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(170, 345)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 28)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'chkSenha
        '
        Me.chkSenha.AutoSize = True
        Me.chkSenha.Location = New System.Drawing.Point(221, 306)
        Me.chkSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSenha.Name = "chkSenha"
        Me.chkSenha.Size = New System.Drawing.Size(116, 20)
        Me.chkSenha.TabIndex = 13
        Me.chkSenha.Text = "Mostrar Senha"
        Me.chkSenha.UseVisualStyleBackColor = True
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(193, 231)
        Me.txtTelefone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefone.Mask = "(99) 00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(180, 22)
        Me.txtTelefone.TabIndex = 14
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.Location = New System.Drawing.Point(70, 408)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(52, 16)
        Me.lblDelete.TabIndex = 18
        Me.lblDelete.Text = "Apagar"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Location = New System.Drawing.Point(314, 408)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(46, 16)
        Me.lblSave.TabIndex = 20
        Me.lblSave.Text = "Salvar"
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.biniGaming.My.Resources.Resources.save_button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Location = New System.Drawing.Point(306, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 60)
        Me.btnSave.TabIndex = 19
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.biniGaming.My.Resources.Resources._3334328
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelete.Location = New System.Drawing.Point(66, 345)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 60)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.biniGaming.My.Resources.Resources.bini_gaming_nole
        Me.PictureBox1.Location = New System.Drawing.Point(112, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'FormRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 446)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.chkSenha)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPsw)
        Me.Controls.Add(Me.lblUser)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormRegistrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPsw As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPsw As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents chkSenha As CheckBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblDelete As Label
    Friend WithEvents lblSave As Label
    Friend WithEvents btnSave As Button
End Class
