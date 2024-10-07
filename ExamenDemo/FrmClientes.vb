Imports dominio
Imports negocio
Imports System.Linq


Public Class FrmClientes

    Private listaClientes As New List(Of Cliente)


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim altaCliente As New FrmAltaCliente
        altaCliente.ShowDialog()
        cargar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvClientes.CurrentRow IsNot Nothing Then
                Dim seleccionado As Cliente = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Cliente)
                Dim modificarForm As New FrmAltaCliente(seleccionado)

                modificarForm.ShowDialog()
                ' Después de que el formulario de modificación se cierre, recargar los datos
                cargar()
            End If
        Catch ex As Exception
            ' Manejo de excepciones
            MessageBox.Show($"Error al modificar el cliente: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim negocio As New ClienteNegocio()
        Dim seleccionado As Cliente

        Try
            If dgvClientes.CurrentRow IsNot Nothing Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Vas a eliminar este artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If respuesta = DialogResult.Yes Then
                    seleccionado = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Cliente)
                    negocio.eliminar(seleccionado.Id)
                    cargar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Throw
        End Try
    End Sub

    Private Sub ocultarColumnas()
        dgvClientes.Columns("Id").Visible = False
    End Sub

    Private Sub txtFiltroCliente_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroCliente.TextChanged

        Dim listaFiltrada As New List(Of Cliente)
        Dim filtro As String = txtFiltroCliente.Text

        If filtro.Length > 2 Then
            listaFiltrada = listaClientes.FindAll(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()) OrElse x.Email.ToUpper().Contains(filtro.ToUpper()))
        Else
            listaFiltrada = listaClientes
        End If

        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = listaFiltrada
        ocultarColumnas()

    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbxCampoCliente.Items.Add("Nombre")
        cbxCampoCliente.Items.Add("Telefono")
        cbxCampoCliente.Items.Add("Email")
        ' cbxCampoCliente.Items.Add("Todos")
        cargar()
    End Sub

    Private Sub cargar()
        Try
            Dim negocio As New ClienteNegocio()
            listaClientes = negocio.listar()
            dgvClientes.DataSource = listaClientes
            ocultarColumnas()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.CurrentRow IsNot Nothing Then
            Dim seleccionado As Cliente = CType(dgvClientes.CurrentRow.DataBoundItem, Cliente)
        End If
    End Sub



    Private Sub txtBuscarCriterio_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCriterio.TextChanged

        Dim listaFiltrada As New List(Of Cliente)
        Dim filtro As String = txtBuscarCriterio.Text
        ' Dim negocio As New ClienteNegocio

        Try

            If filtro.Length > 2 Then
                If cbxCampoCliente.SelectedItem Is "Nombre" Then
                    listaFiltrada = listaClientes.FindAll(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()))
                ElseIf cbxCampoCliente.SelectedItem Is "Email" Then
                    listaFiltrada = listaClientes.FindAll(Function(x) x.Email.ToUpper().Contains(filtro.ToUpper()))
                ElseIf cbxCampoCliente.SelectedItem Is "Telefono" Then
                    listaFiltrada = listaClientes.FindAll(Function(x) x.Telefono.ToUpper().Contains(filtro.ToUpper()))
                End If
            Else
                listaFiltrada = listaClientes
            End If



            dgvClientes.DataSource = Nothing
            dgvClientes.DataSource = listaFiltrada
            ocultarColumnas()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub cbxCampoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCampoCliente.SelectedIndexChanged
        txtBuscarCriterio.Clear()
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        If dgvClientes.CurrentRow IsNot Nothing Then
            Dim seleccionado As Cliente = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Cliente)
            Dim cargarDatosVenta As New FrmNuevaVenta(seleccionado)
            cargarDatosVenta.ShowDialog()

        End If

    End Sub

    Private Sub FrmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cbxCampoCliente.Items.Clear()
        cbxCampoCliente.SelectedIndex = -1
        txtBuscarCriterio.Clear()
    End Sub

    Private Sub btnAtrasVentas_Click(sender As Object, e As EventArgs) Handles btnAtrasClientes.Click
        Close()
    End Sub
End Class
