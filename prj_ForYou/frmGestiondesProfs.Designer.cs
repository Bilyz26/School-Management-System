namespace prj_ForYou
{
    partial class frmGestiondesProfs
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
            this.mtxtteleprof = new System.Windows.Forms.MaskedTextBox();
            this.cmbmatierprof = new System.Windows.Forms.ComboBox();
            this.txtnomprenomprof = new System.Windows.Forms.TextBox();
            this.lblniveauP = new System.Windows.Forms.Label();
            this.lbteleprof = new System.Windows.Forms.Label();
            this.lblnomprenomprof = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtteleprof
            // 
            this.mtxtteleprof.Location = new System.Drawing.Point(342, 133);
            this.mtxtteleprof.Mask = "00 00 00 00 00 ";
            this.mtxtteleprof.Name = "mtxtteleprof";
            this.mtxtteleprof.Size = new System.Drawing.Size(162, 22);
            this.mtxtteleprof.TabIndex = 27;
            // 
            // cmbmatierprof
            // 
            this.cmbmatierprof.FormattingEnabled = true;
            this.cmbmatierprof.Location = new System.Drawing.Point(342, 210);
            this.cmbmatierprof.Name = "cmbmatierprof";
            this.cmbmatierprof.Size = new System.Drawing.Size(162, 24);
            this.cmbmatierprof.TabIndex = 26;
            // 
            // txtnomprenomprof
            // 
            this.txtnomprenomprof.Location = new System.Drawing.Point(342, 65);
            this.txtnomprenomprof.Name = "txtnomprenomprof";
            this.txtnomprenomprof.Size = new System.Drawing.Size(162, 22);
            this.txtnomprenomprof.TabIndex = 25;
            // 
            // lblniveauP
            // 
            this.lblniveauP.AutoSize = true;
            this.lblniveauP.Location = new System.Drawing.Point(147, 218);
            this.lblniveauP.Name = "lblniveauP";
            this.lblniveauP.Size = new System.Drawing.Size(138, 16);
            this.lblniveauP.TabIndex = 24;
            this.lblniveauP.Text = "Matier de Professeur :";
            // 
            // lbteleprof
            // 
            this.lbteleprof.AutoSize = true;
            this.lbteleprof.BackColor = System.Drawing.Color.White;
            this.lbteleprof.Location = new System.Drawing.Point(147, 140);
            this.lbteleprof.Name = "lbteleprof";
            this.lbteleprof.Size = new System.Drawing.Size(167, 16);
            this.lbteleprof.TabIndex = 23;
            this.lbteleprof.Text = "Telephone de Professeur :";
            // 
            // lblnomprenomprof
            // 
            this.lblnomprenomprof.AutoSize = true;
            this.lblnomprenomprof.Location = new System.Drawing.Point(147, 72);
            this.lblnomprenomprof.Name = "lblnomprenomprof";
            this.lblnomprenomprof.Size = new System.Drawing.Size(194, 16);
            this.lblnomprenomprof.TabIndex = 22;
            this.lblnomprenomprof.Text = "Nom et Prénom de Professeur :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbmatierprof);
            this.groupBox1.Controls.Add(this.lblnomprenomprof);
            this.groupBox1.Controls.Add(this.lbteleprof);
            this.groupBox1.Controls.Add(this.lblniveauP);
            this.groupBox1.Controls.Add(this.txtnomprenomprof);
            this.groupBox1.Controls.Add(this.mtxtteleprof);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 310);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btnQuiter.Location = new System.Drawing.Point(630, 12);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(69, 23);
            this.btnQuiter.TabIndex = 33;
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
            this.btnmodifier.Location = new System.Drawing.Point(385, 424);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmodifier.Size = new System.Drawing.Size(88, 22);
            this.btnmodifier.TabIndex = 105;
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
            this.btnrechercher.Location = new System.Drawing.Point(280, 424);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrechercher.Size = new System.Drawing.Size(90, 22);
            this.btnrechercher.TabIndex = 104;
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
            this.btnAjouter.Location = new System.Drawing.Point(181, 424);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 22);
            this.btnAjouter.TabIndex = 103;
            this.btnAjouter.Text = "Ajouter ";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::prj_ForYou.Properties.Resources._100_16_;
            this.pictureBox3.Location = new System.Drawing.Point(385, 424);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources._100_14_;
            this.pictureBox1.Location = new System.Drawing.Point(181, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox2.Location = new System.Drawing.Point(280, 424);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            // 
            // frmGestiondesProfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 512);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestiondesProfs";
            this.Text = "Gestion des Professeurs :";
            this.Load += new System.EventHandler(this.frmGestiondesProfs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtteleprof;
        private System.Windows.Forms.ComboBox cmbmatierprof;
        private System.Windows.Forms.TextBox txtnomprenomprof;
        private System.Windows.Forms.Label lblniveauP;
        private System.Windows.Forms.Label lbteleprof;
        private System.Windows.Forms.Label lblnomprenomprof;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.Button btnAjouter;
    }
}