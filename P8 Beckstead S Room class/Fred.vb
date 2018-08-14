Public Class RoomCoordinates


    Private Level As Integer
    Private row As Integer
    Private column As Integer

    'Sub New(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
    '    Level = x
    '    row = y
    '    column = z
    'End Sub

    Sub New(ByVal r As Integer, ByVal c As Integer)
        row = r
        column = c

    End Sub

    Property _Level() As Integer
        Get
            Return Level
        End Get
        Set(ByVal value As Integer)
            Level = value
        End Set
    End Property
    Property _row() As Integer
        Get
            Return row
        End Get
        Set(ByVal value As Integer)
            row = value
        End Set
    End Property
    Property _column() As Integer
        Get
            Return column
        End Get
        Set(ByVal value As Integer)
            column = value
        End Set
    End Property

End Class
