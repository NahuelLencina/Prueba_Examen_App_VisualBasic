<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaCliente
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
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.btnAceptarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(143, 100)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(193, 20)
        Me.txtEmailCliente.TabIndex = 23
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(83, 103)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(35, 13)
        Me.lblCategoria.TabIndex = 22
        Me.lblCategoria.Text = "E-mail"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(143, 70)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(135, 20)
        Me.txtTelefonoCliente.TabIndex = 21
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(83, 73)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefonoCliente.TabIndex = 20
        Me.lblTelefonoCliente.Text = "Telefono"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(143, 38)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(256, 20)
        Me.txtNombreCliente.TabIndex = 19
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(83, 41)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreCliente.TabIndex = 18
        Me.lblNombreCliente.Text = "Nombre"
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Location = New System.Drawing.Point(251, 189)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarCliente.TabIndex = 25
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'btnAceptarCliente
        '
        Me.btnAceptarCliente.Location = New System.Drawing.Point(156, 189)
        Me.btnAceptarCliente.Name = "btnAceptarCliente"
        Me.btnAceptarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarCliente.TabIndex = 24
        Me.btnAceptarCliente.Text = "Aceptar"
        Me.btnAceptarCliente.UseVisualStyleBackColor = True
        '
        'FrmAltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 401)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnAceptarCliente)
        Me.Controls.Add(Me.txtEmailCliente)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.txtTelefonoCliente)
        Me.Controls.Add(Me.lblTelefonoCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Name = "FrmAltaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Private WithEvents btnCancelarCliente As Button
    Private WithEvents btnAceptarCliente As Button
End Class
