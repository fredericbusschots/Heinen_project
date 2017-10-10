namespace Copy_file_scan
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rech = new System.Windows.Forms.TextBox();
            this.tb_copie1 = new System.Windows.Forms.TextBox();
            this.tb_copie2 = new System.Windows.Forms.TextBox();
            this.b_open_rech = new System.Windows.Forms.Button();
            this.b_open_copy1 = new System.Windows.Forms.Button();
            this.b_open_copy2 = new System.Windows.Forms.Button();
            this.cb_dir1 = new System.Windows.Forms.CheckBox();
            this.cb_dir2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Repertoire de recherche";
            // 
            // tb_rech
            // 
            this.tb_rech.Enabled = false;
            this.tb_rech.Location = new System.Drawing.Point(163, 56);
            this.tb_rech.Name = "tb_rech";
            this.tb_rech.Size = new System.Drawing.Size(260, 20);
            this.tb_rech.TabIndex = 4;
            // 
            // tb_copie1
            // 
            this.tb_copie1.Enabled = false;
            this.tb_copie1.Location = new System.Drawing.Point(163, 82);
            this.tb_copie1.Name = "tb_copie1";
            this.tb_copie1.Size = new System.Drawing.Size(260, 20);
            this.tb_copie1.TabIndex = 5;
            // 
            // tb_copie2
            // 
            this.tb_copie2.Enabled = false;
            this.tb_copie2.Location = new System.Drawing.Point(163, 108);
            this.tb_copie2.Name = "tb_copie2";
            this.tb_copie2.Size = new System.Drawing.Size(260, 20);
            this.tb_copie2.TabIndex = 6;
            // 
            // b_open_rech
            // 
            this.b_open_rech.Location = new System.Drawing.Point(433, 56);
            this.b_open_rech.Name = "b_open_rech";
            this.b_open_rech.Size = new System.Drawing.Size(28, 19);
            this.b_open_rech.TabIndex = 7;
            this.b_open_rech.Text = "...";
            this.b_open_rech.UseVisualStyleBackColor = true;
            this.b_open_rech.Click += new System.EventHandler(this.b_open_rech_Click);
            // 
            // b_open_copy1
            // 
            this.b_open_copy1.Location = new System.Drawing.Point(433, 83);
            this.b_open_copy1.Name = "b_open_copy1";
            this.b_open_copy1.Size = new System.Drawing.Size(28, 19);
            this.b_open_copy1.TabIndex = 8;
            this.b_open_copy1.Text = "...";
            this.b_open_copy1.UseVisualStyleBackColor = true;
            this.b_open_copy1.Click += new System.EventHandler(this.b_open_copy1_Click);
            // 
            // b_open_copy2
            // 
            this.b_open_copy2.Location = new System.Drawing.Point(433, 109);
            this.b_open_copy2.Name = "b_open_copy2";
            this.b_open_copy2.Size = new System.Drawing.Size(28, 19);
            this.b_open_copy2.TabIndex = 9;
            this.b_open_copy2.Text = "...";
            this.b_open_copy2.UseVisualStyleBackColor = true;
            this.b_open_copy2.Click += new System.EventHandler(this.b_open_copy2_Click);
            // 
            // cb_dir1
            // 
            this.cb_dir1.AutoSize = true;
            this.cb_dir1.Location = new System.Drawing.Point(15, 83);
            this.cb_dir1.Name = "cb_dir1";
            this.cb_dir1.Size = new System.Drawing.Size(128, 17);
            this.cb_dir1.TabIndex = 10;
            this.cb_dir1.Text = "Repertoire de copie 1";
            this.cb_dir1.UseVisualStyleBackColor = true;
            // 
            // cb_dir2
            // 
            this.cb_dir2.AutoSize = true;
            this.cb_dir2.Location = new System.Drawing.Point(14, 108);
            this.cb_dir2.Name = "cb_dir2";
            this.cb_dir2.Size = new System.Drawing.Size(128, 17);
            this.cb_dir2.TabIndex = 11;
            this.cb_dir2.Text = "Repertoire de copie 2";
            this.cb_dir2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 160);
            this.Controls.Add(this.cb_dir2);
            this.Controls.Add(this.cb_dir1);
            this.Controls.Add(this.b_open_copy2);
            this.Controls.Add(this.b_open_copy1);
            this.Controls.Add(this.b_open_rech);
            this.Controls.Add(this.tb_copie2);
            this.Controls.Add(this.tb_copie1);
            this.Controls.Add(this.tb_rech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Duplique fichier scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rech;
        private System.Windows.Forms.TextBox tb_copie1;
        private System.Windows.Forms.TextBox tb_copie2;
        private System.Windows.Forms.Button b_open_rech;
        private System.Windows.Forms.Button b_open_copy1;
        private System.Windows.Forms.Button b_open_copy2;
        private System.Windows.Forms.CheckBox cb_dir1;
        private System.Windows.Forms.CheckBox cb_dir2;
    }
}

