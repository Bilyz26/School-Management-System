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
    public partial class frmGestionNiveaumatier : Form
    {
        public frmGestionNiveaumatier()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmGestionNiveaumatier_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from niveauMat where codeNiv='{0}'", txtcodeniveau.Text));
            if (dt.Rows.Count == 0)
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("insert into niveauMat values('{0}','{1}','{2}')", txtcodeniveau.Text, cmbmatier.Text,txtnomniv.Text));
                MessageBox.Show("Ajouter avec succées!");
            }
            else
            {

                MessageBox.Show("existe deja!");

            }
            MemberGlobal.vider(this);

        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from niveauMat  where codeNiv='{0}'", txtcodeniveau.Text));
            if (dt.Rows.Count != 0)
            {
                //b = dt.Rows[0][0].ToString();
                txtcodeniveau.Text = dt.Rows[0][0].ToString();
                cmbmatier.Text = dt.Rows[0][1].ToString();
                txtnomniv.Text = dt.Rows[0][2].ToString();

                //btnmodifier.Enabled = true;

            }
            else
            {
                MessageBox.Show("n'existe pas!");
            }
        }
    }
}
