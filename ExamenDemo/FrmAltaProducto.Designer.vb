<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaProducto
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
        Me.txtCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.lblCategoriaProducto = New System.Windows.Forms.Label()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.lblPrecioProducto = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnAceptarProducto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCategoriaProducto
        '
        Me.txtCategoriaProducto.Location = New System.Drawing.Point(146, 126)
        Me.txtCategoriaProducto.Name = "txtCategoriaProducto"
        Me.txtCategoriaProducto.Size = New System.Drawing.Size(193, 20)
        Me.txtCategoriaProducto.TabIndex = 11
        '
        'lblCategoriaProducto
        '
        Me.lblCategoriaProducto.AutoSize = True
        Me.lblCategoriaProducto.Location = New System.Drawing.Point(86, 129)
        Me.lblCategoriaProducto.Name = "lblCategoriaProducto"
        Me.lblCategoriaProducto.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoriaProducto.TabIndex = 10
        Me.lblCategoriaProducto.Text = "Categoria"
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Location = New System.Drawing.Point(146, 96)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(135, 20)
        Me.txtPrecioProducto.TabIndex = 9
        '
        'lblPrecioProducto
        '
        Me.lblPrecioProducto.AutoSize = True
        Me.lblPrecioProducto.Location = New System.Drawing.Point(86, 99)
        Me.lblPrecioProducto.Name = "lblPrecioProducto"
        Me.lblPrecioProducto.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecioProducto.TabIndex = 8
        Me.lblPrecioProducto.Text = "Precio"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(146, 64)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(256, 20)
        Me.txtNombreProducto.TabIndex = 7
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(86, 67)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreProducto.TabIndex = 6
        Me.lblNombreProducto.Text = "Nombre"
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Location = New System.Drawing.Point(251, 189)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProducto.TabIndex = 27
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnAceptarProducto
        '
        Me.btnAceptarProducto.Location = New System.Drawing.Point(156, 189)
        Me.btnAceptarProducto.Name = "btnAceptarProducto"
        Me.btnAceptarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarProducto.TabIndex = 26
        Me.btnAceptarProducto.Text = "Aceptar"
        Me.btnAceptarProducto.UseVisualStyleBackColor = True
        '
        'FrmAltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnAceptarProducto)
        Me.Controls.Add(Me.txtCategoriaProducto)
        Me.Controls.Add(Me.lblCategoriaProducto)
        Me.Controls.Add(Me.txtPrecioProducto)
        Me.Controls.Add(Me.lblPrecioProducto)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Name = "FrmAltaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCategoriaProducto As TextBox
    Friend WithEvents lblCategoriaProducto As Label
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents lblPrecioProducto As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblNombreProducto As Label
    Private WithEvents btnCancelarProducto As Button
    Private WithEvents btnAceptarProducto As Button
End Class
