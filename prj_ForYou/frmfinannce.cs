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
    public partial class frmfinannce : Form
    {
        public frmfinannce()
        {
            InitializeComponent();

            rdbS.Checked = true;
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
            da_grp.SelectCommand.CommandText = string.Format("select distinct codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}'and #codeNiv='{1}' and Raff.#nomprof='{2}' and  Raff.annee='{3}' ", cmbmatier.Text, cmbniveau.Text, cmbnomprof.Text, cmbannee.Text); /*"select*from grp where #idmat=' "+cmbmatier.Text+"'and #codeNiv='"+cmbniveau.Text+"'";*/

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
            da_grp.SelectCommand.CommandText = string.Format("select distinct codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}'and #codeNiv='{1}' and Raff.#nomprof='{2}' and  Raff.annee='{3}' ", cmbmatier.Text, cmbniveau.Text, cmbnomprof.Text, cmbannee.Text);

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

        private void cmbannee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ds.Tables["g"].Clear();
            da_grp.SelectCommand.CommandText = string.Format("select  distinct codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}'and #codeNiv='{1}' and Raff.#nomprof='{2}' and  Raff.annee='{3}' ", cmbmatier.Text, cmbniveau.Text, cmbnomprof.Text, cmbannee.Text); /*"select*from grp where #idmat=' "+cmbmatier.Text+"'and #codeNiv='"+cmbniveau.Text+"'";*/

            da_grp.Fill(Ds, "g");

            if (Ds.Tables["g"].Rows.Count != 0)
            {

                cmbnomgrp.SelectedIndexChanged -= new EventHandler(cmbnomgrp_SelectedIndexChanged);
                cmbnomgrp.DataSource = Ds.Tables["g"];
                cmbnomgrp.ValueMember = "codegrp";
                cmbnomgrp.SelectedIndexChanged += new EventHandler(cmbnomgrp_SelectedIndexChanged);
            }
        }

        private void cmbmnth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Load---------------------------
        SqlDataAdapter da_matier = new SqlDataAdapter("select*from matier ", MemberGlobal.cnxstring);
        DataSet Ds = new DataSet();
        SqlDataAdapter da_Annee = new SqlDataAdapter("select*from Annee", MemberGlobal.cnxstring);
        private void frmfinannce_Load(object sender, EventArgs e)
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
            //--------------------------------------------------------------------------------------
            da_matier.Fill(Ds, "mt");
            Ds.Tables.Add("nt");
            Ds.Tables.Add("pt");

            cmbMatT.SelectedIndexChanged -= new EventHandler(cmbMatT_SelectedIndexChanged);
            cmbMatT.DataSource = Ds.Tables["mt"];
            cmbMatT.ValueMember = "idmat";
            cmbMatT.SelectedIndexChanged += new EventHandler(cmbMatT_SelectedIndexChanged);
           
           
            da_Annee.Fill(Ds, "at");
            cmbAnneeT.SelectedIndexChanged -= new EventHandler(cmbAnneeT_SelectedIndexChanged);
            cmbAnneeT.DataSource = Ds.Tables["at"];
            cmbAnneeT.ValueMember = "annee";
            cmbAnneeT.SelectedIndexChanged += new EventHandler(cmbAnneeT_SelectedIndexChanged);

            gbT.Location = new Point(12, 25);
            this.Size = new Size(430, 439);
        }

        private void cmbMatT_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Ds.Tables["pt"].Clear();
            da_prof.SelectCommand.CommandText = "select*from prof  where #idmat= " + "'" + cmbMatT.Text + "'";
            da_prof.Fill(Ds, "pt");
            if (Ds.Tables["pt"].Rows.Count != 0)
            {
                cmbProT.SelectedIndexChanged -= new EventHandler(cmbProT_SelectedIndexChanged);
                cmbProT.DataSource = Ds.Tables["pt"];
                cmbProT.ValueMember = "nomprof";
                cmbProT.SelectedIndexChanged += new EventHandler(cmbProT_SelectedIndexChanged);

            }
        }

        private void cmbProT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAnneeT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbS_CheckedChanged(object sender, EventArgs e)
        {
            gbS.Show();
            gbT.Hide();
        }

        private void rdbT_CheckedChanged(object sender, EventArgs e)
        {
            gbS.Hide();
            gbT.Show();
        }
        DataTable dtt=new DataTable();
        DataTable dtt1 = new DataTable();
        private void btnCmnc_Click(object sender, EventArgs e)
        {
            if (dtt1.Rows.Count != 0)
            {
                dtt1.Clear();
            }
            if (dtt.Rows.Count != 0)
            {
                dtt.Clear();
            }
            if (rdbS.Checked==true)
            {
              
                 dtt = MemberGlobal.rechercher(string.Format(" select (sum(prix)) from pay where #codegrp='{0}' and #nomprof='{1}' and #idmat='{2}' and #codeNiv='{3}' and monthp='{4}' and #annee='{5}'",cmbnomgrp.Text,cmbnomprof.Text,cmbmatier.Text,cmbniveau.Text,cmbmnth.Text,cmbannee.Text));
                if(dtt.Rows.Count!=0)
                {
                    txtmT.Text = dtt.Rows[0][0].ToString();
                }
            }
          if(rdbT.Checked==true)
            {
               
                dtt1 = MemberGlobal.rechercher(string.Format(" select (sum(prix)) from pay where   #nomprof='{0}'  and monthp='{1}' and #annee='{2}'",  cmbProT.Text,  cmbmonthpT.Text, cmbAnneeT.Text));
                if (dtt1.Rows.Count != 0)
                {
                    txtmT.Text = dtt1.Rows[0][0].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtmT.Text!="")
            {
                double m = double.Parse(txtmT.Text);
                double p = double.Parse(mtxt100.Text);
                double t = (m / 100) * p;
                txtm.Text = t.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberGlobal.vider(this);
        }
    }
}
