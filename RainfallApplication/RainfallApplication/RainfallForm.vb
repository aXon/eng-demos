Public Class RainfallForm
    ' Rainfall in the UK in 2011 and 2012, by month and year.  Data taken from the 
    ' UK's Met Office website here: http://www.metoffice.gov.uk/climate/uk/datasets/Rainfall/date/UK.txt
    Private rainfall(,) As Double = {
        {102.8, 110.9},
        {114.5, 60.0},
        {49.7, 37},
        {36.7, 128.0},
        {101.8, 65.8},
        {85.1, 149},
        {76.1, 118.9},
        {105.8, 111.3},
        {108.5, 112.9},
        {122.8, 126.2},
        {100.6, 135.5},
        {168.1, 179.4}
    }

    ' Originally, we used the following array declaration to create our rainfall array.  This
    ' declaration orders data by year and month and works fine.  However, we can't resize it 
    ' to add data for new years because ReDim Preserve only let's us change the size of
    ' the rightmost dimension!  That's why this commented out and we use the definition 
    ' above instead.
    'Private rainfall(,) As Double = {
    '        {102.8, 114.5, 49.7, 36.7, 101.8, 85.1, 76.1, 105.8, 108.5, 122.8, 100.6, 168.1},
    '        {110.9, 60.0, 37.0, 128.0, 65.8, 149.0, 118.9, 111.3, 112.9, 126.2, 135.5, 179.4}
    '    }


    Private Sub doItButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doItButton.Click
        ShowSumsAndAverages(rainfall)
    End Sub

    Private Sub ShowSumsAndAverages(ByVal rain(,) As Double)
        Dim sum As Double
        Dim average As Double

        For year As Integer = 0 To UBound(rain, 2)
            sum = 0

            For month As Integer = 0 To 11
                sum = sum + rain(month, year)
            Next

            average = sum / 12

            outputTextBox.Text &= "Sum: " & sum.ToString & " - Average: " & average.ToString("#.00") & Environment.NewLine
        Next
    End Sub
End Class
