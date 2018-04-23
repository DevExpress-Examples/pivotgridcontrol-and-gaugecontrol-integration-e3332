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
Imports System.Windows.Navigation
Imports System.Windows.Shapes


Namespace PivotGauges
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private ReadOnly mainViewModel As New AnalyticsDataViewModel()

		Public Sub New()
			InitializeComponent()
			Me.DataContext = mainViewModel
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			pivot.FocusedCell = New System.Drawing.Point(0, 0)
			SelectColumn(0, 0)
		End Sub

		Private Sub pivot_CellClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.PivotGrid.PivotCellEventArgs)
		   SelectColumn(e.ColumnIndex, e.RowIndex)
		End Sub

		Private Sub SelectColumn(ByVal columnIndex As Integer, ByVal rowIndex As Integer)
			pivot.FocusedCell = New System.Drawing.Point(columnIndex, rowIndex)

			Dim points(pivot.RowCount - 1) As System.Drawing.Point
			For i As Integer = 0 To pivot.RowCount - 1
				points(i) = New System.Drawing.Point(pivot.FocusedCell.X, i)
			Next i

			pivot.MultiSelection.SetSelection(points)

			mainViewModel.UpdateData(pivot)
		End Sub
	End Class
End Namespace
