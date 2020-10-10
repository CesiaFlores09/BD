Public Class frmProveedores
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("proveedores")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProveedores")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Proveedores
            txtCodigoProveedores.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombreProveedor.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtNombreEmpresa.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtPaisProveedor.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtTelefonoProveedor.Text = dataTable.Rows(posicion).ItemArray(5).ToString()
            txtEmailProveedor.Text = dataTable.Rows(posicion).ItemArray(6).ToString()

            lblRegistroProveedor.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProveedor()
            MessageBox.Show("No hay registros que mostrar", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimerProveedor_Click(sender As Object, e As EventArgs) Handles btnPrimerProveedor.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteProveedor_Click(sender As Object, e As EventArgs) Handles btnSiguienteProveedor.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAnteriorProveedor_Click(sender As Object, e As EventArgs) Handles btnAnteriorProveedor.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnUltimoProveedor_Click(sender As Object, e As EventArgs) Handles btnUltimoProveedor.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarProveedores_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        If btnAgregarProveedor.Text = "Nuevo" Then 'Nuevo
            btnAgregarProveedor.Text = "Guardar"
            btnModificarProveedor.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosProveedor()
        Else 'Guardar
            Dim msg = objConexion.mantenimientoDatosProveedor(New String() {
                Me.Tag, txtCodigoProveedores.Text, txtNombreProveedor.Text, txtNombreEmpresa.Text, txtPaisProveedor.Text, txtTelefonoProveedor.Text, txtEmailProveedor.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Proveedores",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarProveedor.Text = "Nuevo"
                btnModificarProveedor.Text = "Modificar"
            End If
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProveedor.Enabled = estado
        btnBuscarProveedor.Enabled = estado
    End Sub
    Private Sub limpiarDatosProveedor()
        txtCodigoProveedores.Text = ""
        txtNombreProveedor.Text = ""
        txtNombreEmpresa.Text = ""
        txtPaisProveedor.Text = ""
        txtTelefonoProveedor.Text = ""
        txtEmailProveedor.Text = ""
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        If btnModificarProveedor.Text = "Modificar" Then 'Modificar
            btnAgregarProveedor.Text = "Guardar"
            btnModificarProveedor.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarProveedor.Text = "Nuevo"
            btnModificarProveedor.Text = "Modificar"
        End If
    End Sub
End Class

