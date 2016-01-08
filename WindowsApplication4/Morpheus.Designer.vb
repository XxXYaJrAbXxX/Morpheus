<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Morpheus
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.red_Pill = New System.Windows.Forms.Button()
        Me.blue_Pill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 1004)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Sorting algorithms"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 1004)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Shortest route"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'red_Pill
        '
        Me.red_Pill.Location = New System.Drawing.Point(13, 12)
        Me.red_Pill.Name = "red_Pill"
        Me.red_Pill.Size = New System.Drawing.Size(186, 135)
        Me.red_Pill.TabIndex = 4
        Me.red_Pill.Text = "Sorting Algorithms"
        Me.red_Pill.UseVisualStyleBackColor = True
        '
        'blue_Pill
        '
        Me.blue_Pill.Location = New System.Drawing.Point(206, 12)
        Me.blue_Pill.Name = "blue_Pill"
        Me.blue_Pill.Size = New System.Drawing.Size(186, 135)
        Me.blue_Pill.TabIndex = 5
        Me.blue_Pill.Text = "Shortest route"
        Me.blue_Pill.UseVisualStyleBackColor = True
        '
        'Morpheus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 158)
        Me.Controls.Add(Me.blue_Pill)
        Me.Controls.Add(Me.red_Pill)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Morpheus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morpheus"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents red_Pill As Button
    Friend WithEvents blue_Pill As Button
End Class
