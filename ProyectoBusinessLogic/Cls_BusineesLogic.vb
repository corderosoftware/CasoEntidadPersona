Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Cls_BusineesLogic

    Private cmd As SqlCommand
    Private rdr As SqlDataReader

    Public Function Listar_Personas() As List(Of ProyectoEntidades.Cls_Entidad_Persona)

        Dim resultado As List(Of ProyectoEntidades.Cls_Entidad_Persona) = Nothing
        Dim queryString As String
        Dim Msgerror As String

        Using connection As SqlConnection = New SqlConnection(connectionString())

            queryString = "SELECT id,nombre_completo,fecha_nacimiento,edad,sexo FROM personas WHERE Estatus = 'A'"
            cmd = New SqlCommand(queryString, connection)

            Try

                connection.Open()
                rdr = cmd.ExecuteReader()

                If rdr.HasRows Then

                    resultado = New List(Of ProyectoEntidades.Cls_Entidad_Persona)

                    While rdr.Read()

                        resultado.Add(New ProyectoEntidades.Cls_Entidad_Persona() With {
                            .id = Convert.ToInt32(rdr("id")),
                            .nombre_completo = rdr("nombre_completo"),
                            .fecha_nacimiento = rdr("fecha_nacimiento"),
                            .edad = rdr("edad"),
                            .sexo = rdr("sexo")
                        })

                    End While

                End If

            Catch ex As Exception
                Msgerror = ex.Message
            End Try

        End Using

        Return resultado

    End Function
    Public Function getPersonasById(prmId As Integer) As ProyectoEntidades.Cls_Entidad_Persona

        Dim resultado As ProyectoEntidades.Cls_Entidad_Persona = Nothing
        Dim queryString As String
        Dim Msgerror As String

        Using connection As SqlConnection = New SqlConnection(connectionString())

            queryString = "SELECT id,nombre_completo,fecha_nacimiento,edad,sexo FROM personas WHERE id = @prmId"
            cmd = New SqlCommand(queryString, connection)
            cmd.Parameters.Add("@prmid", System.Data.SqlDbType.BigInt).Value = prmId

            Try

                connection.Open()
                rdr = cmd.ExecuteReader()

                If rdr.HasRows Then

                    resultado = New ProyectoEntidades.Cls_Entidad_Persona()

                    While rdr.Read()

                        With resultado
                            .id = Convert.ToInt32(rdr("id"))
                            .nombre_completo = rdr("nombre_completo")
                            .fecha_nacimiento = rdr("fecha_nacimiento")
                            .edad = rdr("edad")
                            .sexo = rdr("sexo")
                        End With

                    End While

                End If

            Catch ex As Exception
                Msgerror = ex.Message
            End Try

        End Using

        Return resultado

    End Function

    Public Function Insert_Personas(prmDatos As ProyectoEntidades.Cls_Entidad_Persona) As Boolean

        Dim resultado As Boolean = True
        Dim queryString As String
        Dim Msgerror As String

        Using connection As SqlConnection = New SqlConnection(connectionString())

            queryString = "INSERT INTO personas (nombre_completo,fecha_nacimiento,edad,sexo) " _
                         & "VALUES(@nombre_completo,@fecha_nacimiento,@edad,@sexo)"
            cmd = New SqlCommand(queryString, connection)
            cmd.Parameters.Add("@nombre_completo", System.Data.SqlDbType.VarChar).Value = prmDatos.nombre_completo
            cmd.Parameters.Add("@fecha_nacimiento", System.Data.SqlDbType.DateTime).Value = prmDatos.fecha_nacimiento.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            cmd.Parameters.Add("@edad", System.Data.SqlDbType.SmallInt).Value = prmDatos.edad
            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar).Value = prmDatos.sexo

            Try

                connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Msgerror = ex.Message
                resultado = False
            End Try

        End Using

        Return resultado

    End Function

    Public Function Update_Personas(prmDatos As ProyectoEntidades.Cls_Entidad_Persona) As Boolean

        Dim resultado As Boolean = True
        Dim queryString As String
        Dim Msgerror As String

        Using connection As SqlConnection = New SqlConnection(connectionString())

            queryString = "UPDATE personas SET nombre_completo=@nombre_completo,fecha_nacimiento=@fecha_nacimiento,edad=@edad,sexo = @sexo WHERE id = @prmId"
            cmd = New SqlCommand(queryString, connection)
            cmd.Parameters.Add("@prmid", System.Data.SqlDbType.BigInt).Value = prmDatos.id
            cmd.Parameters.Add("@nombre_completo", System.Data.SqlDbType.VarChar).Value = prmDatos.nombre_completo
            cmd.Parameters.Add("@fecha_nacimiento", System.Data.SqlDbType.DateTime).Value = prmDatos.fecha_nacimiento.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            cmd.Parameters.Add("@edad", System.Data.SqlDbType.SmallInt).Value = prmDatos.edad
            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar).Value = prmDatos.sexo

            Try

                connection.Open()
                cmd.ExecuteNonQuery()



            Catch ex As Exception
                Msgerror = ex.Message
                resultado = False
            End Try

        End Using

        Return resultado

    End Function

    Public Function Delete_Personas(prmIdDel As Integer) As Boolean

        Dim resultado As Boolean = True
        Dim queryString As String
        Dim Msgerror As String

        Using connection As SqlConnection = New SqlConnection(connectionString())

            queryString = "UPDATE personas SET estatus = 'E' WHERE id = @prmId"
            cmd = New SqlCommand(queryString, connection)
            cmd.Parameters.Add("@prmid", System.Data.SqlDbType.BigInt).Value = prmIdDel

            Try

                connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Msgerror = ex.Message
                resultado = False
            End Try

        End Using

        Return resultado

    End Function

    Private Function connectionString() As String

        'La cadena de conexión se coloco aqui por motivos de demostración
        'Pero la recomendación es colocarla en un recurso externo
        Return "Data Source=(local);Initial Catalog=ProyectoPersonas;Integrated Security=true;"
    End Function

End Class
