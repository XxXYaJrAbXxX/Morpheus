<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Form3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form3BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form3BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.DataSet1
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(282, 312)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data})
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 330)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(282, 147)
        Me.DataGridView1.TabIndex = 1
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.Width = 239
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.DataSource = Me.DataSet1
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(295, 12)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(282, 312)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Chart2"
        '
        'Chart3
        '
        Me.Chart3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Me.Chart3.DataSource = Me.DataSet1
        Legend3.Enabled = False
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(585, 12)
        Me.Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(282, 312)
        Me.Chart3.TabIndex = 3
        Me.Chart3.Text = "Chart3"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.DataSet1
        Me.DataGridView2.Location = New System.Drawing.Point(295, 330)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(282, 147)
        Me.DataGridView2.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 239
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.DataGridView3.DataSource = Me.DataSet1
        Me.DataGridView3.Location = New System.Drawing.Point(585, 330)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(282, 147)
        Me.DataGridView3.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 239
        '
        'Timer1
        '
        '
        'Form3BindingSource
        '
        Me.Form3BindingSource.DataSource = GetType(WindowsApplication4.Form3)
        '
        'Form3BindingSource1
        '
        Me.Form3BindingSource1.DataSource = GetType(WindowsApplication4.Form3)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(885, 489)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blue pill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form3BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Form3BindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Form3BindingSource1 As BindingSource
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Timer1 As Timer
End Class
