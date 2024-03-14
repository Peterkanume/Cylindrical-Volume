<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        HeadingLabel = New Label()
        RadiusLabel = New Label()
        HeightLabel = New Label()
        VolumeButton = New Button()
        RadiusTextBox = New TextBox()
        HeightTextBox = New TextBox()
        AnswerTextBox = New TextBox()
        AnswerLabel = New Label()
        ResetButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' HeadingLabel
        ' 
        HeadingLabel.AutoSize = True
        HeadingLabel.BackColor = SystemColors.ControlDark
        HeadingLabel.BorderStyle = BorderStyle.Fixed3D
        HeadingLabel.FlatStyle = FlatStyle.Popup
        HeadingLabel.Font = New Font("Algerian", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        HeadingLabel.Location = New Point(159, 22)
        HeadingLabel.Name = "HeadingLabel"
        HeadingLabel.Size = New Size(437, 26)
        HeadingLabel.TabIndex = 0
        HeadingLabel.Text = "Calculating the Volume of Cylinder"
        ' 
        ' RadiusLabel
        ' 
        RadiusLabel.AutoSize = True
        RadiusLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        RadiusLabel.Location = New Point(58, 74)
        RadiusLabel.Name = "RadiusLabel"
        RadiusLabel.Size = New Size(129, 20)
        RadiusLabel.TabIndex = 1
        RadiusLabel.Text = "Inset The Radius:"
        ' 
        ' HeightLabel
        ' 
        HeightLabel.AutoSize = True
        HeightLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        HeightLabel.Location = New Point(58, 148)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New Size(135, 20)
        HeightLabel.TabIndex = 2
        HeightLabel.Text = "Insert The Height:"
        ' 
        ' VolumeButton
        ' 
        VolumeButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        VolumeButton.Location = New Point(107, 348)
        VolumeButton.Name = "VolumeButton"
        VolumeButton.Size = New Size(118, 32)
        VolumeButton.TabIndex = 3
        VolumeButton.Text = "Calculate Volume"
        VolumeButton.UseVisualStyleBackColor = True
        ' 
        ' RadiusTextBox
        ' 
        RadiusTextBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        RadiusTextBox.Location = New Point(206, 107)
        RadiusTextBox.Name = "RadiusTextBox"
        RadiusTextBox.Size = New Size(390, 27)
        RadiusTextBox.TabIndex = 4
        ' 
        ' HeightTextBox
        ' 
        HeightTextBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        HeightTextBox.Location = New Point(206, 184)
        HeightTextBox.Name = "HeightTextBox"
        HeightTextBox.Size = New Size(390, 27)
        HeightTextBox.TabIndex = 5
        ' 
        ' AnswerTextBox
        ' 
        AnswerTextBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        AnswerTextBox.Location = New Point(206, 252)
        AnswerTextBox.Name = "AnswerTextBox"
        AnswerTextBox.ReadOnly = True
        AnswerTextBox.Size = New Size(390, 27)
        AnswerTextBox.TabIndex = 6
        ' 
        ' AnswerLabel
        ' 
        AnswerLabel.AutoSize = True
        AnswerLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        AnswerLabel.Location = New Point(58, 222)
        AnswerLabel.Name = "AnswerLabel"
        AnswerLabel.Size = New Size(67, 20)
        AnswerLabel.TabIndex = 7
        AnswerLabel.Text = "Answer:"
        ' 
        ' ResetButton
        ' 
        ResetButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        ResetButton.Location = New Point(395, 348)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(75, 32)
        ResetButton.TabIndex = 8
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        ExitButton.Location = New Point(617, 348)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 32)
        ExitButton.TabIndex = 9
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(ResetButton)
        Controls.Add(AnswerLabel)
        Controls.Add(AnswerTextBox)
        Controls.Add(HeightTextBox)
        Controls.Add(RadiusTextBox)
        Controls.Add(VolumeButton)
        Controls.Add(HeightLabel)
        Controls.Add(RadiusLabel)
        Controls.Add(HeadingLabel)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeadingLabel As Label
    Friend WithEvents RadiusLabel As Label
    Friend WithEvents HeightLabel As Label
    Friend WithEvents VolumeButton As Button
    Friend WithEvents RadiusTextBox As TextBox
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button

End Class
