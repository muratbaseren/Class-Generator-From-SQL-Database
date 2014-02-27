#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.SqlClient
#End Region

#Region "Connection"

Public Class Connection

#Region "Local Variables"
    Private _connectionString As String
    Private _connection As SqlConnection
    Private _command As SqlCommand
#End Region

#Region "Properties"
    Public Property Connection() As SqlConnection
        Get
            Return Me._connection
        End Get
        Set(ByVal value As SqlConnection)
            Me._connection = value
        End Set
    End Property

    Public Property ConnectionString() As String
        Get
            Return Me._connectionString
        End Get
        Set(ByVal value As String)
            Me._connectionString = value
        End Set
    End Property

    Public Property Command() As SqlCommand
        Get
            Return Me._command
        End Get
        Set(ByVal value As SqlCommand)
            Me._command = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Function ConnectionOpen() As Integer
        Dim result As Integer
        If Connection.State = ConnectionState.Open <> True Then
            Connection.Open()
            result = Command.ExecuteNonQuery()
        End If
    End Function

    Public Sub ConnectionClose()
        If Connection.State = ConnectionState.Closed <> True Then
            Connection.Close()
        End If
    End Sub

    Public Sub New(ByVal ConnectionStr As String, ByVal CommandQuery As String)
        Me._connectionString = ConnectionStr
        Connection = New SqlConnection
        Connection.ConnectionString = ConnectionStr
        Command = New SqlCommand
        Command.Connection = Connection
        Command.CommandText = CommandQuery
    End Sub
#End Region

End Class

#End Region

