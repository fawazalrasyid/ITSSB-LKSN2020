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

Partial Public Class PrepaidPackage
    Public Property Id As Integer
    Public Property IdCustomer As Integer
    Public Property IdPackage As Integer
    Public Property Price As Integer
    Public Property StartDatetime As Date
    Public Property CompletedDatetime As Nullable(Of Date)

    Public Overridable Property Customer As Customer
    Public Overridable Property DetailDeposits As ICollection(Of DetailDeposit) = New HashSet(Of DetailDeposit)
    Public Overridable Property Package As Package

End Class
