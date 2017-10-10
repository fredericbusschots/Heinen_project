using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Copy_file_scan
{
    public partial class Form1 : Form
    {

        string file_in, file_out1, file_out2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            //load settings
            file_in = Properties.Settings.Default.file_in;
            file_out1 = Properties.Settings.Default.file_out1;
            file_out2 = Properties.Settings.Default.file_out2;

            tb_rech.Text = file_in;
            tb_copie1.Text = file_out1;
            tb_copie2.Text = file_out2;

            cb_dir1.Checked = true;
            cb_dir2.Checked = false;
            
            timer1.Interval = 5000;

            String [] args = Environment.GetCommandLineArgs();
            if (args.Length>1 && args[1]=="-start")
            {
                start_timer();
            }
            else
            {
                reset_timer();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                start_timer();                              
            }
            else
            {
                reset_timer();
            }
        }

        private void b_open_rech_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", tb_rech.Text);
        }

        private void b_open_copy1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", tb_copie1.Text);
        }

        private void b_open_copy2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", tb_copie2.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //arrete la fonction si pas dans la bonne periode
            if (!periode()) return;

            string[] files;
            try
            {
                files = Directory.GetFiles(file_in, "*.pdf");
                if (files != null && files.Length >= 1)
                {
                    FileInfo fInfo = new FileInfo(files[0]);
                    if (fInfo.IsReadOnly || !fileIsAccessible(files[0])) return;

                    if (cb_dir1.Checked)
                    File.Copy(files[0], Path.Combine(file_out1, Path.GetFileName(files[0])));

                    if (cb_dir2.Checked)
                    File.Copy(files[0], Path.Combine(file_out2, Path.GetFileName(files[0])));

                    //evite de supprimer le fichier si aucun des cb n'est checked
                    if (cb_dir1.Checked || cb_dir2.Checked)
                    File.Delete(files[0]);
                }
            }
            catch (Exception ex)
            {
                reset_timer();
                MessageBox.Show(DateTime.Now + " : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void reset_timer()
        {
            {
                timer1.Enabled = false;
                checkBox1.Text = "Démarrer copie fichier";
                this.Text = "Duplique fichier scanner[ARRETE]";
                checkBox1.Checked = false;
            }
        }
        private void start_timer()
        {
            {
                timer1.Enabled = true;
                checkBox1.Text = "Arreter copie fichier";
                this.Text = "Duplique fichier scanner[ACTIF]";                
                checkBox1.Checked = true;
            }
        }

        private bool periode ()
        {
            DateTime now = DateTime.Now;
            // dimanche 12h à lundi 6h et tous les jours entre 20 et 21
            if (now.DayOfWeek == DayOfWeek.Sunday && now.Hour >= 12)
                return false;
            else if (now.DayOfWeek == DayOfWeek.Monday && now.Hour < 6)
                return false;
            else if (now.Hour >= 19 && now.Hour <= 21)
                return false;
            else
                return true;       
        }

        private bool fileIsAccessible(string filePath)
        {
            FileStream fs;
            try
            {
                
                fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                if (fs!=null)
                {
                    fs.Close();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                fs = null;
                return false;
            }
        }


    }
}
