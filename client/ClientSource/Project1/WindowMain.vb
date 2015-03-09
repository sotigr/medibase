Imports System.Windows.Controls
Public Class WindowMain
    Inherits genconts.Window
    WithEvents vw As View
    Public Sub New()
        Me.AllowsTransparency = False
    End Sub
    Private Sub WindowMain_Loaded(sender As Object, e As Windows.RoutedEventArgs) Handles Me.Loaded
        Me.CanMaximize = False
        Me.MinWidth = 500
        Me.MinHeight = 500
        Me.MaxHeight = System.Windows.Forms.Screen.GetWorkingArea(New System.Drawing.Point(Me.Left, Me.Top)).Height
        Me.MaxWidth = System.Windows.Forms.Screen.GetWorkingArea(New System.Drawing.Point(Me.Left, Me.Top)).Width
        Me.WindowTitle = "App client demo"

        vw = New View()
        If System.IO.File.Exists(CurDir() & "\index.html") Then
            vw.browser1.Source = New Uri(CurDir() & "\index.html")
        Else
            System.Windows.Forms.MessageBox.Show("index.html missing")
        End If
        Me.Content = vw.Content
    End Sub


End Class
