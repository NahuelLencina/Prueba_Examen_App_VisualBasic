<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.lblPrecioProducto = New System.Windows.Forms.Label()
        Me.txtCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.lblCategoriaProducto = New System.Windows.Forms.Label()
        Me.dgvListadosProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        CType(Me.dgvListadosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(46, 20)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreProducto.TabIndex = 0
        Me.lblNombreProducto.Text = "Nombre"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(106, 17)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(256, 20)
        Me.txtNombreProducto.TabIndex = 1
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Location = New System.Drawing.Point(106, 49)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(135, 20)
        Me.txtPrecioProducto.TabIndex = 3
        '
        'lblPrecioProducto
        '
        Me.lblPrecioProducto.AutoSize = True
        Me.lblPrecioProducto.Location = New System.Drawing.Point(46, 52)
        Me.lblPrecioProducto.Name = "lblPrecioProducto"
        Me.lblPrecioProducto.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecioProducto.TabIndex = 2
        Me.lblPrecioProducto.Text = "Precio"
        '
        'txtCategoriaProducto
        '
        Me.txtCategoriaProducto.Location = New System.Drawing.Point(106, 79)
        Me.txtCategoriaProducto.Name = "txtCategoriaProducto"
        Me.txtCategoriaProducto.Size = New System.Drawing.Size(193, 20)
        Me.txtCategoriaProducto.TabIndex = 5
        '
        'lblCategoriaProducto
        '
        Me.lblCategoriaProducto.AutoSize = True
        Me.lblCategoriaProducto.Location = New System.Drawing.Point(46, 82)
        Me.lblCategoriaProducto.Name = "lblCategoriaProducto"
        Me.lblCategoriaProducto.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoriaProducto.TabIndex = 4
        Me.lblCategoriaProducto.Text = "Categoria"
        '
        'dgvListadosProductos
        '
        Me.dgvListadosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadosProductos.Location = New System.Drawing.Point(49, 157)
        Me.dgvListadosProductos.Name = "dgvListadosProductos"
        Me.dgvListadosProductos.Size = New System.Drawing.Size(370, 171)
        Me.dgvListadosProductos.TabIndex = 6
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(238, 111)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(75, 29)
        Me.btnEliminarProducto.TabIndex = 10
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(147, 111)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(75, 29)
        Me.btnModificarProducto.TabIndex = 9
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(49, 110)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 30)
        Me.btnAgregarProducto.TabIndex = 8
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(344, 345)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarProducto.TabIndex = 7
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(49, 345)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(264, 20)
        Me.txtBuscarProducto.TabIndex = 11
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 401)
        Me.Controls.Add(Me.txtBuscarProducto)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnModificarProducto)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.dgvListadosProductos)
        Me.Controls.Add(Me.txtCategoriaProducto)
        Me.Controls.Add(Me.lblCategoriaProducto)
        Me.Controls.Add(Me.txtPrecioProducto)
        Me.Controls.Add(Me.lblPrecioProducto)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Name = "FrmProductos"
        Me.Text = "FrmProductos"
        CType(Me.dgvListadosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents lblPrecioProducto As Label
    Friend WithEvents txtCategoriaProducto As TextBox
    Friend WithEvents lblCategoriaProducto As Label
    Friend WithEvents dgvListadosProductos As DataGridView
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtBuscarProducto As TextBox
End Class
