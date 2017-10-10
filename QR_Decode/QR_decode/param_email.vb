Public Class param_email

    Private Sub param_email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_param()
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        save_param()
        MsgBox("Parametres sauvés")
    End Sub

    Private Sub load_param()
        'charge les parametres
        tb_bet.Text = My.Settings.em_bet
        tb_cuis.Text = My.Settings.em_cuisine
        tb_inc.Text = My.Settings.em_inconnu
        tb_martha.Text = My.Settings.em_martha
        tb_sec.Text = My.Settings.em_sec
        tb_f111.Text = My.Settings.em_f111
        tb_erreur.Text = My.Settings.em_erreur
    End Sub

    Private Sub save_param()
        'charge les parametres
        My.Settings.em_bet = tb_bet.Text
        My.Settings.em_cuisine = tb_cuis.Text
        My.Settings.em_inconnu = tb_inc.Text
        My.Settings.em_martha = tb_martha.Text
        My.Settings.em_sec = tb_sec.Text
        My.Settings.em_f111 = tb_f111.Text
        My.Settings.em_erreur = tb_erreur.Text
        My.Settings.Save()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class