Partial Class _Default
    Inherits System.Web.UI.Page
    Private objBL As ProyectoBusinessLogic.Cls_BusineesLogic = New ProyectoBusinessLogic.Cls_BusineesLogic()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            Listar_Personas()
        End If
    End Sub

    Protected Sub Listar_Personas()

        Dim lstPersonas As List(Of ProyectoEntidades.Cls_Entidad_Persona)
        'Dim dtCustomer As DataTable = New CustomerCls().Fetch()
        Try
            'lstPersonas = objBL.Listar_Personas()
            'If lstPersonas.Count > 0 Then
            'Else
            'End If

            GridPersonas.DataSource = objBL.Listar_Personas()
            GridPersonas.DataBind()

            'If dtCustomer.Rows.Count > 0 Then
            '    GridView1.DataSource = dtCustomer
            '    GridView1.DataBind()
            'Else 'if no record, display no record found in a new gridview cell
            '    dtCustomer.Rows.Add(dtCustomer.NewRow())
            '    Me.GridView1.DataSource = dtCustomer
            '    GridView1.DataBind()

            '    'create a new row/table and display a status message
            '    'on the gridview row
            '    Dim TotalColumns As Integer
            '    TotalColumns = GridView1.Rows(0).Cells.Count
            '    GridView1.Rows(0).Cells.Clear()
            '    GridView1.Rows(0).Cells.Add(New TableCell())
            '    GridView1.Rows(0).Cells(0).ColumnSpan = TotalColumns
            '    GridView1.Rows(0).Cells(0).Style.Add("text-align", "center")
            '    GridView1.Rows(0).Cells(0).Text = "No customer records in the database!"

            'End If

        Catch ex As Exception
            Throw New Exception(ex.Message.ToString(), ex)
        End Try

    End Sub
    Protected Sub GridPersonas_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) _
       Handles GridPersonas.RowCancelingEdit
        GridPersonas.EditIndex = -1
        Listar_Personas()
    End Sub

    Protected Sub GridPersonas_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)

        If e.CommandName.Equals("AddNew") Then
            Dim txtNewNombre As TextBox
            txtNewNombre = CType(GridPersonas.FooterRow.FindControl("txtNewNombre"), TextBox)
            Dim txtNewNacimiento As TextBox
            txtNewNacimiento = CType(GridPersonas.FooterRow.FindControl("txtNewNacimiento"), TextBox)
            Dim txtNewEdad As TextBox
            txtNewEdad = CType(GridPersonas.FooterRow.FindControl("txtNewEdad"), TextBox)
            Dim cmbNewSexo As DropDownList
            cmbNewSexo = CType(GridPersonas.FooterRow.FindControl("cmbNewSexo"), DropDownList)

            Dim datosPersonas As New ProyectoEntidades.Cls_Entidad_Persona
            With datosPersonas
                .id = -1
                .nombre_completo = txtNewNombre.Text
                .fecha_nacimiento = txtNewNacimiento.Text
                .edad = txtNewEdad.Text
                .sexo = IIf(cmbNewSexo.SelectedIndex = 0, "F", "M")
            End With

            If (objBL.Insert_Personas(datosPersonas) = True) Then
                GridPersonas.EditIndex = -1
                Listar_Personas()
            Else
                LblError.Text = "Ocurrio un Problema al Insertar los Datos"
            End If


        ElseIf e.CommandName.Equals("Delete") Then
            Dim index As Integer
            index = Convert.ToInt32(e.CommandArgument)
            objBL.Delete_Personas(Convert.ToInt32(GridPersonas.DataKeys(index).Values(0).ToString()))
            Listar_Personas()
        End If

    End Sub



    Protected Sub GridPersonas_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs)

    End Sub

    Protected Sub GridPersonas_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs)
        GridPersonas.EditIndex = e.NewEditIndex
        Listar_Personas()
    End Sub

    'get values when row is updating
    Protected Sub GridPersonas_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs)
        LblError.Text = ""
        If (GridPersonas.EditIndex <> -1) Then

            Dim txtNombre As TextBox
            txtNombre = CType(GridPersonas.Rows(e.RowIndex).FindControl("txtNombre"), TextBox)

            Dim txtFechaNac As TextBox
            txtFechaNac = CType(GridPersonas.Rows(e.RowIndex).FindControl("txtNacimiento"), TextBox)

            Dim cmbSexo As DropDownList
            cmbSexo = CType(GridPersonas.Rows(e.RowIndex).FindControl("cmbSexo"), DropDownList)

            Dim txtEdad As TextBox
            txtEdad = CType(GridPersonas.Rows(e.RowIndex).FindControl("txtEdad"), TextBox)


            Dim datosPersonas As New ProyectoEntidades.Cls_Entidad_Persona
            With datosPersonas
                .id = IIf(GridPersonas.DataKeys(e.RowIndex).Values(0).ToString().Length > 0, Convert.ToInt32(GridPersonas.DataKeys(e.RowIndex).Values(0).ToString()), -1)
                .nombre_completo = txtNombre.Text
                .fecha_nacimiento = txtFechaNac.Text
                .edad = txtEdad.Text
                .sexo = IIf(cmbSexo.SelectedIndex = 0, "F", "M")
            End With




            If (datosPersonas.id = -1) Then

                If (objBL.Insert_Personas(datosPersonas) = True) Then
                    GridPersonas.EditIndex = -1
                    Listar_Personas()
                Else
                    LblError.Text = "Ocurrio un Problema al Insertar los Datos"
                End If

            Else

                If (objBL.Update_Personas(datosPersonas) = True) Then
                    GridPersonas.EditIndex = -1
                    Listar_Personas()
                Else
                    LblError.Text = "Ocurrio un Problema al Actualizar los Datos"
                End If

            End If


        End If

    End Sub
End Class