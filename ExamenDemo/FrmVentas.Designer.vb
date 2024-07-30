<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.btnModificarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.dgvListados = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Location = New System.Drawing.Point(293, 282)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(75, 44)
        Me.btnEliminarVenta.TabIndex = 25
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'btnModificarVenta
        '
        Me.btnModificarVenta.Location = New System.Drawing.Point(197, 282)
        Me.btnModificarVenta.Name = "btnModificarVenta"
        Me.btnModificarVenta.Size = New System.Drawing.Size(75, 44)
        Me.btnModificarVenta.TabIndex = 24
        Me.btnModificarVenta.Text = "Modificar"
        Me.btnModificarVenta.UseVisualStyleBackColor = True
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.Location = New System.Drawing.Point(103, 281)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(75, 45)
        Me.btnAgregarVenta.TabIndex = 23
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = True
        '
        'dgvListados
        '
        Me.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListados.Location = New System.Drawing.Point(53, 23)
        Me.dgvListados.Name = "dgvListados"
        Me.dgvListados.Size = New System.Drawing.Size(370, 231)
        Me.dgvListados.TabIndex = 26
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 401)
        Me.Controls.Add(Me.dgvListados)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Controls.Add(Me.btnModificarVenta)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Name = "FrmVentas"
        Me.Text = "FrmVentas"
        CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents btnModificarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents dgvListados As DataGridView
End Class
