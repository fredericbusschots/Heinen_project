Imports Ghostscript.NET.Rasterizer
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode
Imports System.IO
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports System.Text.RegularExpressions

Public Module Decode_Qr

    ''' <summary>
    ''' decode le qr code contenu dans un pdf et retourn un dictionneaire contenant les différentes informations
    ''' </summary>
    ''' <param name="pdf_file">path du pdf à décoder</param>
    ''' <param name="dico">dictionnaire (par référence)</param>
    ''' <param name="contenu_qr">contenu du qr code (par référence)</param>
    ''' <returns></returns>
    Public Function Get_qr_info(pdf_file As String, dico As Dictionary(Of String, String), ByRef contenu_qr As String) As Boolean

        Dim dossier = "", client As String = ""

        'BOucle de décodage sur la résolution
        Dim resol As Integer = 100
        Dim result As Integer = 0
        While result <> 1 And resol < 500
            result = QR_decode_Img(pdf_file, contenu_qr, resol)
            resol = resol + 100
        End While
        If result = 2 Then
            Throw New LogException("Le QrCode n'est pas valide (pas du type heinen).")
        End If
        If result = 3 Then
            Throw New LogException("Le document ne contient pas de qr code ou n'a pas su être décodé.")
        End If


        'If QR_decode_Img(path_jpg, contenu_qr) = False Then
        '    ' génère une erreur :
        '    Throw New LogException("Le document ne contient pas de qr code ou n'a pas su être décodé.")
        'End If
        '' teste si le qr code est bien un QR code du type HEINEN (y compris V02)
        'If contenu_qr.Substring(0, 6) <> "{""PATH" And contenu_qr.Substring(0, 5) <> "{""V02" And contenu_qr.Substring(0, 5) <> "{""V03" And contenu_qr.Substring(0, 5) <> "{""V01" And contenu_qr.Substring(0, 5) <> "{""V04" Then
        '    ' génère une erreur :
        '    Throw New LogException("Le QrCode n'est pas valide (pas du type heinen).")
        'End If

        ' version initiale.
        If contenu_qr.Substring(0, 6) = "{""PATH" Then
            get_info_qr(contenu_qr, dico)
            get_info_path(dico("PATH"), client, dossier)
            dico.Add("CLIENT", client)
            'si le nom du dossier commence par HNX, alors on supprime les 3 premieres caractères
            If dossier.Substring(0, 3) = "HNX" Then
                dico.Add("DOSSIER", dossier.Substring(3))
            Else
                dico.Add("DOSSIER", dossier)
            End If
        End If
        'version V01
        If contenu_qr.Substring(0, 5) = "{""V01" Then
            get_info_qr_v1(contenu_qr, dico)
            If dico("DOSSIER").Substring(0, 3) = "HNX" Then
                dico("DOSSIER") = dico("DOSSIER").Substring(3)
            End If
        End If
        'version V02
        If contenu_qr.Substring(0, 5) = "{""V02" Then
            get_info_qr_v2(contenu_qr, dico)

            If dico("DOSSIER").Substring(0, 3) = "HNX" Then
                dico("DOSSIER") = dico("DOSSIER").Substring(3)
            End If
        End If
        'version V03
        If contenu_qr.Substring(0, 5) = "{""V03" Then
            get_info_qr_v3(contenu_qr, dico)

        End If
        'version V04
        If contenu_qr.Substring(0, 5) = "{""V04" Then
            get_info_qr_v4(contenu_qr, dico)

        End If
        'version V05
        If contenu_qr.Substring(0, 5) = "{""V05" Then
            get_info_qr_v4(contenu_qr, dico)

            dico("VERSION") = "V05"
            dico("NAME") = Path.GetFileName(pdf_file)

        End If
        Return True
    End Function

    ''' <summary>
    ''' retourne le string d'un QR code contenu dans une image
    ''' </summary>
    ''' <param name="path_Img">chemin d'accès de l'image </param>
    ''' <param name="contenu_qr">contenu du qr_code (par reference) </param>
    ''' <returns>
    ''' retourne true/false 
    ''' </returns>
    Private Function QR_decode_Img(pdf_file As String, ByRef contenu_qr As String, resol As Integer) As Integer

        Dim path_Img As String
        Dim Reader As New BarcodeReader
        Reader.AutoRotate = True
        Reader.Options.TryHarder = True

        path_Img = convert_pdf_img(pdf_file, resol)
        Dim image = New Bitmap(path_Img)

        Try
            'multiple car il peut y avoir plusieurs code barres/qr code sur une fiche
            Dim result As Result() = Reader.DecodeMultiple(image)
            For Each s_resul As Result In Result
                contenu_qr = s_resul.Text
                'FBS 8/12/16 , certains caractère bizarre (non imprimable = ASCII 0->31) apparaissent des fois, on les supprimes grâce à la ligne suivante
                For x = 0 To 31
                    While contenu_qr.Contains(Chr(x))
                        contenu_qr = contenu_qr.Replace(Chr(x), String.Empty)
                    End While
                Next x
                If contenu_qr.StartsWith("{""PATH") Or contenu_qr.StartsWith("{""V01") Or contenu_qr.StartsWith("{""V02") Or contenu_qr.StartsWith("{""V03") Or contenu_qr.StartsWith("{""V04") Or contenu_qr.StartsWith("{""V05") Then
                    Return 1
                End If
            Next
            'Throw New LogException("Le QrCode n'est pas valide (pas du type heinen).")
            Return 2
        Catch
            'Throw New LogException("Le document ne contient pas de qr code ou n'a pas su être décodé.")
            Return 3
        Finally
            ' libere le bitmap, car sinon probleme l'orque l'on charge deux pdf a la suite ( bitmap n'est pas libere et on ne sais pas sauver l'image a nouveau)
            image.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' converti un pdf en bmp
    ''' </summary>
    ''' <param name="file">
    ''' chemin d'accès du fichier pdf (string)
    ''' </param>
    ''' <returns>
    '''  convert_pdf_img : chamin d'accès du jpg en string
    ''' </returns>
    Private Function convert_pdf_img(file As String, resol As Integer) As String
        ' si le pdf est composé de plusieurs pages, on ne prend que la première page (probleme sinon).
        'Dim inputdoc As PdfDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import)
        'Dim outputdoc As PdfDocument = New PdfDocument
        'outputdoc.AddPage(inputdoc.Pages(0))
        'file = Path.Combine(My.Settings.pdf_temp, "pdf_temp.pdf")
        'outputdoc.Save(file)

        Dim rasterizer As GhostscriptRasterizer = New GhostscriptRasterizer
        Dim file_pdf As FileStream = New FileStream(file, FileMode.Open)
        Try

            ' si on utilise la methode rasterizer.Open directement sur un nom de fichier, il y a des problemes avec certains pdf 
            ' -->  Passage par un stream semble résoudre le probleme
            rasterizer.Open(file_pdf)
            Dim Image As Image
            Image = rasterizer.GetPage(resol, resol, 1)
            Image.Save(My.Settings.img_temp, Imaging.ImageFormat.Bmp)
            'libere le fichier
            rasterizer.Close()
        Catch
            Throw New LogException("Problème lors de l'ouverture du fichier pdf")
        Finally
            file_pdf.Close()

        End Try

        Return My.Settings.img_temp

    End Function

    ''' <summary>
    ''' lits les infos contenue dans un QR de type HEINEN et rempli un dictionnaire
    ''' </summary>
    ''' <param name="qr">contenu du gr code (string)</param>
    ''' <param name="dic_qr">dictionnaire a remplir (par référence)</param>
    ''' <returns>
    ''' get_info_qr : boolean , non implémenté (toujours true)
    ''' </returns>
    Private Function get_info_qr(qr As String, dic_qr As Dictionary(Of String, String)) As Boolean
        'decode les inforamtions issues du string contenue dans le QR
        Dim tab() As String
        qr = qr.Trim() 'enleve les blancs
        qr = qr.TrimEnd("}").TrimStart("{")
        tab = qr.Split(",")
        For Each line As String In tab
            Dim tab2() As String
            tab2 = line.Split(":")
            dic_qr.Add(tab2(0).Trim().Trim("""").Trim(), tab2(1).Trim().Trim("""").Trim())
        Next
        dic_qr.Add("VERSION", "PATH")
        Return True
    End Function

    ''' <summary>
    ''' lits les infos contenue dans un QR de type HEINEN V02 et rempli un dictionnaire
    ''' </summary>
    ''' <param name="qr">contenu du gr code (string)</param>
    ''' <param name="dic_qr">dictionnaire a remplir (par référence)</param>
    ''' <returns>
    ''' get_info_qr : boolean , non implémenté (toujours true)
    ''' </returns>
    Private Function get_info_qr_v1(qr As String, dic_qr As Dictionary(Of String, String)) As Boolean
        'decode les inforamtions issues du string contenue dans le QR
        Dim tab() As String
        qr = qr.Trim() 'enleve les blancs
        qr = qr.TrimEnd("}").TrimStart("{")
        tab = qr.Split(",")

        dic_qr.Add("CLIENT", tab(1).Trim().Trim("""").Trim())
        dic_qr.Add("PATH", "null")
        dic_qr.Add("DOSSIER", tab(2).Trim().Trim("""").Trim())
        dic_qr.Add("CAT", tab(3).Trim().Trim("""").Trim())
        dic_qr.Add("NAME", tab(4).Trim().Trim("""").Trim())
        dic_qr.Add("TITRE", tab(5).Trim().Trim("""").Trim())
        dic_qr.Add("DATE", "null")
        dic_qr.Add("VERSION", "V01")

        If dic_qr("CAT") = "" Then
            ' génère une erreur :
            Throw New LogException("Un qr code type V01 doit contenir une catégorie !.")
        End If

        Return True
    End Function

    ''' <summary>
    ''' lits les infos contenue dans un QR de type HEINEN V02 et rempli un dictionnaire
    ''' </summary>
    ''' <param name="qr">contenu du gr code (string)</param>
    ''' <param name="dic_qr">dictionnaire a remplir (par référence)</param>
    ''' <returns>
    ''' get_info_qr : boolean , non implémenté (toujours true)
    ''' </returns>
    Private Function get_info_qr_v2(qr As String, dic_qr As Dictionary(Of String, String)) As Boolean
        'decode les inforamtions issues du string contenue dans le QR
        Dim tab() As String
        qr = qr.Trim() 'enleve les blancs
        qr = qr.TrimEnd("}").TrimStart("{")
        tab = qr.Split(",")

        dic_qr.Add("CLIENT", tab(1).Trim().Trim("""").Trim())
        dic_qr.Add("PATH", tab(3).Trim().Trim("""").Trim())
        dic_qr.Add("DOSSIER", tab(2).Trim().Trim("""").Trim())
        dic_qr.Add("CAT", tab(4).Trim().Trim("""").Trim())
        dic_qr.Add("NAME", tab(5).Trim().Trim("""").Trim())
        dic_qr.Add("TITRE", tab(6).Trim().Trim("""").Trim())
        dic_qr.Add("DATE", "null")
        dic_qr.Add("VERSION", "V02")
        Return True
    End Function

    ''' <summary>
    ''' lits les infos contenue dans un QR de type HEINEN V03 et rempli un dictionnaire
    ''' </summary>
    ''' <param name="qr">contenu du gr code (string)</param>
    ''' <param name="dic_qr">dictionnaire a remplir (par référence)</param>
    ''' <returns>
    ''' get_info_qr : boolean , non implémenté (toujours true)
    ''' </returns>
    Private Function get_info_qr_v3(qr As String, dic_qr As Dictionary(Of String, String)) As Boolean
        'decode les inforamtions issues du string contenue dans le QR
        Dim tab() As String
        qr = qr.Trim() 'enleve les blancs
        qr = qr.TrimEnd("}").TrimStart("{")
        tab = qr.Split(",")

        dic_qr.Add("CLIENT", "")
        dic_qr.Add("PATH", tab(1).Trim().Trim("""").Trim())
        dic_qr.Add("DOSSIER", "")
        dic_qr.Add("CAT", tab(4).Trim().Trim("""").Trim())
        dic_qr.Add("NAME", tab(2).Trim().Trim("""").Trim())
        dic_qr.Add("TITRE", tab(3).Trim().Trim("""").Trim())
        dic_qr.Add("DATE", "null")
        dic_qr.Add("VERSION", "V03")
        Return True
    End Function

    Private Function get_info_qr_v4(qr As String, dic_qr As Dictionary(Of String, String)) As Boolean
        'decode les inforamtions issues du string contenue dans le QR
        Dim tab() As String
        qr = qr.Trim() 'enleve les blancs
        qr = qr.TrimEnd("}").TrimStart("{")
        tab = qr.Split(",")

        If tab.Length < 7 Then
            ' génère une erreur :
            Throw New LogException("Le qr code n'est pas complet (manque d'information) ! :[" + qr + "]")
        End If

        dic_qr.Add("CLIENT", "")
        dic_qr.Add("PATH", tab(3).Trim().Trim("""").Trim())
        dic_qr.Add("DOSSIER", tab(1).Trim().Trim("""").Trim()) 'SITE
        dic_qr.Add("CAT", tab(4).Trim().Trim("""").Trim())
        dic_qr.Add("NAME", tab(5).Trim().Trim("""").Trim())
        dic_qr.Add("TITRE", tab(6).Trim().Trim("""").Trim())
        dic_qr.Add("DATE", "null")
        dic_qr.Add("VERSION", "V04")
        Return True
    End Function

    ''' <summary>
    ''' recupere les infos clients et dossier du PATH
    ''' </summary>
    ''' <param name="path">nom du dissier (par reference)</param>
    ''' <param name="client">nom du client (par référence)</param>
    ''' <param name="dossier">path à décoder</param>
    ''' <returns></returns>
    Private Function get_info_path(path As String, ByRef client As String, ByRef dossier As String) As Boolean
        Dim tab() As String
        tab = path.Split("/")
        client = tab(3)
        dossier = tab(4)
        Return True
    End Function

End Module
