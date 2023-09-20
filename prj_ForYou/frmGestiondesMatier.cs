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
    public partial class frmGestiondesMatier : Form
    {
        //string b;

        public frmGestiondesMatier()
        {
            InitializeComponent();
        }

        private void frmGestiondesMatier_Load(object sender, EventArgs e)
        {
            //btnmodifier.Enabled = false;
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionNiveaumatier f = new frmGestionNiveaumatier();
            f.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from matier where idmat='{0}'", txtidmat.Text));
            if(dt.Rows.Count==0)
            {
                MemberGlobal.Insert_Edit_Delete(string.Format("insert into matier values('{0}','{1}')", txtidmat.Text, txtnommat.Text));
                MemberGlobal.messageBox(new frmMssageboxSucces(), "Ajouter Avec Succées!");
            }
            else
            {


                MemberGlobal.messageBox(new frmMessagboxFaile(), "Existe Déja!");

            }
            MemberGlobal.vider(this);

        }
        
        private void btnrechercher_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from matier  where idmat='{0}'", txtidmat.Text));
            if (dt.Rows.Count != 0)
            {
                //b = dt.Rows[0][0].ToString();
                txtidmat.Text = dt.Rows[0][0].ToString();
                txtnommat.Text = dt.Rows[0][1].ToString();
               
                //btnmodifier.Enabled = true;

            }
            else
            {
                MemberGlobal.messageBox(new frmMessagboxFaile(), " N'Existe Pas!");

            }
        }

        //private void btnmodifier_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = MemberGlobal.rechercher(string.Format("select * from matier where idmat='{0}'", b));
        //    if (dt.Rows.Count != 0)
        //    {
        //        MemberGlobal.Insert_Edit_Delete(string.Format("update prof set idmat='{0}',nomMat='{1}' where  idmat='{2}'", txtidmat.Text, txtnommat.Text, b));
        //        btnmodifier.Enabled = false;
        //        MessageBox.Show("modifier avec succées!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("n'existe pas!");
        //    }
        //    MemberGlobal.vider(this);
        //}

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
