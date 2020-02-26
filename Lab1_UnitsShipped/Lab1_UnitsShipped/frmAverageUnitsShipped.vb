'*****  Lab 2 - Average Units Shipped                                                       *****'
'*****  Name: Andre Agrippa                                                                 *****'
'*****  Purpose: Prompts the user to enter amount of units shipped per day as whole numbers,*****'
'*****          then the the average amount of units shipped will be calculated and shown.  *****'
'*****          The user can reset the form at any time, and exit the form by pressing the  *****'
'*****          exit button.                                                                *****'
'*****  Date: 01/21/2020                                                                    *****'
'*****  Class: NETD 2202 

Option Strict On

Public Class frmAverageUnitsShipped
    'GLOBAL VARIABLES'
    Dim day As Integer = 1 ' keeps track of what day # it is
    Dim unitsTotal As Integer   'keeps track of total amount of units
    Dim unitsAverage As Double  'average amount of units shipped


    ''' <summary>
    ''' Exits the form once the exit button is clicked
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the windows form
        Me.Close()
    End Sub

    ''' <summary>
    ''' Receives user input, displays on the display label, then adds input to total units.
    ''' Once the user has entered units for 7 days, average units is calculated and displayed.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'VARIABLES'
        Dim units As Integer 'user input for # of units
        Const MAX_UNITS As Integer = 5000   'max amount of units user can enter
        Const MIN_UNITS As Integer = 0  'min amount of units user can enter 
        Const DPW As Integer = 7    ' days per week 


        day += 1    'increment days by 1 
        lblDay.Text = "Day " + day.ToString 'display updated day

        'If user input can be parsed into Integer
        If Integer.TryParse(txtUnits.Text, units) Then

            ' Entered units is numeric, check if it is from 0 to 5000
            If units >= MIN_UNITS And units <= MAX_UNITS Then

                unitsTotal += units 'increment totals by user input units
                txtEntries.Text &= units.ToString() & vbCrLf 'display user input and add a new line
                txtUnits.Text = ("")    'reset input text box
                txtUnits.Focus()    'set focus to units input text box

                If day > DPW Then 'if day is equal to days per week

                    day -= 1    'increment days by 1 
                    lblDay.Text = "Day " + day.ToString
                    unitsAverage = unitsTotal / DPW 'calculate average units 
                    'display on lbl average average units and round 2 decimal places
                    lblAverage.Text = "Average Units:" & Math.Round(unitsAverage, 2)
                    btnEnter.Enabled = False 'enter button disabled
                    btnReset.Focus()    'set user focus to reset button

                End If

            Else ' If units was not from 0 to 5000

                MessageBox.Show("Units must be from 0 to 5000. Please try again.")  'display error message box
                txtUnits.SelectAll()    'selects all text in texbox units
                txtUnits.Focus()    'sets user focus to text bot units
                day -= 1    'sets day -1 
                lblDay.Text = "Day " + day.ToString 'display updated day

            End If

        Else ' If units was not numeric

            MessageBox.Show("Units must be numeric whole numbers. Please try again.") 'display error message box
            txtUnits.SelectAll()    'selects all text in texbox units
            txtUnits.Focus()    'sets user focus to text bot units
            day -= 1    'sets day -1 
            lblDay.Text = "Day " + day.ToString 'display updated day

        End If

    End Sub

    ''' <summary>
    ''' Clears clears the units input, units entries and units average. It also sets the days
    ''' back to 0, average to 0 and units total to 0. The enter button is re-enabled. 
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtEntries.Text = ""    'sets the textbox unit entries to ""
        txtUnits.Text = ""  'sets the textbox units to ""
        lblAverage.Text = ""    'sets the label unit average to ""
        lblDay.Text = "Day 1" 'sets the label for day to "Day 1"
        txtUnits.Focus()    'sets focus to textbox units
        day = 1 'sets day to 0
        btnEnter.Enabled = True 'enables enter button
        unitsAverage = 0    'sets units average to 0
        unitsTotal = 0  'sets units total to 0

    End Sub

End Class
