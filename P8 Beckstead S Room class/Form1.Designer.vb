<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PbxWall = New System.Windows.Forms.PictureBox
        Me.btnLeft = New System.Windows.Forms.Button
        Me.btnRight = New System.Windows.Forms.Button
        Me.pbxDoor = New System.Windows.Forms.PictureBox
        Me.pbxLoadBox = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LblNorth = New System.Windows.Forms.Label
        Me.LblEast = New System.Windows.Forms.Label
        Me.LblWest = New System.Windows.Forms.Label
        Me.LblSouth = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.PbxTreasure = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.LbLMessage = New System.Windows.Forms.Label
        CType(Me.PbxWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLoadBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxTreasure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxWall
        '
        Me.PbxWall.BackColor = System.Drawing.Color.Red
        Me.PbxWall.Location = New System.Drawing.Point(203, 78)
        Me.PbxWall.Name = "PbxWall"
        Me.PbxWall.Size = New System.Drawing.Size(399, 341)
        Me.PbxWall.TabIndex = 10
        Me.PbxWall.TabStop = False
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(37, 217)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 11
        Me.btnLeft.Text = "Go Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(650, 217)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 12
        Me.btnRight.Text = "Go Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'pbxDoor
        '
        Me.pbxDoor.BackColor = System.Drawing.SystemColors.ControlText
        Me.pbxDoor.Location = New System.Drawing.Point(319, 136)
        Me.pbxDoor.Name = "pbxDoor"
        Me.pbxDoor.Size = New System.Drawing.Size(152, 283)
        Me.pbxDoor.TabIndex = 14
        Me.pbxDoor.TabStop = False
        '
        'pbxLoadBox
        '
        Me.pbxLoadBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbxLoadBox.Location = New System.Drawing.Point(0, 0)
        Me.pbxLoadBox.Name = "pbxLoadBox"
        Me.pbxLoadBox.Size = New System.Drawing.Size(30, 26)
        Me.pbxLoadBox.TabIndex = 15
        Me.pbxLoadBox.TabStop = False
        Me.pbxLoadBox.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Map"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblNorth
        '
        Me.LblNorth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNorth.ForeColor = System.Drawing.Color.Black
        Me.LblNorth.Location = New System.Drawing.Point(383, 441)
        Me.LblNorth.Name = "LblNorth"
        Me.LblNorth.Size = New System.Drawing.Size(18, 24)
        Me.LblNorth.TabIndex = 18
        Me.LblNorth.Text = "N"
        '
        'LblEast
        '
        Me.LblEast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEast.ForeColor = System.Drawing.Color.Black
        Me.LblEast.Location = New System.Drawing.Point(407, 465)
        Me.LblEast.Name = "LblEast"
        Me.LblEast.Size = New System.Drawing.Size(18, 24)
        Me.LblEast.TabIndex = 19
        Me.LblEast.Text = "E"
        '
        'LblWest
        '
        Me.LblWest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWest.ForeColor = System.Drawing.Color.Black
        Me.LblWest.Location = New System.Drawing.Point(359, 465)
        Me.LblWest.Name = "LblWest"
        Me.LblWest.Size = New System.Drawing.Size(18, 24)
        Me.LblWest.TabIndex = 20
        Me.LblWest.Text = "W"
        '
        'LblSouth
        '
        Me.LblSouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSouth.ForeColor = System.Drawing.Color.Black
        Me.LblSouth.Location = New System.Drawing.Point(383, 483)
        Me.LblSouth.Name = "LblSouth"
        Me.LblSouth.Size = New System.Drawing.Size(18, 24)
        Me.LblSouth.TabIndex = 21
        Me.LblSouth.Text = "S"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Label1"
        '
        'PbxTreasure
        '
        Me.PbxTreasure.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.PbxTreasure.Location = New System.Drawing.Point(230, 340)
        Me.PbxTreasure.Name = "PbxTreasure"
        Me.PbxTreasure.Size = New System.Drawing.Size(147, 79)
        Me.PbxTreasure.TabIndex = 23
        Me.PbxTreasure.TabStop = False
        Me.PbxTreasure.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(611, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Inventory"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LbLMessage
        '
        Me.LbLMessage.BackColor = System.Drawing.Color.Transparent
        Me.LbLMessage.ForeColor = System.Drawing.Color.Black
        Me.LbLMessage.Location = New System.Drawing.Point(295, 91)
        Me.LbLMessage.Name = "LbLMessage"
        Me.LbLMessage.Size = New System.Drawing.Size(213, 42)
        Me.LbLMessage.TabIndex = 25
        Me.LbLMessage.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(768, 518)
        Me.Controls.Add(Me.LbLMessage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PbxTreasure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSouth)
        Me.Controls.Add(Me.LblWest)
        Me.Controls.Add(Me.LblEast)
        Me.Controls.Add(Me.LblNorth)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbxLoadBox)
        Me.Controls.Add(Me.pbxDoor)
        Me.Controls.Add(Me.PbxWall)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PbxWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLoadBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxTreasure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PbxWall As System.Windows.Forms.PictureBox
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents pbxDoor As System.Windows.Forms.PictureBox
    Friend WithEvents pbxLoadBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblNorth As System.Windows.Forms.Label
    Friend WithEvents LblEast As System.Windows.Forms.Label
    Friend WithEvents LblWest As System.Windows.Forms.Label
    Friend WithEvents LblSouth As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PbxTreasure As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LbLMessage As System.Windows.Forms.Label

End Class
