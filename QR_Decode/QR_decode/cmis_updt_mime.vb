Imports DotCMIS
Imports DotCMIS.Client
Imports DotCMIS.Client.Impl
Imports DotCMIS.Data.Impl
Imports System.IO

Public Class cmis_updt_mime

    Private connection, user, pwd As String

    Dim factory As SessionFactory
    Dim session_base As ISession
    Dim parameters As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim list_node As New Dictionary(Of String, Array)
    Dim Info_node(20) As String

    Sub New(connection As String, user As String, pwd As String)
        Me.connection = connection
        Me.user = user
        Me.pwd = pwd
    End Sub

    Public Sub Connexion_Alfresco_Paramettre()
        parameters(SessionParameter.BindingType) = BindingType.AtomPub
        parameters(SessionParameter.AtomPubUrl) = connection
        'parameters(SessionParameter.AtomPubUrl) = "http://ged2:8080/alfresco/api/-default-/public/cmis/versions/1.0/atom"
        parameters(SessionParameter.User) = user
        parameters(SessionParameter.Password) = pwd
    End Sub

    Private Sub Connexion_to_Alfresco()
        Connexion_Alfresco_Paramettre()
        factory = SessionFactory.NewInstance()
        session_base = factory.GetRepositories(parameters)(0).CreateSession()
    End Sub

    Public Function updat_mimetype(file_alf As String, path_pdf As String, cmis_name As String) As Boolean
        Connexion_to_Alfresco()
        Dim docu As Document
        Dim contentstream As ContentStream = New ContentStream

        Dim bytes As Byte() = System.IO.File.ReadAllBytes(path_pdf)
        Dim stream As Stream = New MemoryStream(bytes)

        contentstream.FileName = cmis_name
        contentstream.MimeType = "application/pdf"
        contentstream.Length = stream.Length
        contentstream.Stream = stream

        docu = session_base.GetObjectByPath(file_alf)
        docu.SetContentStream(contentstream, True)

        Return True
    End Function

End Class
