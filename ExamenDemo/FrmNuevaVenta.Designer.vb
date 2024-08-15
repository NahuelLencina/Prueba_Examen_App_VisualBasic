<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevaVenta
    Inherits System.Windows.Forms.Form

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
        Me.txtEmailClienteNuevaVenta = New System.Windows.Forms.TextBox()
        Me.lblCategoriaNuevaVenta = New System.Windows.Forms.Label()
        Me.txtTelefonoClienteNuevaVenta = New System.Windows.Forms.TextBox()
        Me.lblTelefonoClienteNuevaVenta = New System.Windows.Forms.Label()
        Me.txtNombreClienteNuevaVenta = New System.Windows.Forms.TextBox()
        Me.lblNombreClienteNuevaVenta = New System.Windows.Forms.Label()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.btnAceptarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarArticulos = New System.Windows.Forms.Button()
        Me.btnLimpiarCamposNuevaVenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmailClienteNuevaVenta
        '
        Me.txtEmailClienteNuevaVenta.Location = New System.Drawing.Point(95, 80)
        Me.txtEmailClienteNuevaVenta.Name = "txtEmailClienteNuevaVenta"
        Me.txtEmailClienteNuevaVenta.Size = New System.Drawing.Size(193, 20)
        Me.txtEmailClienteNuevaVenta.TabIndex = 29
        '
        'lblCategoriaNuevaVenta
        '
        Me.lblCategoriaNuevaVenta.AutoSize = True
        Me.lblCategoriaNuevaVenta.Location = New System.Drawing.Point(35, 83)
        Me.lblCategoriaNuevaVenta.Name = "lblCategoriaNuevaVenta"
        Me.lblCategoriaNuevaVenta.Size = New System.Drawing.Size(35, 13)
        Me.lblCategoriaNuevaVenta.TabIndex = 28
        Me.lblCategoriaNuevaVenta.Text = "E-mail"
        '
        'txtTelefonoClienteNuevaVenta
        '
        Me.txtTelefonoClienteNuevaVenta.Location = New System.Drawing.Point(95, 50)
        Me.txtTelefonoClienteNuevaVenta.Name = "txtTelefonoClienteNuevaVenta"
        Me.txtTelefonoClienteNuevaVenta.Size = New System.Drawing.Size(135, 20)
        Me.txtTelefonoClienteNuevaVenta.TabIndex = 27
        '
        'lblTelefonoClienteNuevaVenta
        '
        Me.lblTelefonoClienteNuevaVenta.AutoSize = True
        Me.lblTelefonoClienteNuevaVenta.Location = New System.Drawing.Point(35, 53)
        Me.lblTelefonoClienteNuevaVenta.Name = "lblTelefonoClienteNuevaVenta"
        Me.lblTelefonoClienteNuevaVenta.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefonoClienteNuevaVenta.TabIndex = 26
        Me.lblTelefonoClienteNuevaVenta.Text = "Telefono"
        '
        'txtNombreClienteNuevaVenta
        '
        Me.txtNombreClienteNuevaVenta.Location = New System.Drawing.Point(95, 18)
        Me.txtNombreClienteNuevaVenta.Name = "txtNombreClienteNuevaVenta"
        Me.txtNombreClienteNuevaVenta.Size = New System.Drawing.Size(256, 20)
        Me.txtNombreClienteNuevaVenta.TabIndex = 25
        '
        'lblNombreClienteNuevaVenta
        '
        Me.lblNombreClienteNuevaVenta.AutoSize = True
        Me.lblNombreClienteNuevaVenta.Location = New System.Drawing.Point(35, 21)
        Me.lblNombreClienteNuevaVenta.Name = "lblNombreClienteNuevaVenta"
        Me.lblNombreClienteNuevaVenta.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreClienteNuevaVenta.TabIndex = 24
        Me.lblNombreClienteNuevaVenta.Text = "Nombre"
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.Location = New System.Drawing.Point(493, 323)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarVenta.TabIndex = 31
        Me.btnCancelarVenta.Text = "Cancelar"
        Me.btnCancelarVenta.UseVisualStyleBackColor = True
        '
        'btnAceptarVenta
        '
        Me.btnAceptarVenta.Location = New System.Drawing.Point(398, 323)
        Me.btnAceptarVenta.Name = "btnAceptarVenta"
        Me.btnAceptarVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarVenta.TabIndex = 30
        Me.btnAceptarVenta.Text = "Aceptar"
        Me.btnAceptarVenta.UseVisualStyleBackColor = True
        '
        'btnAgregarArticulos
        '
        Me.btnAgregarArticulos.Location = New System.Drawing.Point(38, 128)
        Me.btnAgregarArticulos.Name = "btnAgregarArticulos"
        Me.btnAgregarArticulos.Size = New System.Drawing.Size(75, 45)
        Me.btnAgregarArticulos.TabIndex = 32
        Me.btnAgregarArticulos.Text = "Agregar Articulos"
        Me.btnAgregarArticulos.UseVisualStyleBackColor = True
        '
        'btnLimpiarCamposNuevaVenta
        '
        Me.btnLimpiarCamposNuevaVenta.Location = New System.Drawing.Point(155, 128)
        Me.btnLimpiarCamposNuevaVenta.Name = "btnLimpiarCamposNuevaVenta"
        Me.btnLimpiarCamposNuevaVenta.Size = New System.Drawing.Size(75, 45)
        Me.btnLimpiarCamposNuevaVenta.TabIndex = 33
        Me.btnLimpiarCamposNuevaVenta.Text = "Limpiar Campos"
        Me.btnLimpiarCamposNuevaVenta.UseVisualStyleBackColor = True
        '
        'FrmNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.btnLimpiarCamposNuevaVenta)
        Me.Controls.Add(Me.btnAgregarArticulos)
        Me.Controls.Add(Me.btnCancelarVenta)
        Me.Controls.Add(Me.btnAceptarVenta)
        Me.Controls.Add(Me.txtEmailClienteNuevaVenta)
        Me.Controls.Add(Me.lblCategoriaNuevaVenta)
        Me.Controls.Add(Me.txtTelefonoClienteNuevaVenta)
        Me.Controls.Add(Me.lblTelefonoClienteNuevaVenta)
        Me.Controls.Add(Me.txtNombreClienteNuevaVenta)
        Me.Controls.Add(Me.lblNombreClienteNuevaVenta)
        Me.Name = "FrmNuevaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevaVenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailClienteNuevaVenta As TextBox
    Friend WithEvents lblCategoriaNuevaVenta As Label
    Friend WithEvents txtTelefonoClienteNuevaVenta As TextBox
    Friend WithEvents lblTelefonoClienteNuevaVenta As Label
    Friend WithEvents txtNombreClienteNuevaVenta As TextBox
    Friend WithEvents lblNombreClienteNuevaVenta As Label
    Private WithEvents btnCancelarVenta As Button
    Private WithEvents btnAceptarVenta As Button
    Private WithEvents btnAgregarArticulos As Button
    Private WithEvents btnLimpiarCamposNuevaVenta As Button
End Class
