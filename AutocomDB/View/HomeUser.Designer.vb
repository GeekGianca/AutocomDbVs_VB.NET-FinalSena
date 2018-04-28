<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeUser
    'Inherits System.Windows.Forms.Form'
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnStartServer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.proBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.temp = New System.Windows.Forms.Timer(Me.components)
        Me.time = New MaterialSkin.Controls.MaterialLabel()
        Me.picCheck = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.serverRunning = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.picCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = "Usuario"
        Me.txtUsername.Location = New System.Drawing.Point(384, 167)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(142, 23)
        Me.txtUsername.TabIndex = 5
        Me.txtUsername.TabStop = False
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = "Contraseña"
        Me.txtPassword.Location = New System.Drawing.Point(384, 291)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(142, 23)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.TabStop = False
        Me.txtPassword.UseSystemPasswordChar = False
        '
        'btnLogin
        '
        Me.btnLogin.Depth = 0
        Me.btnLogin.Location = New System.Drawing.Point(384, 336)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(142, 29)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnStartServer
        '
        Me.btnStartServer.AutoSize = True
        Me.btnStartServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStartServer.Depth = 0
        Me.btnStartServer.Location = New System.Drawing.Point(389, 374)
        Me.btnStartServer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnStartServer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Primary = True
        Me.btnStartServer.Size = New System.Drawing.Size(131, 36)
        Me.btnStartServer.TabIndex = 8
        Me.btnStartServer.Text = "Iniciar Servicios"
        Me.btnStartServer.UseVisualStyleBackColor = True
        Me.btnStartServer.Visible = False
        '
        'proBar
        '
        Me.proBar.Depth = 0
        Me.proBar.ForeColor = System.Drawing.Color.Lime
        Me.proBar.Location = New System.Drawing.Point(389, 419)
        Me.proBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.proBar.Name = "proBar"
        Me.proBar.Size = New System.Drawing.Size(120, 5)
        Me.proBar.TabIndex = 9
        Me.proBar.Visible = False
        '
        'temp
        '
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Depth = 0
        Me.time.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.time.Location = New System.Drawing.Point(508, 410)
        Me.time.MouseState = MaterialSkin.MouseState.HOVER
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(28, 19)
        Me.time.TabIndex = 10
        Me.time.Text = "0%"
        Me.time.Visible = False
        '
        'picCheck
        '
        Me.picCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCheck.Image = Global.AutocomDB.My.Resources.Resources.check
        Me.picCheck.Location = New System.Drawing.Point(439, 429)
        Me.picCheck.Name = "picCheck"
        Me.picCheck.Size = New System.Drawing.Size(34, 34)
        Me.picCheck.TabIndex = 11
        Me.picCheck.TabStop = False
        Me.picCheck.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Image = Global.AutocomDB.My.Resources.Resources.codigo_pin
        Me.PictureBox2.Location = New System.Drawing.Point(415, 209)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 65)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = Global.AutocomDB.My.Resources.Resources.hombre
        Me.PictureBox1.Location = New System.Drawing.Point(415, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 69)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'serverRunning
        '
        Me.serverRunning.AutoSize = True
        Me.serverRunning.Depth = 0
        Me.serverRunning.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.serverRunning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.serverRunning.Location = New System.Drawing.Point(334, 464)
        Me.serverRunning.MouseState = MaterialSkin.MouseState.HOVER
        Me.serverRunning.Name = "serverRunning"
        Me.serverRunning.Size = New System.Drawing.Size(263, 19)
        Me.serverRunning.TabIndex = 12
        Me.serverRunning.Text = "Servidor Iniciado Acceda Nuevamente"
        Me.serverRunning.Visible = False
        '
        'HomeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(879, 530)
        Me.Controls.Add(Me.serverRunning)
        Me.Controls.Add(Me.picCheck)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.proBar)
        Me.Controls.Add(Me.btnStartServer)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "HomeUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.picCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnStartServer As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents proBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents temp As Timer
    Friend WithEvents time As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents picCheck As PictureBox
    Friend WithEvents serverRunning As MaterialSkin.Controls.MaterialLabel
End Class
