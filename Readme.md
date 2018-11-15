<!-- default file list -->
*Files to look at*:

* [AnalyticsDataViewModel.cs](./CS/PivotGauges/AnalyticsDataViewModel.cs) (VB: [AnalyticsDataViewModel.vb](./VB/PivotGauges/AnalyticsDataViewModel.vb))
* [MainWindow.xaml](./CS/PivotGauges/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/PivotGauges/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/PivotGauges/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PivotGauges/MainWindow.xaml.vb))
<!-- default file list end -->
# PivotGridControl and GaugeControl integration


<p>This example illustrates the approach of using gauge controls to indicate certain values (i.e. totals) from PivotGridControl.</p><p><strong>IMPORTANT</strong>: The example requires adding an extra database view to the Northwind database:</p><p>CREATE VIEW [dbo].[vwOrdersForPivot]</p><p>AS</p><p>SELECT     dbo.Categories.CategoryName, dbo.Products.ProductName, dbo.Orders.ShippedDate, (dbo.[Order Details].UnitPrice * dbo.[Order Details].Quantity) </p><p>                     * (1 - dbo.[Order Details].Discount) AS Price, dbo.Employees.LastName + ' ' + dbo.Employees.FirstName AS EmployeeName</p><p>FROM         dbo.Orders INNER JOIN</p><p>                     dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID INNER JOIN</p><p>                     dbo.EmployeeTerritories ON dbo.Orders.EmployeeID = dbo.EmployeeTerritories.EmployeeID INNER JOIN</p><p>                     dbo.Employees ON dbo.Orders.EmployeeID = dbo.Employees.EmployeeID AND dbo.EmployeeTerritories.EmployeeID = dbo.Employees.EmployeeID INNER JOIN</p><p>                     dbo.Territories ON dbo.EmployeeTerritories.TerritoryID = dbo.Territories.TerritoryID INNER JOIN</p><p>                     dbo.Region ON dbo.Territories.RegionID = dbo.Region.RegionID INNER JOIN</p><p>                     dbo.Products ON dbo.[Order Details].ProductID = dbo.Products.ProductID INNER JOIN</p><p>                     dbo.Categories ON dbo.Products.CategoryID = dbo.Categories.CategoryID</p><p>WHERE     (dbo.Orders.ShippedDate IS NOT NULL)<br />
</p>

<br/>


