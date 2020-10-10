<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtEmailProveedor = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtPaisProveedor = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtCodigoProveedores = New System.Windows.Forms.TextBox()
        Me.lblCodigoProveedores = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistroProveedor = New System.Windows.Forms.Label()
        Me.btnAnteriorProveedor = New System.Windows.Forms.Button()
        Me.btnPrimerProveedor = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.btnUltimoProveedor = New System.Windows.Forms.Button()
        Me.btnSiguienteProveedor = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtEmailProveedor)
        Me.grbDatos.Controls.Add(Me.lblEmail)
        Me.grbDatos.Controls.Add(Me.txtTelefonoProveedor)
        Me.grbDatos.Controls.Add(Me.lblTelefono)
        Me.grbDatos.Controls.Add(Me.txtPaisProveedor)
        Me.grbDatos.Controls.Add(Me.lblPais)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpresa)
        Me.grbDatos.Controls.Add(Me.lblNombreEmpresa)
        Me.grbDatos.Controls.Add(Me.txtNombreProveedor)
        Me.grbDatos.Controls.Add(Me.lblNombreCliente)
        Me.grbDatos.Controls.Add(Me.txtCodigoProveedores)
        Me.grbDatos.Controls.Add(Me.lblCodigoProveedores)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(12, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(642, 278)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de proveedores"
        '
        'txtEmailProveedor
        '
        Me.txtEmailProveedor.Location = New System.Drawing.Point(102, 228)
        Me.txtEmailProveedor.Name = "txtEmailProveedor"
        Me.txtEmailProveedor.Size = New System.Drawing.Size(147, 20)
        Me.txtEmailProveedor.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 231)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(102, 202)
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(147, 20)
        Me.txtTelefonoProveedor.TabIndex = 9
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(6, 205)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtPaisProveedor
        '
        Me.txtPaisProveedor.Location = New System.Drawing.Point(102, 117)
        Me.txtPaisProveedor.Multiline = True
        Me.txtPaisProveedor.Name = "txtPaisProveedor"
        Me.txtPaisProveedor.Size = New System.Drawing.Size(147, 79)
        Me.txtPaisProveedor.TabIndex = 7
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(6, 152)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(30, 13)
        Me.lblPais.TabIndex = 6
        Me.lblPais.Text = "Pais:"
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(102, 91)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreEmpresa.TabIndex = 5
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(6, 94)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(90, 13)
        Me.lblNombreEmpresa.TabIndex = 4
        Me.lblNombreEmpresa.Text = "Nombre empresa:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(102, 65)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreProveedor.TabIndex = 3
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(6, 68)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreCliente.TabIndex = 2
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'txtCodigoProveedores
        '
        Me.txtCodigoProveedores.Location = New System.Drawing.Point(102, 39)
        Me.txtCodigoProveedores.Name = "txtCodigoProveedores"
        Me.txtCodigoProveedores.Size = New System.Drawing.Size(147, 20)
        Me.txtCodigoProveedores.TabIndex = 1
        '
        'lblCodigoProveedores
        '
        Me.lblCodigoProveedores.AutoSize = True
        Me.lblCodigoProveedores.Location = New System.Drawing.Point(6, 42)
        Me.lblCodigoProveedores.Name = "lblCodigoProveedores"
        Me.lblCodigoProveedores.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigoProveedores.TabIndex = 0
        Me.lblCodigoProveedores.Text = "Codigo:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistroProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProveedor)
        Me.grbNavegacion.Controls.Add(Me.btnPrimerProveedor)
        Me.grbNavegacion.Location = New System.Drawing.Point(12, 296)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(288, 74)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistroProveedor
        '
        Me.lblRegistroProveedor.AutoSize = True
        Me.lblRegistroProveedor.Location = New System.Drawing.Point(79, 37)
        Me.lblRegistroProveedor.Name = "lblRegistroProveedor"
        Me.lblRegistroProveedor.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroProveedor.TabIndex = 4
        Me.lblRegistroProveedor.Text = "x de n"
        '
        'btnAnteriorProveedor
        '
        Me.btnAnteriorProveedor.Location = New System.Drawing.Point(38, 28)
        Me.btnAnteriorProveedor.Name = "btnAnteriorProveedor"
        Me.btnAnteriorProveedor.Size = New System.Drawing.Size(35, 31)
        Me.btnAnteriorProveedor.TabIndex = 1
        Me.btnAnteriorProveedor.Text = "<"
        Me.btnAnteriorProveedor.UseVisualStyleBackColor = True
        '
        'btnPrimerProveedor
        '
        Me.btnPrimerProveedor.Location = New System.Drawing.Point(6, 28)
        Me.btnPrimerProveedor.Name = "btnPrimerProveedor"
        Me.btnPrimerProveedor.Size = New System.Drawing.Size(35, 31)
        Me.btnPrimerProveedor.TabIndex = 0
        Me.btnPrimerProveedor.Text = "|<"
        Me.btnPrimerProveedor.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnModificarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProveedor)
        Me.grbEdicion.Controls.Add(Me.btnUltimoProveedor)
        Me.grbEdicion.Controls.Add(Me.btnSiguienteProveedor)
        Me.grbEdicion.Location = New System.Drawing.Point(306, 296)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(348, 74)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(281, 22)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(67, 37)
        Me.btnBuscarProveedor.TabIndex = 6
        Me.btnBuscarProveedor.Text = "Buscar"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(221, 22)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(67, 37)
        Me.btnEliminarProveedor.TabIndex = 5
        Me.btnEliminarProveedor.Text = "Eliminar"
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Location = New System.Drawing.Point(162, 22)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(63, 37)
        Me.btnModificarProveedor.TabIndex = 4
        Me.btnModificarProveedor.Text = "Modificar"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(100, 22)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(67, 37)
        Me.btnAgregarProveedor.TabIndex = 3
        Me.btnAgregarProveedor.Text = "Nuevo"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'btnUltimoProveedor
        '
        Me.btnUltimoProveedor.Location = New System.Drawing.Point(70, 22)
        Me.btnUltimoProveedor.Name = "btnUltimoProveedor"
        Me.btnUltimoProveedor.Size = New System.Drawing.Size(35, 37)
        Me.btnUltimoProveedor.TabIndex = 3
        Me.btnUltimoProveedor.Text = ">|"
        Me.btnUltimoProveedor.UseVisualStyleBackColor = True
        '
        'btnSiguienteProveedor
        '
        Me.btnSiguienteProveedor.Location = New System.Drawing.Point(38, 22)
        Me.btnSiguienteProveedor.Name = "btnSiguienteProveedor"
        Me.btnSiguienteProveedor.Size = New System.Drawing.Size(35, 37)
        Me.btnSiguienteProveedor.TabIndex = 2
        Me.btnSiguienteProveedor.Text = ">"
        Me.btnSiguienteProveedor.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 378)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmProveedores"
        Me.Text = "Registro de proveedores"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents txtEmailProveedor As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtTelefonoProveedor As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtPaisProveedor As TextBox
    Friend WithEvents lblPais As Label
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtCodigoProveedores As TextBox
    Friend WithEvents lblCodigoProveedores As Label
    Friend WithEvents lblRegistroProveedor As Label
    Friend WithEvents btnAnteriorProveedor As Button
    Friend WithEvents btnPrimerProveedor As Button
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents btnUltimoProveedor As Button
    Friend WithEvents btnSiguienteProveedor As Button
End Class
