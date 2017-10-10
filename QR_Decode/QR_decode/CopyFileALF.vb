Imports System.Text

Public Class CopyFileALF

    'retoune le path d'un dossier/offre 
    Public Function getpath(dossier As String) As String
        Dim ALF As New CMIS(My.Settings.cmis_connection, My.Settings.cmis_user, My.Settings.cmis_pwd)
        Dim path As String
        path = ALF.ALF_Check_Path_repertoire2(dossier)
        Try
            path = convert_unicode(path)
        Catch
            Throw New LogException("Erreur dans la conversion unicode du path :[" + path + "]")
        End Try
        Return path
    End Function

    'vérifie si un path existe dans alfresco
    Public Function checkpath(dossier As String) As Boolean
        Dim ALF As New CMIS(My.Settings.cmis_connection, My.Settings.cmis_user, My.Settings.cmis_pwd)
        Dim path As Boolean
        path = ALF.ALF_Check_Path_repertoire(dossier)
        Return path
    End Function

    Public Function copy_file(file As String, Path As String, dico As Dictionary(Of String, String)) As String
        Dim sub_path As String = ""
        Dim message = ""
        Dim cmis_type = ""
        Dim param_sup As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        'lit le fichier xml pour avoir le sub_path et le cmis_type
        Dim ds As DataSet = New DataSet
        ds.ReadXml(My.Settings.xml_file)

        Dim dr() As DataRow = ds.Tables("CAT").Select("Catégorie LIKE '" & dico("CAT") & "'")

        If dr.Length >= 1 Then
            sub_path = dr(0)("Emplacement")
            cmis_type = dr(0)("cmis_type")
        Else
            sub_path = ""
            cmis_type = "cmis:document"
        End If

        ' paremètres secondaires supplémentaires

        'proprietes secondaire titre (tout le temps)

        param_sup.Add("cm:title", dico("TITRE"))

        'autres proprietes secondaires (dependantes du type de document)

        Select Case dico("CAT")
            Case "Fiche Suiveuse"
                param_sup.Add("hne:clientName", dico("CLIENT"))
                param_sup.Add("hne:nomRepertoireProjet", dico("DOSSIER"))

            Case "Bon de livraison"
                param_sup.Add("hne:clientName", dico("CLIENT"))
                param_sup.Add("hne:nomRepertoireProjet", dico("DOSSIER"))

            Case "Facture"
                param_sup.Add("hne:clientName", dico("CLIENT"))
                param_sup.Add("hne:nomRepertoireProjet", dico("DOSSIER"))

        End Select

        'si version V02 pour le QR code, on prend en compte la path (prevaut à la categorie)
        If dico("VERSION") = "V02" Then
            sub_path = (dico("PATH"))
        End If

        Path = Path + sub_path

        'si version V03 pour le QR code, ne prend en compte que le path
        If dico("VERSION") = "V03" Then
            Path = (dico("PATH"))
        End If

        'si version V04 pour le QR code, ne prend en compte que le path
        If dico("VERSION") = "V04" Then
            Path = "/Sites/" + dico("DOSSIER") + "/documentLibrary" + dico("PATH")
        End If

        'si version V05 pour le QR code, ne prend en compte que le path
        If dico("VERSION") = "V05" Then
            Path = "/Sites/" + dico("DOSSIER") + "/documentLibrary/Clients" + dico("PATH")
        End If

        Dim ALF As New CMIS(My.Settings.cmis_connection, My.Settings.cmis_user, My.Settings.cmis_pwd)
        ' check si le path existe
        ALF.ALF_Check_Path_repertoire(Path)
        ' upload le fichier
        'check si l'extension pdf existe
        'If Not dico("NAME").Substring(dico("NAME").Length - 4) = ".pdf" Then
        If Not dico("NAME").ToLower.EndsWith(".pdf") Then
            dico("NAME") = dico("NAME") + ".pdf"
        End If
        ALF.upload_file_pdf(file, dico("NAME"), param_sup, Path, cmis_type, message)
        Return message
    End Function

    Public Function convert_unicode(str_in As String) As String
        'str_in.Substring()
        Dim index As Integer = str_in.IndexOf("\u")
        While index <> -1
            ' chope les 4 caractères hexa
            Dim hexa As String = str_in.Substring(index + 2, 4)
            Dim dec As Integer = Convert.ToInt32(hexa, 16)
            str_in = str_in.Replace("\u" + hexa, ChrW(dec))
            index = str_in.IndexOf("\u")
        End While
        Return str_in
    End Function
End Class
