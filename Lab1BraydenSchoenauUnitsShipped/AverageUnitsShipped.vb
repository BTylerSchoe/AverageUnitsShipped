''' <summary>
''' Author: Brayden Schoenau
''' Project Name: Lab1AverageUnitsShipped
''' Date: 02-Feb-2018
''' Description: A windows form application that accepts user input for the daily sales in a week
'''              And displays them to the user as well as the calculated average weekly sales.
''' </summary>
''' 
Public Class frmLab1BraydenSchoenauUnitsShipped

    'Initalize variable userInput As an Integer & set it equal to 0
    Dim userInput As Integer = 0
    'Initalize variable sumOfSales As a Double & set it equal to 0.0
    Dim sumOfSales As Double = 0.0
    'Initalize variable weeklyAverageSales As a Double & set it equal to 0.0
    Dim weeklyAverageSales As Double = 0.0
    'Initialize array currentDay and set its index value to 6
    Dim currentDay(6) As Integer
    'Initialize constant daySeven as a double and set it equal to 7.0
    Const DaySeven As Double = 7.0
    'Initalize variable indexCounter As an Integer & set it equal to 0
    Dim indexCounter As Integer = 0
    'Initalize variable dayCounter As an Integer & set it equal to 2
    Dim dayCounter As Integer = 2



    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' It will test If the number is an Integer 
    '''    1. store it in array currentDay 
    '''    2. add input to sumOfSales variable
    '''    3. Display input in txtValueDisplay textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' If the value of txtUservalue is a valid integer store it in userInput variable
        If (Integer.TryParse(txtUserValue.Text, userInput)) Then
            ' If user Input is greater than or equal to 0 and less or equal to 1000
            If (userInput >= 0 And userInput <= 1000) Then

                ' currentDay array current index is equal to userInput
                currentDay(indexCounter) = userInput
                'txtValueDisplay text is equal to userInput, add new line
                txtValueDisplay.Text &= userInput.ToString & vbCrLf
                'lblDay text is equal to "Day " & dayCounter
                lblDay.Text = "Day " & dayCounter
                'dayCounter is equal to dayCounter + 1
                dayCounter += 1
                'indexCounter is equal to indexCounter + 1
                indexCounter += 1
                'txtUserValue text is equal to an empty string
                txtUserValue.Text = ""
                ' Move focus to txtUserValue text box
                txtUserValue.Select()

                'If indexCounter variable is greater than or equal to daySeven variable
                If (indexCounter >= DaySeven) Then

                    'for loop to calculate sum of sales
                    For i As Integer = 0 To currentDay.Length - 1
                        'sumOfSales vairable is equal to sumOfSAles + the value in the currentDay array at index i
                        sumOfSales += currentDay(i)
                    Next

                    'lblDay text is equal to "Day 7"
                    lblDay.Text = "Day 7"
                    'txtUserValue set to read only
                    txtUserValue.ReadOnly = True
                    'weeklyAverageSales is equal to the the sum of sales divided by 7 and rounded to 2 decimal places
                    weeklyAverageSales = Math.Round((sumOfSales / DaySeven), 2)
                    'lblCalculatedAverage text is equal to "Average per day: " & weeklyAverageSales converted to a string
                    lblCalculatedAverage.Text = "Average per day: " & weeklyAverageSales.ToString
                    'Set focus to btnReset control
                    btnReset.Select()
                    'Disable btnEnter button
                    btnEnter.Enabled = False

                End If

            Else
                'If userInput is greater than 1000 or less than 0 Display message 
                ' "Please ensure input is between 0 and 1000 inclusive"
                MessageBox.Show("Please ensure input is between 0 and 1000 inclusive")
                'txtUserValue text is equal to an empty string
                txtUserValue.Text = ""
                'Set focus to txtUserValue text box
                txtUserValue.Select()

            End If

        Else
            'If userInput is not a valid integer display message "Please ensure input is numeric"
            MessageBox.Show("Please ensure input is numeric")
            'txtUserValue text is equal to an empty string
            txtUserValue.Text = ""
            'Set focus to txtUserValue text box
            txtUserValue.Select()

        End If

    End Sub


    ''' <summary>
    ''' Exit button event handler exits the form application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close the current from application
        Me.Close()
    End Sub


    ''' <summary>
    ''' Reset button event handler resets the from application
    '''  when the user clicks reset button
    ''' Set all numeric values to 0
    ''' Set all textboxes to empty 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Set value of userInput to 0
        userInput = 0
        'Set value of sumOfSales to 0
        sumOfSales = 0
        'Set value of weeklyAAverageSales to 0
        weeklyAverageSales = 0
        'Set value of indexCounter to 0
        indexCounter = 0
        'Set value of dayCounter to 0
        dayCounter = 1
        'Set value of txtUserValue text to an empty string
        txtUserValue.Text = ""
        'Set value of txtValueDisplay text to an empty string
        txtValueDisplay.Text = ""
        'Set lblDay text to "Day " & dayCounter value
        lblDay.Text = "Day " & dayCounter
        'Set value of lblCalculatedAverage text to an empty string
        lblCalculatedAverage.Text = ""
        'Set txtUserValue text box read only property to false
        txtUserValue.ReadOnly = False
        'Set focus to txtUserValue text box
        txtUserValue.Select()
        'Enable btnEnter control
        btnEnter.Enabled = True
    End Sub

End Class
