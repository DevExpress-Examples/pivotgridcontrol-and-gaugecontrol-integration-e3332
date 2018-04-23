using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PivotGauges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly AnalyticsDataViewModel mainViewModel = new AnalyticsDataViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mainViewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pivot.FocusedCell = new System.Drawing.Point(0, 0);
            SelectColumn(0, 0);
        }

        void pivot_CellClick(object sender, DevExpress.Xpf.PivotGrid.PivotCellEventArgs e)
        {
           SelectColumn(e.ColumnIndex, e.RowIndex);
        }

        private void SelectColumn(int columnIndex, int rowIndex)
        {
            pivot.FocusedCell = new System.Drawing.Point(columnIndex, rowIndex);

            System.Drawing.Point[] points = new System.Drawing.Point[pivot.RowCount];
            for (int i = 0; i < pivot.RowCount; i++)
                points[i] = new System.Drawing.Point(pivot.FocusedCell.X, i);

            pivot.MultiSelection.SetSelection(points);

            mainViewModel.UpdateData(pivot);
        }
    }
}
