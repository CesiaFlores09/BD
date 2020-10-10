Imports System.Data
Imports System.Data.SqlClient

Public Class db_conexion
    Dim miConexion As New SqlConnection
    Dim miCommand As New SqlCommand
    Dim miAdapter As New SqlDataAdapter
    Dim ds As New DataSet

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Source = (LocalDB) \ MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_proveedores.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()

    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion



        miCommand.CommandText = "select * from proveedores"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "proveedores")

        Return ds
    End Function
    Public Function mantenimientoDatosProveedor(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO proveedores (codigo,nombre,nombreEmpresa,pais,telefono,email) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + ",'" + datos(4) + ",'" + datos(5) + ",'" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE proveedores Set codigo='" + datos(1) + "',nombre='" + datos(2) + "',nombreEmpresa='" + datos(3) + "',pais='" + datos(4) + "',telefono='" + datos(5) + "',email='" + datos(6) + "' WHERE idProveedores='" + datos(0) + "'"
            Case "eliminar"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class

