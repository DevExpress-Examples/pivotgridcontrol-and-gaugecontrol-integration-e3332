﻿'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.235
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System.Data.Linq
	Imports System.Data.Linq.Mapping
	Imports System.Data
	Imports System.Collections.Generic
	Imports System.Reflection
	Imports System.Linq
	Imports System.Linq.Expressions
	Imports System.ComponentModel
	Imports System
Namespace PivotGauges


	<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Northwind")> _
	Partial Public Class NorthwindDataContext
		Inherits System.Data.Linq.DataContext

		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnCreated()
	End Sub
	#End Region

		Public Sub New()
			MyBase.New(My.Settings.Default.NorthwindConnectionString, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public ReadOnly Property vwOrdersForPivots() As System.Data.Linq.Table(Of vwOrdersForPivot)
			Get
				Return Me.GetTable(Of vwOrdersForPivot)()
			End Get
		End Property
	End Class

	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.vwOrdersForPivot")> _
	Partial Public Class vwOrdersForPivot

		Private _CategoryName As String

		Private _ProductName As String

		Private _ShippedDate? As System.DateTime

		Private _Price? As Single

		Private _EmployeeName As String

		Public Sub New()
		End Sub

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryName", DbType:="NVarChar(15) NOT NULL", CanBeNull:=False)> _
		Public Property CategoryName() As String
			Get
				Return Me._CategoryName
			End Get
			Set(ByVal value As String)
				If (Me._CategoryName <> value) Then
					Me._CategoryName = value
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=False)> _
		Public Property ProductName() As String
			Get
				Return Me._ProductName
			End Get
			Set(ByVal value As String)
				If (Me._ProductName <> value) Then
					Me._ProductName = value
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShippedDate", DbType:="DateTime")> _
		Public Property ShippedDate() As System.DateTime?
			Get
				Return Me._ShippedDate
			End Get
			Set(ByVal value? As System.DateTime)
				If (Not Me._ShippedDate.Equals(value)) Then
					Me._ShippedDate = value
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Price", DbType:="Real")> _
		Public Property Price() As Single?
			Get
				Return Me._Price
			End Get
			Set(ByVal value? As Single)
				If (Not Me._Price.Equals(value)) Then
					Me._Price = value
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmployeeName", DbType:="NVarChar(31) NOT NULL", CanBeNull:=False)> _
		Public Property EmployeeName() As String
			Get
				Return Me._EmployeeName
			End Get
			Set(ByVal value As String)
				If (Me._EmployeeName <> value) Then
					Me._EmployeeName = value
				End If
			End Set
		End Property
	End Class
End Namespace
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591
