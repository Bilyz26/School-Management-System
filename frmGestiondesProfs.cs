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
    public partial class frmGestiondesProfs : Form
    {
        string b;
        public frmGestiondesProfs()
        {
            InitializeComponent();
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataTable dt= MemberGlobal.rechercher(string.Format("select * from prof where nomprof='{0}'", txtnomprenomprof.Text));
            if(dt.Rows.Count != 0)
            {
                MessageBox.Show("existe deja!");

            }
            else
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("insert into prof values('{0}','{1}','{2}')", txtnomprenomprof.Text, mtxtteleprof.Text, cmbmatierprof.Text));
                MessageBox.Show("Ajouter avec succées!");

            }
            MemberGlobal.vider(this);

        }

       

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from prof where nomprof='{0}'", b));
            if (dt.Rows.Count != 0)
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("update prof set nomprof='{0}',teleprof='{1}',#idmat='{2}' where nomprof='{3}'", txtnomprenomprof.Text, mtxtteleprof.Text, cmbmatierprof.Text,dt.Rows[0][0].ToString()));
                btnmodifier.Enabled = false;
                MessageBox.Show("modifier avec succées!");
            }
            else
            {
                MessageBox.Show("n'existe pas!");
            }
            MemberGlobal.vider(this);

        }

        private void frmGestiondesProfs_Load(object sender, EventArgs e)
        {
            btnmodifier.Enabled=false;
            DataTable dt = MemberGlobal.rechercher(string.Format("select  * from matier"));
            cmbmatierprof.DataSource = dt;
            cmbmatierprof.ValueMember = "idmat";


        }

        //private void btnsupprimer_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = MemberGlobal.rechercher(string.Format("select * from prof where nomprof='{0}'", txtnomprenomprof.Text));
        //    if (dt.Rows.Count != 0)
        //    {
        //        MemberGlobal.Insert_Edit_Delete(string.Format("delete from prof where nomprof='{0}'", txtnomprenomprof.Text));
                
        //        MessageBox.Show("supprimer avec succées!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("n'existe pas!");
        //    }
        //    btnmodifier.Enabled = false;
        //    MemberGlobal.vider(this);

        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from prof where nomprof='{0}'", txtnomprenomprof.Text));
            if (dt.Rows.Count != 0)
            {
                b = dt.Rows[0][0].ToString();
                txtnomprenomprof.Text = dt.Rows[0][0].ToString();
                mtxtteleprof.Text = dt.Rows[0][1].ToString();
                cmbmatierprof.Text = dt.Rows[0][2].ToString();
                btnmodifier.Enabled = true;

            }
            else
            {
                MessageBox.Show("n'existe pas!");
            }
        }
    }
}
