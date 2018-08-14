Public Class Door
    Private Visible As Boolean
    Private Locked As Boolean
    Private Open As Boolean
    Private DoorIndex As Integer

    Sub New()

    End Sub

    Sub New(ByVal VD As Boolean, ByVal LD As Boolean, ByVal OD As Boolean, ByVal DI As Integer)
        Visible = VD
        Locked = LD
        Open = OD
        DoorIndex = DI
    End Sub

    Property IsVisible() As Boolean
        Get
            Return Visible
        End Get
        Set(ByVal value As Boolean)
            Visible = value
        End Set
    End Property

    Property IsLocked() As Boolean
        Get
            Return Locked
        End Get
        Set(ByVal value As Boolean)
            Locked = value
        End Set
    End Property

    Property IsOpen() As Boolean
        Get
            Return Open
        End Get
        Set(ByVal value As Boolean)
            Open = value
        End Set
    End Property
End Class
