<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtEntries = New System.Windows.Forms.TextBox()
        Me.averageUnitsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(46, 672)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(198, 68)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.averageUnitsToolTip.SetToolTip(Me.btnEnter, "Enters your input and puts it on the entries output")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(349, 672)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(198, 68)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.averageUnitsToolTip.SetToolTip(Me.btnReset, "Resets the form to its original state")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(654, 672)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(198, 68)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.averageUnitsToolTip.SetToolTip(Me.btnExit, "Closes the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(230, 121)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(67, 25)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        Me.averageUnitsToolTip.SetToolTip(Me.lblUnits, "Units must be whole numbers from 0 to 5000")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(349, 110)
        Me.txtUnits.Multiline = True
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(126, 36)
        Me.txtUnits.TabIndex = 1
        Me.averageUnitsToolTip.SetToolTip(Me.txtUnits, "Enter amount of units shipped for the displayed day")
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(521, 121)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(68, 25)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        Me.averageUnitsToolTip.SetToolTip(Me.lblDay, "Day counter")
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(235, 553)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(354, 47)
        Me.lblAverage.TabIndex = 4
        Me.averageUnitsToolTip.SetToolTip(Me.lblAverage, "Average units shipped display")
        '
        'txtEntries
        '
        Me.txtEntries.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEntries.Location = New System.Drawing.Point(235, 224)
        Me.txtEntries.Multiline = True
        Me.txtEntries.Name = "txtEntries"
        Me.txtEntries.ReadOnly = True
        Me.txtEntries.Size = New System.Drawing.Size(354, 287)
        Me.txtEntries.TabIndex = 3
        Me.txtEntries.TabStop = False
        Me.averageUnitsToolTip.SetToolTip(Me.txtEntries, "Entries output")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(883, 780)
        Me.Controls.Add(Me.txtEntries)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents txtEntries As TextBox
    Friend WithEvents averageUnitsToolTip As ToolTip
End Class
