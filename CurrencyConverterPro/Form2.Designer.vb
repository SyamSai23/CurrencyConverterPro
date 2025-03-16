Imports System.ComponentModel
Imports System.Windows.Forms

Partial Class Form2
    Inherits System.Windows.Forms.Form

    ' Declare UI components
    Private components As IContainer
    Friend WithEvents lblFacts As Label
    Friend WithEvents btnClose As Button

    ' Initialize UI Components
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFacts = New Label()
        Me.btnClose = New Button()

        ' Label (lblFacts)
        Me.lblFacts.AutoSize = True
        Me.lblFacts.Location = New System.Drawing.Point(20, 20)
        Me.lblFacts.Size = New System.Drawing.Size(250, 20)
        Me.lblFacts.Text = "Money Facts"

        ' Button (btnClose)
        Me.btnClose.Location = New System.Drawing.Point(20, 60)
        Me.btnClose.Size = New System.Drawing.Size(100, 30)
        Me.btnClose.Text = "Close"
        AddHandler Me.btnClose.Click, AddressOf Me.btnClose_Click

        ' Add Controls
        Me.Controls.Add(Me.lblFacts)
        Me.Controls.Add(Me.btnClose)

        ' Form Properties
        Me.Text = "Fun Facts"
        Me.ClientSize = New System.Drawing.Size(300, 150)
    End Sub
End Class
