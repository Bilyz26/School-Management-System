namespace prj_ForYou
{
    partial class frmGestiondesEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmotdepasse = new System.Windows.Forms.CheckBox();
            this.txtmodepasseemp = new System.Windows.Forms.TextBox();
            this.mtxttelemp = new System.Windows.Forms.MaskedTextBox();
            this.cmbfonctionemp = new System.Windows.Forms.ComboBox();
            this.txtusernameemp = new System.Windows.Forms.TextBox();
            this.txtnomprenomemp = new System.Windows.Forms.TextBox();
            this.lbldatedebutP = new System.Windows.Forms.Label();
            this.lblfonctionemp = new System.Windows.Forms.Label();
            this.lblusernameemp = new System.Windows.Forms.Label();
            this.lblelemployee = new System.Windows.Forms.Label();
            this.lblnomprenomemployee = new System.Windows.Forms.Label();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbmotdepasse);
            this.groupBox1.Controls.Add(this.txtmodepasseemp);
            this.groupBox1.Controls.Add(this.mtxttelemp);
            this.groupBox1.Controls.Add(this.cmbfonctionemp);
            this.groupBox1.Controls.Add(this.txtusernameemp);
            this.groupBox1.Controls.Add(this.txtnomprenomemp);
            this.groupBox1.Controls.Add(this.lbldatedebutP);
            this.groupBox1.Controls.Add(this.lblfonctionemp);
            this.groupBox1.Controls.Add(this.lblusernameemp);
            this.groupBox1.Controls.Add(this.lblelemployee);
            this.groupBox1.Controls.Add(this.lblnomprenomemployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(40, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 354);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cbmotdepasse
            // 
            this.cbmotdepasse.AutoSize = true;
            this.cbmotdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmotdepasse.Location = new System.Drawing.Point(324, 300);
            this.cbmotdepasse.Name = "cbmotdepasse";
            this.cbmotdepasse.Size = new System.Drawing.Size(141, 17);
            this.cbmotdepasse.TabIndex = 34;
            this.cbmotdepasse.Text = "Afficher le Mot de Passe";
            this.cbmotdepasse.UseVisualStyleBackColor = true;
            this.cbmotdepasse.CheckedChanged += new System.EventHandler(this.cbmotdepasse_CheckedChanged);
            // 
            // txtmodepasseemp
            // 
            this.txtmodepasseemp.Location = new System.Drawing.Point(324, 260);
            this.txtmodepasseemp.Name = "txtmodepasseemp";
            this.txtmodepasseemp.Size = new System.Drawing.Size(179, 22);
            this.txtmodepasseemp.TabIndex = 33;
            // 
            // mtxttelemp
            // 
            this.mtxttelemp.Location = new System.Drawing.Point(324, 97);
            this.mtxttelemp.Mask = "00 00 00 00 00 ";
            this.mtxttelemp.Name = "mtxttelemp";
            this.mtxttelemp.Size = new System.Drawing.Size(179, 22);
            this.mtxttelemp.TabIndex = 32;
            // 
            // cmbfonctionemp
            // 
            this.cmbfonctionemp.FormattingEnabled = true;
            this.cmbfonctionemp.Items.AddRange(new object[] {
            "secrétaire",
            "directeur"});
            this.cmbfonctionemp.Location = new System.Drawing.Point(324, 152);
            this.cmbfonctionemp.Name = "cmbfonctionemp";
            this.cmbfonctionemp.Size = new System.Drawing.Size(179, 24);
            this.cmbfonctionemp.TabIndex = 31;
            // 
            // txtusernameemp
            // 
            this.txtusernameemp.Location = new System.Drawing.Point(324, 210);
            this.txtusernameemp.Name = "txtusernameemp";
            this.txtusernameemp.Size = new System.Drawing.Size(179, 22);
            this.txtusernameemp.TabIndex = 30;
            // 
            // txtnomprenomemp
            // 
            this.txtnomprenomemp.Location = new System.Drawing.Point(324, 37);
            this.txtnomprenomemp.Name = "txtnomprenomemp";
            this.txtnomprenomemp.Size = new System.Drawing.Size(179, 22);
            this.txtnomprenomemp.TabIndex = 29;
            // 
            // lbldatedebutP
            // 
            this.lbldatedebutP.AutoSize = true;
            this.lbldatedebutP.Location = new System.Drawing.Point(129, 267);
            this.lbldatedebutP.Name = "lbldatedebutP";
            this.lbldatedebutP.Size = new System.Drawing.Size(173, 16);
            this.lbldatedebutP.TabIndex = 28;
            this.lbldatedebutP.Text = "Mot de Passe d\'Employée :";
            // 
            // lblfonctionemp
            // 
            this.lblfonctionemp.AutoSize = true;
            this.lblfonctionemp.Location = new System.Drawing.Point(129, 160);
            this.lblfonctionemp.Name = "lblfonctionemp";
            this.lblfonctionemp.Size = new System.Drawing.Size(141, 16);
            this.lblfonctionemp.TabIndex = 27;
            this.lblfonctionemp.Text = "Fonction d\'Employée :";
            // 
            // lblusernameemp
            // 
            this.lblusernameemp.AutoSize = true;
            this.lblusernameemp.Location = new System.Drawing.Point(129, 217);
            this.lblusernameemp.Name = "lblusernameemp";
            this.lblusernameemp.Size = new System.Drawing.Size(159, 16);
            this.lblusernameemp.TabIndex = 25;
            this.lblusernameemp.Text = "User Name d\'Employée :";
            // 
            // lblelemployee
            // 
            this.lblelemployee.AutoSize = true;
            this.lblelemployee.BackColor = System.Drawing.Color.White;
            this.lblelemployee.Location = new System.Drawing.Point(129, 104);
            this.lblelemployee.Name = "lblelemployee";
            this.lblelemployee.Size = new System.Drawing.Size(156, 16);
            this.lblelemployee.TabIndex = 26;
            this.lblelemployee.Text = "Telephone d\'Employée :";
            // 
            // lblnomprenomemployee
            // 
            this.lblnomprenomemployee.AutoSize = true;
            this.lblnomprenomemployee.Location = new System.Drawing.Point(129, 44);
            this.lblnomprenomemployee.Name = "lblnomprenomemployee";
            this.lblnomprenomemployee.Size = new System.Drawing.Size(183, 16);
            this.lblnomprenomemployee.TabIndex = 24;
            this.lblnomprenomemployee.Text = "Nom et Prénom d\'Employée :";
            // 
            // btnQuiter
            // 
            this.btnQuiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuiter.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderSize = 0;
            this.btnQuiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnQuiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiter.ForeColor = System.Drawing.Color.White;
            this.btnQuiter.Location = new System.Drawing.Point(625, 15);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(69, 23);
            this.btnQuiter.TabIndex = 38;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = false;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmodifier.BackColor = System.Drawing.Color.DarkRed;
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(357, 434);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmodifier.Size = new System.Drawing.Size(88, 22);
            this.btnmodifier.TabIndex = 97;
            this.btnmodifier.Text = "Modifier ";
            this.btnmodifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnrechercher
            // 
            this.btnrechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrechercher.BackColor = System.Drawing.Color.DarkRed;
            this.btnrechercher.FlatAppearance.BorderSize = 0;
            this.btnrechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnrechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrechercher.ForeColor = System.Drawing.Color.White;
            this.btnrechercher.Location = new System.Drawing.Point(252, 434);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrechercher.Size = new System.Drawing.Size(90, 22);
            this.btnrechercher.TabIndex = 96;
            this.btnrechercher.Text = "Rechercher ";
            this.btnrechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrechercher.UseVisualStyleBackColor = false;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.DarkRed;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(153, 434);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 22);
            this.btnAjouter.TabIndex = 95;
            this.btnAjouter.Text = "Ajouter ";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(466, 434);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(88, 22);
            this.btnsupprimer.TabIndex = 98;
            this.btnsupprimer.Text = "Supprimer ";
            this.btnsupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::prj_ForYou.Properties.Resources._100_17_;
            this.pictureBox4.Location = new System.Drawing.Point(466, 434);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 102;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::prj_ForYou.Properties.Resources._100_16_;
            this.pictureBox3.Location = new System.Drawing.Point(357, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 101;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources._100_14_;
            this.pictureBox1.Location = new System.Drawing.Point(153, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox2.Location = new System.Drawing.Point(252, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // frmGestiondesEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 512);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestiondesEmployees";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Text = "Gestion des Employées :";
            this.Load += new System.EventHandler(this.frmGestiondesEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbmotdepasse;
        private System.Windows.Forms.TextBox txtmodepasseemp;
        private System.Windows.Forms.MaskedTextBox mtxttelemp;
        private System.Windows.Forms.ComboBox cmbfonctionemp;
        private System.Windows.Forms.TextBox txtusernameemp;
        private System.Windows.Forms.TextBox txtnomprenomemp;
        private System.Windows.Forms.Label lbldatedebutP;
        private System.Windows.Forms.Label lblfonctionemp;
        private System.Windows.Forms.Label lblusernameemp;
        private System.Windows.Forms.Label lblelemployee;
        private System.Windows.Forms.Label lblnomprenomemployee;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnsupprimer;
    }
}