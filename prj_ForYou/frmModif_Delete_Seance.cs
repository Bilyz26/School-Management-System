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
    public partial class frmModif_Delete_Seance : Form
    {
        public frmModif_Delete_Seance()
        {
            InitializeComponent();
        }
        SqlDataAdapter da_matier = new SqlDataAdapter("select*from matier ", MemberGlobal.cnxstring);
        DataSet Ds = new DataSet();
        SqlDataAdapter da_Annee = new SqlDataAdapter("select*from Annee", MemberGlobal.cnxstring);
        private void frmModif_Delete_Seance_Load(object sender, EventArgs e)
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
            cmbannee.SelectedIndexChanged -= new EventHandler(cmbannee_SelectedIndexChanged);
            cmbannee.DataSource = Ds.Tables["a"];
            cmbannee.ValueMember = "annee";
            cmbannee.SelectedIndexChanged += new EventHandler(cmbannee_SelectedIndexChanged);
          
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
                cmbnomprof.SelectedIndexChanged -= new EventHandler(cmbnomprof_SelectedIndexChanged);
                cmbnomprof.DataSource = Ds.Tables["p"];
                cmbnomprof.ValueMember = "nomprof";
                cmbnomprof.SelectedIndexChanged += new EventHandler(cmbnomprof_SelectedIndexChanged);

            }
        }
        SqlDataAdapter da_grp = new SqlDataAdapter("", MemberGlobal.cnxstring);

        private void cmbniveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ds.Tables["g"].Clear();
            da_grp.SelectCommand.CommandText = string.Format("select * from grp inner join Raff on codegrp=#codegrp where #idmat='{0}'and #codeNiv='{1}' and Raff.#nomprof='{2}' and  Raff.annee='{3}' ", cmbmatier.Text, cmbniveau.Text, cmbnomprof.Text, cmbannee.Text); /*"select*from grp where #idmat=' "+cmbmatier.Text+"'and #codeNiv='"+cmbniveau.Text+"'";*/

            da_grp.Fill(Ds, "g");

            if (Ds.Tables["g"].Rows.Count != 0)
            {

                cmbnomgrp.SelectedIndexChanged -= new EventHandler(cmbnomgrp_SelectedIndexChanged);
                cmbnomgrp.DataSource = Ds.Tables["g"];
                cmbnomgrp.ValueMember = "codegrp";
                cmbnomgrp.SelectedIndexChanged += new EventHandler(cmbnomgrp_SelectedIndexChanged);
            }
        }

        private void cmbnomprof_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ds.Tables["g"].Clear();
            da_grp.SelectCommand.CommandText = string.Format("select * from grp inner join Raff on codegrp=#codegrp where #idmat='{0}'and #codeNiv='{1}' and Raff.#nomprof='{2}' and  Raff.annee='{3}' ", cmbmatier.Text, cmbniveau.Text, cmbnomprof.Text, cmbannee.Text);

            da_grp.Fill(Ds, "g");

            if (Ds.Tables["g"].Rows.Count != 0)
            {

                cmbnomgrp.SelectedIndexChanged -= new EventHandler(cmbnomgrp_SelectedIndexChanged);
                cmbnomgrp.DataSource = Ds.Tables["g"];
                cmbnomgrp.ValueMember = "codegrp";
                cmbnomgrp.SelectedIndexChanged += new EventHandler(cmbnomgrp_SelectedIndexChanged);
            }
        }

        private void cmbannee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ds.Tables["g"].Clear();
            da_grp.SelectCommand.CommandText = string.Format("select * from grp inner join Raff on codegrp=#codegrp where #idmat='{0}'and #codeNiv='{1}' and Raff.#nomprof='{2}' and  Raff.annee='{3}' ", cmbmatier.Text, cmbniveau.Text, cmbnomprof.Text, cmbannee.Text); /*"select*from grp where #idmat=' "+cmbmatier.Text+"'and #codeNiv='"+cmbniveau.Text+"'";*/

            da_grp.Fill(Ds, "g");

            if (Ds.Tables["g"].Rows.Count != 0)
            {

                cmbnomgrp.SelectedIndexChanged -= new EventHandler(cmbnomgrp_SelectedIndexChanged);
                cmbnomgrp.DataSource = Ds.Tables["g"];
                cmbnomgrp.ValueMember = "codegrp";
                cmbnomgrp.SelectedIndexChanged += new EventHandler(cmbnomgrp_SelectedIndexChanged);
            }
        }

        private void cmbnomgrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format(" select count(#nom) from Raff where #nomprof='{0}'and #codegrp='{1}' and annee='{2}'", cmbnomprof.Text, cmbnomgrp.Text, cmbannee.Text));
            lblnombrEleve.Text = dt.Rows[0][0].ToString();
        }
        int pos;
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            txtjour.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            mtxtHD.Text= dgv.CurrentRow.Cells[1].Value.ToString();
            mtxtHF.Text= dgv.CurrentRow.Cells[2].Value.ToString();
            pos = dgv.CurrentRow.Index;
        }
         
        private void btnrechercher_Click(object sender, EventArgs e)
        {
            if (cmbannee.Text != "" && cmbmatier.Text != "" && cmbniveau.Text != "" && cmbnomgrp.Text != "" && cmbnomprof.Text != "")
            {
                DataTable dt = MemberGlobal.rechercher(string.Format(" select dayy,heureD,heureF from seance where #codegrp='{0}' and #annee='{1}' and #nomprof='{2}'", cmbnomgrp.Text, cmbannee.Text, cmbnomprof.Text));

                
                if ( dt.Rows.Count!=0)
                {
                   

                    dgv.DataSource = dt;
                }
                else
                {
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "N'Exist pas");
                }


            }
        }
       

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (cmbannee.Text != "" && cmbmatier.Text != "" && cmbniveau.Text != "" && cmbnomgrp.Text != "" && cmbnomprof.Text != "")
            {


                if (dgv.Rows.Count != 0)
                {
                    string query = string.Format("update seance set   heureD ='{0}',heureF ='{1}' where #codegrp ='{2}' and #nomprof='{3}' and #annee= {4} and dayy='{5}'", mtxtHD.Text, mtxtHF.Text, cmbnomgrp.Text, cmbnomprof.Text, cmbannee.Text, dgv.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(query);
                    bool i = false;
                       i= MemberGlobal.Insert_Edit_Delete(query);
                    if(i==true)
                    {

                        MemberGlobal.messageBox(new frmMssageboxSucces(), "modifié avec succèe");
                    }
                    else
                    {
                        MemberGlobal.messageBox(new frmMessagboxFaile(), "modification echoué ressayé");
                    }
                }

               
            }
           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (cmbannee.Text != "" && cmbmatier.Text != "" && cmbniveau.Text != "" && cmbnomgrp.Text != "" && cmbnomprof.Text != "")
            {


                if (dgv.Rows.Count != 0)
                {
                    bool i = MemberGlobal.Insert_Edit_Delete(string.Format("delete from seance  where #codegrp='{0}' and #nomprof='{1}' and #annee='{2}' and dayy='{3}'", cmbnomgrp.Text, cmbnomprof.Text, cmbannee.Text, dgv.CurrentRow.Cells[0].Value.ToString()));
                    if (i == true)
                    {
                        MessageBox.Show("supprimé avec succèe");
                        MemberGlobal.messageBox(new frmMssageboxSucces(), "Supprimé avec succèe");

                    }
                    else
                    {
                        
                        MemberGlobal.messageBox(new frmMessagboxFaile(), "supprission echoué ressayé");

                    }
                }


            }
        }
    }
}
