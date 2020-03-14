<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.heightBox = New System.Windows.Forms.TextBox()
        Me.velocityBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaxHeightButton = New System.Windows.Forms.Button()
        Me.ApproxTimeButton = New System.Windows.Forms.Button()
        Me.DisplayTableButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.TotalOutputBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'heightBox
        '
        Me.heightBox.Location = New System.Drawing.Point(107, 24)
        Me.heightBox.Margin = New System.Windows.Forms.Padding(2)
        Me.heightBox.Name = "heightBox"
        Me.heightBox.Size = New System.Drawing.Size(40, 20)
        Me.heightBox.TabIndex = 0
        '
        'velocityBox
        '
        Me.velocityBox.Location = New System.Drawing.Point(292, 22)
        Me.velocityBox.Margin = New System.Windows.Forms.Padding(2)
        Me.velocityBox.Name = "velocityBox"
        Me.velocityBox.Size = New System.Drawing.Size(40, 20)
        Me.velocityBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Initial Velocity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(194, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Feet / Second)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Initial Height:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "(Feet)"
        '
        'MaxHeightButton
        '
        Me.MaxHeightButton.Location = New System.Drawing.Point(11, 81)
        Me.MaxHeightButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MaxHeightButton.Name = "MaxHeightButton"
        Me.MaxHeightButton.Size = New System.Drawing.Size(107, 71)
        Me.MaxHeightButton.TabIndex = 6
        Me.MaxHeightButton.Text = "Determine Maximum Height"
        Me.MaxHeightButton.UseVisualStyleBackColor = True
        '
        'ApproxTimeButton
        '
        Me.ApproxTimeButton.Location = New System.Drawing.Point(11, 174)
        Me.ApproxTimeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ApproxTimeButton.Name = "ApproxTimeButton"
        Me.ApproxTimeButton.Size = New System.Drawing.Size(107, 67)
        Me.ApproxTimeButton.TabIndex = 7
        Me.ApproxTimeButton.Text = "Determine Approximate Time Until Ball Hits the Ground"
        Me.ApproxTimeButton.UseVisualStyleBackColor = True
        '
        'DisplayTableButton
        '
        Me.DisplayTableButton.Location = New System.Drawing.Point(225, 81)
        Me.DisplayTableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DisplayTableButton.Name = "DisplayTableButton"
        Me.DisplayTableButton.Size = New System.Drawing.Size(107, 71)
        Me.DisplayTableButton.TabIndex = 8
        Me.DisplayTableButton.Text = "Display Table"
        Me.DisplayTableButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(223, 174)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(107, 67)
        Me.QuitButton.TabIndex = 9
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'TotalOutputBox
        '
        Me.TotalOutputBox.Location = New System.Drawing.Point(67, 266)
        Me.TotalOutputBox.Multiline = True
        Me.TotalOutputBox.Name = "TotalOutputBox"
        Me.TotalOutputBox.ReadOnly = True
        Me.TotalOutputBox.Size = New System.Drawing.Size(222, 74)
        Me.TotalOutputBox.TabIndex = 11
        '
        'ProjectileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 388)
        Me.Controls.Add(Me.TotalOutputBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.DisplayTableButton)
        Me.Controls.Add(Me.ApproxTimeButton)
        Me.Controls.Add(Me.MaxHeightButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.velocityBox)
        Me.Controls.Add(Me.heightBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProjectileForm"
        Me.Text = "Projectile Motion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents heightBox As TextBox
    Friend WithEvents velocityBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaxHeightButton As Button
    Friend WithEvents ApproxTimeButton As Button
    Friend WithEvents DisplayTableButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents TotalOutputBox As TextBox
End Class
