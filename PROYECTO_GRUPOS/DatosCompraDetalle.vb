Public Class DatosCompraDetalle
    Dim _idcompra As Integer
    Dim _idprovee As Integer
    Dim _idproduc As Integer
    Dim _produc As String
    Dim _cant As Integer
    Dim _costounidad As Decimal
    Dim _itbms As Decimal
    Dim _totalcompr As Decimal

    Public Property idcompra As Integer
        Get
            idcompra = _idcompra
        End Get
        Set(value As Integer)
            _idcompra = value
        End Set
    End Property
    Public Property idproveedor As Integer
        Get
            idproveedor = _idprovee
        End Get
        Set(value As Integer)
            _idprovee = value
        End Set
    End Property


    Public Property idproducto As Integer
        Get
            idproducto = _idproduc
        End Get
        Set(value As Integer)
            _idproduc = value
        End Set
    End Property
    Public Property producto As String
        Get
            producto = _produc
        End Get
        Set(value As String)
            _produc = value
        End Set

    End Property
    Public Property cantidad As Integer
        Get
            cantidad = _cant
        End Get
        Set(value As Integer)
            _cant = value
        End Set

    End Property
    Public Property costounidad As Decimal
        Get
            costounidad = _costounidad
        End Get
        Set(value As Decimal)
            _costounidad = value
        End Set

    End Property

    Public Property itbms As Decimal
        Get
            itbms = _itbms
        End Get
        Set(value As Decimal)
            _itbms = value
        End Set

    End Property

    Public Property totalcompra As Decimal
        Get
            totalcompra = _totalcompr
        End Get
        Set(value As Decimal)
            _totalcompr = value
        End Set

    End Property





End Class
