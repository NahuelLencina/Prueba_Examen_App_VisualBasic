Imports negocio
Imports dominio
Imports System.Linq


Public Class FrmProductos

    Private listaProductos As New List(Of Producto)
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim altaProducto As New FrmAltaProducto
        altaProducto.ShowDialog()
        cargar()
    End Sub


    Private Sub ocultarColumnas()
        dgvListadosProductos.Columns("Id").Visible = False
        dgvListadosProductos.Columns("Cantidad").Visible = False
        dgvListadosProductos.Columns("ItemsPrecioTotal").Visible = False
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

    Private Sub txtFiltroProducto_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroProducto.TextChanged
        Dim listaFiltrada As New List(Of Producto)
        Dim filtro As String = txtFiltroProducto.Text
        cbxCriterioProducto.Items.Clear()

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
        cbxCampoProducto.Items.Add("Nombre")
        cbxCampoProducto.Items.Add("Categoria")
        cargar()

    End Sub

    Private Sub dgvListadosProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListadosProductos.SelectionChanged
        If dgvListadosProductos.CurrentRow IsNot Nothing Then
            Dim seleccionado As Producto = CType(dgvListadosProductos.CurrentRow.DataBoundItem, Producto)
        End If
    End Sub


    Private Sub cbxCriterioProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCriterioProducto.SelectedIndexChanged
        Dim listaFiltrada As New List(Of Producto)
        Dim filtro As String = cbxCriterioProducto.Text

        If cbxCampoProducto.SelectedItem Is "Nombre" Then
            listaFiltrada = listaProductos.FindAll(Function(x) x.Nombre.ToUpper().Contains(filtro.ToUpper()))
        ElseIf cbxCampoProducto.SelectedItem Is "Categoria" Then
            listaFiltrada = listaProductos.FindAll(Function(x) x.Categoria.ToUpper().Contains(filtro.ToUpper()))
        End If



        dgvListadosProductos.DataSource = Nothing
        dgvListadosProductos.DataSource = listaFiltrada
        ocultarColumnas()

    End Sub

    Private Sub cbxCampoProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCampoProducto.SelectedIndexChanged
        Dim negocio As New ProductoNegocio
        Dim productos As List(Of Producto) = negocio.listar()
        cbxCriterioProducto.Items.Clear()

        If cbxCampoProducto.SelectedItem IsNot Nothing Then
            Dim campoSeleccionado As String = cbxCampoProducto.SelectedItem.ToString()

            If campoSeleccionado Is "Nombre" Then
                Dim nombresUnicos = productos.Select(Function(p) p.Nombre).Distinct().ToList()
                For Each nombre In nombresUnicos
                    cbxCriterioProducto.Items.Add(nombre)
                Next

            ElseIf campoSeleccionado = "Categoria" Then
                ' Obtener categorías únicas
                Dim categoriasUnicas = productos.Select(Function(p) p.Categoria).Distinct().ToList()
                For Each categoria In categoriasUnicas
                    cbxCriterioProducto.Items.Add(categoria)
                Next

            End If


        End If

    End Sub

    Private Sub FrmProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cbxCampoProducto.Items.Clear()
        cbxCampoProducto.SelectedIndex = -1
    End Sub
End Class