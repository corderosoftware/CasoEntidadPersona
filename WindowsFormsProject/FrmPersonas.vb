Public Class FrmPersonas
    Dim objWS As WSPersonas.WebServicePersonas = New WSPersonas.WebServicePersonas()
    Dim _objDatosPersona As WSPersonas.Cls_Entidad_Persona = New WSPersonas.Cls_Entidad_Persona()
    Dim _IdPersona As Integer = -1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        CmbSexo.SelectedIndex = 0
        Refrescar()

    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""
        DateNacimiento.Value = Now
        TxtEdad.Text = ""
        CmbSexo.SelectedIndex = 0
        BtnGuardar.Enabled = False
        _IdPersona = -1
        BtnAgregar.Enabled = True
        BtnEditar.Enabled = True
        BtnEliminar.Enabled = True
        dgvPersonas.Enabled = True
    End Sub

    Private Sub Habilitar(prmValor As Boolean)
        TxtNombre.Enabled = prmValor
        DateNacimiento.Enabled = prmValor
        TxtEdad.Enabled = prmValor
        CmbSexo.Enabled = prmValor
    End Sub

    Private Sub Refrescar()
        dgvPersonas.AutoGenerateColumns = False
        dgvPersonas.RowHeadersVisible = False
        dgvPersonas.DataSource = objWS.Listar_Personas()
        dgvPersonas.ClearSelection()
        dgvPersonas.CurrentCell = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpiar()
        Habilitar(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Limpiar()
        Habilitar(True)
        BtnGuardar.Enabled = True
        BtnAgregar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Function ValidarDatos() As Boolean

        If (String.IsNullOrEmpty(TxtNombre.Text) = True) Then
            MsgBox("Debe Indicar el Nombre Completo")
            Return False
        End If

        If (String.IsNullOrEmpty(TxtEdad.Text) = True) Then
            MsgBox("Debe Indicar la Edad")
            Return False
        End If

        If (CmbSexo.SelectedIndex = 0) Then
            MsgBox("Debe Indicar el Sexo")
            Return False
        End If

        Return True

    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (ValidarDatos() = False) Then
            Return
        End If

        With _objDatosPersona
            .id = _IdPersona
            .nombre_completo = TxtNombre.Text
            .fecha_nacimiento = DateNacimiento.Value
            .edad = TxtEdad.Text
            .sexo = IIf(CmbSexo.SelectedIndex = 1, "F", "M")
        End With

        If (_IdPersona = -1) Then
            If (objWS.Insertar_Personas(_objDatosPersona) = True) Then
                MsgBox("Datos Registrados Correctamente", MsgBoxStyle.Information)
                Limpiar()
                Refrescar()
            Else
                MsgBox("Problemas al intentar Insertar los Datos", MsgBoxStyle.Critical)
            End If
        Else
            If (objWS.Update_Personas(_objDatosPersona) = True) Then
                MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information)
                Limpiar()
                Refrescar()
            Else
                MsgBox("Problemas al intentar Actualizar los Datos", MsgBoxStyle.Critical)
            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (dgvPersonas.Rows.Count > 0) Then

            If (dgvPersonas.SelectedRows.Count > 0) Then

                _IdPersona = Int32.Parse(dgvPersonas.Rows(dgvPersonas.CurrentRow.Index).Cells(0).Value.ToString())
                _objDatosPersona = objWS.getPersonasById(Int32.Parse(dgvPersonas.Rows(dgvPersonas.CurrentRow.Index).Cells(0).Value.ToString()))

                TxtNombre.Text = _objDatosPersona.nombre_completo
                DateNacimiento.Value = _objDatosPersona.fecha_nacimiento
                TxtEdad.Text = _objDatosPersona.edad
                CmbSexo.SelectedIndex = IIf(_objDatosPersona.sexo = "F", 1, 2)

                BtnAgregar.Enabled = False
                BtnEditar.Enabled = False
                BtnEliminar.Enabled = False
                BtnGuardar.Enabled = True

                dgvPersonas.Enabled = False

                Habilitar(True)


            Else
                MsgBox("Debe Seleccionar un Elemento", MessageBoxButtons.OK + MessageBoxIcon.Error, "Error")
            End If

        Else
            MsgBox("No existen elementos en la lista")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (dgvPersonas.Rows.Count > 0) Then

            If (dgvPersonas.SelectedRows.Count > 0) Then

                If (MsgBox("¿Desea eliminar el registro?", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "Eliminar") = DialogResult.No) Then
                    Return
                End If

                If (objWS.Delete_Personas(Int32.Parse(dgvPersonas.Rows(dgvPersonas.CurrentRow.Index).Cells(0).Value.ToString())) = True) Then
                    Refrescar()
                Else
                    MsgBox("Ocurrio un Problema al Intentar Eliminar", MessageBoxButtons.OK + MessageBoxIcon.Error, "Error")
                End If


            Else
                    MsgBox("Debe Seleccionar un Elemento", MessageBoxButtons.OK + MessageBoxIcon.Error, "Error")
            End If

        Else
                MsgBox("No existen elementos en la lista")
        End If
    End Sub

    Private Sub dgvPersonas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPersonas.DataBindingComplete
        Dim gridView As DataGridView
        gridView = CType(sender, DataGridView)
        gridView.ClearSelection()
    End Sub
End Class
