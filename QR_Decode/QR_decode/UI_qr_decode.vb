Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode

Imports System.IO
Imports System.Drawing
Imports Ghostscript.NET.Rasterizer

Public Class UI_qr_decode

    Dim PdfFileName As String
    Dim dic_qr As New Dictionary(Of String, String)
    Dim contenu_qr As String = ""

    'initialisation formulaire
    Private Sub QR_decode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'charge les parametres
        tb_doc_ko.Text = My.Settings.tb_pdf_ko
        tb_doc_ok.Text = My.Settings.tb_pdf_ok
        Timer1.Interval = 5000
        Dim args() As String = Environment.GetCommandLineArgs()
        If (args.Length > 1) Then
            If (args(1) = "-start") Then
                start_timer()
            Else
                stop_timer()
            End If
        Else
            stop_timer()
        End If
    End Sub

    'fermeture du formulaire
    Private Sub UI_qr_decode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.tb_pdf_ko = tb_doc_ko.Text
        My.Settings.tb_pdf_ok = tb_doc_ok.Text
        My.Settings.Save()
    End Sub

    'changement mode AUTOMATIQUE/MANUEL
    Private Sub cb_automatique_CheckedChanged(sender As Object, e As EventArgs) Handles cb_automatique.CheckedChanged
        If cb_automatique.Checked Then
            start_timer()
        Else
            stop_timer()
        End If
    End Sub

    ' AUTOMATIQUE : lit le contenu du qr code contenu dans le pdf et retourne les infos dans les champs textes (AUTOMATIQUE)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'vérifie si on est dans la bonne période (voir fonction plus bas)
        If Not periode() Then Exit Sub

        'nettoyage des dossiers vides dans EPLAN 
        nettoyer_dossier_vides(My.Settings.pdf_in_2)



        Dim path_alf As String
        'cherche un pdf dans le dossier de recherche
        Dim files As String() = Nothing
        Dim files2 As String() = Nothing
        Try
            'dossier racine
            files = Directory.GetFiles(My.Settings.pdf_in, "*.pdf")
            ' dossier dans lequel on prend ausis les sous dossiers
            files2 = Directory.GetFiles(My.Settings.pdf_in_2, "*.pdf", SearchOption.AllDirectories)

            'MsgBox("Nombre de fichiers : " + files.Length.ToString + "Dossier :" + My.Settings.pdf_in)
        Catch ex As Exception
            stop_timer()
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' fusion des deux tableaux de pdf
        Dim files_tot(files.Length + files2.Length - 1) As String
        'Dim files_tot() As String
        Array.Copy(files, files_tot, files.Length)
        Array.Copy(files2, 0, files_tot, files.Length, files2.Length)

        'decode le pdf
        If files_tot IsNot Nothing Then
            If files_tot.Length >= 1 Then
                PdfFileName = files_tot(0)
                Dim fileinfo As FileInfo = New FileInfo(PdfFileName)

                ' verifie que le pdf n'est pas en lecture seule
                If fileinfo.IsReadOnly Or Not TryExclusiveOpen(PdfFileName) Then Exit Sub

                ' decode le pdf
                Try
                    decode_pdf_ui()
                Catch ex As LogException
                    LogFile.write(My.Settings.log_file, "Erreur", Path.GetFileName(PdfFileName), ex.Message)
                    LogFile.write_txtbx(tb_doc_ko, Path.GetFileName(PdfFileName), ex.Message)
                    LogFile.send_email(PdfFileName, ex.Message, cb_debug.Checked)

                    move_file_error(PdfFileName)
                    LogFile.write(My.Settings.log_file, "Move", Path.GetFileName(PdfFileName), "Fichier déplacé vers " + My.Settings.pdf_error)
                    Exit Sub
                Catch ex As OutOfMemoryException
                    LogFile.write(My.Settings.log_file, "Erreur", Path.GetFileName(PdfFileName), ex.Message)
                    LogFile.write_txtbx(tb_doc_ko, Path.GetFileName(PdfFileName), ex.Message)
                    LogFile.send_email(PdfFileName, ex.Message, cb_debug.Checked)

                    move_file_error(PdfFileName)
                    LogFile.write(My.Settings.log_file, "Move", Path.GetFileName(PdfFileName), "Fichier déplacé vers " + My.Settings.pdf_error)
                    Exit Sub
                Catch ex As Exception
                    stop_timer()
                    LogFile.send_email_ex(PdfFileName, ex.Message)
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                ' teste le repertoir client
                Dim copy_file = New CopyFileALF
                Try
                    'path_alf = copy_file.getpath(dic_qr("DOSSIER"))
                    'teste le dossier ou repertoire pour V03
                    If dic_qr("VERSION") <> "V03" Then
                        path_alf = copy_file.getpath(LBL_Dossier.Text)
                    Else
                        Dim path_ex As Boolean = copy_file.checkpath(LBL_PATH.Text)
                        path_alf = "" ' le path est directement dans le qr
                    End If

                Catch ex As LogException
                    LogFile.write(My.Settings.log_file, "Erreur", Path.GetFileName(PdfFileName), "Le dossier [" + dic_qr("DOSSIER") + "] n'est pas trouvable dans Alfresco")
                    LogFile.write_txtbx(tb_doc_ko, Path.GetFileName(PdfFileName), "Le dossier [" + dic_qr("DOSSIER") + "] n'est pas trouvable dans Alfresco")
                    LogFile.send_email(PdfFileName, "Le dossier [" + dic_qr("DOSSIER") + "] n'est pas trouvable dans Alfresco", cb_debug.Checked)

                    move_file_error(PdfFileName)
                    LogFile.write(My.Settings.log_file, "Move", Path.GetFileName(PdfFileName), "Fichier déplacé vers " + My.Settings.pdf_error)
                    Exit Sub
                Catch ex As Exception
                    stop_timer()
                    LogFile.send_email_ex(PdfFileName, ex.Message)
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                ' copie le fichier
                Try
                    Dim message As String = ""
                    message = copy_file.copy_file(PdfFileName, path_alf, dic_qr)
                    LogFile.write(My.Settings.log_file, "OK", Path.GetFileName(PdfFileName), message)
                    LogFile.write_txtbx(tb_doc_ok, Path.GetFileName(PdfFileName), message)


                    LogFile.move_file_ok(PdfFileName)
                    LogFile.write(My.Settings.log_file, "Move", Path.GetFileName(PdfFileName), "Fichier déplacé vers " + My.Settings.pdf_ok)
                Catch ex As LogException
                    LogFile.write(My.Settings.log_file, "Erreur", Path.GetFileName(PdfFileName), ex.Message)
                    LogFile.write_txtbx(tb_doc_ko, Path.GetFileName(PdfFileName), ex.Message)
                    LogFile.send_email(PdfFileName, ex.Message, cb_debug.Checked)

                    'LogFile.move_file_error(PdfFileName)
                    move_file_error(PdfFileName)
                    LogFile.write(My.Settings.log_file, "Move", Path.GetFileName(PdfFileName), "Fichier déplacé vers " + My.Settings.pdf_error)
                Catch ex As Exception
                    stop_timer()
                    LogFile.send_email_ex(PdfFileName, ex.Message)
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                ' deplace le pdf dans ok
                'LogFile.move_file_ok(PdfFileName)
                'LogFile.write(My.Settings.log_file, "Move", Path.GetFileName(PdfFileName), "Fichier déplacé vers " + My.Settings.pdf_ok)
            End If
        End If
        'copie le pdf
    End Sub

    'MANUEL lit le contenu du qr code contenu dans le pdf et retourne les infos dans les champs textes (MANUEL)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_decode_pdf.Click
        OpenFileDialog1.Filter = "PDF Files |*.pdf"
        OpenFileDialog1.InitialDirectory = "C:\temp\QRcode"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PdfFileName = OpenFileDialog1.FileName
            'AxAcroPDF1.src = PdfFileName
            Try
                decode_pdf_ui()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'MANUEL : bouton CHECK DOSSIER
    Private Sub b_test_dossier_Click(sender As Object, e As EventArgs) Handles b_test_dossier.Click
        create_dico_from_ui() ' recrée le dico a partir de l'UI (pour tests)
        Try
            Dim copy_file = New CopyFileALF
            Dim path As String
            If dic_qr("VERSION") <> "V03" Then
                path = copy_file.getpath(LBL_Dossier.Text)
                MessageBox.Show(path, "Path", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim path_ex As Boolean = copy_file.checkpath(LBL_PATH.Text)
                MessageBox.Show("Path [" + LBL_PATH.Text + "] existe dans aflresco", "-", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'MANUEL : copie le fichier au bon endroit dans alfresco (BOUTON MANUEL) 
    Private Sub b_copy_file_Click_1(sender As Object, e As EventArgs) Handles b_copy_file.Click
        create_dico_from_ui() ' recrée le dico a partir de l'UI (pour tests)
        Dim copy_file = New CopyFileALF
        Dim path As String
        Dim message = ""
        Try
            'teste le dossier ou repertoire pour V03
            If dic_qr("VERSION") <> "V03" Then
                path = copy_file.getpath(LBL_Dossier.Text)
            Else
                Dim path_ex As Boolean = copy_file.checkpath(LBL_PATH.Text)
                path = "" ' le path est directement dans le qr
            End If
            message = copy_file.copy_file(PdfFileName, path, dic_qr)
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function move_file_error(file As String) As Boolean
        Try
            LogFile.move_file_error(file)
            Return True
        Catch ex As Exception
            stop_timer()
            LogFile.send_email_ex(PdfFileName, ex.Message)
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
        End Try
    End Function

    Private Sub decode_pdf_ui()
        'lecture via QR code
        'vide le dico et les champs texte
        dic_qr.Clear()
        empty_txtbox()
        Decode_Qr.Get_qr_info(PdfFileName, dic_qr, contenu_qr)
        TXT_GUID.Text = contenu_qr
        LBL_TS.Text = dic_qr("DATE")
        LBL_PATH.Text = dic_qr("PATH")
        LBL_Fichier.Text = dic_qr("NAME")
        LBL_Cat.Text = dic_qr("CAT")
        LBL_Titre.Text = dic_qr("TITRE")
        LBL_Client.Text = dic_qr("CLIENT")
        LBL_Dossier.Text = dic_qr("DOSSIER")
        lab_vers_qr.Text = dic_qr("VERSION")
    End Sub

    Private Sub create_dico_from_ui()
        dic_qr.Clear()
        dic_qr("DATE") = LBL_TS.Text
        dic_qr("PATH") = LBL_PATH.Text
        dic_qr("NAME") = LBL_Fichier.Text
        dic_qr("CAT") = LBL_Cat.Text
        dic_qr("TITRE") = LBL_Titre.Text
        dic_qr("CLIENT") = LBL_Client.Text
        dic_qr("DOSSIER") = LBL_Dossier.Text
        dic_qr("VERSION") = lab_vers_qr.Text
    End Sub

    Private Sub stop_timer()
        cb_automatique.Checked = False
        cb_automatique.Text = "Démarrer automatique"
        Me.Text = "Décode et injecte [MANUEL]"
        Timer1.Enabled = False
        b_copy_file.Enabled = True
        b_test_dossier.Enabled = True
        b_decode_pdf.Enabled = True
        PictureBox1.Image = My.Resources.pt_rouge
    End Sub

    Private Sub start_timer()
        cb_automatique.Checked = True
        cb_automatique.Text = "Passage en manuel"
        Me.Text = "Décode et injecte [AUTOMATIQUE]"
        Timer1.Enabled = True
        b_copy_file.Enabled = False
        b_test_dossier.Enabled = False
        b_decode_pdf.Enabled = False
        PictureBox1.Image = My.Resources.pt_vert

    End Sub

    Private Sub empty_txtbox()
        TXT_GUID.Text = ""
        LBL_TS.Text = ""
        LBL_PATH.Text = ""
        LBL_Fichier.Text = ""
        LBL_Cat.Text = ""
        LBL_Titre.Text = ""
        LBL_Client.Text = ""
        LBL_Dossier.Text = ""
    End Sub

    Private Sub b_open_lf_Click_1(sender As Object, e As EventArgs) Handles b_open_lf.Click
        System.Diagnostics.Process.Start(My.Settings.log_file)
    End Sub

    Private Sub b_open_scan_in_Click(sender As Object, e As EventArgs) Handles b_open_scan_in.Click
        Process.Start("explorer.exe", My.Settings.pdf_in)
    End Sub

    Private Sub b_open_pdf_error_Click(sender As Object, e As EventArgs) Handles b_open_pdf_error.Click
        Process.Start("explorer.exe", My.Settings.pdf_error)
    End Sub

    Private Sub b_open_pdf_ok_Click(sender As Object, e As EventArgs) Handles b_open_pdf_ok.Click
        Process.Start("explorer.exe", My.Settings.pdf_ok)
    End Sub

    Private Sub b_param_email_Click(sender As Object, e As EventArgs) Handles b_param_email.Click
        Dim email_form As New param_email
        email_form.Show()
    End Sub

    Private Sub envoi_email_erreur()

    End Sub

    Private Function periode() As Boolean
        Dim now As DateTime = DateTime.Now
        'dimanche 12h à lundi 6h et tous les jours entre 20 et 21
        If (now.DayOfWeek = DayOfWeek.Sunday And now.Hour >= 22) Then
            Return False
        ElseIf (now.DayOfWeek = DayOfWeek.Monday And now.Hour < 6)
            Return False
        ElseIf (now.Hour >= 19 And now.Hour <= 21)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function TryExclusiveOpen(filePath As String) As Boolean
        Dim fs As FileStream
        Try
            fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            fs.Close()
            Return True
        Catch
            fs = Nothing
            Return False
        End Try
    End Function


    Private Sub PARAMETRESEMAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARAMETRESEMAILSToolStripMenuItem.Click
        Dim email_form As New param_email
        email_form.ShowDialog()
    End Sub

    Private Sub QUITTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUITTERToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SETTINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETTINGSToolStripMenuItem.Click
        Dim param_form As New param_app
        param_form.ShowDialog()
    End Sub

    Private Sub nettoyer_dossier_vides(dir_to_clean As String)
        Dim dir As String()
        dir = Directory.GetDirectories(dir_to_clean, "*", SearchOption.AllDirectories)

        For Each directory As String In dir
            Dim files As String()
            Dim direc As String()
            files = System.IO.Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories)
            direc = System.IO.Directory.GetDirectories(directory, "*", SearchOption.AllDirectories)
            If files.Length <= 0 And direc.Length <= 0 Then
                Try
                    System.IO.Directory.Delete(directory)
                Catch
                    'le dossier n'a pas pu etre supprime (probleme de droits)
                End Try
            End If
        Next

    End Sub
End Class
