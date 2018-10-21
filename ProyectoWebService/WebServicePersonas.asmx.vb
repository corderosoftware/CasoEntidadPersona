Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports ProyectoBusinessLogic

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class WebServicePersonas
    Inherits System.Web.Services.WebService


    <WebMethod()>
    Public Function HelloWorld() As String

        Return "Hello World"
    End Function
    <WebMethod()>
    Public Function Listar_Personas() As List(Of ProyectoEntidades.Cls_Entidad_Persona)

        Dim objBusiness As ProyectoBusinessLogic.Cls_BusineesLogic = New Cls_BusineesLogic()

        Return objBusiness.Listar_Personas()

    End Function

    <WebMethod()>
    Public Function getPersonasById(prmId As Integer) As ProyectoEntidades.Cls_Entidad_Persona

        Dim objBusiness As ProyectoBusinessLogic.Cls_BusineesLogic = New Cls_BusineesLogic()

        Return objBusiness.getPersonasById(prmId)

    End Function

    <WebMethod()>
    Public Function Insertar_Personas(prmPersona As ProyectoEntidades.Cls_Entidad_Persona) As Boolean

        Dim objBusiness As ProyectoBusinessLogic.Cls_BusineesLogic = New Cls_BusineesLogic()

        Return objBusiness.Insert_Personas(prmPersona)

    End Function

    <WebMethod()>
    Public Function Update_Personas(prmPersona As ProyectoEntidades.Cls_Entidad_Persona) As Boolean

        Dim objBusiness As ProyectoBusinessLogic.Cls_BusineesLogic = New Cls_BusineesLogic()

        Return objBusiness.Update_Personas(prmPersona)

    End Function

    <WebMethod()>
    Public Function Delete_Personas(prmId As Integer) As Boolean

        Dim objBusiness As ProyectoBusinessLogic.Cls_BusineesLogic = New Cls_BusineesLogic()

        Return objBusiness.Delete_Personas(prmId)

    End Function

End Class