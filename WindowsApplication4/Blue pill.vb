Public Class Form3
    Dim RefData() As Integer
    Dim DataCollected As Boolean
    Dim FileLoc As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeWindow()
    End Sub
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Morpheus.Show()
    End Sub
    Public Function PassData(ByVal DataRef() As Integer, ByVal DataCollected As Boolean, ByVal FileName As String) As Boolean
        DataCollected = DataCollected
        FileLoc = FileName
        DataGridView1.AllowUserToAddRows = False
        Dim anyRow As DataRow = DataTable1.NewRow
        'DataTable1.NewRow().Table.Rows.Add(DataRef)
        DataTable1.Columns.Add("Data")
        For i = 0 To 49
            anyRow("Data") = DataRef(i)
        Next
        DataTable1.Rows.Add(anyRow)
        DataGridView1.DataSource = DataSet1
        For i = 0 To DataRef.Length
            'DataGridView1.Rows(i).Cells("Data").Value = anyRow(i)
        Next
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

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

End Class