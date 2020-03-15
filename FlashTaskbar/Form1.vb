Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("user32.dll", EntryPoint:="FlashWindow")>
    Public Shared Function FlashWindow(ByVal hwnd As Integer, ByVal bInvert As Integer) As Integer
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FlashWindow(Me.Handle, 1)
    End Sub

End Class
