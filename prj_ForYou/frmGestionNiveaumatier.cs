using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            SqlDataAdapter da_matier = new SqlDataAdapter("select*from matier ", MemberGlobal.cnxstring);
            DataSet Ds = new DataSet();


            da_matier.Fill(Ds, "m");
            cmbmatier.DataSource = Ds.Tables["m"];
            cmbmatier.ValueMember = "idmat";

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from niveauMat where codeNiv='{0}'", txtcodeniveau.Text));
            if (dt.Rows.Count == 0)
            {
               bool b= MemberGlobal.Insert_Edit_Delete(string.Format("insert into niveauMat values('{0}','{1}','{2}')", txtcodeniveau.Text, cmbmatier.Text,txtnomniv.Text));
               if(b==true)
                {                    MemberGlobal.messageBox(new frmMssageboxSucces(), "Ajouter avec succées!" );
                  }

            }
            else
            {

               
                MemberGlobal.messageBox(new frmMessagboxFaile(), "Existe Déja!");

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
                MemberGlobal.messageBox(new frmMessagboxFaile(), " N'Existe Pas!");

                
            }
        }
    }
}
