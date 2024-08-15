Imports dominio
Imports negocio

Public Class FrmNuevaVenta


    Private _clienteSeleccionado As Cliente

    Public Sub New()
        InitializeComponent()
        'Crea el nuevo cliente
        Me.Text = "Nuevo Cliente"
    End Sub

    Public Sub New(seleccionado As Cliente)
        Me.New()
        _clienteSeleccionado = seleccionado
        Me.Text = "Modificar Cliente"
        ' Rellenar los controles con los datos del cliente seleccionado
        If _clienteSeleccionado IsNot Nothing Then
            txtNombreClienteNuevaVenta.Text = _clienteSeleccionado.Nombre
            txtTelefonoClienteNuevaVenta.Text = _clienteSeleccionado.Telefono
            txtEmailClienteNuevaVenta.Text = _clienteSeleccionado.Email
        End If
    End Sub

    Private Sub btnAgregarArticulos_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulos.Click
        FrmCargaArticulos.ShowDialog()
    End Sub

    Private Sub btnLimpiarCamposNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnLimpiarCamposNuevaVenta.Click
        txtEmailClienteNuevaVenta.Clear()
        txtNombreClienteNuevaVenta.Clear()
        txtTelefonoClienteNuevaVenta.Clear()
    End Sub
End Class