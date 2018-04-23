Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid


Namespace PivotGauges
	Public Class AnalyticsDataViewModel
		Inherits DependencyObject
		#Region "Dependency Properties"
		Public Shared AverageValueProperty As DependencyProperty = DependencyProperty.Register("AverageValue", GetType(Double), GetType(AnalyticsDataViewModel))
		Public Property AverageValue() As Double
			Get
				Return CDbl(GetValue(AverageValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(AverageValueProperty, value)
			End Set
		End Property

		Public Shared MinValueProperty As DependencyProperty = DependencyProperty.Register("MinValue", GetType(Double), GetType(AnalyticsDataViewModel))
		Public Property MinValue() As Double
			Get
				Return CDbl(GetValue(MinValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MinValueProperty, value)
			End Set
		End Property

		Public Shared MaxValueProperty As DependencyProperty = DependencyProperty.Register("MaxValue", GetType(Double), GetType(AnalyticsDataViewModel))
		Public Property MaxValue() As Double
			Get
				Return CDbl(GetValue(MaxValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MaxValueProperty, value)
			End Set
		End Property

		Public Shared TotalValueProperty As DependencyProperty = DependencyProperty.Register("TotalValue", GetType(Double), GetType(AnalyticsDataViewModel))
		Public Property TotalValue() As Double
			Get
				Return CDbl(GetValue(TotalValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(TotalValueProperty, value)
			End Set
		End Property

		Public Shared TargetValueProperty As DependencyProperty = DependencyProperty.Register("TargetValue", GetType(Double), GetType(AnalyticsDataViewModel))
		Public Property TargetValue() As Double
			Get
				Return CDbl(GetValue(TargetValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(TargetValueProperty, value)
			End Set
		End Property

		Public Shared CurrentValueProperty As DependencyProperty = DependencyProperty.Register("CurrentValue", GetType(Double), GetType(AnalyticsDataViewModel))
		Public Property CurrentValue() As Double
			Get
				Return CDbl(GetValue(CurrentValueProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(CurrentValueProperty, value)
			End Set
		End Property
		#End Region

		Public ReadOnly Property PivotDataSource() As IEnumerable(Of vwOrdersForPivot)
			Get
				Using dc As New NorthwindDataContext()
					Dim array = dc.vwOrdersForPivots.Select(Function(z) z).ToArray()
					Return array
				End Using
			End Get
		End Property

		Public Sub UpdateData(ByVal pivot As PivotGridControl)
			Dim rnd As New Random()
			Dim values As List(Of Double) = GetSelectedPivotValues(pivot)

			MinValue = values.Min()
			MaxValue = values.Max()
			AverageValue = values.Average()
			CurrentValue = Convert.ToDouble(pivot.GetCellValue(pivot.FocusedCell.X, pivot.FocusedCell.Y))
			TotalValue = values.Sum()
			TargetValue = TotalValue * 1 + TotalValue * 0.3 * ((rnd.NextDouble()))
		End Sub
		Private Function GetSelectedPivotValues(ByVal pivot As PivotGridControl) As List(Of Double)
			Dim result As New List(Of Double)()
			For Each selectedCell As System.Drawing.Point In pivot.MultiSelection.SelectedCells
				result.Add(Convert.ToDouble(pivot.GetCellValue(selectedCell.X, selectedCell.Y)))
			Next selectedCell
			Return result
		End Function
	End Class
End Namespace