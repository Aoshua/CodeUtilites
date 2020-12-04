Imports System.ComponentModel.DataAnnotations
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations.Schema

Namespace EXS_OBJECTS

	Public Class App_Dashboards
		<Key()>
		Public Property DashboardID As Integer
		Public Property Title As String
		Public Property CompanyID As Integer
		Public Property LayoutType As String

		Public Overridable Property App_Dashboards_Panels As List(Of App_Dashboards_Panels) = New List(Of App_Dashboards_Panels)
	End Class
End Namespace

