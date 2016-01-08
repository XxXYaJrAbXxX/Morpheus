Public Class Form2
    Dim RefData() As Integer
    Dim DataCollected As Boolean
    Dim FileLoc As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Morpheus.Show()
    End Sub
    Public Function PassData(ByVal Data() As Integer, ByVal DataCollected As Boolean, ByVal FileName As String) As Boolean
        RefData = Data
        DataCollected = DataCollected
        FileLoc = FileName
        Return True
    End Function
End Class