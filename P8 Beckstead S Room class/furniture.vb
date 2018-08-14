Public Class furniture
    Private FurnName As String
    Private FurnUse As Boolean
    Private RmFurn As Boolean

    Sub New()

    End Sub

    Property TheFurnName() As String
        Get
            Return FurnName
        End Get
        Set(ByVal value As String)
            FurnName = value
        End Set
    End Property
    Property TheFurnUse() As Boolean
        Get
            Return FurnUse
        End Get
        Set(ByVal value As Boolean)
            FurnUse = value
        End Set
    End Property
    Property TheRmFurn() As Boolean
        Get
            Return RmFurn
        End Get
        Set(ByVal value As Boolean)
            RmFurn = value
        End Set
    End Property
End Class
