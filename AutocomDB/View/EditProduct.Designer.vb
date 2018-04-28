<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEp
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtNameProduct = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtRefProduct = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtInit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtIn = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtDateIn = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtOut = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtDateOut = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblFac = New MaterialSkin.Controls.MaterialLabel()
        Me.numberFac = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(36, 146)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(128, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Nombre Producto"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(280, 146)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(80, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Referencia"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(539, 146)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(49, 19)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Inicial"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(723, 146)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(68, 19)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Entradas"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(539, 234)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(50, 19)
        Me.MaterialLabel5.TabIndex = 4
        Me.MaterialLabel5.Text = "Salida"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(41, 234)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(123, 19)
        Me.MaterialLabel6.TabIndex = 5
        Me.MaterialLabel6.Text = "Fecha de Ingreso"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnUpdate.Depth = 0
        Me.btnUpdate.Location = New System.Drawing.Point(347, 334)
        Me.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Primary = True
        Me.btnUpdate.Size = New System.Drawing.Size(205, 40)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Actualizar Producto"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtNameProduct
        '
        Me.txtNameProduct.BackColor = System.Drawing.Color.White
        Me.txtNameProduct.Depth = 0
        Me.txtNameProduct.Enabled = False
        Me.txtNameProduct.Hint = ""
        Me.txtNameProduct.Location = New System.Drawing.Point(40, 178)
        Me.txtNameProduct.MaxLength = 32767
        Me.txtNameProduct.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtNameProduct.Name = "txtNameProduct"
        Me.txtNameProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameProduct.SelectedText = ""
        Me.txtNameProduct.SelectionLength = 0
        Me.txtNameProduct.SelectionStart = 0
        Me.txtNameProduct.Size = New System.Drawing.Size(184, 23)
        Me.txtNameProduct.TabIndex = 7
        Me.txtNameProduct.TabStop = False
        Me.txtNameProduct.UseSystemPasswordChar = False
        '
        'txtRefProduct
        '
        Me.txtRefProduct.BackColor = System.Drawing.Color.White
        Me.txtRefProduct.Depth = 0
        Me.txtRefProduct.Enabled = False
        Me.txtRefProduct.Hint = ""
        Me.txtRefProduct.Location = New System.Drawing.Point(284, 178)
        Me.txtRefProduct.MaxLength = 32767
        Me.txtRefProduct.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRefProduct.Name = "txtRefProduct"
        Me.txtRefProduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRefProduct.SelectedText = ""
        Me.txtRefProduct.SelectionLength = 0
        Me.txtRefProduct.SelectionStart = 0
        Me.txtRefProduct.Size = New System.Drawing.Size(174, 23)
        Me.txtRefProduct.TabIndex = 8
        Me.txtRefProduct.TabStop = False
        Me.txtRefProduct.UseSystemPasswordChar = False
        '
        'txtInit
        '
        Me.txtInit.BackColor = System.Drawing.Color.White
        Me.txtInit.Depth = 0
        Me.txtInit.Hint = ""
        Me.txtInit.Location = New System.Drawing.Point(543, 177)
        Me.txtInit.MaxLength = 32767
        Me.txtInit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtInit.Name = "txtInit"
        Me.txtInit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInit.SelectedText = ""
        Me.txtInit.SelectionLength = 0
        Me.txtInit.SelectionStart = 0
        Me.txtInit.Size = New System.Drawing.Size(75, 23)
        Me.txtInit.TabIndex = 9
        Me.txtInit.TabStop = False
        Me.txtInit.UseSystemPasswordChar = False
        '
        'txtIn
        '
        Me.txtIn.BackColor = System.Drawing.Color.White
        Me.txtIn.Depth = 0
        Me.txtIn.Hint = ""
        Me.txtIn.Location = New System.Drawing.Point(727, 177)
        Me.txtIn.MaxLength = 32767
        Me.txtIn.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtIn.Name = "txtIn"
        Me.txtIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIn.SelectedText = ""
        Me.txtIn.SelectionLength = 0
        Me.txtIn.SelectionStart = 0
        Me.txtIn.Size = New System.Drawing.Size(82, 23)
        Me.txtIn.TabIndex = 10
        Me.txtIn.TabStop = False
        Me.txtIn.UseSystemPasswordChar = False
        '
        'txtDateIn
        '
        Me.txtDateIn.BackColor = System.Drawing.Color.White
        Me.txtDateIn.Depth = 0
        Me.txtDateIn.Hint = ""
        Me.txtDateIn.Location = New System.Drawing.Point(45, 270)
        Me.txtDateIn.MaxLength = 32767
        Me.txtDateIn.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDateIn.Name = "txtDateIn"
        Me.txtDateIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDateIn.SelectedText = ""
        Me.txtDateIn.SelectionLength = 0
        Me.txtDateIn.SelectionStart = 0
        Me.txtDateIn.Size = New System.Drawing.Size(174, 23)
        Me.txtDateIn.TabIndex = 11
        Me.txtDateIn.TabStop = False
        Me.txtDateIn.UseSystemPasswordChar = False
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.Color.White
        Me.txtOut.Depth = 0
        Me.txtOut.Hint = ""
        Me.txtOut.Location = New System.Drawing.Point(543, 270)
        Me.txtOut.MaxLength = 32767
        Me.txtOut.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtOut.Name = "txtOut"
        Me.txtOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOut.SelectedText = ""
        Me.txtOut.SelectionLength = 0
        Me.txtOut.SelectionStart = 0
        Me.txtOut.Size = New System.Drawing.Size(75, 23)
        Me.txtOut.TabIndex = 12
        Me.txtOut.TabStop = False
        Me.txtOut.UseSystemPasswordChar = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-2, 380)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(894, 59)
        Me.MaterialDivider1.TabIndex = 13
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutocomDB.My.Resources.Resources.reader
        Me.PictureBox1.Location = New System.Drawing.Point(397, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 69)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(280, 234)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(120, 19)
        Me.MaterialLabel7.TabIndex = 15
        Me.MaterialLabel7.Text = "Fecha de Egreso"
        '
        'txtDateOut
        '
        Me.txtDateOut.Depth = 0
        Me.txtDateOut.Enabled = False
        Me.txtDateOut.Hint = ""
        Me.txtDateOut.Location = New System.Drawing.Point(280, 270)
        Me.txtDateOut.MaxLength = 32767
        Me.txtDateOut.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDateOut.Name = "txtDateOut"
        Me.txtDateOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDateOut.SelectedText = ""
        Me.txtDateOut.SelectionLength = 0
        Me.txtDateOut.SelectionStart = 0
        Me.txtDateOut.Size = New System.Drawing.Size(178, 23)
        Me.txtDateOut.TabIndex = 16
        Me.txtDateOut.TabStop = False
        Me.txtDateOut.UseSystemPasswordChar = False
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(723, 238)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(52, 19)
        Me.MaterialLabel8.TabIndex = 17
        Me.MaterialLabel8.Text = "Precio"
        '
        'txtPrice
        '
        Me.txtPrice.Depth = 0
        Me.txtPrice.Hint = ""
        Me.txtPrice.Location = New System.Drawing.Point(721, 270)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.Size = New System.Drawing.Size(88, 23)
        Me.txtPrice.TabIndex = 18
        Me.txtPrice.TabStop = False
        Me.txtPrice.UseSystemPasswordChar = False
        '
        'lblFac
        '
        Me.lblFac.AutoSize = True
        Me.lblFac.Depth = 0
        Me.lblFac.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFac.Location = New System.Drawing.Point(12, 70)
        Me.lblFac.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFac.Name = "lblFac"
        Me.lblFac.Size = New System.Drawing.Size(84, 19)
        Me.lblFac.TabIndex = 19
        Me.lblFac.Text = "Factura N°:"
        '
        'numberFac
        '
        Me.numberFac.AutoSize = True
        Me.numberFac.Depth = 0
        Me.numberFac.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.numberFac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.numberFac.Location = New System.Drawing.Point(102, 70)
        Me.numberFac.MouseState = MaterialSkin.MouseState.HOVER
        Me.numberFac.Name = "numberFac"
        Me.numberFac.Size = New System.Drawing.Size(0, 19)
        Me.numberFac.TabIndex = 20
        '
        'formEp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 438)
        Me.Controls.Add(Me.numberFac)
        Me.Controls.Add(Me.lblFac)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.txtDateOut)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtDateIn)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.txtInit)
        Me.Controls.Add(Me.txtRefProduct)
        Me.Controls.Add(Me.txtNameProduct)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.MaximizeBox = False
        Me.Name = "formEp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edicion de Productos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtNameProduct As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtRefProduct As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtInit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtIn As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtDateIn As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtOut As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDateOut As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtPrice As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblFac As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents numberFac As MaterialSkin.Controls.MaterialLabel
End Class
