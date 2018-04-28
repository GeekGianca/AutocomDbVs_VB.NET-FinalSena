<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeShowA
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tpSeleccion = New MaterialSkin.Controls.MaterialTabControl()
        Me.userControl = New System.Windows.Forms.TabPage()
        Me.DateTimePickerAdv1 = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.NombProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entradas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgvDatabase = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnAcces = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.txtRef = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.picName = New System.Windows.Forms.PictureBox()
        Me.txtNamePro = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbAcces = New MaterialSkin.Controls.MaterialCheckBox()
        Me.lblSearch = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tpSeleccion.SuspendLayout()
        Me.userControl.SuspendLayout()
        CType(Me.DateTimePickerAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tpSeleccion
        '
        Me.tpSeleccion.Controls.Add(Me.userControl)
        Me.tpSeleccion.Controls.Add(Me.TabPage2)
        Me.tpSeleccion.Controls.Add(Me.TabPage3)
        Me.tpSeleccion.Controls.Add(Me.TabPage4)
        Me.tpSeleccion.Controls.Add(Me.TabPage5)
        Me.tpSeleccion.Controls.Add(Me.TabPage6)
        Me.tpSeleccion.Depth = 0
        Me.tpSeleccion.Location = New System.Drawing.Point(0, 93)
        Me.tpSeleccion.MouseState = MaterialSkin.MouseState.HOVER
        Me.tpSeleccion.Name = "tpSeleccion"
        Me.tpSeleccion.SelectedIndex = 0
        Me.tpSeleccion.Size = New System.Drawing.Size(878, 384)
        Me.tpSeleccion.TabIndex = 0
        '
        'userControl
        '
        Me.userControl.BackColor = System.Drawing.Color.White
        Me.userControl.Controls.Add(Me.DateTimePickerAdv1)
        Me.userControl.Controls.Add(Me.dgvInventory)
        Me.userControl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.userControl.Location = New System.Drawing.Point(4, 22)
        Me.userControl.Name = "userControl"
        Me.userControl.Padding = New System.Windows.Forms.Padding(3)
        Me.userControl.Size = New System.Drawing.Size(870, 358)
        Me.userControl.TabIndex = 0
        Me.userControl.Text = "Inventario"
        '
        'DateTimePickerAdv1
        '
        Me.DateTimePickerAdv1.BorderColor = System.Drawing.Color.Empty
        Me.DateTimePickerAdv1.CalendarForeColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePickerAdv1.CalendarSize = New System.Drawing.Size(189, 176)
        Me.DateTimePickerAdv1.DropDownImage = Nothing
        Me.DateTimePickerAdv1.DropDownNormalColor = System.Drawing.SystemColors.Control
        Me.DateTimePickerAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerAdv1.Location = New System.Drawing.Point(340, 34)
        Me.DateTimePickerAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DateTimePickerAdv1.MinValue = New Date(CType(0, Long))
        Me.DateTimePickerAdv1.Name = "DateTimePickerAdv1"
        Me.DateTimePickerAdv1.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePickerAdv1.TabIndex = 1
        Me.DateTimePickerAdv1.Value = New Date(2017, 11, 7, 8, 38, 37, 212)
        '
        'dgvInventory
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombProducto, Me.Referencia, Me.Inicial, Me.Entradas, Me.FechaIngreso, Me.Salidas, Me.FechaEgreso, Me.Precio, Me.Factura})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Monaco", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInventory.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvInventory.Location = New System.Drawing.Point(3, 99)
        Me.dgvInventory.Name = "dgvInventory"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvInventory.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(867, 259)
        Me.dgvInventory.TabIndex = 0
        '
        'NombProducto
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Monaco", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.NombProducto.DefaultCellStyle = DataGridViewCellStyle6
        Me.NombProducto.HeaderText = "Nombre"
        Me.NombProducto.Name = "NombProducto"
        Me.NombProducto.Width = 200
        '
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Width = 112
        '
        'Inicial
        '
        Me.Inicial.HeaderText = "Inicial"
        Me.Inicial.Name = "Inicial"
        Me.Inicial.Width = 50
        '
        'Entradas
        '
        Me.Entradas.HeaderText = "Entradas"
        Me.Entradas.Name = "Entradas"
        Me.Entradas.Width = 50
        '
        'FechaIngreso
        '
        Me.FechaIngreso.HeaderText = "Fecha Ingreso"
        Me.FechaIngreso.Name = "FechaIngreso"
        '
        'Salidas
        '
        Me.Salidas.HeaderText = "Salidas"
        Me.Salidas.Name = "Salidas"
        Me.Salidas.Width = 50
        '
        'FechaEgreso
        '
        Me.FechaEgreso.HeaderText = "Fecha Egreso"
        Me.FechaEgreso.Name = "FechaEgreso"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 60
        '
        'Factura
        '
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(870, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Facturacion"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(870, 358)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Clientes"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(870, 358)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Contabilidad"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(870, 358)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Gerencia"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.dgvDatabase)
        Me.TabPage6.Controls.Add(Me.btnEdit)
        Me.TabPage6.Controls.Add(Me.PictureBox3)
        Me.TabPage6.Controls.Add(Me.btnDelete)
        Me.TabPage6.Controls.Add(Me.btnAcces)
        Me.TabPage6.Controls.Add(Me.picUser)
        Me.TabPage6.Controls.Add(Me.txtRef)
        Me.TabPage6.Controls.Add(Me.txtPass)
        Me.TabPage6.Controls.Add(Me.picName)
        Me.TabPage6.Controls.Add(Me.txtNamePro)
        Me.TabPage6.Controls.Add(Me.txtUsername)
        Me.TabPage6.Controls.Add(Me.cbAcces)
        Me.TabPage6.Controls.Add(Me.lblSearch)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(870, 358)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Recursos"
        '
        'dgvDatabase
        '
        Me.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatabase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvDatabase.Location = New System.Drawing.Point(213, 6)
        Me.dgvDatabase.Name = "dgvDatabase"
        Me.dgvDatabase.ReadOnly = True
        Me.dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatabase.Size = New System.Drawing.Size(654, 344)
        Me.dgvDatabase.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Referencia"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Inicial"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Entradas"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fecha Ingreso"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Salidas"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Fecha Egreso"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Precio"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Column9
        '
        Me.Column9.HeaderText = "Factura"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Depth = 0
        Me.btnEdit.Location = New System.Drawing.Point(6, 117)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Primary = True
        Me.btnEdit.Size = New System.Drawing.Size(59, 36)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Tag = "Hola"
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AutocomDB.My.Resources.Resources.ic_streetview_black_24dp
        Me.PictureBox3.Location = New System.Drawing.Point(177, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Depth = 0
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(110, 118)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Primary = True
        Me.btnDelete.Size = New System.Drawing.Size(74, 36)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnAcces
        '
        Me.btnAcces.Depth = 0
        Me.btnAcces.Enabled = False
        Me.btnAcces.Location = New System.Drawing.Point(39, 322)
        Me.btnAcces.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAcces.Name = "btnAcces"
        Me.btnAcces.Primary = True
        Me.btnAcces.Size = New System.Drawing.Size(110, 29)
        Me.btnAcces.TabIndex = 2
        Me.btnAcces.Text = "Acceder"
        Me.btnAcces.UseVisualStyleBackColor = True
        Me.btnAcces.Visible = False
        '
        'picUser
        '
        Me.picUser.Image = Global.AutocomDB.My.Resources.Resources.ic_vpn_key_black_24dp
        Me.picUser.Location = New System.Drawing.Point(16, 278)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(29, 22)
        Me.picUser.TabIndex = 8
        Me.picUser.TabStop = False
        Me.picUser.Visible = False
        '
        'txtRef
        '
        Me.txtRef.Depth = 0
        Me.txtRef.Hint = "Referencia"
        Me.txtRef.Location = New System.Drawing.Point(8, 87)
        Me.txtRef.MaxLength = 32767
        Me.txtRef.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRef.Name = "txtRef"
        Me.txtRef.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRef.SelectedText = ""
        Me.txtRef.SelectionLength = 0
        Me.txtRef.SelectionStart = 0
        Me.txtRef.Size = New System.Drawing.Size(176, 23)
        Me.txtRef.TabIndex = 8
        Me.txtRef.TabStop = False
        Me.txtRef.UseSystemPasswordChar = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPass.Depth = 0
        Me.txtPass.Hint = "Contraseña"
        Me.txtPass.Location = New System.Drawing.Point(50, 279)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.Size = New System.Drawing.Size(122, 23)
        Me.txtPass.TabIndex = 3
        Me.txtPass.TabStop = False
        Me.txtPass.UseSystemPasswordChar = False
        Me.txtPass.Visible = False
        '
        'picName
        '
        Me.picName.Image = Global.AutocomDB.My.Resources.Resources.ic_person_black_24dp
        Me.picName.Location = New System.Drawing.Point(18, 219)
        Me.picName.Name = "picName"
        Me.picName.Size = New System.Drawing.Size(26, 26)
        Me.picName.TabIndex = 7
        Me.picName.TabStop = False
        Me.picName.Visible = False
        '
        'txtNamePro
        '
        Me.txtNamePro.Depth = 0
        Me.txtNamePro.Hint = "Nombre Producto"
        Me.txtNamePro.Location = New System.Drawing.Point(8, 52)
        Me.txtNamePro.MaxLength = 32767
        Me.txtNamePro.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtNamePro.Name = "txtNamePro"
        Me.txtNamePro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamePro.SelectedText = ""
        Me.txtNamePro.SelectionLength = 0
        Me.txtNamePro.SelectionStart = 0
        Me.txtNamePro.Size = New System.Drawing.Size(176, 23)
        Me.txtNamePro.TabIndex = 7
        Me.txtNamePro.TabStop = False
        Me.txtNamePro.UseSystemPasswordChar = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = "Usuario"
        Me.txtUsername.Location = New System.Drawing.Point(50, 222)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(122, 23)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.TabStop = False
        Me.txtUsername.UseSystemPasswordChar = False
        Me.txtUsername.Visible = False
        '
        'cbAcces
        '
        Me.cbAcces.AutoSize = True
        Me.cbAcces.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbAcces.Depth = 0
        Me.cbAcces.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cbAcces.Location = New System.Drawing.Point(9, 160)
        Me.cbAcces.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAcces.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cbAcces.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbAcces.Name = "cbAcces"
        Me.cbAcces.Ripple = True
        Me.cbAcces.Size = New System.Drawing.Size(169, 30)
        Me.cbAcces.TabIndex = 6
        Me.cbAcces.Text = "Acceso Administrativo"
        Me.cbAcces.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Depth = 0
        Me.lblSearch.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(3, 16)
        Me.lblSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(173, 19)
        Me.lblSearch.TabIndex = 4
        Me.lblSearch.Text = "Busqueda Personalizada"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.tpSeleccion
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 55)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(878, 32)
        Me.MaterialTabSelector1.TabIndex = 1
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 471)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(885, 60)
        Me.MaterialDivider1.TabIndex = 2
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.PictureBox1.Image = Global.AutocomDB.My.Resources.Resources.hombre
        Me.PictureBox1.Location = New System.Drawing.Point(805, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 63)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'HomeShowA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 530)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.tpSeleccion)
        Me.MaximizeBox = False
        Me.Name = "HomeShowA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tpSeleccion.ResumeLayout(False)
        Me.userControl.ResumeLayout(False)
        CType(Me.DateTimePickerAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dgvDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpSeleccion As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents userControl As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btnAcces As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbAcces As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents lblSearch As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents picName As PictureBox
    Friend WithEvents picUser As PictureBox
    Friend WithEvents txtRef As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtNamePro As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents dgvDatabase As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents NombProducto As DataGridViewTextBoxColumn
    Friend WithEvents Referencia As DataGridViewTextBoxColumn
    Friend WithEvents Inicial As DataGridViewTextBoxColumn
    Friend WithEvents Entradas As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents Salidas As DataGridViewTextBoxColumn
    Friend WithEvents FechaEgreso As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePickerAdv1 As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
End Class
