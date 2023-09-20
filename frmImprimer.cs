﻿using System;
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
    public partial class frmImprimer : Form
    {
        public static string groupe;
        public static string Matiere;
        public static string Niveau;
        public static string prof;
        public static string Annee;



        public frmImprimer()
        {
            InitializeComponent();
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmImprimer_Load(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher("select idmat from matier");
            if(dt.Rows.Count!=0)
            {
                
                cmbmatier.DataSource = dt;
                cmbmatier.ValueMember = "idmat";
            }
        }

        private void cmbmatier_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtt = MemberGlobal.rechercher(string.Format("select * from niveauMat where #idmat='{0}'",cmbmatier.Text));
            if (dtt.Rows.Count != 0)
            {
                cmbniveau.DataSource = dtt;
                cmbniveau.ValueMember = "nomMat";
            }

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from prof where #idmat='{0}'", cmbmatier.Text));
            if (dt.Rows.Count != 0)
            {
                cmbnomprof.DataSource = dt;
                cmbnomprof.ValueMember = "nomprof";

            }



        }

        private void cmbniveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select codegrp from grp where #idmat='{0}' and #codeNiv='{1}'", cmbmatier.Text,cmbniveau.Text));
            if (dt.Rows.Count != 0)
            {
                cmbgroup.DataSource = dt;
                cmbgroup.ValueMember = "codegrp";
            }
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
         groupe=cmbgroup.Text;
         Matiere=cmbmatier.Text;
         Niveau=cmbniveau.Text;
         prof=cmbnomprof.Text;
         Annee=cmbannee.Text;
            frmAbsence f = new frmAbsence();
            f.Show();
    }
    }
}
