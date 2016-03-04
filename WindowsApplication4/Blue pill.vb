Public Class Form3
    Private StartingData() As Integer
    Private RefData() As Integer
    Private DataCollected As Boolean
    Private FileLoc As String
    Private x1Val() As String
    Private x2Val() As String
    Private x3Val() As String
    Private List() As Integer
    Dim InsertionSort As Integer = 0
    Dim iOuter As Long
    Dim iInner As Long
    Dim iLBound As Long
    Dim iUBound As Long
    Dim iTemp As Long

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeWindow()
        'List = RefData
        InsertionSort = 1
        Timer1.Start()
    End Sub
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Morpheus.Show()
        Timer1.Stop()
        PassData(StartingData, True, FileLoc)
    End Sub
    Public Function PassData(ByVal DataRef() As Integer, ByVal DataCollected As Boolean, ByVal FileName As String) As Boolean
        Me.DataCollected = DataCollected
        FileLoc = FileName
        'DataGridView1.AllowUserToAddRows = False
        'Dim anyRow As DataRow = DataTable1.NewRow
        'DataTable1.NewRow().Table.Rows.Add(DataRef)
        ReDim StartingData(DataRef.Count - 1)
        ReDim RefData(DataRef.Count - 1)
        ReDim List(DataRef.Count - 1)
        For i = 0 To DataRef.Count - 1
            StartingData(i) = DataRef(i)
            RefData(i) = DataRef(i)
            List(i) = DataRef(i)
        Next

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

    Private Sub BubbleSortFunc()
        Chart1.Series.Clear()
        Chart1.Titles.Clear()
        ReDim x1Val(RefData.Count - 1)
        Dim seriesname1 As String
        Dim BubbleCache As Integer
        seriesname1 = "Bubble sort"
        Chart1.Series.Add(seriesname1)
        For i = 0 To RefData.Count
            If RefData(i + 1) >= RefData(i) Then
            Else
                BubbleCache = RefData(i)
                RefData(i) = RefData(i + 1)
                RefData(i + 1) = BubbleCache
                Exit For
            End If
        Next
        For i = 0 To List.Count - 1
            x1Val(i) = i.ToString
        Next
        Chart1.Series(seriesname1).Points.DataBindXY(x1Val, RefData)

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
    'Sub InsertionSort(List() As Integer, min As Integer, max As Integer)
    '    Dim med_value As Long
    '    Dim i As Integer

    '    ' If the list has no more than 1 element, it's sorted.
    '    If min >= max Then Exit Sub

    '    ' Pick a dividing item.
    '    i = Int((max - min + 1) * Rnd() + min)
    '    x2Val(i) = i.ToString
    '    med_value = List(i)

    '    ' Swap it to the front so we can find it easily.
    '    List(i) = List(min)

    '    ' Move the items smaller than this into the left
    '    ' half of the list. Move the others into the right.
    '    lo = min
    '    hi = max
    '    ' Look down from hi for a value < med_value.
    '    If List(hi) >= med_value Then
    '        hi = hi - 1
    '        If hi <= lo Then
    '            If hi <= lo Then
    '                List(lo) = med_value
    '            End If
    '        End If
    '    End If

    '    ' Swap the lo and hi values.
    '    List(lo) = List(hi)

    '    ' Look up from lo for a value >= med_value.
    '    lo = lo + 1
    '    If List(lo) < med_value Then
    '        lo = lo + 1
    '        If lo >= hi Then
    '            If lo >= hi Then
    '                lo = hi
    '                List(hi) = med_value
    '            End If
    '        End If
    '    End If


    '    ' Swap the lo and hi values.
    '    List(hi) = List(lo)

    '    ' Sort the two sublists
    '    'InsertionSort(List, min, lo - 1)
    '    'InsertionSort(List, lo + 1, max)
    'End Sub

    Private Sub InsertionSortFunc()

        Chart2.Series.Clear()
        Chart2.Titles.Clear()
        ReDim x2Val(List.Count - 1)
        Dim seriesname2 As String
        seriesname2 = "Insertion sort"
        Chart2.Series.Add(seriesname2)

        iLBound = LBound(List)
        iUBound = UBound(List)
        If InsertionSort = 1 Then
            InsertionSort = 2
            iOuter = iLBound + 1
        End If
        If InsertionSort < 3 Then
            If iOuter <= iUBound Then

                'Get the value to be inserted
                iTemp = List(iOuter)

                'Move along the already sorted values shifting along
                iInner = iOuter - 1
                For iInner = iOuter - 1 To iLBound Step -1

                    'No more shifting needed, we found the right spot!
                    If List(iInner) <= iTemp Then Exit For
                    List(iInner + 1) = List(iInner)
                Next iInner
                'Insert value in the slot
                List(iInner + 1) = iTemp
            End If
            iOuter += 1
        End If

        'Initializes the Insertion sort

        ''Checks to see if the sort is finished
        'If InsertionSort < 3 Then
        '    'Checks to see if it is less or equal to upper bound
        '    If iOuter <= iUBound Then
        '        'Has inner status been ran before?
        '        If innerstatus = 0 Then
        '            innerstatus = 1
        '            iInner = iOuter - 1
        '        End If
        '        iTemp = List(iOuter)
        '        'Is iInner greater than iLBound?
        '        If iInner > iLBound Then
        '            If List(iInner) <= iTemp Then
        '                innerstatus = 0
        '                iOuter = iOuter + 1
        '            Else
        '                List(iInner + 1) = List(iInner)
        '            End If
        '            iInner = iInner - 1
        '        Else
        '            iOuter = iOuter + 1
        '            innerstatus = 0
        '        End If

        '        List(iInner + 1) = iTemp
        '    End If
        'Else
        '    InsertionSort = 3
        'End If
        For i = 0 To List.Count - 1
            x2Val(i) = i.ToString
        Next
        'For i = 1 To RefData.Count - 1
        '    If RefData(i - 1) < RefData(i) Then
        '    Else
        '        RefData(0) = RefData(i)
        '        RefData(i) = RefData(i - 1)
        '        RefData(i - 1) = RefData(0)
        '        x2Val(i) = i.ToString
        '    End If
        'Next

        'Dim ints() As Integer = {10, 10, 44}
        Chart2.Series(seriesname2).Points.DataBindXY(x2Val, List)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BubbleSortFunc()
        InsertionSortFunc()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Timer1.Interval = 550 - TrackBar1.Value * 50
    End Sub
End Class