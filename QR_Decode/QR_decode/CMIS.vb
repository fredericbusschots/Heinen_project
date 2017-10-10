Option Explicit On


Imports PortCMIS
Imports PortCMIS.Client
Imports PortCMIS.Client.Impl
Imports PortCMIS.Data
Imports System.IO
Imports System.Numerics
Imports System.Web
Imports System.Text

'Imports DotCMIS
'Imports DotCMIS.Client
'Imports DotCMIS.Client.Impl
'Imports DotCMIS.Data.Impl

Public Class CMIS

    Private connection, user, pwd As String

    Dim factory As SessionFactory
    Dim session_base As ISession
    Dim parameters As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim list_node As New Dictionary(Of String, Array)
    Dim Info_node(20) As String

#Region "connexion Alfresco"
    Sub New(connection As String, user As String, pwd As String)
        Me.connection = connection
        Me.user = user
        Me.pwd = pwd
    End Sub

    ' attention , avec PortCMIS, version 1.1 de atom car on a besoin d'avoir accès aux sous prorpiétés.
    Public Sub Connexion_Alfresco_Paramettre()
        parameters(SessionParameter.BindingType) = BindingType.AtomPub
        parameters(SessionParameter.AtomPubUrl) = connection
        'parameters(SessionParameter.AtomPubUrl) = "http://ged2:8080/alfresco/api/-default-/public/cmis/versions/1.1/atom"
        parameters(SessionParameter.User) = user
        parameters(SessionParameter.Password) = pwd
    End Sub

    Private Sub Connexion_to_Alfresco()
        Connexion_Alfresco_Paramettre()
        factory = SessionFactory.NewInstance()
        session_base = factory.GetRepositories(parameters)(0).CreateSession()
    End Sub

#End Region

    'teste si un repertoire existe dans alfresco
    Public Function ALF_Check_Path_repertoire(dossier As String) As Boolean

        Dim path As String = ""
        Dim folder As Folder
        Connexion_to_Alfresco()
        Try
            folder = session_base.GetObjectByPath(dossier)
            Return True
        Catch
            Throw New LogException("Le répertoire :[ " + dossier + "] N'existe pas dans Alfresco")
        End Try
    End Function

    ' **** Test UN le répertoire est dans ALfresco 
    ' **** retourne le 1er PATH du répertoire s'il existe autrement ""
    ' version 2 : valable avec nomdossier+tire (ex = AA001D_titre)
    Public Function ALF_Check_Path_repertoire2(dossier As String) As String
        Dim query As String
        Dim results As IItemEnumerable(Of IQueryResult)
        'Dim objectId As String
        Dim path As String = ""
        Dim name As String = ""

        Connexion_to_Alfresco()
        query = "SELECT * from cmis:folder where cmis:name LIKE '" & dossier & "%'"
        results = session_base.Query(query, False)
        If results.TotalNumItems <= 0 Then
            ' test s'il n'existe pas avec juste le nom de projet/offre
            'query = "SELECT * from cmis:folder where cmis:name LIKE '" & dossier & "'"
            'results = session_base.Query(query, False)
            'If results.TotalNumItems <= 0 Then
            Throw New LogException("Le dossier : [" + dossier + "] N'existe pas dans Alfresco")
            'End If
        End If

        If results.TotalNumItems > 1 Then
            ' il faut chercher le bon dans la liste
            For Each qResult In results
                name = qResult.GetPropertyValueByQueryName("cmis:name")
                If name.Split("_")(0) = dossier Then
                    path = qResult.GetPropertyValueByQueryName("cmis:path")
                    Return path
                End If
            Next
            'le dossier n'a pas ete trouve
            Throw New LogException("Le dossier : [" + dossier + "] est ambigu dans Alfresco")
        Else
            'objectId = results(0).GetPropertyValueByQueryName("cmis:path")
            'Debug.Print(objectId)
            path = results(0).GetPropertyValueByQueryName("cmis:path")
            Return path.ToString()
        End If
    End Function


    'upload file
    Public Function upload_file_pdf(file_path As String, cmis_name As String, param_sup As Dictionary(Of String, Object), alf_path As String, cmis_type As String, ByRef message As String) As Boolean
        Connexion_to_Alfresco()
        Dim folder As IFolder
        Dim contentstream As ContentStream = New ContentStream
        Dim docu As Document

        Dim bytes As Byte() = System.IO.File.ReadAllBytes(file_path)
        Dim stream As Stream = New MemoryStream(bytes)

        Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        param.Add(PropertyIds.ObjectTypeId, cmis_type)
        param.Add(PropertyIds.Name, cmis_name)

        contentstream.FileName = cmis_name
        contentstream.MimeType = "application/pdf"
        contentstream.Length = stream.Length
        contentstream.Stream = stream

        ' test si l'objet existe
        Try
            docu = session_base.GetObjectByPath(alf_path & "/" & cmis_name)
        Catch
            ' le fichier n'existe pas, il faut le créer
            folder = session_base.GetObjectByPath(alf_path)
            docu = folder.CreateDocument(param, contentstream, versioningState:=2)

            'ajoute les propriétés client et projet (propriétés secondaires)
            If (param_sup.Count >= 1) Then
                docu.UpdateProperties(param_sup)
            End If

            message = "[" + alf_path & "/" & cmis_name + "] correctement crée"
            Return True
            'contentstream.FileName
        End Try
        ' le fichier existe : mise à jour
        'FBS 4/11/2016 ... si la mise a jour se fait avec la dll DOTCMIS, probleme au niveau du MIMETYPE.
        'on passe dans une autre classe qui fait référence à l'ancienne DLL PORTCMIS qui fonctionne

        Dim cmis_new As cmis_updt_mime = New cmis_updt_mime(My.Settings.cmis_conn_10, My.Settings.cmis_user, My.Settings.cmis_pwd)
        cmis_new.updat_mimetype(alf_path & "/" & cmis_name, file_path, cmis_name)

        message = "[" + alf_path & "/" & cmis_name + "] correctement mis à jour"

        Return True
    End Function
End Class
