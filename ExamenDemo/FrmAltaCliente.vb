Imports dominio
Imports negocio

Public Class FrmAltaCliente

    Private _clienteSeleccionado As Cliente

    Public Sub New()
        InitializeComponent()
        'Crea el nuevo cliente
        Me.Text = "Agregar Nuevo Cliente"
    End Sub

    Public Sub New(seleccionado As Cliente)
        Me.New()
        _clienteSeleccionado = seleccionado
        Me.Text = "Modificar Cliente"
        ' Rellenar los controles con los datos del cliente seleccionado
        If _clienteSeleccionado IsNot Nothing Then
            txtNombreCliente.Text = _clienteSeleccionado.Nombre
            txtTelefonoCliente.Text = _clienteSeleccionado.Telefono
            txtEmailCliente.Text = _clienteSeleccionado.Email
        End If
    End Sub


    Private Sub btnAceptarCliente_Click(sender As Object, e As EventArgs) Handles btnAceptarCliente.Click
        Dim cliente As New Cliente With {
        .Nombre = txtNombreCliente.Text,
        .Telefono = txtTelefonoCliente.Text,
        .Email = txtEmailCliente.Text
    }
        Dim negocio As New ClienteNegocio()

        If _clienteSeleccionado Is Nothing Then
            Try
                ' Intentar agregar el nuevo cliente
                negocio.agregar(cliente)
                MessageBox.Show("Cliente agregado exitosamente.")
                Close()

            Catch ex As Exception
                ' Mostrar el mensaje de error
                MessageBox.Show("Ocurrió un error al agregar el cliente: " & ex.Message)
            End Try

        Else
            Try
                cliente.Id = _clienteSeleccionado.Id
                negocio.modificar(cliente)
                MessageBox.Show("Cliente modificado exitosamente.")
                Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al modificar el cliente: " & ex.Message)
            End Try

        End If


    End Sub

    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        Close()
    End Sub
End Class