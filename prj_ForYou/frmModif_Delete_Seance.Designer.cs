namespace prj_ForYou
{
    partial class frmModif_Delete_Seance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModif_Delete_Seance));
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.cmbnomprof = new System.Windows.Forms.ComboBox();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbmatier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnombrEleve = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.cmbnomgrp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnomgrp = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.mtxtHF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHD = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtjour = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmodifier.BackColor = System.Drawing.Color.DarkRed;
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(185, 383);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmodifier.Size = new System.Drawing.Size(88, 22);
            this.btnmodifier.TabIndex = 96;
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
            this.btnrechercher.Location = new System.Drawing.Point(80, 383);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrechercher.Size = new System.Drawing.Size(90, 22);
            this.btnrechercher.TabIndex = 95;
            this.btnrechercher.Text = "Rechercher ";
            this.btnrechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrechercher.UseVisualStyleBackColor = false;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(294, 383);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(88, 22);
            this.btnsupprimer.TabIndex = 97;
            this.btnsupprimer.Text = "Supprimer ";
            this.btnsupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // cmbnomprof
            // 
            this.cmbnomprof.FormattingEnabled = true;
            this.cmbnomprof.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.cmbnomprof.Location = new System.Drawing.Point(239, 59);
            this.cmbnomprof.Name = "cmbnomprof";
            this.cmbnomprof.Size = new System.Drawing.Size(180, 21);
            this.cmbnomprof.TabIndex = 112;
            this.cmbnomprof.SelectedIndexChanged += new System.EventHandler(this.cmbnomprof_SelectedIndexChanged);
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Location = new System.Drawing.Point(239, 32);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(180, 21);
            this.cmbniveau.TabIndex = 110;
            this.cmbniveau.SelectedIndexChanged += new System.EventHandler(this.cmbniveau_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Choisir Le Professeur :";
            // 
            // cmbmatier
            // 
            this.cmbmatier.FormattingEnabled = true;
            this.cmbmatier.Location = new System.Drawing.Point(239, 5);
            this.cmbmatier.Name = "cmbmatier";
            this.cmbmatier.Size = new System.Drawing.Size(180, 21);
            this.cmbmatier.TabIndex = 109;
            this.cmbmatier.SelectedIndexChanged += new System.EventHandler(this.cmbmatier_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Choisir Une Matièere :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 107;
            this.label8.Text = " Choisir Un Niveau :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = " ";
            // 
            // lblnombrEleve
            // 
            this.lblnombrEleve.AutoSize = true;
            this.lblnombrEleve.Location = new System.Drawing.Point(211, 157);
            this.lblnombrEleve.Name = "lblnombrEleve";
            this.lblnombrEleve.Size = new System.Drawing.Size(13, 13);
            this.lblnombrEleve.TabIndex = 81;
            this.lblnombrEleve.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Nombre des élèves :";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(169, 156);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(0, 13);
            this.lblcount.TabIndex = 79;
            // 
            // cmbannee
            // 
            this.cmbannee.FormattingEnabled = true;
            this.cmbannee.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.cmbannee.Location = new System.Drawing.Point(239, 88);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(180, 21);
            this.cmbannee.TabIndex = 104;
            this.cmbannee.SelectedIndexChanged += new System.EventHandler(this.cmbannee_SelectedIndexChanged);
            // 
            // cmbnomgrp
            // 
            this.cmbnomgrp.FormattingEnabled = true;
            this.cmbnomgrp.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.cmbnomgrp.Location = new System.Drawing.Point(239, 115);
            this.cmbnomgrp.Name = "cmbnomgrp";
            this.cmbnomgrp.Size = new System.Drawing.Size(180, 21);
            this.cmbnomgrp.TabIndex = 103;
            this.cmbnomgrp.SelectedIndexChanged += new System.EventHandler(this.cmbnomgrp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Année  d\'étude:";
            // 
            // lblnomgrp
            // 
            this.lblnomgrp.AutoSize = true;
            this.lblnomgrp.Location = new System.Drawing.Point(52, 118);
            this.lblnomgrp.Name = "lblnomgrp";
            this.lblnomgrp.Size = new System.Drawing.Size(88, 13);
            this.lblnomgrp.TabIndex = 101;
            this.lblnomgrp.Text = "Nom du Groupe :";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(55, 232);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(364, 145);
            this.dgv.TabIndex = 113;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // mtxtHF
            // 
            this.mtxtHF.Location = new System.Drawing.Point(415, 200);
            this.mtxtHF.Mask = "00:00";
            this.mtxtHF.Name = "mtxtHF";
            this.mtxtHF.Size = new System.Drawing.Size(37, 20);
            this.mtxtHF.TabIndex = 119;
            this.mtxtHF.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHD
            // 
            this.mtxtHD.Location = new System.Drawing.Point(286, 200);
            this.mtxtHD.Mask = "00:00";
            this.mtxtHD.Name = "mtxtHD";
            this.mtxtHD.Size = new System.Drawing.Size(37, 20);
            this.mtxtHD.TabIndex = 118;
            this.mtxtHD.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Fin de séance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Début de séance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Jour du séance";
            // 
            // txtjour
            // 
            this.txtjour.Enabled = false;
            this.txtjour.Location = new System.Drawing.Point(95, 199);
            this.txtjour.Name = "txtjour";
            this.txtjour.Size = new System.Drawing.Size(68, 20);
            this.txtjour.TabIndex = 136;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::prj_ForYou.Properties.Resources._100_17_;
            this.pictureBox4.Location = new System.Drawing.Point(294, 383);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 100;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::prj_ForYou.Properties.Resources._100_16_;
            this.pictureBox3.Location = new System.Drawing.Point(185, 383);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox2.Location = new System.Drawing.Point(80, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            // 
            // frmModif_Delete_Seance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 417);
            this.Controls.Add(this.txtjour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtHF);
            this.Controls.Add(this.mtxtHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombrEleve);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.cmbnomprof);
            this.Controls.Add(this.cmbniveau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbmatier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbannee);
            this.Controls.Add(this.cmbnomgrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnomgrp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.btnsupprimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModif_Delete_Seance";
            this.Load += new System.EventHandler(this.frmModif_Delete_Seance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.ComboBox cmbnomprof;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbmatier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblnombrEleve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.ComboBox cmbannee;
        private System.Windows.Forms.ComboBox cmbnomgrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnomgrp;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MaskedTextBox mtxtHF;
        private System.Windows.Forms.MaskedTextBox mtxtHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtjour;
    }
}