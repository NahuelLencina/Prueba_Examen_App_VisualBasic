Public Class Producto
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Precio As Decimal
    Public Property Categoria As String

    'Propiedades para cantidad y precio total
    Public Property Cantidad As Integer
    Public Property ItemsPrecioTotal As Decimal

    'Public ReadOnly Property ItemsPrecioTotal As Decimal

    '    Get
    '        Return Precio * Cantidad
    '    End Get
    'End Property

End Class
