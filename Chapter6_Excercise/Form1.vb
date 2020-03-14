﻿''Jennifer Pezzulo
''March 14, 2020
''Chapter 6 Excercise

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

    Private Sub ThrowError()

        TotalOutputBox.BackColor = DefaultBackColor
        TotalOutputBox.ForeColor = Color.Red
        TotalOutputBox.Text = "ERROR!!! Please enter a numeric value for the initial height and initial velocity"

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HeightBox_TextChanged(sender As Object, e As EventArgs) Handles heightBox.Leave

        If (String.IsNullOrEmpty(heightBox.Text) Or Not IsNumeric(heightBox.Text)) Then
            ThrowError()
            heightBox.Clear()
            DisableButtons()
        Else
            ClearOutputField()
            EnableButtons()
            TotalOutputBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub VelocityBox_TextChanged(sender As Object, e As EventArgs) Handles velocityBox.Leave

        If (String.IsNullOrEmpty(velocityBox.Text) Or Not IsNumeric(velocityBox.Text)) Then
            ThrowError()
            velocityBox.Clear()
            DisableButtons()
        Else
            ClearOutputField()
            EnableButtons()
            TotalOutputBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        QuitProgram()

    End Sub

    Private Sub MaxHeightButton_Click(sender As Object, e As EventArgs) Handles MaxHeightButton.Click

        ClearOutputField()
        TotalOutputBox.AppendText("Max Height: " + CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), (GetVelocity() / GRAVITY)).ToString("####0.00"))

    End Sub

    Private Sub ApproxTimeButton_Click(sender As Object, e As EventArgs) Handles ApproxTimeButton.Click
        ClearOutputField()
        Dim time As Double = 0
        While Not BallHitGround(time)
            time += 0.1
        End While
        TotalOutputBox.AppendText("Time: " + time.ToString("####0.00") + " " + "seconds")

    End Sub

    Private Sub DisplayTableButton_Click(sender As Object, e As EventArgs) Handles DisplayTableButton.Click
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
