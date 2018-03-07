<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1BraydenSchoenauUnitsShipped
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
        Me.txtValueDisplay = New System.Windows.Forms.TextBox()
        Me.txtUserValue = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblUnitsPrompt = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCalculatedAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValueDisplay
        '
        Me.txtValueDisplay.Location = New System.Drawing.Point(21, 57)
        Me.txtValueDisplay.Multiline = True
        Me.txtValueDisplay.Name = "txtValueDisplay"
        Me.txtValueDisplay.ReadOnly = True
        Me.txtValueDisplay.Size = New System.Drawing.Size(369, 206)
        Me.txtValueDisplay.TabIndex = 3
        Me.txtValueDisplay.TabStop = False
        '
        'txtUserValue
        '
        Me.txtUserValue.Location = New System.Drawing.Point(146, 29)
        Me.txtUserValue.Name = "txtUserValue"
        Me.txtUserValue.Size = New System.Drawing.Size(100, 22)
        Me.txtUserValue.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(21, 343)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(119, 35)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblUnitsPrompt
        '
        Me.lblUnitsPrompt.AutoSize = True
        Me.lblUnitsPrompt.Location = New System.Drawing.Point(18, 34)
        Me.lblUnitsPrompt.Name = "lblUnitsPrompt"
        Me.lblUnitsPrompt.Size = New System.Drawing.Size(44, 17)
        Me.lblUnitsPrompt.TabIndex = 0
        Me.lblUnitsPrompt.Text = "Units:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(345, 29)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 17)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(146, 343)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 35)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(271, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCalculatedAverage
        '
        Me.lblCalculatedAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalculatedAverage.Location = New System.Drawing.Point(21, 282)
        Me.lblCalculatedAverage.Name = "lblCalculatedAverage"
        Me.lblCalculatedAverage.Size = New System.Drawing.Size(369, 47)
        Me.lblCalculatedAverage.TabIndex = 4
        '
        'frmLab1BraydenSchoenauUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(414, 390)
        Me.Controls.Add(Me.lblCalculatedAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnitsPrompt)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUserValue)
        Me.Controls.Add(Me.txtValueDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmLab1BraydenSchoenauUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValueDisplay As TextBox
    Friend WithEvents txtUserValue As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblUnitsPrompt As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCalculatedAverage As Label
End Class
