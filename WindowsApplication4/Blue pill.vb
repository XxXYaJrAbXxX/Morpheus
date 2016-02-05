Public Class Form3
    Private RefData() As Integer
    Private DataCollected As Boolean
    Private FileLoc As String
    Private Yval(50) As Integer
    Private xVal(50) As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeWindow()
        Timer1.Start()
    End Sub
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Morpheus.Show()
        Timer1.Stop()
    End Sub
    Public Function PassData(ByVal DataRef() As Integer, ByVal DataCollected As Boolean, ByVal FileName As String) As Boolean
        Me.DataCollected = DataCollected
        FileLoc = FileName
        'DataGridView1.AllowUserToAddRows = False
        'Dim anyRow As DataRow = DataTable1.NewRow
        'DataTable1.NewRow().Table.Rows.Add(DataRef)
        RefData = DataRef
        'DataTable1.Columns.Add("Data")
        'For i = 0 To 49
        'anyRow("Data") = DataRef(i)
        'Next
        'DataTable1.Rows.Add(anyRow)
        'DataGridView1.DataSource = DataSet1
        'For i = 0 To DataRef.Length
        ' DataGridView1.Rows(i).Cells("Data").Value = anyRow(i)
        'Next
        Return True
    End Function
    Function ResizeWindow()
        Dim windowWidth As Integer = Me.Size.Width
        Chart2.Left = (windowWidth * 0.3333) - 2
        Chart3.Left = (windowWidth * 0.6666) - 9
        DataGridView2.Left = (windowWidth * 0.3333) - 2
        DataGridView3.Left = (windowWidth * 0.6666) - 9

        Chart1.Width = (windowWidth * 0.3333) - 12
        Chart2.Width = (windowWidth * 0.3333) - 12
        Chart3.Width = (windowWidth * 0.3333) - 12
        DataGridView1.Width = (windowWidth * 0.3333) - 12
        DataGridView2.Width = (windowWidth * 0.3333) - 12
        DataGridView3.Width = (windowWidth * 0.3333) - 12

    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Chart1.Series.Clear()
        Chart1.Titles.Clear()
        Dim seriesname As String
        seriesname = "Sort 1"
        Chart1.Series.Add(seriesname)
        'For i = 1 To 50

        '    Yval(i) = n

        '    xVal(i) = "n" + i.ToString

        '    'System.Threading.Thread.Sleep(50)
        '    'Chart1.Show()

        'Next
        For i = 1 To RefData.Count - 1
            If RefData(i - 1) < RefData(i) Then
            Else
                RefData(0) = RefData(i)
                RefData(i) = RefData(i - 1)
                RefData(i - 1) = RefData(0)
                'count = count + 1
                Yval(i) = RefData(i)
                xVal(i) = i.ToString
            End If
        Next
        Chart1.Series(seriesname).Points.DataBindXY(xVal, RefData)
        'DataTable1.Rows.Add(RefData)

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class