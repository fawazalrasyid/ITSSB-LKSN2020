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

Partial Public Class Employee
    Public Property Id As Integer
    Public Property Password As String
    Public Property Name As String
    Public Property Email As String
    Public Property Address As String
    Public Property PhoneNumber As String
    Public Property DateofBirth As Date
    Public Property IdJob As Integer
    Public Property Salary As Decimal

    Public Overridable Property Job As Job
    Public Overridable Property HeaderDeposits As ICollection(Of HeaderDeposit) = New HashSet(Of HeaderDeposit)

End Class
