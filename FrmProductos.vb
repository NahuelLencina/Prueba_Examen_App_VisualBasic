Imports negocio
Imports dominio
Imports System.Linq


Public Class FrmProductos

    Private listaProductos As New List(Of Producto)
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim altaProducto As New FrmAltaProducto
        FrmAltaProducto.ShowDialog()
        cargar()
    End Sub


    Private Sub ocultarColumnas()
        dgvListadosProductos.Columns("Id").Visible = False
    End Sub
    Private Sub cargar()
        Try
            Dim negocio As New ProductoNegocio()
            listaProductos = negocio.listar()
            dgvListadosProductos.DataSource = listaProductos
            ocultarColumnas()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        Try
            If dgvListadosProductos.CurrentRow IsNot Nothing Then
                Dim seleccionado As Producto = DirectCast(dgvListadosProductos.CurrentRow.DataBoundItem, Producto)
                Dim modificarForm As New FrmAltaProducto(seleccionado)
                modificarForm.ShowDialog()
                ' Después de que el formulario de modificación se cierre, recargar los datos
                cargar()
            End If
        Catch ex As Exception
            ' Manejo de excepciones
            MessageBox.Show($"Error al modificar el Producto: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        Dim negocio As New ProductoNegocio()
        Dim seleccionado As Producto

        Try
            If dgvListadosProductos.CurrentRow IsNot Nothing Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Vas a eliminar este artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If respuesta = DialogResult.Yes Then
                    seleccionado = DirectCast(dgvListadosProductos.CurrentRow.DataBoundItem, Producto)
                    negocio.eliminar(seleccionado.Id)
                    cargar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Throw
        End Try
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        Dim listaFiltrada As New List(Of Producto)
        Dim filtro As String = txtBuscarProducto.Text

        If filtro.Length > 2 Then
            listaFiltrada = listaProductos.FindAll(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()) OrElse x.Categoria.ToUpper().Contains(filtro.ToUpper()))
        Else
            listaFiltrada = listaProductos
        End If

        dgvListadosProductos.DataSource = Nothing
        dgvListadosProductos.DataSource = listaFiltrada
        ocultarColumnas()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar()
    End Sub

    Private Sub dgvListadosProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListadosProductos.SelectionChanged
        If dgvListadosProductos.CurrentRow IsNot Nothing Then
            Dim seleccionado As Producto = CType(dgvListadosProductos.CurrentRow.DataBoundItem, Producto)
        End If
    End Sub
End Class