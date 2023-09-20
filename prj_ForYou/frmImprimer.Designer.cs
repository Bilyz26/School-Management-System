namespace prj_ForYou
{
    partial class frmImprimer
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmatier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnomprenomprof = new System.Windows.Forms.Label();
            this.lblnomgrp = new System.Windows.Forms.Label();
            this.cmbgroup = new System.Windows.Forms.ComboBox();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.cmbnomprof = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(136, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liste d\'Absence par groupe";
            // 
            // cmbmatier
            // 
            this.cmbmatier.FormattingEnabled = true;
            this.cmbmatier.Location = new System.Drawing.Point(350, 158);
            this.cmbmatier.Name = "cmbmatier";
            this.cmbmatier.Size = new System.Drawing.Size(180, 21);
            this.cmbmatier.TabIndex = 50;
            this.cmbmatier.SelectedIndexChanged += new System.EventHandler(this.cmbmatier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "choisir une Matière :";
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Location = new System.Drawing.Point(350, 213);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(180, 21);
            this.cmbniveau.TabIndex = 92;
            this.cmbniveau.SelectedIndexChanged += new System.EventHandler(this.cmbniveau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Choisir un Niveau :";
            // 
            // lblnomprenomprof
            // 
            this.lblnomprenomprof.AutoSize = true;
            this.lblnomprenomprof.Location = new System.Drawing.Point(166, 315);
            this.lblnomprenomprof.Name = "lblnomprenomprof";
            this.lblnomprenomprof.Size = new System.Drawing.Size(112, 13);
            this.lblnomprenomprof.TabIndex = 89;
            this.lblnomprenomprof.Text = "Choisir un Professeur :";
            // 
            // lblnomgrp
            // 
            this.lblnomgrp.AutoSize = true;
            this.lblnomgrp.Location = new System.Drawing.Point(166, 273);
            this.lblnomgrp.Name = "lblnomgrp";
            this.lblnomgrp.Size = new System.Drawing.Size(100, 13);
            this.lblnomgrp.TabIndex = 87;
            this.lblnomgrp.Text = "Choisir un  Groupe :";
            // 
            // cmbgroup
            // 
            this.cmbgroup.FormattingEnabled = true;
            this.cmbgroup.Location = new System.Drawing.Point(350, 265);
            this.cmbgroup.Name = "cmbgroup";
            this.cmbgroup.Size = new System.Drawing.Size(180, 21);
            this.cmbgroup.TabIndex = 93;
            // 
            // btnimprimer
            // 
            this.btnimprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnimprimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnimprimer.FlatAppearance.BorderSize = 0;
            this.btnimprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnimprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimer.ForeColor = System.Drawing.Color.White;
            this.btnimprimer.Location = new System.Drawing.Point(250, 394);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(154, 23);
            this.btnimprimer.TabIndex = 94;
            this.btnimprimer.Text = "Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = false;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
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
            this.btnQuiter.TabIndex = 95;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = false;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Choisir l\'Année";
            // 
            // cmbannee
            // 
            this.cmbannee.FormattingEnabled = true;
            this.cmbannee.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.cmbannee.Location = new System.Drawing.Point(350, 347);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(180, 21);
            this.cmbannee.TabIndex = 97;
            // 
            // cmbnomprof
            // 
            this.cmbnomprof.FormattingEnabled = true;
            this.cmbnomprof.Location = new System.Drawing.Point(350, 307);
            this.cmbnomprof.Name = "cmbnomprof";
            this.cmbnomprof.Size = new System.Drawing.Size(180, 21);
            this.cmbnomprof.TabIndex = 98;
            // 
            // frmImprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 512);
            this.Controls.Add(this.cmbnomprof);
            this.Controls.Add(this.cmbannee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.cmbgroup);
            this.Controls.Add(this.cmbniveau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnomprenomprof);
            this.Controls.Add(this.lblnomgrp);
            this.Controls.Add(this.cmbmatier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImprimer";
            this.Text = "frmImprimer";
            this.Load += new System.EventHandler(this.frmImprimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmatier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnomprenomprof;
        private System.Windows.Forms.Label lblnomgrp;
        private System.Windows.Forms.ComboBox cmbgroup;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbannee;
        private System.Windows.Forms.ComboBox cmbnomprof;
    }
}