'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Service
    Public Property Id As Integer
    Public Property Name As String
    Public Property IdCategory As Integer
    Public Property IdUnit As Integer
    Public Property PriceUnit As Integer
    Public Property EstimationDuration As Integer

    Public Overridable Property Category As Category
    Public Overridable Property DetailDeposits As ICollection(Of DetailDeposit) = New HashSet(Of DetailDeposit)
    Public Overridable Property Packages As ICollection(Of Package) = New HashSet(Of Package)
    Public Overridable Property Unit As Unit

End Class
