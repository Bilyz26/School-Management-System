namespace prj_ForYou
{
    partial class frmExplorer
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
            this.gbemplelev = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbanneee = new System.Windows.Forms.ComboBox();
            this.txtnomprenomeleve = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnrechercher_emplpareleve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbgroup = new System.Windows.Forms.ComboBox();
            this.lblnomgrp = new System.Windows.Forms.Label();
            this.gbemplgrp = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbgrp = new System.Windows.Forms.ComboBox();
            this.btnrechercher_emplpargrp = new System.Windows.Forms.Button();
            this.cmbprof = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbniv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbmat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rbeleve = new System.Windows.Forms.RadioButton();
            this.rbgroupe = new System.Windows.Forms.RadioButton();
            this.gbemploie = new System.Windows.Forms.GroupBox();
            this.txtcinornom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbrecgerche = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnrech = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbemplelev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbemplgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbemploie.SuspendLayout();
            this.gbrecgerche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbemplelev
            // 
            this.gbemplelev.Controls.Add(this.pictureBox3);
            this.gbemplelev.Controls.Add(this.label11);
            this.gbemplelev.Controls.Add(this.label9);
            this.gbemplelev.Controls.Add(this.cmbanneee);
            this.gbemplelev.Controls.Add(this.txtnomprenomeleve);
            this.gbemplelev.Controls.Add(this.pictureBox2);
            this.gbemplelev.Controls.Add(this.btnrechercher_emplpareleve);
            this.gbemplelev.Controls.Add(this.label2);
            this.gbemplelev.Controls.Add(this.cmbgroup);
            this.gbemplelev.Controls.Add(this.lblnomgrp);
            this.gbemplelev.Location = new System.Drawing.Point(636, 282);
            this.gbemplelev.Name = "gbemplelev";
            this.gbemplelev.Size = new System.Drawing.Size(316, 218);
            this.gbemplelev.TabIndex = 3;
            this.gbemplelev.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::prj_ForYou.Properties.Resources._1opp;
            this.pictureBox3.Location = new System.Drawing.Point(264, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 116;
            this.label11.Text = "Vider ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Choisir l\'Année";
            // 
            // cmbanneee
            // 
            this.cmbanneee.FormattingEnabled = true;
            this.cmbanneee.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.cmbanneee.Location = new System.Drawing.Point(130, 77);
            this.cmbanneee.Name = "cmbanneee";
            this.cmbanneee.Size = new System.Drawing.Size(180, 21);
            this.cmbanneee.TabIndex = 115;
            this.cmbanneee.SelectedIndexChanged += new System.EventHandler(this.cmbanneee_SelectedIndexChanged);
            // 
            // txtnomprenomeleve
            // 
            this.txtnomprenomeleve.Enabled = false;
            this.txtnomprenomeleve.Location = new System.Drawing.Point(130, 36);
            this.txtnomprenomeleve.Name = "txtnomprenomeleve";
            this.txtnomprenomeleve.Size = new System.Drawing.Size(182, 20);
            this.txtnomprenomeleve.TabIndex = 113;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox2.Location = new System.Drawing.Point(89, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // btnrechercher_emplpareleve
            // 
            this.btnrechercher_emplpareleve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrechercher_emplpareleve.BackColor = System.Drawing.Color.DarkRed;
            this.btnrechercher_emplpareleve.FlatAppearance.BorderSize = 0;
            this.btnrechercher_emplpareleve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnrechercher_emplpareleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrechercher_emplpareleve.ForeColor = System.Drawing.Color.White;
            this.btnrechercher_emplpareleve.Location = new System.Drawing.Point(89, 181);
            this.btnrechercher_emplpareleve.Name = "btnrechercher_emplpareleve";
            this.btnrechercher_emplpareleve.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrechercher_emplpareleve.Size = new System.Drawing.Size(105, 22);
            this.btnrechercher_emplpareleve.TabIndex = 110;
            this.btnrechercher_emplpareleve.Text = "Rechercher ";
            this.btnrechercher_emplpareleve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrechercher_emplpareleve.UseVisualStyleBackColor = false;
            this.btnrechercher_emplpareleve.Click += new System.EventHandler(this.btnrechercher_emplpareleve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nom et Prénom d\'élève :";
            // 
            // cmbgroup
            // 
            this.cmbgroup.FormattingEnabled = true;
            this.cmbgroup.Location = new System.Drawing.Point(130, 130);
            this.cmbgroup.Name = "cmbgroup";
            this.cmbgroup.Size = new System.Drawing.Size(180, 21);
            this.cmbgroup.TabIndex = 105;
            // 
            // lblnomgrp
            // 
            this.lblnomgrp.AutoSize = true;
            this.lblnomgrp.Location = new System.Drawing.Point(3, 138);
            this.lblnomgrp.Name = "lblnomgrp";
            this.lblnomgrp.Size = new System.Drawing.Size(100, 13);
            this.lblnomgrp.TabIndex = 101;
            this.lblnomgrp.Text = "Choisir un  Groupe :";
            // 
            // gbemplgrp
            // 
            this.gbemplgrp.Controls.Add(this.pictureBox5);
            this.gbemplgrp.Controls.Add(this.label10);
            this.gbemplgrp.Controls.Add(this.cmbannee);
            this.gbemplgrp.Controls.Add(this.label4);
            this.gbemplgrp.Controls.Add(this.pictureBox1);
            this.gbemplgrp.Controls.Add(this.cmbgrp);
            this.gbemplgrp.Controls.Add(this.btnrechercher_emplpargrp);
            this.gbemplgrp.Controls.Add(this.cmbprof);
            this.gbemplgrp.Controls.Add(this.label5);
            this.gbemplgrp.Controls.Add(this.label6);
            this.gbemplgrp.Controls.Add(this.cmbniv);
            this.gbemplgrp.Controls.Add(this.label7);
            this.gbemplgrp.Controls.Add(this.cmbmat);
            this.gbemplgrp.Controls.Add(this.label8);
            this.gbemplgrp.Location = new System.Drawing.Point(558, 12);
            this.gbemplgrp.Name = "gbemplgrp";
            this.gbemplgrp.Size = new System.Drawing.Size(316, 218);
            this.gbemplgrp.TabIndex = 109;
            this.gbemplgrp.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::prj_ForYou.Properties.Resources._1opp;
            this.pictureBox5.Location = new System.Drawing.Point(251, 175);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 115;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(217, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 114;
            this.label10.Text = "Vider ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbannee
            // 
            this.cmbannee.FormattingEnabled = true;
            this.cmbannee.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.cmbannee.Location = new System.Drawing.Point(133, 104);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(180, 21);
            this.cmbannee.TabIndex = 113;
            this.cmbannee.SelectedIndexChanged += new System.EventHandler(this.cmbannee_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Choisir l\'Année";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox1.Location = new System.Drawing.Point(93, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // cmbgrp
            // 
            this.cmbgrp.FormattingEnabled = true;
            this.cmbgrp.Location = new System.Drawing.Point(133, 130);
            this.cmbgrp.Name = "cmbgrp";
            this.cmbgrp.Size = new System.Drawing.Size(180, 21);
            this.cmbgrp.TabIndex = 105;
            // 
            // btnrechercher_emplpargrp
            // 
            this.btnrechercher_emplpargrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrechercher_emplpargrp.BackColor = System.Drawing.Color.DarkRed;
            this.btnrechercher_emplpargrp.FlatAppearance.BorderSize = 0;
            this.btnrechercher_emplpargrp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnrechercher_emplpargrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrechercher_emplpargrp.ForeColor = System.Drawing.Color.White;
            this.btnrechercher_emplpargrp.Location = new System.Drawing.Point(93, 174);
            this.btnrechercher_emplpargrp.Name = "btnrechercher_emplpargrp";
            this.btnrechercher_emplpargrp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrechercher_emplpargrp.Size = new System.Drawing.Size(105, 22);
            this.btnrechercher_emplpargrp.TabIndex = 110;
            this.btnrechercher_emplpargrp.Text = "Rechercher ";
            this.btnrechercher_emplpargrp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrechercher_emplpargrp.UseVisualStyleBackColor = false;
            this.btnrechercher_emplpargrp.Click += new System.EventHandler(this.btnrechercher_emplpargrp_Click);
            // 
            // cmbprof
            // 
            this.cmbprof.FormattingEnabled = true;
            this.cmbprof.Location = new System.Drawing.Point(133, 77);
            this.cmbprof.Name = "cmbprof";
            this.cmbprof.Size = new System.Drawing.Size(180, 21);
            this.cmbprof.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "choisir une Matière :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Choisir un Niveau :";
            // 
            // cmbniv
            // 
            this.cmbniv.FormattingEnabled = true;
            this.cmbniv.Location = new System.Drawing.Point(133, 51);
            this.cmbniv.Name = "cmbniv";
            this.cmbniv.Size = new System.Drawing.Size(180, 21);
            this.cmbniv.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Choisir un  Groupe :";
            // 
            // cmbmat
            // 
            this.cmbmat.FormattingEnabled = true;
            this.cmbmat.Location = new System.Drawing.Point(133, 24);
            this.cmbmat.Name = "cmbmat";
            this.cmbmat.Size = new System.Drawing.Size(182, 21);
            this.cmbmat.TabIndex = 100;
            this.cmbmat.SelectedIndexChanged += new System.EventHandler(this.cmbmat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Choisir un Professeur :";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(111, 354);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(471, 146);
            this.dgv.TabIndex = 112;
            // 
            // rbeleve
            // 
            this.rbeleve.AutoSize = true;
            this.rbeleve.Location = new System.Drawing.Point(7, 19);
            this.rbeleve.Name = "rbeleve";
            this.rbeleve.Size = new System.Drawing.Size(51, 17);
            this.rbeleve.TabIndex = 0;
            this.rbeleve.TabStop = true;
            this.rbeleve.Text = "élève";
            this.rbeleve.UseVisualStyleBackColor = true;
            this.rbeleve.CheckedChanged += new System.EventHandler(this.rbeleve_CheckedChanged);
            // 
            // rbgroupe
            // 
            this.rbgroupe.AutoSize = true;
            this.rbgroupe.Location = new System.Drawing.Point(144, 19);
            this.rbgroupe.Name = "rbgroupe";
            this.rbgroupe.Size = new System.Drawing.Size(58, 17);
            this.rbgroupe.TabIndex = 1;
            this.rbgroupe.TabStop = true;
            this.rbgroupe.Text = "groupe";
            this.rbgroupe.UseVisualStyleBackColor = true;
            this.rbgroupe.CheckedChanged += new System.EventHandler(this.rbgroupe_CheckedChanged);
            // 
            // gbemploie
            // 
            this.gbemploie.Controls.Add(this.rbgroupe);
            this.gbemploie.Controls.Add(this.rbeleve);
            this.gbemploie.Location = new System.Drawing.Point(210, 12);
            this.gbemploie.Name = "gbemploie";
            this.gbemploie.Size = new System.Drawing.Size(246, 46);
            this.gbemploie.TabIndex = 2;
            this.gbemploie.TabStop = false;
            this.gbemploie.Text = "l\'emploie du temps :";
            // 
            // txtcinornom
            // 
            this.txtcinornom.Location = new System.Drawing.Point(145, 14);
            this.txtcinornom.Name = "txtcinornom";
            this.txtcinornom.Size = new System.Drawing.Size(182, 20);
            this.txtcinornom.TabIndex = 119;
            this.txtcinornom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcinornom_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 118;
            this.label12.Text = "choisir un élève :";
            // 
            // gbrecgerche
            // 
            this.gbrecgerche.Controls.Add(this.pictureBox4);
            this.gbrecgerche.Controls.Add(this.label12);
            this.gbrecgerche.Controls.Add(this.btnrech);
            this.gbrecgerche.Controls.Add(this.txtcinornom);
            this.gbrecgerche.Location = new System.Drawing.Point(129, 307);
            this.gbrecgerche.Name = "gbrecgerche";
            this.gbrecgerche.Size = new System.Drawing.Size(453, 41);
            this.gbrecgerche.TabIndex = 120;
            this.gbrecgerche.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox4.Location = new System.Drawing.Point(342, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 119;
            this.pictureBox4.TabStop = false;
            // 
            // btnrech
            // 
            this.btnrech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrech.BackColor = System.Drawing.Color.DarkRed;
            this.btnrech.FlatAppearance.BorderSize = 0;
            this.btnrech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnrech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrech.ForeColor = System.Drawing.Color.White;
            this.btnrech.Location = new System.Drawing.Point(342, 9);
            this.btnrech.Name = "btnrech";
            this.btnrech.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrech.Size = new System.Drawing.Size(105, 22);
            this.btnrech.TabIndex = 118;
            this.btnrech.Text = "Rechercher ";
            this.btnrech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrech.UseVisualStyleBackColor = false;
            this.btnrech.Click += new System.EventHandler(this.btnrech_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(58, 46);
            this.dataGridView1.TabIndex = 120;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbrecgerche);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbemplgrp);
            this.Controls.Add(this.gbemplelev);
            this.Controls.Add(this.gbemploie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExplorer";
            this.Load += new System.EventHandler(this.frmExplorer_Load);
            this.gbemplelev.ResumeLayout(false);
            this.gbemplelev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbemplgrp.ResumeLayout(false);
            this.gbemplgrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbemploie.ResumeLayout(false);
            this.gbemploie.PerformLayout();
            this.gbrecgerche.ResumeLayout(false);
            this.gbrecgerche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbemplelev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbgroup;
        private System.Windows.Forms.Label lblnomgrp;
        private System.Windows.Forms.GroupBox gbemplgrp;
        private System.Windows.Forms.ComboBox cmbgrp;
        private System.Windows.Forms.ComboBox cmbprof;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbniv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbmat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrechercher_emplpareleve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrechercher_emplpargrp;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtnomprenomeleve;
        private System.Windows.Forms.ComboBox cmbannee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbanneee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbeleve;
        private System.Windows.Forms.RadioButton rbgroupe;
        private System.Windows.Forms.GroupBox gbemploie;
        private System.Windows.Forms.TextBox txtcinornom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbrecgerche;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnrech;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}