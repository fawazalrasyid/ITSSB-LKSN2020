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

Partial Public Class Customer
    Public Property Id As Integer
    Public Property Name As String
    Public Property PhoneNumber As String
    Public Property Address As String

    Public Overridable Property HeaderDeposits As ICollection(Of HeaderDeposit) = New HashSet(Of HeaderDeposit)
    Public Overridable Property PrepaidPackages As ICollection(Of PrepaidPackage) = New HashSet(Of PrepaidPackage)

End Class
