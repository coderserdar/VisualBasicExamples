' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.Globalization

Public Class FormCountryListing
    Private cultureList As New List(Of String)()
    Private cultures As CultureInfo() = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
    Private region As RegionInfo
    Public Sub New()

        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each culture As CultureInfo In cultures
            region = New RegionInfo(culture.LCID)

            If Not (cultureList.Contains(region.EnglishName)) Then
                cultureList.Add(region.EnglishName)
                '  cultureList.Add(region.ISOCurrencySymbol);
                ' comboBox1.Items.Add(region.ISOCurrencySymbol);
                comboBox1.Items.Add(region.EnglishName & " (" & region.ISOCurrencySymbol & ")")
            End If
        Next
    End Sub
End Class
