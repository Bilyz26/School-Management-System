namespace prj_ForYou
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelFormes = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnaide = new System.Windows.Forms.Button();
            this.btnimpression = new System.Windows.Forms.Button();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.btnseance = new System.Windows.Forms.Button();
            this.btnmatier = new System.Windows.Forms.Button();
            this.btngrp = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panelAdministration = new System.Windows.Forms.Panel();
            this.btnfrmemp = new System.Windows.Forms.Button();
            this.btnfrmprof = new System.Windows.Forms.Button();
            this.btnAdministration = new System.Windows.Forms.Button();
            this.btnFrmpay = new System.Windows.Forms.Button();
            this.btnFrmRaff = new System.Windows.Forms.Button();
            this.btnFrmIncription = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFormes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelAdministration.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormes
            // 
            this.panelFormes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormes.BackColor = System.Drawing.Color.Transparent;
            this.panelFormes.Controls.Add(this.pictureBox1);
            this.panelFormes.Location = new System.Drawing.Point(220, 0);
            this.panelFormes.Name = "panelFormes";
            this.panelFormes.Size = new System.Drawing.Size(709, 508);
            this.panelFormes.TabIndex = 3;
            this.panelFormes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormes_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources._1645492648277;
            this.pictureBox1.Location = new System.Drawing.Point(115, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnaide);
            this.panelMenu.Controls.Add(this.btnimpression);
            this.panelMenu.Controls.Add(this.btnExplorer);
            this.panelMenu.Controls.Add(this.panelGeneral);
            this.panelMenu.Controls.Add(this.btnGeneral);
            this.panelMenu.Controls.Add(this.panelAdministration);
            this.panelMenu.Controls.Add(this.btnAdministration);
            this.panelMenu.Controls.Add(this.btnFrmpay);
            this.panelMenu.Controls.Add(this.btnFrmRaff);
            this.panelMenu.Controls.Add(this.btnFrmIncription);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 508);
            this.panelMenu.TabIndex = 2;
            // 
            // btnaide
            // 
            this.btnaide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaide.FlatAppearance.BorderSize = 0;
            this.btnaide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnaide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnaide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaide.ForeColor = System.Drawing.Color.Transparent;
            this.btnaide.Location = new System.Drawing.Point(0, 595);
            this.btnaide.Name = "btnaide";
            this.btnaide.Size = new System.Drawing.Size(203, 40);
            this.btnaide.TabIndex = 11;
            this.btnaide.Text = "Aide";
            this.btnaide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaide.UseVisualStyleBackColor = true;
            this.btnaide.Click += new System.EventHandler(this.btnaide_Click);
            this.btnaide.MouseLeave += new System.EventHandler(this.btnaide_MouseLeave);
            this.btnaide.MouseHover += new System.EventHandler(this.btnaide_MouseHover);
            // 
            // btnimpression
            // 
            this.btnimpression.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnimpression.FlatAppearance.BorderSize = 0;
            this.btnimpression.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnimpression.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnimpression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimpression.ForeColor = System.Drawing.Color.Transparent;
            this.btnimpression.Location = new System.Drawing.Point(0, 555);
            this.btnimpression.Name = "btnimpression";
            this.btnimpression.Size = new System.Drawing.Size(203, 40);
            this.btnimpression.TabIndex = 10;
            this.btnimpression.Text = "Impression";
            this.btnimpression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimpression.UseVisualStyleBackColor = true;
            this.btnimpression.Click += new System.EventHandler(this.btnimpression_Click);
            this.btnimpression.MouseLeave += new System.EventHandler(this.btnimpression_MouseLeave);
            this.btnimpression.MouseHover += new System.EventHandler(this.btnimpression_MouseHover);
            // 
            // btnExplorer
            // 
            this.btnExplorer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExplorer.FlatAppearance.BorderSize = 0;
            this.btnExplorer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorer.ForeColor = System.Drawing.Color.Transparent;
            this.btnExplorer.Location = new System.Drawing.Point(0, 516);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(203, 39);
            this.btnExplorer.TabIndex = 9;
            this.btnExplorer.Text = "Emploie Du Temps";
            this.btnExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            this.btnExplorer.MouseLeave += new System.EventHandler(this.btnExplorer_MouseLeave);
            this.btnExplorer.MouseHover += new System.EventHandler(this.btnExplorer_MouseHover);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.btnseance);
            this.panelGeneral.Controls.Add(this.btnmatier);
            this.panelGeneral.Controls.Add(this.btngrp);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 397);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(203, 119);
            this.panelGeneral.TabIndex = 8;
            // 
            // btnseance
            // 
            this.btnseance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btnseance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnseance.FlatAppearance.BorderSize = 0;
            this.btnseance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnseance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseance.ForeColor = System.Drawing.Color.Transparent;
            this.btnseance.Location = new System.Drawing.Point(0, 80);
            this.btnseance.Name = "btnseance";
            this.btnseance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnseance.Size = new System.Drawing.Size(203, 40);
            this.btnseance.TabIndex = 9;
            this.btnseance.Text = "Gestion des Séances";
            this.btnseance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseance.UseVisualStyleBackColor = false;
            this.btnseance.Click += new System.EventHandler(this.btnseance_Click);
            this.btnseance.MouseLeave += new System.EventHandler(this.btnseance_MouseLeave);
            this.btnseance.MouseHover += new System.EventHandler(this.btnseance_MouseHover);
            // 
            // btnmatier
            // 
            this.btnmatier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btnmatier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmatier.FlatAppearance.BorderSize = 0;
            this.btnmatier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnmatier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatier.ForeColor = System.Drawing.Color.Transparent;
            this.btnmatier.Location = new System.Drawing.Point(0, 40);
            this.btnmatier.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnmatier.Name = "btnmatier";
            this.btnmatier.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnmatier.Size = new System.Drawing.Size(203, 40);
            this.btnmatier.TabIndex = 8;
            this.btnmatier.Text = "Gestion des matières";
            this.btnmatier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmatier.UseVisualStyleBackColor = false;
            this.btnmatier.Click += new System.EventHandler(this.btnmatier_Click);
            this.btnmatier.MouseLeave += new System.EventHandler(this.btnmatier_MouseLeave);
            this.btnmatier.MouseHover += new System.EventHandler(this.btnmatier_MouseHover);
            // 
            // btngrp
            // 
            this.btngrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btngrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngrp.FlatAppearance.BorderSize = 0;
            this.btngrp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btngrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrp.ForeColor = System.Drawing.Color.Transparent;
            this.btngrp.Location = new System.Drawing.Point(0, 0);
            this.btngrp.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btngrp.Name = "btngrp";
            this.btngrp.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btngrp.Size = new System.Drawing.Size(203, 40);
            this.btngrp.TabIndex = 6;
            this.btngrp.Text = "Gestion des group";
            this.btngrp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrp.UseVisualStyleBackColor = false;
            this.btngrp.Click += new System.EventHandler(this.btngrp_Click);
            this.btngrp.MouseLeave += new System.EventHandler(this.btngrp_MouseLeave);
            this.btngrp.MouseHover += new System.EventHandler(this.btngrp_MouseHover);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGeneral.Location = new System.Drawing.Point(0, 357);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(203, 40);
            this.btnGeneral.TabIndex = 7;
            this.btnGeneral.Text = "Général";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            this.btnGeneral.MouseLeave += new System.EventHandler(this.btnGeneral_MouseLeave);
            this.btnGeneral.MouseHover += new System.EventHandler(this.btnGeneral_MouseHover);
            // 
            // panelAdministration
            // 
            this.panelAdministration.Controls.Add(this.btnfrmemp);
            this.panelAdministration.Controls.Add(this.btnfrmprof);
            this.panelAdministration.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdministration.Location = new System.Drawing.Point(0, 275);
            this.panelAdministration.Name = "panelAdministration";
            this.panelAdministration.Size = new System.Drawing.Size(203, 82);
            this.panelAdministration.TabIndex = 6;
            // 
            // btnfrmemp
            // 
            this.btnfrmemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btnfrmemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfrmemp.FlatAppearance.BorderSize = 0;
            this.btnfrmemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnfrmemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfrmemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmemp.ForeColor = System.Drawing.Color.Transparent;
            this.btnfrmemp.Location = new System.Drawing.Point(0, 40);
            this.btnfrmemp.Name = "btnfrmemp";
            this.btnfrmemp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnfrmemp.Size = new System.Drawing.Size(203, 40);
            this.btnfrmemp.TabIndex = 7;
            this.btnfrmemp.Text = "Gestion des employés";
            this.btnfrmemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmemp.UseVisualStyleBackColor = false;
            this.btnfrmemp.Click += new System.EventHandler(this.btnfrmemp_Click);
            this.btnfrmemp.MouseLeave += new System.EventHandler(this.btnfrmemp_MouseLeave);
            this.btnfrmemp.MouseHover += new System.EventHandler(this.btnfrmemp_MouseHover);
            // 
            // btnfrmprof
            // 
            this.btnfrmprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btnfrmprof.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfrmprof.FlatAppearance.BorderSize = 0;
            this.btnfrmprof.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnfrmprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfrmprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmprof.ForeColor = System.Drawing.Color.Transparent;
            this.btnfrmprof.Location = new System.Drawing.Point(0, 0);
            this.btnfrmprof.Name = "btnfrmprof";
            this.btnfrmprof.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnfrmprof.Size = new System.Drawing.Size(203, 40);
            this.btnfrmprof.TabIndex = 6;
            this.btnfrmprof.Text = "Gestion des professeurs";
            this.btnfrmprof.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmprof.UseVisualStyleBackColor = false;
            this.btnfrmprof.Click += new System.EventHandler(this.btnfrmprof_Click);
            this.btnfrmprof.MouseLeave += new System.EventHandler(this.btnfrmprof_MouseLeave);
            this.btnfrmprof.MouseHover += new System.EventHandler(this.btnfrmprof_MouseHover);
            // 
            // btnAdministration
            // 
            this.btnAdministration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministration.FlatAppearance.BorderSize = 0;
            this.btnAdministration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministration.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdministration.Location = new System.Drawing.Point(0, 235);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(203, 40);
            this.btnAdministration.TabIndex = 5;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            this.btnAdministration.MouseLeave += new System.EventHandler(this.btnAdministration_MouseLeave);
            this.btnAdministration.MouseHover += new System.EventHandler(this.btnAdministration_MouseHover);
            // 
            // btnFrmpay
            // 
            this.btnFrmpay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmpay.FlatAppearance.BorderSize = 0;
            this.btnFrmpay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFrmpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmpay.ForeColor = System.Drawing.Color.Transparent;
            this.btnFrmpay.Location = new System.Drawing.Point(0, 195);
            this.btnFrmpay.Name = "btnFrmpay";
            this.btnFrmpay.Size = new System.Drawing.Size(203, 40);
            this.btnFrmpay.TabIndex = 3;
            this.btnFrmpay.Text = "Gestion des paiement";
            this.btnFrmpay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmpay.UseVisualStyleBackColor = true;
            this.btnFrmpay.Click += new System.EventHandler(this.btnFrmpay_Click);
            this.btnFrmpay.MouseLeave += new System.EventHandler(this.btnFrmpay_MouseLeave);
            this.btnFrmpay.MouseHover += new System.EventHandler(this.btnFrmpay_MouseHover);
            // 
            // btnFrmRaff
            // 
            this.btnFrmRaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmRaff.FlatAppearance.BorderSize = 0;
            this.btnFrmRaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFrmRaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmRaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmRaff.ForeColor = System.Drawing.Color.White;
            this.btnFrmRaff.Location = new System.Drawing.Point(0, 140);
            this.btnFrmRaff.Name = "btnFrmRaff";
            this.btnFrmRaff.Size = new System.Drawing.Size(203, 55);
            this.btnFrmRaff.TabIndex = 2;
            this.btnFrmRaff.Text = "Ajouter un élève à un group";
            this.btnFrmRaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmRaff.UseVisualStyleBackColor = true;
            this.btnFrmRaff.Click += new System.EventHandler(this.btnFrmRaff_Click);
            this.btnFrmRaff.MouseLeave += new System.EventHandler(this.btnFrmRaff_MouseLeave);
            this.btnFrmRaff.MouseHover += new System.EventHandler(this.btnFrmRaff_MouseHover);
            // 
            // btnFrmIncription
            // 
            this.btnFrmIncription.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmIncription.FlatAppearance.BorderSize = 0;
            this.btnFrmIncription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnFrmIncription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFrmIncription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmIncription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmIncription.ForeColor = System.Drawing.Color.White;
            this.btnFrmIncription.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFrmIncription.Location = new System.Drawing.Point(0, 100);
            this.btnFrmIncription.Name = "btnFrmIncription";
            this.btnFrmIncription.Size = new System.Drawing.Size(203, 40);
            this.btnFrmIncription.TabIndex = 1;
            this.btnFrmIncription.Text = "Inscription";
            this.btnFrmIncription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmIncription.UseVisualStyleBackColor = true;
            this.btnFrmIncription.Click += new System.EventHandler(this.btnFrmIncription_Click);
            this.btnFrmIncription.MouseLeave += new System.EventHandler(this.btnFrmIncription_MouseLeave);
            this.btnFrmIncription.MouseHover += new System.EventHandler(this.btnFrmIncription_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FOR YOU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prj_ForYou.Properties.Resources._1645492648277;
            this.pictureBox2.Location = new System.Drawing.Point(43, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 508);
            this.Controls.Add(this.panelFormes);
            this.Controls.Add(this.panelMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(945, 547);
            this.Name = "FrmMenu";
            this.Text = "Bienvenue à FOR YOU";
            this.MaximumSizeChanged += new System.EventHandler(this.FrmMenu_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelFormes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelAdministration.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnimpression;
        private System.Windows.Forms.Button btnExplorer;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button btnseance;
        private System.Windows.Forms.Button btnmatier;
        private System.Windows.Forms.Button btngrp;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Panel panelAdministration;
        private System.Windows.Forms.Button btnfrmemp;
        private System.Windows.Forms.Button btnfrmprof;
        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Button btnFrmpay;
        private System.Windows.Forms.Button btnFrmRaff;
        private System.Windows.Forms.Button btnFrmIncription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnaide;
    }
}