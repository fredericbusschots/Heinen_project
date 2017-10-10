Public Class param_app
    Private Sub param_app_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_cmis10.Text = My.Settings.cmis_conn_10
        tb_cmis11.Text = My.Settings.cmis_connection
        tb_user.Text = My.Settings.cmis_user
        tb_mdp.Text = My.Settings.cmis_pwd

        tb_pdf_in.Text = My.Settings.pdf_in
        tb_pdf_in_2.Text = My.Settings.pdf_in_2
        tb_pdf_error.Text = My.Settings.pdf_error
        tb_pdf_ok.Text = My.Settings.pdf_ok

        tb_log.Text = My.Settings.log_file
        tb_xml.Text = My.Settings.xml_file

    End Sub

    Private Sub b_save_param_Click(sender As Object, e As EventArgs) Handles b_save_param.Click
        My.Settings.cmis_conn_10 = tb_cmis10.Text
        My.Settings.cmis_connection = tb_cmis11.Text
        My.Settings.cmis_user = tb_user.Text
        My.Settings.cmis_pwd = tb_mdp.Text

        My.Settings.pdf_in = tb_pdf_in.Text
        My.Settings.pdf_in_2 = tb_pdf_in_2.Text
        My.Settings.pdf_error = tb_pdf_error.Text
        My.Settings.pdf_ok = tb_pdf_ok.Text

        My.Settings.log_file = tb_log.Text
        My.Settings.xml_file = tb_xml.Text

        My.Settings.Save()

        MsgBox("Parametres sauvés")
    End Sub
End Class