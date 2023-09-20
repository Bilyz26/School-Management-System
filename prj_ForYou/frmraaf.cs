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
    public partial class frmraaf : Form
    {
        public frmraaf()
        {
            InitializeComponent();
        }
        SqlDataAdapter da_matier = new SqlDataAdapter("select*from matier ", MemberGlobal.cnxstring);
        DataSet Ds = new DataSet();



        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncreategroup_Click_1(object sender, EventArgs e)
        {
            frmCreationNouveauGroupe g = new frmCreationNouveauGroupe();
            g.Show();
            g.MaximumSize = new Size(574, 286);
            foreach (Control c in g.Controls)
            {
                if (c is Button)
                {
                    if (c.Name == "btnQuiter")
                    {
                        c.Hide();
                    }
                }
            }
        }
        SqlDataAdapter da_Annee = new SqlDataAdapter("select*from Annee", MemberGlobal.cnxstring);
        private void frmraaf_Load(object sender, EventArgs e)
        {
            
            da_matier.Fill(Ds, "m");
            cmbmatier.SelectedIndexChanged -= new EventHandler(cmbmatier_SelectedIndexChanged);
            cmbmatier.DataSource = Ds.Tables["m"];
            cmbmatier.ValueMember = "idmat";
            cmbmatier.SelectedIndexChanged += new EventHandler(cmbmatier_SelectedIndexChanged);
            Ds.Tables.Add("n");
            Ds.Tables.Add("p");
            Ds.Tables.Add("g");
            da_Annee.Fill(Ds, "a");
            cmbAnnee.DataSource = Ds.Tables["a"];
            cmbAnnee.ValueMember = "annee";
            dgvelevegrp.Hide();
            dgv.SelectionChanged += new EventHandler(dgv_SelectionChanged);


        }
        SqlDataAdapter da_Niv = new SqlDataAdapter("", MemberGlobal.cnxstring);
        SqlDataAdapter da_prof = new SqlDataAdapter("", MemberGlobal.cnxstring);

        private void cmbmatier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ds.Tables["n"].Clear();
            da_Niv.SelectCommand.CommandText = "select*from niveauMat where #idmat= " + "'" + cmbmatier.Text + "'";
            da_Niv.Fill(Ds, "n");

            if (Ds.Tables["n"].Rows.Count != 0)
            {



                cmbniveau.SelectedIndexChanged -= new EventHandler(cmbniveau_SelectedIndexChanged);
                cmbniveau.DataSource = Ds.Tables["n"];
                cmbniveau.ValueMember = "nomMat";
                cmbniveau.SelectedIndexChanged += new EventHandler(cmbniveau_SelectedIndexChanged);
            }
            Ds.Tables["p"].Clear();
            da_prof.SelectCommand.CommandText = "select*from prof  where #idmat= " + "'" + cmbmatier.Text + "'";
            da_prof.Fill(Ds, "p");
            if (Ds.Tables["p"].Rows.Count != 0)
            {

                cmbprof.DataSource = Ds.Tables["p"];
                cmbprof.ValueMember = "nomprof";
            }
        }

        private void cmbGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format(" select count(#nom) from Raff where #nomprof='{0}'and #codegrp='{1}' and annee='{2}'", cmbprof.Text, cmbGrp.Text,cmbAnnee.Text));
            lblnombreeleve.Text = dt.Rows[0][0].ToString();
        }
        SqlDataAdapter da_grp = new SqlDataAdapter("", MemberGlobal.cnxstring);

        private void cmbniveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ds.Tables["g"].Clear();
            da_grp.SelectCommand.CommandText = string.Format("select * from grp where #idmat='{0}'and #codeNiv='{1}'", cmbmatier.Text, cmbniveau.Text); 

            da_grp.Fill(Ds, "g");

            if (Ds.Tables["g"].Rows.Count != 0)
            {

                cmbGrp.SelectedIndexChanged -= new EventHandler(cmbGrp_SelectedIndexChanged);
                cmbGrp.DataSource = Ds.Tables["g"];
                cmbGrp.ValueMember = "codegrp";
                cmbGrp.SelectedIndexChanged += new EventHandler(cmbGrp_SelectedIndexChanged);
            }
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {

            DataTable dt = MemberGlobal.rechercher(string.Format(" select #nom as'Nom d élève',#codegrp as'Group',annee as'Année d étude' ,#nomprof as'Nom de Professeur' from Raff where #nom='{0}'", txtnomprenomeleve.Text));
            if (dt.Rows.Count != 0)
            {
                dgv.Hide();
                dgvelevegrp.SelectionChanged -= new EventHandler(dgvelevegrp_SelectionChanged);
                dgvelevegrp.DataSource = dt;
                dgvelevegrp.SelectionChanged += new EventHandler(dgvelevegrp_SelectionChanged);

                dgvelevegrp.Size = new Size(622, 150);
                dgvelevegrp.Location = new Point(32, 296);
                dgvelevegrp.Show();
            }


        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

            txtnomprenomeleve.Text = dgv.CurrentRow.Cells[0].Value.ToString();
          
        }

        private void btnRchercherEleve_Click(object sender, EventArgs e)
        {
          

            DataTable dt = MemberGlobal.rechercher(string.Format("select nom as'Nom et Prenom',#cin as'CIN', qui as'Le propriétaire de Cin',tele as'numéro de telephone',frinsc as'Frais d inscription',dateD as'date  d inscription' from inscStd where #cin='{0}' or nom like '{1}%' ", txtcin.Text,txtcin.Text));
            if (dt.Rows.Count != 0)
            {
                dgvelevegrp.Hide();
                dgv.Show();
                dgv.DataSource = dt;
               

            }
            else
            { MemberGlobal.messageBox(new frmMessagboxFaile(),"y'a aucun élève avec les donnée vous saisire"); }
        }

        private void dgvelevegrp_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select * from grp where codegrp='{0}'", dgvelevegrp.CurrentRow.Cells[1].Value.ToString()));
            if (dt.Rows.Count != 0)
            {
                txtnomprenomeleve.Text = dgvelevegrp.CurrentRow.Cells[0].Value.ToString();
                cmbmatier.Text = dt.Rows[0][1].ToString();
                cmbniveau.Text = dt.Rows[0][2].ToString();
                cmbGrp.Text = dgvelevegrp.CurrentRow.Cells[1].Value.ToString();
                cmbprof.Text = dgvelevegrp.CurrentRow.Cells[3].Value.ToString();
                cmbAnnee.Text = dgvelevegrp.CurrentRow.Cells[2].Value.ToString();
                DataTable dtcount = MemberGlobal.rechercher(string.Format(" select count(#nom) from Raff where #nomprof='{0}'and #codegrp='{1}'", cmbprof.Text, cmbGrp.Text));
                lblnombreeleve.Text = dtcount.Rows[0][0].ToString();
              
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            DataTable dt = MemberGlobal.rechercher(string.Format(" select * from Raff where #nomprof='{0}'and #codegrp='{1}' and #nom='{2}'",cmbprof.Text,cmbGrp.Text,txtnomprenomeleve.Text));
            if (dt.Rows.Count == 0)
            {
                if (cmbGrp.Text != "" && cmbprof.Text != "" && txtnomprenomeleve.Text != "")
                {
                    bool i = MemberGlobal.Insert_Edit_Delete(string.Format("insert into Raff values('{0}','{1}','{2}','{3}')", txtnomprenomeleve.Text, cmbGrp.Text, cmbAnnee.Text, cmbprof.Text));
                    if (i == true)
                    {
                       
                        MemberGlobal.messageBox(new frmMssageboxSucces(), "Ajouter avec succée");

                    }

                }
                else
                {
                   
                  
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "Vous avez oublié un ou plus champs vide");

                }



            }
            else
            {
               
                MemberGlobal.messageBox(new frmMessagboxFaile(),"il existe deja" );

            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("Select*from Raff where #nom='{0}' and #codegrp='{1}' and #nomprof='{2}'", dgvelevegrp.CurrentRow.Cells[0].Value.ToString(), dgvelevegrp.CurrentRow.Cells[1].Value.ToString(), dgvelevegrp.CurrentRow.Cells[3].Value.ToString()));
            if (dt.Rows.Count != 0)
            {
                bool i = MemberGlobal.Insert_Edit_Delete(string.Format("Update Raff set  #nom='{0}' , #codegrp='{1}' ,annee='{2}' ,#nomprof='{3}' " +
                    " where #nom='{4}' and #codegrp='{5}' and #nomprof='{6}'", txtnomprenomeleve.Text, cmbGrp.Text, cmbAnnee.Text, cmbprof.Text
                   , dgvelevegrp.CurrentRow.Cells[0].Value.ToString(), dgvelevegrp.CurrentRow.Cells[1].Value.ToString(), dgvelevegrp.CurrentRow.Cells[3].Value.ToString()));
                if (i==true)
                {
                    
                    MemberGlobal.messageBox(new frmMssageboxSucces(), "modifier avec succée");

                }
                else { 
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "modification echoué ressayé");
                }
            }
            else
            {

               
                MemberGlobal.messageBox(new frmMessagboxFaile(), "y'a aucun élève avec les donnée vous saisire");

            }



        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("Select*from Raff where #nom='{0}' and #codegrp='{1}' and #nomprof='{2}'", dgvelevegrp.CurrentRow.Cells[0].Value.ToString(), dgvelevegrp.CurrentRow.Cells[1].Value.ToString(), dgvelevegrp.CurrentRow.Cells[3].Value.ToString()));
            if (dt.Rows.Count != 0)
            {
                bool i = MemberGlobal.Insert_Edit_Delete(string.Format("delete from Raff " +
                    " where #nom='{0}' and #codegrp='{1}' and #nomprof='{2}'"
                   , dgvelevegrp.CurrentRow.Cells[0].Value.ToString(), dgvelevegrp.CurrentRow.Cells[1].Value.ToString(), dgvelevegrp.CurrentRow.Cells[3].Value.ToString()));
                if (i == true)
                {
                   
                    MemberGlobal.messageBox(new frmMssageboxSucces(), "supprimé avec succée");

                }
                else { 
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "supprission echoué ressayé");
                }
            }
            else
            {

                
                MemberGlobal.messageBox(new frmMessagboxFaile(),"y'a aucun élève avec les donnée vous saisire" );

            }

        }

        private void txtcin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRchercherEleve_Click(sender, e);
            }
        }
    }
}
