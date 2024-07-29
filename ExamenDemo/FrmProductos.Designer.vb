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
        Me.dgvListadosProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.lblFiltroProducto = New System.Windows.Forms.Label()
        CType(Me.dgvListadosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadosProductos
        '
        Me.dgvListadosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadosProductos.Location = New System.Drawing.Point(49, 72)
        Me.dgvListadosProductos.Name = "dgvListadosProductos"
        Me.dgvListadosProductos.Size = New System.Drawing.Size(370, 171)
        Me.dgvListadosProductos.TabIndex = 6
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(287, 265)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(75, 29)
        Me.btnEliminarProducto.TabIndex = 10
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(196, 265)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(75, 29)
        Me.btnModificarProducto.TabIndex = 9
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(98, 264)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 30)
        Me.btnAgregarProducto.TabIndex = 8
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(118, 26)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(301, 20)
        Me.txtBuscarProducto.TabIndex = 11
        '
        'lblFiltroProducto
        '
        Me.lblFiltroProducto.AutoSize = True
        Me.lblFiltroProducto.Location = New System.Drawing.Point(46, 29)
        Me.lblFiltroProducto.Name = "lblFiltroProducto"
        Me.lblFiltroProducto.Size = New System.Drawing.Size(66, 13)
        Me.lblFiltroProducto.TabIndex = 12
        Me.lblFiltroProducto.Text = "Filtro Rapido"
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 401)
        Me.Controls.Add(Me.lblFiltroProducto)
        Me.Controls.Add(Me.txtBuscarProducto)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnModificarProducto)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.dgvListadosProductos)
        Me.Name = "FrmProductos"
        Me.Text = "FrmProductos"
        CType(Me.dgvListadosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadosProductos As DataGridView
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents lblFiltroProducto As Label
End Class
