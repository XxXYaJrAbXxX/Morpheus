<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGeneration
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 13)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(213, 477)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(233, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 477)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'DataGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "DataGeneration"
        Me.Text = "DataGeneration"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
