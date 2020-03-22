''Jennifer Pezzulo
''March 14, 2020
''Chapter 6 Excercise
''git repo:  https://github.com/pwnstarprincess/Chapter6_Excercise.git

Imports System.Text

Public Class ProjectileForm
    'Declare Constant for GRAVITY
    Const GRAVITY As Integer = 32

    'Function to Close the form and consequently quit the program
    Private Sub QuitProgram()
        Close()
    End Sub

    'Calculate and Return the height as a function of time 
    'H(t) = h + v * t -16 * t^2 
    Private Function CalculateHeightAsFunctionOfTime(height As Double, velocity As Double, time As Double) As Double

        Return height + velocity * time - 16 * (time * time)

    End Function

    'Function to determine if the ball hit the ground
    Private Function BallHitGround(time As Double) As Boolean
        'IF H(t) < 0 then the ball hit the ground
        If (CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), time) < 0) Then
            Return True
        Else
            'h(t) greater than 0 return false because the ball has not hit the ground yet
            Return False
        End If
    End Function

    'Function to return the height as Double
    Private Function GetHeight() As Double

        Return Convert.ToDouble(heightBox.Text)

    End Function
    'Function to return the velocity as double
    Private Function GetVelocity() As Double

        Return Convert.ToDouble(velocityBox.Text)

    End Function
    'Function to clear the output text box
    Private Sub ClearOutputField()

        TotalOutputBox.Clear()

    End Sub
    'Function to determine if height is valid
    Private Function HeightValid() As Boolean
        'if height is a number greater than or equal to 0 then the height is valid
        If (Not String.IsNullOrEmpty(heightBox.Text) And IsNumeric(heightBox.Text) AndAlso GetHeight() >= 0) Then
            Return True

        Else
            Return False
        End If

    End Function
    'Function to determine if the velocity is valid
    Private Function VelocityValid() As Boolean
        ' If velocity is a number greater than or equal to 0 then the height is valid
        If (Not String.IsNullOrEmpty(velocityBox.Text) And IsNumeric(velocityBox.Text) AndAlso GetVelocity() >= 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    'Sub routine to print and manipulate validation message
    Private Sub IsValid(valid As Boolean, problem As String)
        'Variables for color and message array
        Dim color As Color
        Dim messages(3) As String
        'Populate message array with input requirements
        messages(0) = "Please enter a numeric value for the initial height"
        messages(1) = "Please enter a numeric value for the initial velocity"
        messages(2) = "The height must be at 0 or above as the origin is assumed to be at (0,0)"
        messages(3) = "Please enter a positive number for the velocity"
        'If inpout is not valid Disable the buttons and set text color to red
        If Not valid Then
            DisableButtons()
            TotalOutputBox.BackColor = DefaultBackColor
            color = Color.Red
            ' If output box does not contain the requirements message then clear the output and 
            'Print the requirements
            If Not TotalOutputBox.Text.Contains(messages(0)) Then

                TotalOutputBox.Clear()
                For Each message In messages
                    TotalOutputBox.ForeColor = color
                    TotalOutputBox.AppendText(message & Environment.NewLine)
                    TotalOutputBox.AppendText(Environment.NewLine)
                    'After pinting requirements run both inpouts through validation checks
                    InputValidation(heightBox)
                    InputValidation(velocityBox)

                Next

            End If
            'if data is valid then the text color should be green
        ElseIf valid Then
            TotalOutputBox.BackColor = DefaultBackColor
            color = Color.Green
        End If
        'Depending on the problem manipulate the applicable message
        Select Case problem
            Case "heightBox-Text"

                TotalOutputBox.Find(messages(0))
                TotalOutputBox.SelectionColor = color

            Case "velocityBox-Text"
                TotalOutputBox.Find(messages(1))
                TotalOutputBox.SelectionColor = color

            Case "heightBox"
                TotalOutputBox.Find(messages(2))
                TotalOutputBox.SelectionColor = color

            Case "velocityBox"
                TotalOutputBox.Find(messages(3))
                TotalOutputBox.SelectionColor = color

            Case "everything"
                For Each message In messages
                    TotalOutputBox.Find(message)
                    TotalOutputBox.SelectionColor = color

                Next
        End Select
        'If everythinbg is valid then enable the buttons
        If VelocityValid() And HeightValid() Then
            EnableButtons()
        End If

    End Sub
    'Sub routine to validate input based on input box trigger
    Private Sub InputValidation(myTrigger As TextBox)
        ' look for which case is true and manipulate the applicable instruction messages with IsValid
        Select Case True
            'if triggered input box contains an empty value or a value that is not a number
            Case (String.IsNullOrEmpty(myTrigger.Text) Or Not IsNumeric(myTrigger.Text))
                IsValid(False, myTrigger.Name.ToString + "-Text")
                IsValid(False, myTrigger.Name.ToString)
                'If triggered input box is a number check to see if the number is valid (i.e. at or above 0)
            Case (Not String.IsNullOrEmpty(myTrigger.Text) AndAlso IsNumeric(myTrigger.Text))
                IsValid(True, myTrigger.Name.ToString + "-Text")

                If (Convert.ToDouble(myTrigger.Text) < 0) Then
                    IsValid(False, myTrigger.Name.ToString)

                End If

                If (Convert.ToDouble(myTrigger.Text) >= 0) Then

                    IsValid(True, myTrigger.Name.ToString)

                End If

        End Select

    End Sub
    'Sub routine to disable the buttons
    Private Sub DisableButtons()
        MaxHeightButton.Enabled = False
        ApproxTimeButton.Enabled = False
        DisplayTableButton.Enabled = False
    End Sub
    'Sub routine to enable the buttons
    Private Sub EnableButtons()
        MaxHeightButton.Enabled = True
        ApproxTimeButton.Enabled = True
        DisplayTableButton.Enabled = True
    End Sub
    'Load the form and print instructions in red
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        IsValid(False, "Everything")

    End Sub
    'When input box is changed, validate the input
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles velocityBox.TextChanged, heightBox.TextChanged

        Dim myTrigger As TextBox = CType(sender, TextBox)
        InputValidation(myTrigger)

    End Sub
    'Close the form and end the program when the quit button is clicked
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        QuitProgram()

    End Sub
    'Sub to handle click of Max Hight Button
    Private Sub MaxHeightButton_Click(sender As Object, e As EventArgs) Handles MaxHeightButton.Click
        'Set text color to black
        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Black
        'Clear the output fields
        ClearOutputField()
        'output max height.  Max Height is equal to h + v * (v/gravity) -16 * (velocity/gravity)^2
        TotalOutputBox.AppendText("Max Height: " + CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), (GetVelocity() / GRAVITY)).ToString("####0.00"))

    End Sub
    'Sub to handle click of Approximate Time untill ball hits the ground button
    Private Sub ApproxTimeButton_Click(sender As Object, e As EventArgs) Handles ApproxTimeButton.Click
        'Set text color = to black and clear output field
        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Black
        ClearOutputField()

        'variable for time and set it to 0
        Dim time As Double = 0.00
        'While the ball is still above the ground increment the time by .1 seconds
        While Not BallHitGround(time)
            time += 0.1
        End While
        'When the ball hits the ground output the value of time
        TotalOutputBox.AppendText("Time: " + time.ToString("####0.00") + " " + "seconds")

    End Sub
    'Sub routine to handle click of Display table button
    Private Sub DisplayTableButton_Click(sender As Object, e As EventArgs) Handles DisplayTableButton.Click
        'Set the text color to black and clear output field
        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Black
        ClearOutputField()
        'Variable for time and set at 0
        Dim time As Double = 0.00
        'Variable for formatting of output in columns
        Dim format As String = "{0,4}{1,20}"
        'String builder variable
        Dim builder As New Text.StringBuilder
        'Append to the string builder the column headers
        builder.AppendFormat(format, "Time:", "Height: ")
        builder.AppendLine()
        'While the time is less than 5 seconds and the ball has not hit the ground
        While time <= 5.0 And Not BallHitGround(time)
            'Get the table values
            GetTableValues(time, format, builder)

        End While
        'Print the table values
        TotalOutputBox.Text = builder.ToString()

    End Sub
    'Sub routine to get the table values
    Private Sub GetTableValues(ByRef time As Double, format As String, builder As StringBuilder)
        'Add Line to string builder containing height for given time
        builder.AppendFormat(format, time.ToString("####0.00"), (CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), time)).ToString("####0.00"))
        builder.AppendLine()
        'increment the time by .25 seconds
        time += 0.25
    End Sub
End Class
