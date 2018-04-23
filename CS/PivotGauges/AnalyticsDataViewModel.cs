using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.PivotGrid;


namespace PivotGauges
{
    public class AnalyticsDataViewModel : DependencyObject
    {
        #region Dependency Properties
        public static DependencyProperty AverageValueProperty = DependencyProperty.Register("AverageValue", typeof(double), typeof(AnalyticsDataViewModel));
        public double AverageValue
        {
            get { return (double)GetValue(AverageValueProperty); }
            set { SetValue(AverageValueProperty, value); }
        }

        public static DependencyProperty MinValueProperty = DependencyProperty.Register("MinValue", typeof(double), typeof(AnalyticsDataViewModel));
        public double MinValue
        {
            get { return (double)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        public static DependencyProperty MaxValueProperty = DependencyProperty.Register("MaxValue", typeof(double), typeof(AnalyticsDataViewModel));
        public double MaxValue
        {
            get { return (double)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        public static DependencyProperty TotalValueProperty = DependencyProperty.Register("TotalValue", typeof(double), typeof(AnalyticsDataViewModel));
        public double TotalValue
        {
            get { return (double)GetValue(TotalValueProperty); }
            set { SetValue(TotalValueProperty, value); }
        }

        public static DependencyProperty TargetValueProperty = DependencyProperty.Register("TargetValue", typeof(double), typeof(AnalyticsDataViewModel));
        public double TargetValue
        {
            get { return (double)GetValue(TargetValueProperty); }
            set { SetValue(TargetValueProperty, value); }
        }

        public static DependencyProperty CurrentValueProperty = DependencyProperty.Register("CurrentValue", typeof(double), typeof(AnalyticsDataViewModel));
        public double CurrentValue
        {
            get { return (double)GetValue(CurrentValueProperty); }
            set { SetValue(CurrentValueProperty, value); }
        }
        #endregion

        public IEnumerable<vwOrdersForPivot> PivotDataSource
        {
            get
            {
                using (NorthwindDataContext dc = new NorthwindDataContext())
                {
                    var array = dc.vwOrdersForPivots.Select(z => z).ToArray();
                    return array;
                }
            }
        }

        public void UpdateData(PivotGridControl pivot)
        {
            Random rnd = new Random();
            List<double> values = GetSelectedPivotValues(pivot);
            
            MinValue = values.Min();
            MaxValue = values.Max();
            AverageValue = values.Average();
            CurrentValue = Convert.ToDouble(pivot.GetCellValue(pivot.FocusedCell.X, pivot.FocusedCell.Y));
            TotalValue = values.Sum();
            TargetValue = TotalValue * 1 + TotalValue * 0.3 * ((rnd.NextDouble()));
        }
        List<double> GetSelectedPivotValues(PivotGridControl pivot)
        {
            List<double> result = new List<double>();
            foreach (System.Drawing.Point selectedCell in pivot.MultiSelection.SelectedCells)
            {
            	result.Add(Convert.ToDouble(pivot.GetCellValue(selectedCell.X, selectedCell.Y)));
            }
            return result;
        }    
    }
}