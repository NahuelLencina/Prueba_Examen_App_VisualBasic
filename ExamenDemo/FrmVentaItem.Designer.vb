<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaItem
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
        Me.btnAtrasVentas = New System.Windows.Forms.Button()
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.dgvItemsVentas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvItemsVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtrasVentas
        '
        Me.btnAtrasVentas.Location = New System.Drawing.Point(313, 303)
        Me.btnAtrasVentas.Name = "btnAtrasVentas"
        Me.btnAtrasVentas.Size = New System.Drawing.Size(75, 44)
        Me.btnAtrasVentas.TabIndex = 34
        Me.btnAtrasVentas.Text = "Atras"
        Me.btnAtrasVentas.UseVisualStyleBackColor = True
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Location = New System.Drawing.Point(200, 303)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(75, 44)
        Me.btnEliminarVenta.TabIndex = 30
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'dgvItemsVentas
        '
        Me.dgvItemsVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemsVentas.Location = New System.Drawing.Point(38, 25)
        Me.dgvItemsVentas.Name = "dgvItemsVentas"
        Me.dgvItemsVentas.Size = New System.Drawing.Size(530, 227)
        Me.dgvItemsVentas.TabIndex = 35
        '
        'FrmVentaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.dgvItemsVentas)
        Me.Controls.Add(Me.btnAtrasVentas)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Name = "FrmVentaItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVentaItem"
        CType(Me.dgvItemsVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAtrasVentas As Button
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents dgvItemsVentas As DataGridView
End Class
