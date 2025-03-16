Imports System.Windows.Forms

Public Class Form2
    Inherits System.Windows.Forms.Form

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Fun facts array
    Dim moneyFacts As String() = {
        "The largest banknote ever issued was 100,000 pesos in the Philippines.",
        "The first paper money was used in China over 1,400 years ago.",
        "There is more Monopoly money printed every year than real U.S. currency!",
        "Coins were once made from real gold and silver.",
        "The U.S. penny costs more to make than it is worth!"
    }
    Dim rand As New Random()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display a random fact
        lblFacts.Text = moneyFacts(rand.Next(moneyFacts.Length))
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
