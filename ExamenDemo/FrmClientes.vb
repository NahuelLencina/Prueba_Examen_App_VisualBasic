
Public Class FrmClientes
    Private clientes As New List(Of Cliente)
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim cliente As New Cliente With {
        .Nombre = txtNombreCliente.Text,
        .Email = txtEmailCliente.Text,
        .Telefono = txtTelefonoCliente.Text
        }
        clientes.Add(cliente)
        ActualizarDataGridView()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cliente As Cliente = clientes.Find(Function(c) c.Email = txtEmailCliente.Text)
        If cliente IsNot Nothing Then
            cliente.Nombre = txtNombreCliente.Text
            cliente.Email = txtEmailCliente.Text
            cliente.Telefono = txtTelefonoCliente.Text
            ActualizarDataGridView()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cliente As Cliente = clientes.Find(Function(c) c.Id = txtEmailCliente.Text)
        If cliente IsNot Nothing Then
            clientes.Remove(cliente)
            ActualizarDataGridView()
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim cliente As Cliente = clientes.Find(Function(c) c.Id = txtEmailCliente.Text)
        If cliente IsNot Nothing Then
            clientes.Remove(cliente)
            ActualizarDataGridView()
        End If
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged
        Dim filtro As String = txtBuscarCliente.Text.ToLower()
        Dim resultados = clientes.Where(Function(c) c.Nombre.ToLower().Contains(filtro)).ToList()
        dgvClientes.DataSource = resultados
    End Sub
    Private Sub ActualizarDataGridView()
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = clientes
    End Sub
End Class
