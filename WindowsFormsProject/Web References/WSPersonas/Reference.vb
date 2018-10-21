﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace WSPersonas
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WebServicePersonasSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class WebServicePersonas
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private HelloWorldOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Listar_PersonasOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getPersonasByIdOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Insertar_PersonasOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Update_PersonasOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Delete_PersonasOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WindowsFormsProject.My.MySettings.Default.WindowsFormsProject_WSPersonas_WebServicePersonas
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event HelloWorldCompleted As HelloWorldCompletedEventHandler
        
        '''<remarks/>
        Public Event Listar_PersonasCompleted As Listar_PersonasCompletedEventHandler
        
        '''<remarks/>
        Public Event getPersonasByIdCompleted As getPersonasByIdCompletedEventHandler
        
        '''<remarks/>
        Public Event Insertar_PersonasCompleted As Insertar_PersonasCompletedEventHandler
        
        '''<remarks/>
        Public Event Update_PersonasCompleted As Update_PersonasCompletedEventHandler
        
        '''<remarks/>
        Public Event Delete_PersonasCompleted As Delete_PersonasCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function HelloWorld() As String
            Dim results() As Object = Me.Invoke("HelloWorld", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub HelloWorldAsync()
            Me.HelloWorldAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub HelloWorldAsync(ByVal userState As Object)
            If (Me.HelloWorldOperationCompleted Is Nothing) Then
                Me.HelloWorldOperationCompleted = AddressOf Me.OnHelloWorldOperationCompleted
            End If
            Me.InvokeAsync("HelloWorld", New Object(-1) {}, Me.HelloWorldOperationCompleted, userState)
        End Sub
        
        Private Sub OnHelloWorldOperationCompleted(ByVal arg As Object)
            If (Not (Me.HelloWorldCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HelloWorldCompleted(Me, New HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar_Personas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Listar_Personas() As Cls_Entidad_Persona()
            Dim results() As Object = Me.Invoke("Listar_Personas", New Object(-1) {})
            Return CType(results(0),Cls_Entidad_Persona())
        End Function
        
        '''<remarks/>
        Public Overloads Sub Listar_PersonasAsync()
            Me.Listar_PersonasAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Listar_PersonasAsync(ByVal userState As Object)
            If (Me.Listar_PersonasOperationCompleted Is Nothing) Then
                Me.Listar_PersonasOperationCompleted = AddressOf Me.OnListar_PersonasOperationCompleted
            End If
            Me.InvokeAsync("Listar_Personas", New Object(-1) {}, Me.Listar_PersonasOperationCompleted, userState)
        End Sub
        
        Private Sub OnListar_PersonasOperationCompleted(ByVal arg As Object)
            If (Not (Me.Listar_PersonasCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Listar_PersonasCompleted(Me, New Listar_PersonasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getPersonasById", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getPersonasById(ByVal prmId As Integer) As Cls_Entidad_Persona
            Dim results() As Object = Me.Invoke("getPersonasById", New Object() {prmId})
            Return CType(results(0),Cls_Entidad_Persona)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getPersonasByIdAsync(ByVal prmId As Integer)
            Me.getPersonasByIdAsync(prmId, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getPersonasByIdAsync(ByVal prmId As Integer, ByVal userState As Object)
            If (Me.getPersonasByIdOperationCompleted Is Nothing) Then
                Me.getPersonasByIdOperationCompleted = AddressOf Me.OngetPersonasByIdOperationCompleted
            End If
            Me.InvokeAsync("getPersonasById", New Object() {prmId}, Me.getPersonasByIdOperationCompleted, userState)
        End Sub
        
        Private Sub OngetPersonasByIdOperationCompleted(ByVal arg As Object)
            If (Not (Me.getPersonasByIdCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getPersonasByIdCompleted(Me, New getPersonasByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insertar_Personas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Insertar_Personas(ByVal prmPersona As Cls_Entidad_Persona) As Boolean
            Dim results() As Object = Me.Invoke("Insertar_Personas", New Object() {prmPersona})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Insertar_PersonasAsync(ByVal prmPersona As Cls_Entidad_Persona)
            Me.Insertar_PersonasAsync(prmPersona, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Insertar_PersonasAsync(ByVal prmPersona As Cls_Entidad_Persona, ByVal userState As Object)
            If (Me.Insertar_PersonasOperationCompleted Is Nothing) Then
                Me.Insertar_PersonasOperationCompleted = AddressOf Me.OnInsertar_PersonasOperationCompleted
            End If
            Me.InvokeAsync("Insertar_Personas", New Object() {prmPersona}, Me.Insertar_PersonasOperationCompleted, userState)
        End Sub
        
        Private Sub OnInsertar_PersonasOperationCompleted(ByVal arg As Object)
            If (Not (Me.Insertar_PersonasCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Insertar_PersonasCompleted(Me, New Insertar_PersonasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Update_Personas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Update_Personas(ByVal prmPersona As Cls_Entidad_Persona) As Boolean
            Dim results() As Object = Me.Invoke("Update_Personas", New Object() {prmPersona})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Update_PersonasAsync(ByVal prmPersona As Cls_Entidad_Persona)
            Me.Update_PersonasAsync(prmPersona, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Update_PersonasAsync(ByVal prmPersona As Cls_Entidad_Persona, ByVal userState As Object)
            If (Me.Update_PersonasOperationCompleted Is Nothing) Then
                Me.Update_PersonasOperationCompleted = AddressOf Me.OnUpdate_PersonasOperationCompleted
            End If
            Me.InvokeAsync("Update_Personas", New Object() {prmPersona}, Me.Update_PersonasOperationCompleted, userState)
        End Sub
        
        Private Sub OnUpdate_PersonasOperationCompleted(ByVal arg As Object)
            If (Not (Me.Update_PersonasCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Update_PersonasCompleted(Me, New Update_PersonasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Delete_Personas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Delete_Personas(ByVal prmId As Integer) As Boolean
            Dim results() As Object = Me.Invoke("Delete_Personas", New Object() {prmId})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Delete_PersonasAsync(ByVal prmId As Integer)
            Me.Delete_PersonasAsync(prmId, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Delete_PersonasAsync(ByVal prmId As Integer, ByVal userState As Object)
            If (Me.Delete_PersonasOperationCompleted Is Nothing) Then
                Me.Delete_PersonasOperationCompleted = AddressOf Me.OnDelete_PersonasOperationCompleted
            End If
            Me.InvokeAsync("Delete_Personas", New Object() {prmId}, Me.Delete_PersonasOperationCompleted, userState)
        End Sub
        
        Private Sub OnDelete_PersonasOperationCompleted(ByVal arg As Object)
            If (Not (Me.Delete_PersonasCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Delete_PersonasCompleted(Me, New Delete_PersonasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Cls_Entidad_Persona
        
        Private idField As Integer
        
        Private nombre_completoField As String
        
        Private fecha_nacimientoField As Date
        
        Private edadField As Short
        
        Private sexoField As String
        
        '''<remarks/>
        Public Property id() As Integer
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property nombre_completo() As String
            Get
                Return Me.nombre_completoField
            End Get
            Set
                Me.nombre_completoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property fecha_nacimiento() As Date
            Get
                Return Me.fecha_nacimientoField
            End Get
            Set
                Me.fecha_nacimientoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property edad() As Short
            Get
                Return Me.edadField
            End Get
            Set
                Me.edadField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property sexo() As String
            Get
                Return Me.sexoField
            End Get
            Set
                Me.sexoField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub HelloWorldCompletedEventHandler(ByVal sender As Object, ByVal e As HelloWorldCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class HelloWorldCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub Listar_PersonasCompletedEventHandler(ByVal sender As Object, ByVal e As Listar_PersonasCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Listar_PersonasCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Cls_Entidad_Persona()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Cls_Entidad_Persona())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub getPersonasByIdCompletedEventHandler(ByVal sender As Object, ByVal e As getPersonasByIdCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getPersonasByIdCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Cls_Entidad_Persona
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Cls_Entidad_Persona)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub Insertar_PersonasCompletedEventHandler(ByVal sender As Object, ByVal e As Insertar_PersonasCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Insertar_PersonasCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub Update_PersonasCompletedEventHandler(ByVal sender As Object, ByVal e As Update_PersonasCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Update_PersonasCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub Delete_PersonasCompletedEventHandler(ByVal sender As Object, ByVal e As Delete_PersonasCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Delete_PersonasCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
End Namespace