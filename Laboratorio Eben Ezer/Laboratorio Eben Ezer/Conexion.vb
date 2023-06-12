Imports System.Data.SqlClient
Public Class Conexion
    'Dim DataSource As String = "DESKTOP-DPEQ09E\LEE"
    Dim DataSource As String = "VIERNES\VIERNES"
    Public servidor As String = "Data Source=DESKTOP-UND6B3R\SQLEXPRESS;Initial Catalog=LabEbenEzer;Integrated Security=True"
    Public cnn As New SqlConnection(servidor)
    Dim keychar As String
    Public Sub conectar()
        Try
            If cnn.State = Data.ConnectionState.Closed Then
                cnn.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar a BD" & vbCrLf & ex.Message)
        End Try
    End Sub
    Public Sub desconectar()
        Try
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function reader(ByVal cons As String) As SqlDataReader
        Dim dr As SqlDataReader
        Try
            conectar()
            Dim cmdImstrucciom As New SqlCommand(cons, cnn)
            dr = cmdImstrucciom.ExecuteReader
        Catch ex As Exception
            dr = Nothing
            MsgBox(ex.Message)
        Finally

        End Try
        Return dr
    End Function
    Public Sub insertar(ByVal query As String)
        Dim comando As New SqlCommand(query, cnn)
        Try
            conectar()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            desconectar()

        End Try
    End Sub
    Public Function val(ByVal query As String) As Boolean
        Dim cmd As New SqlCommand
        Try
            conectar()
            cmd = New SqlCommand(query, cnn)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class


