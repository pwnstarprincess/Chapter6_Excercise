''Jennifer Pezzulo
''March 14, 2020
''Chapter 6 Excercise
''git repo:  https://github.com/pwnstarprincess/Chapter6_Excercise.git

Imports System.Text

Public Class ProjectileForm
    Const GRAVITY As Integer = 32
    Private Sub QuitProgram()
        Close()
    End Sub

    Private Function CalculateHeightAsFunctionOfTime(height As Double, velocity As Double, time As Double) As Double

        Return height + velocity * time - 16 * (time * time)

    End Function

    Private Function BallHitGround(time As Double) As Boolean
        If (CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), time) < 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetHeight() As Double

        Return Convert.ToDouble(heightBox.Text)

    End Function

    Private Function GetVelocity() As Double

        Return Convert.ToDouble(velocityBox.Text)

    End Function

    Private Sub ClearOutputField()

        TotalOutputBox.Clear()

    End Sub

    Private Function HeightValid() As Boolean

        If (Not String.IsNullOrEmpty(heightBox.Text) And IsNumeric(heightBox.Text) AndAlso GetHeight() >= 0) Then
            Return True

        Else
            Return False
        End If

    End Function

    Private Function VelocityValid() As Boolean

        If (Not String.IsNullOrEmpty(velocityBox.Text) And IsNumeric(velocityBox.Text) AndAlso GetVelocity() >= 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub IsValid(valid As Boolean, problem As String)

        Dim color As Color
        Dim messages(3) As String

        messages(0) = "Please enter a numeric value for the initial height"
        messages(1) = "Please enter a numeric value for the initial velocity"
        messages(2) = "The height must be at 0 or above as the origin is assumed to be at (0,0)"
        messages(3) = "Please enter a positive number for the velocity"


        If Not valid Then
            DisableButtons()
            TotalOutputBox.BackColor = DefaultBackColor
            color = Color.Red

            If (Not (TotalOutputBox.Text.Contains(messages.Any))) Then

                TotalOutputBox.Clear()
                For Each message In messages
                    TotalOutputBox.ForeColor = color
                    TotalOutputBox.AppendText(message & Environment.NewLine)
                    TotalOutputBox.AppendText(Environment.NewLine & Environment.NewLine)

                    InputValidation(heightBox)
                    InputValidation(velocityBox)

                Next

            End If

        ElseIf valid Then
            TotalOutputBox.BackColor = DefaultBackColor
            color = Color.Green
        End If

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

        If VelocityValid() And HeightValid() Then
            EnableButtons()
        End If

    End Sub

    Private Sub InputValidation(myTrigger As TextBox)

        Select Case True
            Case (String.IsNullOrEmpty(myTrigger.Text) Or Not IsNumeric(myTrigger.Text))
                IsValid(False, myTrigger.Name.ToString + "-Text")

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

    Private Sub DisableButtons()
        MaxHeightButton.Enabled = False
        ApproxTimeButton.Enabled = False
        DisplayTableButton.Enabled = False
    End Sub

    Private Sub EnableButtons()
        MaxHeightButton.Enabled = True
        ApproxTimeButton.Enabled = True
        DisplayTableButton.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        IsValid(False, "Everything")

    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles velocityBox.TextChanged, heightBox.TextChanged

        Dim myTrigger As TextBox = CType(sender, TextBox)
        InputValidation(myTrigger)

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        QuitProgram()

    End Sub

    Private Sub MaxHeightButton_Click(sender As Object, e As EventArgs) Handles MaxHeightButton.Click

        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Black
        ClearOutputField()
        TotalOutputBox.AppendText("Max Height: " + CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), (GetVelocity() / GRAVITY)).ToString("####0.00"))

    End Sub

    Private Sub ApproxTimeButton_Click(sender As Object, e As EventArgs) Handles ApproxTimeButton.Click
        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Black
        ClearOutputField()
        Dim time As Double = 0.00
        While Not BallHitGround(time)
            time += 0.1
        End While
        TotalOutputBox.AppendText("Time: " + time.ToString("####0.00") + " " + "seconds")

    End Sub

    Private Sub DisplayTableButton_Click(sender As Object, e As EventArgs) Handles DisplayTableButton.Click
        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Black
        ClearOutputField()
        Dim time As Double = 0.00
        Dim format As String = "{0,4}{1,20}"
        Dim builder As New Text.StringBuilder
        builder.AppendFormat(format, "Time:", "Height: ")
        builder.AppendLine()
        While time <= 5.0 And Not BallHitGround(time)

            GetTableValues(time, format, builder)

        End While

        TotalOutputBox.Text = builder.ToString()

    End Sub

    Private Sub GetTableValues(ByRef time As Double, format As String, builder As StringBuilder)
        builder.AppendFormat(format, time.ToString("####0.00"), (CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), time)).ToString("####0.00"))
        builder.AppendLine()
        time += 0.25
    End Sub
End Class
