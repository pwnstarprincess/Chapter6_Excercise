''Jennifer Pezzulo
''March 14, 2020
''Chapter 6 Excercise

Public Class ProjectileForm

    Const GRAVITY As Integer = 32

    Private Sub QuitProgram()

        Close()

    End Sub

    Private Function CalculateHeightAsFunctionOfTime(height As Double, velocity As Double, time As Double) As Double

        Return height + velocity * time - 16 * (time * time)

    End Function

    Private Function GetHeight() As Double

        Return Convert.ToDouble(heightBox.Text)

    End Function

    Private Function GetVelocity() As Double

        Return Convert.ToDouble(velocityBox.Text)

    End Function

    Private Sub ClearInputFields()

        heightBox.Clear()
        velocityBox.Clear()

    End Sub

    Private Sub ClearOutputField()

        TotalOutputBox.Clear()

    End Sub

    Private Sub ThrowError()

        TotalOutputBox.Text = "ERROR!!! Please enter a numeric value for the initial height and initial velocity"

    End Sub

    Private Function HeightAndVelocityNotEmpty() As Boolean

        If (Not String.IsNullOrEmpty(heightBox.Text) And Not String.IsNullOrEmpty(velocityBox.Text)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function InputValid() As Boolean

        If (Not String.IsNullOrEmpty(heightBox.Text) And Not String.IsNullOrEmpty(velocityBox.Text) AndAlso IsNumeric(heightBox.Text) And IsNumeric(velocityBox.Text)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        QuitProgram()

    End Sub

    Private Sub MaxHeightButton_Click(sender As Object, e As EventArgs) Handles MaxHeightButton.Click

        If (InputValid()) Then
            ClearOutputField()
            TotalOutputBox.AppendText("Max Height:    " + Convert.ToString(CalculateHeightAsFunctionOfTime(GetHeight(), GetVelocity(), (GetVelocity() / GRAVITY))) & Environment.NewLine)
            ClearInputFields()
        Else
            ThrowError()
        End If


    End Sub

    Private Sub HeightBox_TextChanged(sender As Object, e As EventArgs) Handles heightBox.Leave

        If (String.IsNullOrEmpty(heightBox.Text) Or Not IsNumeric(heightBox.Text)) Then
            heightBox.Clear()
            ThrowError()
        End If
    End Sub

    Private Sub VelocityBox_TextChanged(sender As Object, e As EventArgs) Handles velocityBox.Leave

        If (String.IsNullOrEmpty(velocityBox.Text) Or Not IsNumeric(velocityBox.Text)) Then
            ThrowError()
            velocityBox.Clear()
        End If
    End Sub

End Class
