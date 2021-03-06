﻿Imports System.IO.File
Public Class Morpheus
    Dim Data(50) As Integer
    Dim DataCollected As Boolean = False
    Dim redPill As New Form2()
    Dim bluePill As New Form3()
    Dim FileName As String
    Dim blueDataPass As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileName = Application.StartupPath + "\Data.txt"
        DataCollected = GetData(FileName)
        'If DataCollected = False Then
        '    ToolStripStatusLabel1.Text = "File has NOT been found! - " + FileName
        'ElseIf DataCollected = True Then
        '    ToolStripStatusLabel1.Text = "File has been found! - " + FileName
        'End If

    End Sub
    Function GetData(ByVal File As String) As Boolean
        Try
            Using reader As System.IO.StreamReader = New System.IO.StreamReader(File)
                Dim NoLines As Integer = System.IO.File.ReadAllLines(File).Length
                For i = 1 To NoLines
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
        If blueDataPass = False Then
            blueDataPass = bluePill.PassData(Data, DataCollected, FileName)
        End If
        bluePill.Show()
        bluePill = New Form3()
    End Sub
End Class
