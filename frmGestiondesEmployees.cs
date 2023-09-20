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
    public partial class frmGestiondesEmployees : Form
    {
        string b;
        public frmGestiondesEmployees()
        {
            InitializeComponent();
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestiondesEmployees_Load(object sender, EventArgs e)
        {
            btnmodifier.Enabled = false;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from emp where nomemp='{0}'", txtnomprenomemp.Text));

            if (dt.Rows.Count !=0)
            {

                MessageBox.Show("existe deja!");

            }
            else
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("insert into emp values('{0}','{1}','{2}','{3}','{4}')"
                 , txtnomprenomemp.Text, mtxttelemp.Text, cmbfonctionemp.Text, txtusernameemp.Text, txtmodepasseemp.Text));

                MessageBox.Show("Ajouter avec succées!");
            }

            MemberGlobal.vider(this);
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from emp where nomemp='{0}'", txtnomprenomemp.Text));
            if (dt.Rows.Count != 0)
            {
                b = dt.Rows[0][0].ToString();
                txtnomprenomemp.Text = dt.Rows[0][0].ToString();
                mtxttelemp.Text = dt.Rows[0][1].ToString();
                cmbfonctionemp.Text = dt.Rows[0][2].ToString();
                txtusernameemp.Text = dt.Rows[0][3].ToString();
                txtmodepasseemp.Text = dt.Rows[0][4].ToString();

                btnmodifier.Enabled = true;

            }
            else
            {
                MessageBox.Show("n'existe pas!");
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from emp where nomemp='{0}'", b));
            if(dt.Rows.Count!=0)
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("update emp set nomemp='{0}',tele='{1}',fonction='{2}',username='{3}',pw='{4}' where nomemp='{3}'", txtnomprenomemp.Text, mtxttelemp.Text, cmbfonctionemp.Text, txtusernameemp.Text, txtmodepasseemp.Text,b));
             
                MessageBox.Show("modifier avec succées!");
            }
            else
            {
                MessageBox.Show("n'existe pas!");
            }
            btnmodifier.Enabled = false;
            MemberGlobal.vider(this);

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from emp where nomemp='{0}'", txtnomprenomemp.Text));
            if (dt.Rows.Count != 0)
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("delete from emp where nomemp='{0}'", txtnomprenomemp.Text));
                MessageBox.Show("supprimer avec succées!");
            }
            else
            {
                MessageBox.Show("n'existe pas!");
            }

            MemberGlobal.vider(this);

        }
    }
}
