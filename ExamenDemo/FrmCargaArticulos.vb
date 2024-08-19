Imports negocio
Imports dominio
Imports System.Linq


Public Class FrmCargaArticulos

    Public listaProductos As New List(Of Producto)

    Public ReadOnly Property ProductosSeleccionados As List(Of Producto)
        Get
            Return DirectCast(dgvArticulosSeleccionado.DataSource, List(Of Producto))
        End Get
    End Property

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            If dgvListadosProductos.CurrentRow IsNot Nothing Then
                ' Obtén el objeto Producto de la fila seleccionada
                Dim seleccionado As Producto = DirectCast(dgvListadosProductos.CurrentRow.DataBoundItem, Producto)

                ' Verifica si el DataGridView de artículos seleccionados tiene un DataSource
                If dgvArticulosSeleccionado.DataSource Is Nothing Then
                    ' Si no tiene un DataSource, crea una nueva lista de productos
                    Dim listaSeleccionados As New List(Of Producto)

                    ' Crear una copia del producto seleccionado
                    Dim nuevoProducto As New Producto With {
                    .Id = seleccionado.Id,
                    .Nombre = seleccionado.Nombre,
                    .Precio = seleccionado.Precio,
                    .Cantidad = 1,
                    .ItemsPrecioTotal = seleccionado.Precio
                }

                    listaSeleccionados.Add(nuevoProducto)
                    dgvArticulosSeleccionado.DataSource = listaSeleccionados
                Else
                    ' Si ya tiene un DataSource, obtén la lista y añade el nuevo producto
                    Dim listaSeleccionados As List(Of Producto) = DirectCast(dgvArticulosSeleccionado.DataSource, List(Of Producto))
                    Dim productoExistente As Producto = listaSeleccionados.FirstOrDefault(Function(p) p.Id = seleccionado.Id)

                    If productoExistente IsNot Nothing Then
                        ' Si el producto ya está en la lista, actualiza la cantidad
                        productoExistente.Cantidad += 1
                        productoExistente.ItemsPrecioTotal += seleccionado.Precio
                    Else
                        ' Crear una copia del producto seleccionado
                        Dim nuevoProducto As New Producto With {
                        .Id = seleccionado.Id,
                        .Nombre = seleccionado.Nombre,
                        .Precio = seleccionado.Precio,
                        .Cantidad = 1,
                        .ItemsPrecioTotal = seleccionado.Precio
                    }

                        listaSeleccionados.Add(nuevoProducto)
                    End If

                    ' Refresca el DataGridView para mostrar los cambios
                    dgvArticulosSeleccionado.DataSource = Nothing
                    dgvArticulosSeleccionado.DataSource = listaSeleccionados
                End If

                ' Oculta la columna "Id"
                dgvArticulosSeleccionado.Columns("Id").Visible = False
                lblValorTotal.Text = sumaTotal()

            End If

        Catch ex As Exception
            ' Muestra un mensaje de error (si prefieres lanzar una excepción, también es válido)
            MessageBox.Show("Ocurrió un error al agregar el producto: " & ex.Message)
        End Try
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

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If dgvArticulosSeleccionado.CurrentRow IsNot Nothing Then
                ' Obtén el objeto Producto de la fila seleccionada
                Dim seleccionado As Producto = DirectCast(dgvArticulosSeleccionado.CurrentRow.DataBoundItem, Producto)

                ' Verifica si el DataGridView de artículos seleccionados tiene un DataSource
                If dgvArticulosSeleccionado.DataSource Is Nothing Then
                    ' Si no tiene un DataSource, crea una nueva lista de productos
                    Dim listaSeleccionados As New List(Of Producto)

                    If seleccionado.Cantidad > 1 Then
                        seleccionado.Cantidad -= 1
                        seleccionado.ItemsPrecioTotal += seleccionado.Precio
                    Else
                        'si la cantidad es 1, remueve de la lista
                        listaSeleccionados.Remove(seleccionado)
                    End If
                    dgvArticulosSeleccionado.DataSource = listaSeleccionados
                Else
                    ' Si ya tiene un DataSource, obtén la lista 
                    Dim listaSeleccionados As List(Of Producto) = DirectCast(dgvArticulosSeleccionado.DataSource, List(Of Producto))
                    Dim productoExistente As Producto = listaSeleccionados.FirstOrDefault(Function(p) p.Id = seleccionado.Id)

                    If productoExistente IsNot Nothing Then
                        ' Si el producto ya está en la lista, actualiza la cantidad
                        If productoExistente.Cantidad > 1 Then
                            productoExistente.Cantidad -= 1
                            productoExistente.ItemsPrecioTotal -= seleccionado.Precio
                        Else
                            ' Si la cantidad es 1 o menor, elimina el producto de la lista
                            listaSeleccionados.Remove(productoExistente)
                        End If

                    End If
                    ' Refresca el DataGridView para mostrar los cambios
                    dgvArticulosSeleccionado.DataSource = Nothing
                    dgvArticulosSeleccionado.DataSource = listaSeleccionados

                End If
                dgvArticulosSeleccionado.Columns("Id").Visible = False
                lblValorTotal.Text = sumaTotal()
            End If

        Catch ex As Exception
            ' Muestra un mensaje de error (si prefieres lanzar una excepción, también es válido)
            MessageBox.Show("Ocurrió un error al eliminar el producto: " & ex.Message)
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

    Private Sub FrmCargaArticulos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cbxCampoProducto.Items.Clear()
        cbxCampoProducto.SelectedIndex = -1
        cbxCriterioProducto.Items.Clear()
    End Sub

    Private Function sumaTotal() As Decimal
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvArticulosSeleccionado.Rows
            ' Verifica que la fila no sea una fila nueva (la fila en blanco para agregar un nuevo registro)
            If Not row.IsNewRow Then
                ' Suma el valor de la columna "Precio" (asegurándote de que no sea nulo)
                Dim CellValue As Object = row.Cells("ItemsPrecioTotal").Value
                If CellValue IsNot Nothing AndAlso IsNumeric(CellValue) Then
                    total += Convert.ToDecimal(CellValue)
                End If
            End If
        Next
        Return total

    End Function

    Private Sub btnFinalCompra_Click(sender As Object, e As EventArgs) Handles btnFinalCompra.Click
        Me.DialogResult = DialogResult.OK
        Me.lblValorTotal = lblValorTotal
        Me.Close()
    End Sub
End Class