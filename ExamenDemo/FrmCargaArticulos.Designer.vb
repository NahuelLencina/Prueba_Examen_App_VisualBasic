<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaArticulos
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
        Me.cbxCriterioProducto = New System.Windows.Forms.ComboBox()
        Me.cbxCampoProducto = New System.Windows.Forms.ComboBox()
        Me.lblFiltroProducto = New System.Windows.Forms.Label()
        Me.txtFiltroProducto = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvListadosProductos = New System.Windows.Forms.DataGridView()
        Me.dgvArticulosSeleccionado = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListadosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArticulosSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxCriterioProducto
        '
        Me.cbxCriterioProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCriterioProducto.FormattingEnabled = True
        Me.cbxCriterioProducto.Location = New System.Drawing.Point(166, 282)
        Me.cbxCriterioProducto.Name = "cbxCriterioProducto"
        Me.cbxCriterioProducto.Size = New System.Drawing.Size(120, 21)
        Me.cbxCriterioProducto.TabIndex = 38
        '
        'cbxCampoProducto
        '
        Me.cbxCampoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCampoProducto.FormattingEnabled = True
        Me.cbxCampoProducto.Location = New System.Drawing.Point(34, 282)
        Me.cbxCampoProducto.Name = "cbxCampoProducto"
        Me.cbxCampoProducto.Size = New System.Drawing.Size(126, 21)
        Me.cbxCampoProducto.TabIndex = 37
        '
        'lblFiltroProducto
        '
        Me.lblFiltroProducto.AutoSize = True
        Me.lblFiltroProducto.Location = New System.Drawing.Point(31, 49)
        Me.lblFiltroProducto.Name = "lblFiltroProducto"
        Me.lblFiltroProducto.Size = New System.Drawing.Size(66, 13)
        Me.lblFiltroProducto.TabIndex = 36
        Me.lblFiltroProducto.Text = "Filtro Rapido"
        '
        'txtFiltroProducto
        '
        Me.txtFiltroProducto.Location = New System.Drawing.Point(103, 46)
        Me.txtFiltroProducto.Name = "txtFiltroProducto"
        Me.txtFiltroProducto.Size = New System.Drawing.Size(219, 20)
        Me.txtFiltroProducto.TabIndex = 35
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(301, 166)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(44, 29)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Del"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(301, 134)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(44, 26)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvListadosProductos
        '
        Me.dgvListadosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadosProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListadosProductos.Location = New System.Drawing.Point(34, 92)
        Me.dgvListadosProductos.Name = "dgvListadosProductos"
        Me.dgvListadosProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadosProductos.Size = New System.Drawing.Size(252, 171)
        Me.dgvListadosProductos.TabIndex = 31
        '
        'dgvArticulosSeleccionado
        '
        Me.dgvArticulosSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulosSeleccionado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvArticulosSeleccionado.Location = New System.Drawing.Point(361, 92)
        Me.dgvArticulosSeleccionado.Name = "dgvArticulosSeleccionado"
        Me.dgvArticulosSeleccionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulosSeleccionado.Size = New System.Drawing.Size(233, 171)
        Me.dgvArticulosSeleccionado.TabIndex = 39
        '
        'FrmCargaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.dgvArticulosSeleccionado)
        Me.Controls.Add(Me.cbxCriterioProducto)
        Me.Controls.Add(Me.cbxCampoProducto)
        Me.Controls.Add(Me.lblFiltroProducto)
        Me.Controls.Add(Me.txtFiltroProducto)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvListadosProductos)
        Me.Name = "FrmCargaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCargaArticulos"
        CType(Me.dgvListadosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArticulosSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbxCriterioProducto As ComboBox
    Private WithEvents cbxCampoProducto As ComboBox
    Friend WithEvents lblFiltroProducto As Label
    Friend WithEvents txtFiltroProducto As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Private WithEvents dgvListadosProductos As DataGridView
    Private WithEvents dgvArticulosSeleccionado As DataGridView
End Class
