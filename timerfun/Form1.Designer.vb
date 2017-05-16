<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.count = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.start = New System.Windows.Forms.Button()
        Me.stoptimer = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'count
        '
        Me.count.BackColor = System.Drawing.Color.White
        Me.count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.count.Enabled = False
        Me.count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count.Location = New System.Drawing.Point(115, 88)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(43, 20)
        Me.count.TabIndex = 0
        Me.count.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(100, 124)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 1
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'stoptimer
        '
        Me.stoptimer.Location = New System.Drawing.Point(100, 162)
        Me.stoptimer.Name = "stoptimer"
        Me.stoptimer.Size = New System.Drawing.Size(75, 23)
        Me.stoptimer.TabIndex = 2
        Me.stoptimer.Text = "Stop"
        Me.stoptimer.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(100, 45)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 3
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.stoptimer)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.count)
        Me.Name = "Form1"
        Me.Text = "Stop Watch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents count As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents start As Button
    Friend WithEvents stoptimer As Button
    Friend WithEvents reset As Button
    Friend WithEvents Timer2 As Timer
End Class
