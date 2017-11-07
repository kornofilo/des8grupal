Public Class Datos_Devoluciones
    Dim _idDevolucion As Integer
    Dim _idproveedor As Integer
    Dim _idproducto As Integer
    Dim _fechaDevolucion As Date
    Dim _cantProductos As Integer
    Dim _idCompra As Integer
    Dim _costoUnitario As Decimal
    Dim _montoDev As Decimal
    Dim _saldo As Decimal


    Public Property IDDevolucion As Integer
        Get
            IDDevolucion = _idDevolucion
        End Get
        Set(value As Integer)
            _idDevolucion = value
        End Set
    End Property

    Public Property IDProveedor As Integer
        Get
            IDProveedor = _idproveedor
        End Get
        Set(value As Integer)
            _idproveedor = value
        End Set
    End Property

    Public Property IDProducto As Integer
        Get
            IDProducto = _idproducto
        End Get
        Set(value As Integer)
            _idproducto = value
        End Set
    End Property

    Public Property FechaDev As Date
        Get
            FechaDev = _fechaDevolucion
        End Get
        Set(value As Date)
            _fechaDevolucion = value
        End Set
    End Property

    Public Property CantidadProduct As Integer
        Get
            CantidadProduct = _cantProductos
        End Get
        Set(value As Integer)
            _cantProductos = value
        End Set
    End Property

    Public Property IDCompra As Integer
        Get
            IDCompra = _idCompra
        End Get
        Set(value As Integer)
            _idCompra = value
        End Set
    End Property

    Public Property CostoUnitario As Decimal
        Get
            CostoUnitario = _costoUnitario
        End Get
        Set(value As Decimal)
            _costoUnitario = value
        End Set
    End Property

    Public Property MontoDev As Decimal
        Get
            MontoDev = _montoDev
        End Get
        Set(value As Decimal)
            _montoDev = value
        End Set
    End Property

    Public Property Saldo As Decimal
        Get
            Saldo = _saldo
        End Get
        Set(value As Decimal)
            _saldo = value
        End Set
    End Property



End Class
