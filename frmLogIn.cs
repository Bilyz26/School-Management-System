using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_ForYou
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from emp where username='{0}' and pw='{1}'",txtusername.Text,txtpassword.Text));
            if(dt.Rows.Count==1)
            {

                this.Hide();
                new FrmMenu().Show();

            }

            //if (txtusername.Text == "n" && txtpassword.Text == "1")
            //{
            //    this.Hide();
            //    new FrmMenu().Show();

            //}
            else
            {
                MessageBox.Show("le nom d'utilisateur ou le mot de passe est incorrect, Réessayer");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
            txtusername.Focus();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
