Public Class clsRoom
    '   Public  Field Members

    Public Const MIN_NUM_EXITS As Integer = 1

    ' Private Data Members
    Private NDoor As New Door
    Private EDoor As New Door
    Private WDoor As New Door
    Private SDoor As New Door
    Private RmName As String
    Private RmColor As Color
    Private NumExits As Integer
    Private RmFurniture() As Furniture
    Private RmObject As Treasure
    Private DefaultColor As Color = Color.Yellow
    Private DefaultName As String = "New"
    Private DefaultNumExits As Integer = 6
    Private DefaultFurnName As String = "Chair"
    Private DefaultFurnType As Boolean = False

    'Private RoomExits As RmExits

    'Private HasTreasure As Boolean
    'Private RoomTreasure As Treasure

    'Private Structure RmExits
    '    Dim East As doors
    '    Dim West As doors
    '    Dim North As doors
    '    Dim South As doors
    'End Structure

    'Private Structure doors
    '    Dim locked As Boolean
    '    Dim open As Boolean
    '    Dim wall As String
    '    Dim exits As Boolean
    'End Structure



    Private Structure Furniture
        Dim FurnName As String
        Dim FurnType As Boolean
    End Structure

    ' Property Members

    Property RoomName() As String
        Get
            Return RmName
        End Get
        Set(ByVal value As String)
            If value <> Nothing Then
                RmName = value
            Else : RmName = DefaultName
            End If

        End Set
    End Property

    Property newroomcolor() As Color
        Get
            Return RmColor
        End Get
        Set(ByVal value As Color)
            RmColor = value
        End Set
    End Property

    Property RoomNumExits() As String
        Get
            Return NumExits
        End Get
        Set(ByVal value As String)
            If value <> Nothing Then
                NumExits = Val(value)
            Else : NumExits = DefaultNumExits
            End If
        End Set
    End Property

    ' Public Methods

    Protected Sub AddFurniture()
        ReDim Preserve RmFurniture(RmFurniture.Length)
        Dim newFurniture As Furniture
        newFurniture.FurnName = DefaultFurnName
        newFurniture.FurnType = DefaultFurnType
    End Sub

    Sub New()
        Me.RmName = RoomName
        Me.RmColor = Color.Yellow
        Me.NumExits = RoomNumExits
    End Sub

    Sub New(ByVal newroomcolor As Color, ByVal rmname As String, ByVal ND As Door, ByVal SD As Door, ByVal ED As Door, ByVal WD As Door)
        Me.RmColor = newroomcolor
        Me.RoomName = rmname
        NDoor = ND
        SDoor = SD
        EDoor = ED
        WDoor = WD


    End Sub

    'Sub New(ByVal NewName As String, ByVal NewColor As Color)
    '    Me.RmName = NewName
    '    Me.RmColor = DefaultColor
    '    Me.NumExits = DefaultNumExits
    'End Sub

    'Sub New(ByVal Newname As String, ByVal newColor As Color, ByVal NewExits As Integer)
    '    Me.RmName = Newname
    '    Me.RmColor = DefaultColor
    '    Me.NumExits = NewExits
    'End Sub
End Class
