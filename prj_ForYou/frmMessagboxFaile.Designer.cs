namespace prj_ForYou
{
    partial class frmMessagboxFaile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessagboxFaile));
            this.btnQuiter = new System.Windows.Forms.Button();
            this.lbltextS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuiter
            // 
            this.btnQuiter.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnQuiter.FlatAppearance.BorderSize = 0;
            this.btnQuiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnQuiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiter.ForeColor = System.Drawing.Color.White;
            this.btnQuiter.Location = new System.Drawing.Point(122, 100);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(69, 23);
            this.btnQuiter.TabIndex = 46;
            this.btnQuiter.Text = "OK";
            this.btnQuiter.UseVisualStyleBackColor = false;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // lbltextS
            // 
            this.lbltextS.AutoSize = true;
            this.lbltextS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextS.ForeColor = System.Drawing.Color.White;
            this.lbltextS.Location = new System.Drawing.Point(2, 61);
            this.lbltextS.Name = "lbltextS";
            this.lbltextS.Size = new System.Drawing.Size(45, 16);
            this.lbltextS.TabIndex = 48;
            this.lbltextS.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prj_ForYou.Properties.Resources.no;
            this.pictureBox1.Location = new System.Drawing.Point(124, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // frmMessagboxFaile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(310, 139);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltextS);
            this.Controls.Add(this.btnQuiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(326, 178);
            this.MinimumSize = new System.Drawing.Size(326, 178);
            this.Name = "frmMessagboxFaile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Label lbltextS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}