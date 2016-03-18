Imports System.IO.File
Public Class Morpheus
    Private Data() As Integer
    Private DataCollected As Boolean = False
    Private redPill As New Form2()
    Private bluePill As New Form3()
    Private FileName As String
    Private blueDataPass As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileName = Application.StartupPath + "\Data.txt"
        DataCollected = GetData(FileName)
    End Sub
    Function GetData(ByVal File As String) As Boolean
        Try
            Using reader As System.IO.StreamReader = New System.IO.StreamReader(File)
                Dim NoLines As Integer = System.IO.File.ReadAllLines(File).Length
                ReDim Data(NoLines - 1)
                For i = 0 To NoLines
                    Data(i) = Int(reader.ReadLine())
                Next
                reader.Close()
            End Using
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub red_Pill_Click(sender As Object, e As EventArgs) Handles red_Pill.Click
        Me.Hide()
        redPill.Show()
        redPill.PassData(Data, DataCollected, FileName)
        redPill = New Form2()


    End Sub

    Private Sub blue_Pill_Click(sender As Object, e As EventArgs) Handles blue_Pill.Click
        Me.Hide()
        blueDataPass = bluePill.PassData(Data, DataCollected, FileName)
        bluePill.Show()
        bluePill = New Form3()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        DataGeneration.Show()
    End Sub
End Class
