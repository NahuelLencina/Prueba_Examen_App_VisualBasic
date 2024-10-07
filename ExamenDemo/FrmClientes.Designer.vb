<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.txtFiltroCliente = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.cbxCampoCliente = New System.Windows.Forms.ComboBox()
        Me.txtBuscarCriterio = New System.Windows.Forms.TextBox()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.btnAtrasClientes = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFiltroCliente
        '
        Me.txtFiltroCliente.Location = New System.Drawing.Point(127, 35)
        Me.txtFiltroCliente.Name = "txtFiltroCliente"
        Me.txtFiltroCliente.Size = New System.Drawing.Size(297, 20)
        Me.txtFiltroCliente.TabIndex = 23
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(299, 274)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 29)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(199, 274)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 29)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(100, 274)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 30)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(54, 78)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(370, 171)
        Me.dgvClientes.TabIndex = 18
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(60, 35)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(61, 13)
        Me.lblFiltro.TabIndex = 24
        Me.lblFiltro.Text = "Filtro rapido"
        '
        'cbxCampoCliente
        '
        Me.cbxCampoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCampoCliente.FormattingEnabled = True
        Me.cbxCampoCliente.Location = New System.Drawing.Point(100, 334)
        Me.cbxCampoCliente.Name = "cbxCampoCliente"
        Me.cbxCampoCliente.Size = New System.Drawing.Size(137, 21)
        Me.cbxCampoCliente.TabIndex = 25
        '
        'txtBuscarCriterio
        '
        Me.txtBuscarCriterio.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtBuscarCriterio.Location = New System.Drawing.Point(254, 334)
        Me.txtBuscarCriterio.Name = "txtBuscarCriterio"
        Me.txtBuscarCriterio.Size = New System.Drawing.Size(125, 20)
        Me.txtBuscarCriterio.TabIndex = 28
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Location = New System.Drawing.Point(486, 78)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(75, 69)
        Me.btnNuevaVenta.TabIndex = 29
        Me.btnNuevaVenta.Text = "Generar Venta"
        Me.btnNuevaVenta.UseVisualStyleBackColor = True
        '
        'btnAtrasClientes
        '
        Me.btnAtrasClientes.Location = New System.Drawing.Point(486, 321)
        Me.btnAtrasClientes.Name = "btnAtrasClientes"
        Me.btnAtrasClientes.Size = New System.Drawing.Size(75, 44)
        Me.btnAtrasClientes.TabIndex = 35
        Me.btnAtrasClientes.Text = "Atras"
        Me.btnAtrasClientes.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.btnAtrasClientes)
        Me.Controls.Add(Me.btnNuevaVenta)
        Me.Controls.Add(Me.txtBuscarCriterio)
        Me.Controls.Add(Me.cbxCampoCliente)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtFiltroCliente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCliente"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFiltroCliente As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblFiltro As Label
    Private WithEvents dgvClientes As DataGridView
    Private WithEvents txtBuscarCriterio As TextBox
    Private WithEvents cbxCampoCliente As ComboBox
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents btnAtrasClientes As Button
End Class
