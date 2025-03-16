Imports System.Windows.Forms

Public Class Form1
    Inherits System.Windows.Forms.Form

    ' Constructor
    Public Sub New()
        InitializeComponent() ' Ensure this is called to initialize form controls
    End Sub

    ' Dictionary for exchange rates
    Dim exchangeRates As New Dictionary(Of String, Double)
    Dim rand As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize Exchange Rates
        exchangeRates.Add("USD_INR", 83.25)
        exchangeRates.Add("INR_USD", 0.012)
        exchangeRates.Add("USD_EUR", 0.91)
        exchangeRates.Add("EUR_USD", 1.10)
        exchangeRates.Add("GBP_USD", 1.26)
        exchangeRates.Add("USD_GBP", 0.79)

        ' Populate ComboBoxes
        cmbFromCurrency.Items.AddRange(New String() {"USD", "INR", "EUR", "GBP"})
        cmbToCurrency.Items.AddRange(New String() {"USD", "INR", "EUR", "GBP"})
        cmbFromCurrency.SelectedIndex = 0
        cmbToCurrency.SelectedIndex = 1
    End Sub ' ✅ Fixed missing End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Get user inputs
        Dim fromCurrency As String = cmbFromCurrency.SelectedItem.ToString()
        Dim toCurrency As String = cmbToCurrency.SelectedItem.ToString()

        ' Validate amount input
        Dim amount As Double
        If Not Double.TryParse(txtAmount.Text, amount) Then
            MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Get the exchange rate
        Dim key As String = fromCurrency & "_" & toCurrency
        If exchangeRates.ContainsKey(key) Then
            Dim convertedAmount As Double = amount * exchangeRates(key)
            lblResult.Text = $"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}"

            ' Store conversion history
            lstHistory.Items.Add($"{amount} {fromCurrency} → {convertedAmount:F2} {toCurrency}")
        Else
            lblResult.Text = "Exchange rate not available."
        End If
    End Sub ' ✅ Fixed missing End Sub

    Private Sub btnFunFacts_Click(sender As Object, e As EventArgs) Handles btnFunFacts.Click
        ' Open fun facts form
        Dim funFactsForm As New Form2()
        funFactsForm.Show()

    End Sub ' ✅ Fixed missing End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Simulate exchange rate updates
        exchangeRates("USD_INR") = 80 + rand.NextDouble() * 5
        exchangeRates("INR_USD") = 0.012 + rand.NextDouble() * 0.002
        exchangeRates("USD_EUR") = 0.90 + rand.NextDouble() * 0.03
        exchangeRates("EUR_USD") = 1.09 + rand.NextDouble() * 0.02

        ' Log update (Optional)
        Debug.Print("Exchange rates updated!")
    End Sub ' ✅ Fixed missing End Sub

End Class
