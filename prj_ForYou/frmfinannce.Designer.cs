namespace prj_ForYou
{
    partial class frmfinannce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfinannce));
            this.rdbS = new System.Windows.Forms.RadioButton();
            this.rdbT = new System.Windows.Forms.RadioButton();
            this.gbS = new System.Windows.Forms.GroupBox();
            this.cmbmnth = new System.Windows.Forms.ComboBox();
            this.lblnombrEleve = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbnomprof = new System.Windows.Forms.ComboBox();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbmatier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.cmbnomgrp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnomgrp = new System.Windows.Forms.Label();
            this.gbT = new System.Windows.Forms.GroupBox();
            this.cmbmonthpT = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnneeT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMatT = new System.Windows.Forms.ComboBox();
            this.btnCmnc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxt100 = new System.Windows.Forms.MaskedTextBox();
            this.txtmT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbS.SuspendLayout();
            this.gbT.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbS
            // 
            this.rdbS.AutoSize = true;
            this.rdbS.Location = new System.Drawing.Point(88, 2);
            this.rdbS.Name = "rdbS";
            this.rdbS.Size = new System.Drawing.Size(97, 17);
            this.rdbS.TabIndex = 0;
            this.rdbS.TabStop = true;
            this.rdbS.Text = "Un seul groupe";
            this.rdbS.UseVisualStyleBackColor = true;
            this.rdbS.CheckedChanged += new System.EventHandler(this.rdbS_CheckedChanged);
            // 
            // rdbT
            // 
            this.rdbT.AutoSize = true;
            this.rdbT.Location = new System.Drawing.Point(209, 2);
            this.rdbT.Name = "rdbT";
            this.rdbT.Size = new System.Drawing.Size(106, 17);
            this.rdbT.TabIndex = 1;
            this.rdbT.TabStop = true;
            this.rdbT.Text = "Tous les groupes";
            this.rdbT.UseVisualStyleBackColor = true;
            this.rdbT.CheckedChanged += new System.EventHandler(this.rdbT_CheckedChanged);
            // 
            // gbS
            // 
            this.gbS.BackColor = System.Drawing.Color.White;
            this.gbS.Controls.Add(this.cmbmnth);
            this.gbS.Controls.Add(this.lblnombrEleve);
            this.gbS.Controls.Add(this.label14);
            this.gbS.Controls.Add(this.label7);
            this.gbS.Controls.Add(this.cmbnomprof);
            this.gbS.Controls.Add(this.cmbniveau);
            this.gbS.Controls.Add(this.label4);
            this.gbS.Controls.Add(this.cmbmatier);
            this.gbS.Controls.Add(this.label5);
            this.gbS.Controls.Add(this.label8);
            this.gbS.Controls.Add(this.label9);
            this.gbS.Controls.Add(this.cmbannee);
            this.gbS.Controls.Add(this.cmbnomgrp);
            this.gbS.Controls.Add(this.label1);
            this.gbS.Controls.Add(this.lblnomgrp);
            this.gbS.Location = new System.Drawing.Point(12, 25);
            this.gbS.Name = "gbS";
            this.gbS.Size = new System.Drawing.Size(388, 230);
            this.gbS.TabIndex = 2;
            this.gbS.TabStop = false;
            // 
            // cmbmnth
            // 
            this.cmbmnth.FormattingEnabled = true;
            this.cmbmnth.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cmbmnth.Location = new System.Drawing.Point(182, 162);
            this.cmbmnth.Name = "cmbmnth";
            this.cmbmnth.Size = new System.Drawing.Size(180, 21);
            this.cmbmnth.TabIndex = 112;
            this.cmbmnth.SelectedIndexChanged += new System.EventHandler(this.cmbmnth_SelectedIndexChanged);
            // 
            // lblnombrEleve
            // 
            this.lblnombrEleve.AutoSize = true;
            this.lblnombrEleve.Location = new System.Drawing.Point(319, 196);
            this.lblnombrEleve.Name = "lblnombrEleve";
            this.lblnombrEleve.Size = new System.Drawing.Size(13, 13);
            this.lblnombrEleve.TabIndex = 126;
            this.lblnombrEleve.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 111;
            this.label14.Text = "Mois de Paiement :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Nombre des élèves :";
            // 
            // cmbnomprof
            // 
            this.cmbnomprof.FormattingEnabled = true;
            this.cmbnomprof.Location = new System.Drawing.Point(182, 83);
            this.cmbnomprof.Name = "cmbnomprof";
            this.cmbnomprof.Size = new System.Drawing.Size(180, 21);
            this.cmbnomprof.TabIndex = 110;
            this.cmbnomprof.SelectedIndexChanged += new System.EventHandler(this.cmbnomprof_SelectedIndexChanged);
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Location = new System.Drawing.Point(182, 56);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(180, 21);
            this.cmbniveau.TabIndex = 108;
            this.cmbniveau.SelectedIndexChanged += new System.EventHandler(this.cmbniveau_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Choisir Le Professeur :";
            // 
            // cmbmatier
            // 
            this.cmbmatier.FormattingEnabled = true;
            this.cmbmatier.Location = new System.Drawing.Point(182, 29);
            this.cmbmatier.Name = "cmbmatier";
            this.cmbmatier.Size = new System.Drawing.Size(180, 21);
            this.cmbmatier.TabIndex = 107;
            this.cmbmatier.SelectedIndexChanged += new System.EventHandler(this.cmbmatier_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Choisir Une Matièere :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "Choisir Un Niveau :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = " ";
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
            this.cmbannee.Location = new System.Drawing.Point(182, 110);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(180, 21);
            this.cmbannee.TabIndex = 102;
            this.cmbannee.SelectedIndexChanged += new System.EventHandler(this.cmbannee_SelectedIndexChanged);
            // 
            // cmbnomgrp
            // 
            this.cmbnomgrp.FormattingEnabled = true;
            this.cmbnomgrp.Location = new System.Drawing.Point(182, 137);
            this.cmbnomgrp.Name = "cmbnomgrp";
            this.cmbnomgrp.Size = new System.Drawing.Size(180, 21);
            this.cmbnomgrp.TabIndex = 101;
            this.cmbnomgrp.SelectedIndexChanged += new System.EventHandler(this.cmbnomgrp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Année  d\'étude:";
            // 
            // lblnomgrp
            // 
            this.lblnomgrp.AutoSize = true;
            this.lblnomgrp.Location = new System.Drawing.Point(12, 146);
            this.lblnomgrp.Name = "lblnomgrp";
            this.lblnomgrp.Size = new System.Drawing.Size(88, 13);
            this.lblnomgrp.TabIndex = 99;
            this.lblnomgrp.Text = "Nom du Groupe :";
            // 
            // gbT
            // 
            this.gbT.BackColor = System.Drawing.Color.White;
            this.gbT.Controls.Add(this.cmbmonthpT);
            this.gbT.Controls.Add(this.label15);
            this.gbT.Controls.Add(this.label10);
            this.gbT.Controls.Add(this.cmbProT);
            this.gbT.Controls.Add(this.label2);
            this.gbT.Controls.Add(this.cmbAnneeT);
            this.gbT.Controls.Add(this.label3);
            this.gbT.Controls.Add(this.cmbMatT);
            this.gbT.Location = new System.Drawing.Point(433, 25);
            this.gbT.Name = "gbT";
            this.gbT.Size = new System.Drawing.Size(388, 245);
            this.gbT.TabIndex = 3;
            this.gbT.TabStop = false;
            // 
            // cmbmonthpT
            // 
            this.cmbmonthpT.FormattingEnabled = true;
            this.cmbmonthpT.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cmbmonthpT.Location = new System.Drawing.Point(173, 162);
            this.cmbmonthpT.Name = "cmbmonthpT";
            this.cmbmonthpT.Size = new System.Drawing.Size(180, 21);
            this.cmbmonthpT.TabIndex = 120;
            this.cmbmonthpT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 119;
            this.label15.Text = "Mois de Paiement :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "Année  d\'étude:";
            // 
            // cmbProT
            // 
            this.cmbProT.FormattingEnabled = true;
            this.cmbProT.Location = new System.Drawing.Point(173, 97);
            this.cmbProT.Name = "cmbProT";
            this.cmbProT.Size = new System.Drawing.Size(180, 21);
            this.cmbProT.TabIndex = 117;
            this.cmbProT.SelectedIndexChanged += new System.EventHandler(this.cmbProT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Choisir Le Professeur :";
            // 
            // cmbAnneeT
            // 
            this.cmbAnneeT.FormattingEnabled = true;
            this.cmbAnneeT.Location = new System.Drawing.Point(173, 130);
            this.cmbAnneeT.Name = "cmbAnneeT";
            this.cmbAnneeT.Size = new System.Drawing.Size(180, 21);
            this.cmbAnneeT.TabIndex = 114;
            this.cmbAnneeT.SelectedIndexChanged += new System.EventHandler(this.cmbAnneeT_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Choisir Une Matièere :";
            // 
            // cmbMatT
            // 
            this.cmbMatT.FormattingEnabled = true;
            this.cmbMatT.Location = new System.Drawing.Point(173, 57);
            this.cmbMatT.Name = "cmbMatT";
            this.cmbMatT.Size = new System.Drawing.Size(180, 21);
            this.cmbMatT.TabIndex = 111;
            this.cmbMatT.SelectedIndexChanged += new System.EventHandler(this.cmbMatT_SelectedIndexChanged);
            // 
            // btnCmnc
            // 
            this.btnCmnc.BackColor = System.Drawing.Color.DarkRed;
            this.btnCmnc.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCmnc.FlatAppearance.BorderSize = 0;
            this.btnCmnc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCmnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmnc.ForeColor = System.Drawing.Color.White;
            this.btnCmnc.Location = new System.Drawing.Point(93, 365);
            this.btnCmnc.Name = "btnCmnc";
            this.btnCmnc.Size = new System.Drawing.Size(85, 23);
            this.btnCmnc.TabIndex = 46;
            this.btnCmnc.Text = "Commencer";
            this.btnCmnc.UseVisualStyleBackColor = false;
            this.btnCmnc.Click += new System.EventHandler(this.btnCmnc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtxt100
            // 
            this.mtxt100.Location = new System.Drawing.Point(154, 309);
            this.mtxt100.Mask = "999";
            this.mtxt100.Name = "mtxt100";
            this.mtxt100.Size = new System.Drawing.Size(34, 20);
            this.mtxt100.TabIndex = 48;
            this.mtxt100.ValidatingType = typeof(int);
            // 
            // txtmT
            // 
            this.txtmT.Enabled = false;
            this.txtmT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmT.Location = new System.Drawing.Point(140, 274);
            this.txtmT.Name = "txtmT";
            this.txtmT.Size = new System.Drawing.Size(79, 22);
            this.txtmT.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "Montant total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Pourcentage de Formateur:";
            // 
            // txtm
            // 
            this.txtm.Enabled = false;
            this.txtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtm.Location = new System.Drawing.Point(285, 334);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(79, 22);
            this.txtm.TabIndex = 121;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "Montant :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(194, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 123;
            this.label13.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(223, 279);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 127;
            this.label16.Text = "DH";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(370, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 128;
            this.label17.Text = "DH";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 342);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 129;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vider les champs";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmfinannce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 400);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmT);
            this.Controls.Add(this.mtxt100);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCmnc);
            this.Controls.Add(this.gbT);
            this.Controls.Add(this.gbS);
            this.Controls.Add(this.rdbT);
            this.Controls.Add(this.rdbS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmfinannce";
            this.Load += new System.EventHandler(this.frmfinannce_Load);
            this.gbS.ResumeLayout(false);
            this.gbS.PerformLayout();
            this.gbT.ResumeLayout(false);
            this.gbT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbS;
        private System.Windows.Forms.RadioButton rdbT;
        private System.Windows.Forms.GroupBox gbS;
        private System.Windows.Forms.GroupBox gbT;
        private System.Windows.Forms.ComboBox cmbnomprof;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbmatier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbnomgrp;
        private System.Windows.Forms.Label lblnomgrp;
        private System.Windows.Forms.ComboBox cmbProT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnneeT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMatT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCmnc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtxt100;
        private System.Windows.Forms.TextBox txtmT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbannee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombrEleve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbmnth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbmonthpT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}