Public Class Form3
    Private StartingData() As Integer
    Private BubbleArr() As Integer
    Private InsertionArr() As Integer
    Private InsertionSelArr() As Integer
    Private InsertionNewArr() As Integer
    Private QuicksortArr() As Integer
    Private DataCollected As Boolean
    Private FileLoc As String
    Private x1Val() As String
    Private x2Val() As String
    Private x3Val() As String
    Dim BubbleActive As Boolean
    Dim InsertionActive As Boolean
    Dim InsertionSort As Integer = 0
    Dim iOuter As Long
    Dim iInner As Long
    Dim iLBound As Long
    Dim iUBound As Long
    Dim iTemp As Long

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeWindow()
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
        ReDim StartingData(DataRef.Count - 1)
        ReDim BubbleArr(DataRef.Count - 1)
        ReDim InsertionArr(DataRef.Count - 1)
        ReDim QuicksortArr(DataRef.Count - 1)
        For i = 0 To DataRef.Count - 1
            StartingData(i) = DataRef(i)
            BubbleArr(i) = DataRef(i)
            InsertionArr(i) = DataRef(i)
            QuicksortArr(i) = DataRef(i)
        Next
        BubbleActive = True
        InsertionActive = True
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
        If BubbleActive = True Then
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            ReDim x1Val(BubbleArr.Count - 1)
            Dim BubbleSeries1 As String
            Dim BubbleCache As Integer
            BubbleSeries1 = "Bubble sort"
            Chart1.Series.Add(BubbleSeries1)
            For i = 0 To BubbleArr.Count - 2
                If BubbleArr(i + 1) >= BubbleArr(i) Then
                Else
                    BubbleCache = BubbleArr(i)
                    BubbleArr(i) = BubbleArr(i + 1)
                    BubbleArr(i + 1) = BubbleCache
                    Exit For
                End If
            Next
            For i = 0 To InsertionArr.Count - 1
                x1Val(i) = i.ToString
            Next
            Chart1.Series(BubbleSeries1).Points.DataBindXY(x1Val, BubbleArr)
        Else
        End If
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        BubbleActive = False
        For i = 0 To StartingData.Count - 1
            BubbleArr(i) = StartingData(i)
        Next
        BubbleActive = True
    End Sub

    Private Sub InsertionSortFunc()

        If InsertionActive = True Then
            Chart2.Series.Clear()
            Chart2.Titles.Clear()
            ReDim x2Val(InsertionArr.Count - 1)
            ReDim InsertionSelArr(InsertionArr.Count - 1)
            ReDim InsertionNewArr(InsertionArr.Count - 1)
            Dim InsertionSeries1 As String
            Dim InsertionSeries2 As String
            Dim InsertionSeries3 As String
            InsertionSeries1 = "Insertion sort"
            InsertionSeries2 = "Original slot"
            InsertionSeries3 = "New slot"
            Chart2.Series.Add(InsertionSeries1)
            Chart2.Series.Add(InsertionSeries2)
            Chart2.Series.Add(InsertionSeries3)

            iLBound = LBound(InsertionArr)
            iUBound = UBound(InsertionArr)
            If InsertionSort = 1 Then
                InsertionSort = 2
                iOuter = iLBound + 1
            End If
            If InsertionSort < 3 Then
                If iOuter <= iUBound Then
                    iTemp = InsertionArr(iOuter)
                    InsertionSelArr(iOuter) = InsertionArr(iOuter)
                    iInner = iOuter - 1
                    For iInner = iOuter - 1 To iLBound Step -1
                        For i = 0 To InsertionArr.Count - 1
                            InsertionNewArr(i) = 0
                        Next
                        InsertionNewArr(iInner) = iTemp
                        If InsertionArr(iInner) <= iTemp Then Exit For
                        InsertionArr(iInner + 1) = InsertionArr(iInner)
                    Next iInner
                    InsertionArr(iInner + 1) = iTemp
                End If
                iOuter += 1
            End If
            For i = 0 To InsertionArr.Count - 1
                x2Val(i) = i.ToString
            Next
            Chart2.Series(InsertionSeries1).Points.DataBindXY(x2Val, InsertionArr)
            Chart2.Series(InsertionSeries2).Points.DataBindXY(x2Val, InsertionSelArr)
            Chart2.Series(InsertionSeries3).Points.DataBindXY(x2Val, InsertionNewArr)
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BubbleSortFunc()
        InsertionSortFunc()
        Quicksort(LBound(QuicksortArr), UBound(QuicksortArr))
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Timer1.Interval = 550 - TrackBar1.Value * 50
        If TrackBar1.Value = 0 Then
            Timer1.Stop()
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click
        InsertionActive = False
        For i = 0 To StartingData.Count - 1
            InsertionArr(i) = StartingData(i)
        Next
        InsertionSort = 1
        iOuter = 0
        iInner = 0
        iLBound = 0
        iUBound = 0
        iTemp = 0
        InsertionActive = True
    End Sub

    Private Sub Quicksort(Low As Integer, High As Integer)
        Chart3.Series.Clear()
        Chart3.Titles.Clear()
        ReDim x3Val(QuicksortArr.Count - 1)
        Dim seriesname3 As String
        seriesname3 = "Quicksort"
        Chart3.Series.Add(seriesname3)

        Dim xTmp As Int32
        Dim xLo As Int32 = Low
        Dim xHi As Int32 = High
        Dim xPivot As Int32 = QuicksortArr((xLo + xHi) \ 2)
        If xLo <= xHi Then

            Do While QuicksortArr(xLo) < xPivot
                xLo += 1
            Loop
            Do While QuicksortArr(xHi) > xPivot
                xHi -= 1
            Loop
            If xLo <= xHi Then
                xTmp = QuicksortArr(xLo)
                QuicksortArr(xLo) = QuicksortArr(xHi)
                QuicksortArr(xHi) = xTmp
                xLo += 1
                xHi -= 1
            End If
            xLo += 1
        End If
        If (xLo < High) Then Quicksort(xLo, High)
        If (xHi > Low) Then Quicksort(Low, xHi)
        For i = 0 To QuicksortArr.Count - 1
            x3Val(i) = i.ToString
        Next
        Chart3.Series(seriesname3).Points.DataBindXY(x3Val, QuicksortArr)
    End Sub
End Class