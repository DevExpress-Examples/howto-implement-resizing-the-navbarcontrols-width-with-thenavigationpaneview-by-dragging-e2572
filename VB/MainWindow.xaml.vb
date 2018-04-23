Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Layout.Core
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.NavBar

Namespace DXWpfApplication
	Partial Public Class MainWindow
		Inherits DXWindow
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Thumb_DragDelta(ByVal sender As Object, ByVal e As System.Windows.Controls.Primitives.DragDeltaEventArgs)
			Dim minWidth As Double = 100

			Dim newWidth As Double = navBar.ActualWidth + e.HorizontalChange

			If newWidth >= minWidth Then
				If (Not view.IsExpanded) Then
					view.IsExpanded = True
				End If
				navBar.MaxWidth = newWidth

			ElseIf newWidth < minWidth AndAlso e.HorizontalChange < 0 Then
				view.IsExpanded = False
				thumb.CancelDrag()
			End If

		End Sub
	End Class

End Namespace
