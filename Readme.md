<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570716/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3332)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [AnalyticsDataViewModel.cs](./CS/PivotGauges/AnalyticsDataViewModel.cs) (VB: [AnalyticsDataViewModel.vb](./VB/PivotGauges/AnalyticsDataViewModel.vb))
* [MainWindow.xaml](./CS/PivotGauges/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PivotGauges/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/PivotGauges/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PivotGauges/MainWindow.xaml.vb))
<!-- default file list end -->
# PivotGridControl and GaugeControl integration


<p>This example illustrates the approach of using gauge controls to indicate certain values (i.e. totals) from PivotGridControl.</p><p><strong>IMPORTANT</strong>: The example requires adding an extra database view to the Northwind database:</p><p>CREATE VIEW [dbo].[vwOrdersForPivot]</p><p>AS</p><p>SELECT     dbo.Categories.CategoryName, dbo.Products.ProductName, dbo.Orders.ShippedDate, (dbo.[Order Details].UnitPrice * dbo.[Order Details].Quantity) </p><p>                     * (1 - dbo.[Order Details].Discount) AS Price, dbo.Employees.LastName + ' ' + dbo.Employees.FirstName AS EmployeeName</p><p>FROM         dbo.Orders INNER JOIN</p><p>                     dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID INNER JOIN</p><p>                     dbo.EmployeeTerritories ON dbo.Orders.EmployeeID = dbo.EmployeeTerritories.EmployeeID INNER JOIN</p><p>                     dbo.Employees ON dbo.Orders.EmployeeID = dbo.Employees.EmployeeID AND dbo.EmployeeTerritories.EmployeeID = dbo.Employees.EmployeeID INNER JOIN</p><p>                     dbo.Territories ON dbo.EmployeeTerritories.TerritoryID = dbo.Territories.TerritoryID INNER JOIN</p><p>                     dbo.Region ON dbo.Territories.RegionID = dbo.Region.RegionID INNER JOIN</p><p>                     dbo.Products ON dbo.[Order Details].ProductID = dbo.Products.ProductID INNER JOIN</p><p>                     dbo.Categories ON dbo.Products.CategoryID = dbo.Categories.CategoryID</p><p>WHERE     (dbo.Orders.ShippedDate IS NOT NULL)<br />
</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pivotgridcontrol-and-gaugecontrol-integration-e3332&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pivotgridcontrol-and-gaugecontrol-integration-e3332&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
