Imports System.Data.SqlClient
Module mdlConnection

    Public conn As New SqlConnection("Data Source=DESKTOP-LQURJJC;Initial Catalog=PC_BE_MODUL2;Integrated Security=True")
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public dr As SqlDataReader

    Sub koneksi()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
