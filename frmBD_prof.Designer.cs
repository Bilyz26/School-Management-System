namespace prj_ForYou
{
    partial class frmBD_prof
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
            this.btnimporter = new System.Windows.Forms.Button();
            this.btncharger = new System.Windows.Forms.Button();
            this.cmbmatierprof = new System.Windows.Forms.ComboBox();
            this.lblnomprenomprof = new System.Windows.Forms.Label();
            this.lbteleprof = new System.Windows.Forms.Label();
            this.lblniveauP = new System.Windows.Forms.Label();
            this.txtnomprenomprof = new System.Windows.Forms.TextBox();
            this.mtxtteleprof = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnimporter
            // 
            this.btnimporter.Location = new System.Drawing.Point(218, 329);
            this.btnimporter.Name = "btnimporter";
            this.btnimporter.Size = new System.Drawing.Size(75, 23);
            this.btnimporter.TabIndex = 0;
            this.btnimporter.Text = "Importer";
            this.btnimporter.UseVisualStyleBackColor = true;
            this.btnimporter.Click += new System.EventHandler(this.btnimporter_Click);
            // 
            // btncharger
            // 
            this.btncharger.Location = new System.Drawing.Point(404, 329);
            this.btncharger.Name = "btncharger";
            this.btncharger.Size = new System.Drawing.Size(75, 23);
            this.btncharger.TabIndex = 1;
            this.btncharger.Text = "charger";
            this.btncharger.UseVisualStyleBackColor = true;
            this.btncharger.Click += new System.EventHandler(this.btncharger_Click);
            // 
            // cmbmatierprof
            // 
            this.cmbmatierprof.FormattingEnabled = true;
            this.cmbmatierprof.Location = new System.Drawing.Point(383, 197);
            this.cmbmatierprof.Name = "cmbmatierprof";
            this.cmbmatierprof.Size = new System.Drawing.Size(162, 21);
            this.cmbmatierprof.TabIndex = 32;
            // 
            // lblnomprenomprof
            // 
            this.lblnomprenomprof.AutoSize = true;
            this.lblnomprenomprof.Location = new System.Drawing.Point(188, 59);
            this.lblnomprenomprof.Name = "lblnomprenomprof";
            this.lblnomprenomprof.Size = new System.Drawing.Size(154, 13);
            this.lblnomprenomprof.TabIndex = 28;
            this.lblnomprenomprof.Text = "Nom et Prénom de Professeur :";
            // 
            // lbteleprof
            // 
            this.lbteleprof.AutoSize = true;
            this.lbteleprof.BackColor = System.Drawing.Color.White;
            this.lbteleprof.Location = new System.Drawing.Point(188, 127);
            this.lbteleprof.Name = "lbteleprof";
            this.lbteleprof.Size = new System.Drawing.Size(132, 13);
            this.lbteleprof.TabIndex = 29;
            this.lbteleprof.Text = "Telephone de Professeur :";
            // 
            // lblniveauP
            // 
            this.lblniveauP.AutoSize = true;
            this.lblniveauP.Location = new System.Drawing.Point(188, 205);
            this.lblniveauP.Name = "lblniveauP";
            this.lblniveauP.Size = new System.Drawing.Size(110, 13);
            this.lblniveauP.TabIndex = 30;
            this.lblniveauP.Text = "Matier de Professeur :";
            // 
            // txtnomprenomprof
            // 
            this.txtnomprenomprof.Location = new System.Drawing.Point(383, 52);
            this.txtnomprenomprof.Name = "txtnomprenomprof";
            this.txtnomprenomprof.Size = new System.Drawing.Size(162, 20);
            this.txtnomprenomprof.TabIndex = 31;
            // 
            // mtxtteleprof
            // 
            this.mtxtteleprof.Location = new System.Drawing.Point(383, 120);
            this.mtxtteleprof.Mask = "00 00 00 00 00 ";
            this.mtxtteleprof.Name = "mtxtteleprof";
            this.mtxtteleprof.Size = new System.Drawing.Size(162, 20);
            this.mtxtteleprof.TabIndex = 33;
            // 
            // frmBD_prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbmatierprof);
            this.Controls.Add(this.lblnomprenomprof);
            this.Controls.Add(this.lbteleprof);
            this.Controls.Add(this.lblniveauP);
            this.Controls.Add(this.txtnomprenomprof);
            this.Controls.Add(this.mtxtteleprof);
            this.Controls.Add(this.btncharger);
            this.Controls.Add(this.btnimporter);
            this.Name = "frmBD_prof";
            this.Text = "frmBD_prof";
            this.Load += new System.EventHandler(this.frmBD_prof_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimporter;
        private System.Windows.Forms.Button btncharger;
        private System.Windows.Forms.ComboBox cmbmatierprof;
        private System.Windows.Forms.Label lblnomprenomprof;
        private System.Windows.Forms.Label lbteleprof;
        private System.Windows.Forms.Label lblniveauP;
        private System.Windows.Forms.TextBox txtnomprenomprof;
        private System.Windows.Forms.MaskedTextBox mtxtteleprof;
    }
}