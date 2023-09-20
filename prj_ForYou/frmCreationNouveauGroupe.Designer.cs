namespace prj_ForYou
{
    partial class frmCreationNouveauGroupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreationNouveauGroupe));
            this.lblnomgrp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomgroup = new System.Windows.Forms.TextBox();
            this.cmbmatier = new System.Windows.Forms.ComboBox();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnomgrp
            // 
            this.lblnomgrp.AutoSize = true;
            this.lblnomgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomgrp.Location = new System.Drawing.Point(109, 33);
            this.lblnomgrp.Name = "lblnomgrp";
            this.lblnomgrp.Size = new System.Drawing.Size(160, 16);
            this.lblnomgrp.TabIndex = 0;
            this.lblnomgrp.Text = "Saisir le Nom du Groupe :";
            this.lblnomgrp.Click += new System.EventHandler(this.lblnomgrp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = " Choisir Un Niveau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisir Une Matièere";
            // 
            // txtnomgroup
            // 
            this.txtnomgroup.Location = new System.Drawing.Point(287, 29);
            this.txtnomgroup.Name = "txtnomgroup";
            this.txtnomgroup.Size = new System.Drawing.Size(180, 20);
            this.txtnomgroup.TabIndex = 4;
            this.txtnomgroup.TextChanged += new System.EventHandler(this.txtnomgroup_TextChanged);
            // 
            // cmbmatier
            // 
            this.cmbmatier.FormattingEnabled = true;
            this.cmbmatier.Location = new System.Drawing.Point(287, 71);
            this.cmbmatier.Name = "cmbmatier";
            this.cmbmatier.Size = new System.Drawing.Size(180, 21);
            this.cmbmatier.TabIndex = 43;
            this.cmbmatier.SelectedIndexChanged += new System.EventHandler(this.cmbmatier_SelectedIndexChanged);
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Location = new System.Drawing.Point(287, 115);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(180, 21);
            this.cmbniveau.TabIndex = 44;
            this.cmbniveau.SelectedIndexChanged += new System.EventHandler(this.cmbniveau_SelectedIndexChanged);
            // 
            // btnQuiter
            // 
            this.btnQuiter.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderSize = 0;
            this.btnQuiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnQuiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiter.ForeColor = System.Drawing.Color.White;
            this.btnQuiter.Location = new System.Drawing.Point(562, 21);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(69, 23);
            this.btnQuiter.TabIndex = 45;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = false;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.DarkRed;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(340, 171);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 22);
            this.btnAjouter.TabIndex = 95;
            this.btnAjouter.Text = "Crée ";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources._100_14_;
            this.pictureBox1.Location = new System.Drawing.Point(340, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // frmCreationNouveauGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.cmbniveau);
            this.Controls.Add(this.cmbmatier);
            this.Controls.Add(this.txtnomgroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnomgrp);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreationNouveauGroupe";
            this.Load += new System.EventHandler(this.frmCreationNouveauGroupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnomgrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomgroup;
        private System.Windows.Forms.ComboBox cmbmatier;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAjouter;
    }
}