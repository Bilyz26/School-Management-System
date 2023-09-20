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
    public partial class frmCreationNouveauGroupe : Form
    {
        public frmCreationNouveauGroupe()
        {
            InitializeComponent();
        }
        SqlDataAdapter da_matier = new SqlDataAdapter("select*from matier ", MemberGlobal.cnxstring);
        DataSet Ds = new DataSet();

        private void txtnomgroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnomgrp_Click(object sender, EventArgs e)
        {

        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreationNouveauGroupe_Load(object sender, EventArgs e)
        {
            
            da_matier.Fill(Ds, "m");
            cmbmatier.SelectedIndexChanged -= new EventHandler(cmbmatier_SelectedIndexChanged);
            cmbmatier.DataSource = Ds.Tables["m"];
            cmbmatier.ValueMember = "idmat";
            cmbmatier.SelectedIndexChanged += new EventHandler(cmbmatier_SelectedIndexChanged);
            Ds.Tables.Add("n");
        }
        SqlDataAdapter da_Niv = new SqlDataAdapter("", MemberGlobal.cnxstring);
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
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = MemberGlobal.rechercher(string.Format("select*from grp where codegrp='{0}' ", txtnomgroup.Text));
                if (dt.Rows.Count == 0)
                {
                    if (txtnomgroup.Text != "" && cmbmatier.Text != "" && cmbniveau.Text != "")
                    {
                        bool i = MemberGlobal.Insert_Edit_Delete(string.Format("insert into grp values('{0}','{1}','{2}') ", txtnomgroup.Text, cmbmatier.Text, cmbniveau.Text));
                        if (i == true)
                        {
                           
                            MemberGlobal.messageBox(new frmMssageboxSucces(), "le groupe été crée avec succée");
                        }
                    }
                    else
                    { 
                        MemberGlobal.messageBox(new frmMessagboxFaile(), "Vous avez oublié un ou plus champs vide ");
                    }
                }
                else
                {
                   
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "Exist Déja ");
                }



            }
            catch
            {

            }
        }

        private void cmbniveau_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
