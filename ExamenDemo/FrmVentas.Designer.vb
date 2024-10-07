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
        Me.dgvListados = New System.Windows.Forms.DataGridView()
        Me.btnViewVenta = New System.Windows.Forms.Button()
        Me.dgvItemsVentas = New System.Windows.Forms.DataGridView()
        Me.btnAtrasVentas = New System.Windows.Forms.Button()
        CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemsVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Location = New System.Drawing.Point(482, 87)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(75, 44)
        Me.btnEliminarVenta.TabIndex = 25
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'dgvListados
        '
        Me.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListados.Location = New System.Drawing.Point(53, 23)
        Me.dgvListados.Name = "dgvListados"
        Me.dgvListados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListados.Size = New System.Drawing.Size(370, 231)
        Me.dgvListados.TabIndex = 26
        '
        'btnViewVenta
        '
        Me.btnViewVenta.Location = New System.Drawing.Point(482, 154)
        Me.btnViewVenta.Name = "btnViewVenta"
        Me.btnViewVenta.Size = New System.Drawing.Size(75, 44)
        Me.btnViewVenta.TabIndex = 27
        Me.btnViewVenta.Text = "Ver"
        Me.btnViewVenta.UseVisualStyleBackColor = True
        '
        'dgvItemsVentas
        '
        Me.dgvItemsVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemsVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItemsVentas.Location = New System.Drawing.Point(53, 23)
        Me.dgvItemsVentas.Name = "dgvItemsVentas"
        Me.dgvItemsVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemsVentas.Size = New System.Drawing.Size(370, 231)
        Me.dgvItemsVentas.TabIndex = 28
        Me.dgvItemsVentas.Visible = False
        '
        'btnAtrasVentas
        '
        Me.btnAtrasVentas.Location = New System.Drawing.Point(482, 225)
        Me.btnAtrasVentas.Name = "btnAtrasVentas"
        Me.btnAtrasVentas.Size = New System.Drawing.Size(75, 44)
        Me.btnAtrasVentas.TabIndex = 29
        Me.btnAtrasVentas.Text = "Atras"
        Me.btnAtrasVentas.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.btnAtrasVentas)
        Me.Controls.Add(Me.dgvItemsVentas)
        Me.Controls.Add(Me.btnViewVenta)
        Me.Controls.Add(Me.dgvListados)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVentas"
        CType(Me.dgvListados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemsVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminarVenta As Button
    Private WithEvents dgvListados As DataGridView
    Friend WithEvents btnViewVenta As Button
    Private WithEvents dgvItemsVentas As DataGridView
    Friend WithEvents btnAtrasVentas As Button
End Class
