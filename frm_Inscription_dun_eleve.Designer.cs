namespace prj_ForYou
{
    partial class frm_Inscription_dun_eleve
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
            this.gbeleve = new System.Windows.Forms.GroupBox();
            this.txtfrinscr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcin = new System.Windows.Forms.CheckBox();
            this.mtxtteleleve = new System.Windows.Forms.MaskedTextBox();
            this.dtpdatedebut = new System.Windows.Forms.DateTimePicker();
            this.txtnomprenomeleve = new System.Windows.Forms.TextBox();
            this.txtcineleve = new System.Windows.Forms.TextBox();
            this.lbldatedebut = new System.Windows.Forms.Label();
            this.lblteleleve = new System.Windows.Forms.Label();
            this.lblnomprenomeleve = new System.Windows.Forms.Label();
            this.lblcineleve = new System.Windows.Forms.Label();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbeleve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbeleve
            // 
            this.gbeleve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbeleve.Controls.Add(this.txtfrinscr);
            this.gbeleve.Controls.Add(this.label1);
            this.gbeleve.Controls.Add(this.cbcin);
            this.gbeleve.Controls.Add(this.mtxtteleleve);
            this.gbeleve.Controls.Add(this.dtpdatedebut);
            this.gbeleve.Controls.Add(this.txtnomprenomeleve);
            this.gbeleve.Controls.Add(this.txtcineleve);
            this.gbeleve.Controls.Add(this.lbldatedebut);
            this.gbeleve.Controls.Add(this.lblteleleve);
            this.gbeleve.Controls.Add(this.lblnomprenomeleve);
            this.gbeleve.Controls.Add(this.lblcineleve);
            this.gbeleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbeleve.ForeColor = System.Drawing.Color.Black;
            this.gbeleve.Location = new System.Drawing.Point(85, 42);
            this.gbeleve.Name = "gbeleve";
            this.gbeleve.Size = new System.Drawing.Size(488, 335);
            this.gbeleve.TabIndex = 2;
            this.gbeleve.TabStop = false;
            this.gbeleve.Enter += new System.EventHandler(this.gbeleve_Enter);
            // 
            // txtfrinscr
            // 
            this.txtfrinscr.Location = new System.Drawing.Point(219, 214);
            this.txtfrinscr.Name = "txtfrinscr";
            this.txtfrinscr.Size = new System.Drawing.Size(200, 22);
            this.txtfrinscr.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Frais d\'Inscription :";
            // 
            // cbcin
            // 
            this.cbcin.AutoSize = true;
            this.cbcin.FlatAppearance.BorderSize = 0;
            this.cbcin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcin.Location = new System.Drawing.Point(219, 28);
            this.cbcin.Name = "cbcin";
            this.cbcin.Size = new System.Drawing.Size(83, 19);
            this.cbcin.TabIndex = 13;
            this.cbcin.Text = "Cin Parent";
            this.cbcin.UseVisualStyleBackColor = true;
            // 
            // mtxtteleleve
            // 
            this.mtxtteleleve.Location = new System.Drawing.Point(219, 164);
            this.mtxtteleleve.Mask = "00 00 00 00 00 ";
            this.mtxtteleleve.Name = "mtxtteleleve";
            this.mtxtteleleve.Size = new System.Drawing.Size(200, 22);
            this.mtxtteleleve.TabIndex = 10;
            // 
            // dtpdatedebut
            // 
            this.dtpdatedebut.Location = new System.Drawing.Point(219, 250);
            this.dtpdatedebut.Name = "dtpdatedebut";
            this.dtpdatedebut.Size = new System.Drawing.Size(200, 22);
            this.dtpdatedebut.TabIndex = 8;
            // 
            // txtnomprenomeleve
            // 
            this.txtnomprenomeleve.Location = new System.Drawing.Point(219, 115);
            this.txtnomprenomeleve.Name = "txtnomprenomeleve";
            this.txtnomprenomeleve.Size = new System.Drawing.Size(200, 22);
            this.txtnomprenomeleve.TabIndex = 6;
            // 
            // txtcineleve
            // 
            this.txtcineleve.Location = new System.Drawing.Point(219, 61);
            this.txtcineleve.Name = "txtcineleve";
            this.txtcineleve.Size = new System.Drawing.Size(200, 22);
            this.txtcineleve.TabIndex = 5;
            // 
            // lbldatedebut
            // 
            this.lbldatedebut.AutoSize = true;
            this.lbldatedebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatedebut.Location = new System.Drawing.Point(27, 256);
            this.lbldatedebut.Name = "lbldatedebut";
            this.lbldatedebut.Size = new System.Drawing.Size(82, 16);
            this.lbldatedebut.TabIndex = 4;
            this.lbldatedebut.Text = "Date Début :";
            // 
            // lblteleleve
            // 
            this.lblteleleve.AutoSize = true;
            this.lblteleleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteleleve.Location = new System.Drawing.Point(27, 171);
            this.lblteleleve.Name = "lblteleleve";
            this.lblteleleve.Size = new System.Drawing.Size(80, 16);
            this.lblteleleve.TabIndex = 2;
            this.lblteleleve.Text = "Telephone :";
            // 
            // lblnomprenomeleve
            // 
            this.lblnomprenomeleve.AutoSize = true;
            this.lblnomprenomeleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomprenomeleve.Location = new System.Drawing.Point(27, 122);
            this.lblnomprenomeleve.Name = "lblnomprenomeleve";
            this.lblnomprenomeleve.Size = new System.Drawing.Size(155, 16);
            this.lblnomprenomeleve.TabIndex = 1;
            this.lblnomprenomeleve.Text = "Nom et Prénom d\'élève :";
            // 
            // lblcineleve
            // 
            this.lblcineleve.AutoSize = true;
            this.lblcineleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcineleve.ForeColor = System.Drawing.Color.Black;
            this.lblcineleve.Location = new System.Drawing.Point(27, 68);
            this.lblcineleve.Name = "lblcineleve";
            this.lblcineleve.Size = new System.Drawing.Size(81, 16);
            this.lblcineleve.TabIndex = 0;
            this.lblcineleve.Text = "Cin d\'élève :";
            // 
            // btnQuiter
            // 
            this.btnQuiter.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderSize = 0;
            this.btnQuiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnQuiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiter.ForeColor = System.Drawing.Color.White;
            this.btnQuiter.Location = new System.Drawing.Point(619, 12);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(69, 23);
            this.btnQuiter.TabIndex = 15;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = false;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::prj_ForYou.Properties.Resources._100_16_;
            this.pictureBox3.Location = new System.Drawing.Point(416, 421);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources._100_14_;
            this.pictureBox1.Location = new System.Drawing.Point(165, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmodifier.BackColor = System.Drawing.Color.DarkRed;
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(416, 421);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmodifier.Size = new System.Drawing.Size(88, 22);
            this.btnmodifier.TabIndex = 104;
            this.btnmodifier.Text = "Modifier ";
            this.btnmodifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodifier.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::prj_ForYou.Properties.Resources._1ooooo;
            this.pictureBox2.Location = new System.Drawing.Point(282, 421);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // btnrechercher
            // 
            this.btnrechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrechercher.BackColor = System.Drawing.Color.DarkRed;
            this.btnrechercher.FlatAppearance.BorderSize = 0;
            this.btnrechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnrechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrechercher.ForeColor = System.Drawing.Color.White;
            this.btnrechercher.Location = new System.Drawing.Point(282, 421);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnrechercher.Size = new System.Drawing.Size(105, 22);
            this.btnrechercher.TabIndex = 103;
            this.btnrechercher.Text = "Rechercher ";
            this.btnrechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrechercher.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.DarkRed;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(165, 421);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 22);
            this.btnAjouter.TabIndex = 102;
            this.btnAjouter.Text = "S\'inscrir";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // frm_Inscription_dun_eleve
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
            this.Controls.Add(this.gbeleve);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Inscription_dun_eleve";
            this.Text = "s";
            this.Load += new System.EventHandler(this.frm_Inscription_dun_eleve_Load);
            this.gbeleve.ResumeLayout(false);
            this.gbeleve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbeleve;
        private System.Windows.Forms.TextBox txtfrinscr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbcin;
        private System.Windows.Forms.MaskedTextBox mtxtteleleve;
        private System.Windows.Forms.DateTimePicker dtpdatedebut;
        private System.Windows.Forms.TextBox txtnomprenomeleve;
        private System.Windows.Forms.TextBox txtcineleve;
        private System.Windows.Forms.Label lbldatedebut;
        private System.Windows.Forms.Label lblteleleve;
        private System.Windows.Forms.Label lblnomprenomeleve;
        private System.Windows.Forms.Label lblcineleve;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.Button btnAjouter;
    }
}