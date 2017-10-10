Imports System.IO

Public Module LogFile
    Private sw As StreamWriter

    Sub write(log_file As String, message_type As String, filename As String, message As String)
        sw = New StreamWriter(log_file, True)
        sw.WriteLine(Date.Now + ";" + message_type + ";" + filename + ";" + message)
        sw.Close()
    End Sub

    Sub move_file_error(fileName As String)
        ' deplace fichier dans le path erreur
        If Not Directory.Exists(My.Settings.pdf_error) Then
            Directory.CreateDirectory(My.Settings.pdf_error)
        End If
        File.Move(fileName, Make_file_unique(Path.Combine(My.Settings.pdf_error, Path.GetFileName(fileName))))
    End Sub

    Sub move_file_ok(fileName As String)
        ' deplace fichier dans le path erreur
        If Not Directory.Exists(My.Settings.pdf_ok) Then
            Directory.CreateDirectory(My.Settings.pdf_ok)
        End If
        Dim new_file_name = Make_file_unique(Path.Combine(My.Settings.pdf_ok, Path.GetFileName(fileName)))
        File.Move(fileName, new_file_name)
    End Sub

    Function Make_file_unique(filename As String)
        Dim tab_files As String()
        tab_files = Directory.GetFiles(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename) & "*")
        If tab_files.Length <= 0 Then
            Return filename
        Else
            Dim spath As String = Path.GetDirectoryName(filename)
            Dim sfile As String = Path.GetFileNameWithoutExtension(filename)
            Dim sext As String = Path.GetExtension(filename)
            Dim newname As String = spath + "\" + sfile + "(" + (tab_files.Length + 1).ToString + ")" + sext
            Return newname
        End If
    End Function

    Sub write_txtbx(txtbox As TextBox, file As String, message As String)

        Dim new_line = Date.Now + " : " + file + " : " + message

        'crée un tableau avec le contenu du txt box
        Dim tab() As String
        tab = txtbox.Text.Split(vbCrLf)
        Dim list As List(Of String) = tab.ToList
        list.Insert(0, new_line)

        Dim new_txt As String = ""
        For i As Integer = 0 To Math.Min(9, list.Count - 1)
            If i = 0 Then
                new_txt = list(i)
            Else
                new_txt = new_txt + vbCrLf + list(i)
            End If
        Next
        txtbox.Text = new_txt

    End Sub

    Sub send_email(file_path As String, message As String, debug As Boolean)
        ' vide le dossier pdf_temp
        Dim tmp_files() = Directory.GetFiles(My.Settings.pdf_temp)
        For Each tmp_file As String In tmp_files
            File.Delete(tmp_file)
        Next

        ' copie le fichier afin qu'il soit encore accessible durant la phase d'envoi du message
        Dim new_file = Path.Combine(My.Settings.pdf_temp, Path.GetFileName(file_path))
        File.Copy(file_path, new_file)

        Dim email As String
        ' test le nom du fichier

        If (Path.GetFileName(file_path).StartsWith("MBR")) Then
            email = My.Settings.em_martha
        ElseIf (Path.GetFileName(file_path).StartsWith(Date.Now.Year.ToString)) Then

            email = My.Settings.em_bet

        ElseIf (Path.GetFileName(file_path).StartsWith("in_")) Then
            email = My.Settings.em_sec

        ElseIf (Path.GetFileName(file_path).StartsWith("DOC")) Then
            email = My.Settings.em_cuisine
            'F111
        ElseIf (Path.GetFileName(file_path).StartsWith("F111")) Then
            email = My.Settings.em_f111

        Else
            email = My.Settings.em_inconnu

        End If

        If debug Then
            email = "fbs@heinen.eu"
        End If

        Try
            message = message + vbCrLf + "Veuillez reclasser manuellement le fichier qui se trouve en pièce jointe et dans " + "http://ged:8080/share/page/repository#filter=path%7C%2FHeinen%2FQRCode_Erreur&page=1"
            Mailling.Mail_a_envoyer("ged@heinen.eu", email, "Erreur qr code", message, True, new_file)
        Catch
            Exit Sub
        End Try

    End Sub

    Sub send_email_ex(file_path As String, message As String)
        ' vide le dossier pdf_temp
        Dim tmp_files() = Directory.GetFiles(My.Settings.pdf_temp)
        For Each tmp_file As String In tmp_files
            File.Delete(tmp_file)
        Next
        ' copie le fichier afin qu'il soit encore accessible durant la phase d'envoi du message
        Dim new_file = Path.Combine(My.Settings.pdf_temp, Path.GetFileName(file_path))
        File.Copy(file_path, new_file)

        Dim email As String
        ' test le nom du fichier

        email = My.Settings.em_erreur

        Try
            message = "Le fichier joint à provoqué une erreur non gérée : " + message + vbCrLf + "Veuillez redémarer manuellement le programme sur srv08 svp"
            Mailling.Mail_a_envoyer("ged@heinen.eu", email, "Erreur qr code - STOP", message, True, new_file)
        Catch
            Exit Sub
        End Try

    End Sub

End Module
