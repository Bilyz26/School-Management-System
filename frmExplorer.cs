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
    public partial class frmExplorer : Form
    {
        public frmExplorer()
        {
            InitializeComponent();
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            //cmb mat
            DataTable dt = MemberGlobal.rechercher("select idmat from matier");
            if (dt.Rows.Count != 0)
            {
                cmbmat.SelectedIndexChanged-=new EventHandler(cmbmat_SelectedIndexChanged);
                cmbmat.DataSource = dt;
                cmbmat.ValueMember = "idmat";
                cmbmat.SelectedIndexChanged += new EventHandler(cmbmat_SelectedIndexChanged);

            }


            //cmbmatier
           

            rbemploie.Checked = true;

            //gbpaiement.Hide();
            //gbemploie.Hide();
            //gbemplelev.Hide();
            //gbemplgrp.Hide();
            //dgv.Hide();
            dataGridView1.Hide();


           
        }
        

        private void rbeleve_CheckedChanged(object sender, EventArgs e)
        {
            //vide
            label10_Click(null, null);
            label11_Click(null, null);

            gbrecgerche.Location = new Point(120, 307);
            gbrecgerche.Show();

            gbemplelev.Location = new Point(171, 87);
            gbemplelev.Show();
            gbemplgrp.Hide();
           


        }

        private void rbgroupe_CheckedChanged(object sender, EventArgs e)
        {
            //vide
            label10_Click(null, null);
            label11_Click(null, null);


            gbemplgrp.Location = new Point(171, 87);
            gbemplelev.Hide();
            gbrecgerche.Hide();
            gbemplgrp.Show();
           
        }

        private void cmbmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb niv & prof

            DataTable dtt = MemberGlobal.rechercher(string.Format("select * from niveauMat where #idmat='{0}'", cmbmat.Text));
            if (dtt.Rows.Count != 0)
            {
                cmbniv.DataSource = dtt;
                cmbniv.ValueMember = "nomMat";
            }

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from prof where #idmat='{0}'", cmbmat.Text));
            if (dt.Rows.Count != 0)
            {
                cmbprof.DataSource = dt;
                cmbprof.ValueMember = "nomprof";

            }
        }


        private void cmbannee_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct grp.codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}' and #codeNiv='{1}' and Raff.#nomprof='{2}' and Raff.annee='{3}'", cmbmat.Text, cmbniv.Text, cmbprof.Text, cmbannee.Text));
            if (dt.Rows.Count != 0)
            {
                cmbgrp.DataSource = dt;
                cmbgrp.ValueMember = "codegrp";
            }
        }


        private void btnrechercher_emplpargrp_Click(object sender, EventArgs e)
        {

            //dgv.Size = new Size(687, 213);
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct dayy,heureD,heureF from seance inner join Raff " +
                "on Raff.#codegrp=seance.#codegrp where seance.#codegrp='{0}' and annee='{1}' and Raff.#nomprof='{2}'"
                ,cmbgrp.Text , cmbannee.Text,  cmbprof.Text));
            if (dt.Rows.Count != 0)
            {
                //dgv.Show();
                dgv.DataSource = dt;
                
            }

        }

        private void cmbmatier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb niv & prof

          

        }
        private void cmbanneee_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select grp.* from grp inner join Raff on codegrp=#codegrp" +
                " where Raff.#nom='{0}' and Raff.annee='{1}'", txtnomprenomeleve.Text, cmbanneee.Text));
            if (dt.Rows.Count != 0)
            {
                cmbgroup.DataSource = dt;
                cmbgroup.ValueMember = "codegrp";
            }
        }



        private void btnrechercher_emplpareleve_Click(object sender, EventArgs e)
        {
            //dgv.Size = new Size(687, 213);
            DataTable dt = MemberGlobal.rechercher(string.Format("select dayy,heureD,heureF from seance where #codegrp='{0}' and #annee='{1}'", cmbgroup.Text, cmbanneee.Text));
            if (dt.Rows.Count != 0)
            {
                dataGridView1.Hide();
                dgv.Show();
                dgv.DataSource = dt;

            }
            
        }

        private void rbemploie_CheckedChanged(object sender, EventArgs e)
        {

            
            gbemploie.Location = new Point(209, 35);
            gbemploie.Show();
            gbpaiement.Hide();
            
        }

        private void rbpaiement_CheckedChanged(object sender, EventArgs e)
        {
            gbpaiement.Location = new Point(209, 35);
            gbemploie.Hide();
            gbpaiement.Show();
        }

      


      

        private void label10_Click(object sender, EventArgs e)
        {
            
            cmbmat.Text = "";
            cmbniv.Text = "";
            cmbannee.Text = "";
            cmbgrp.Text = "";
            cmbprof.Text = "";
            dgv.Columns.Clear();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            cmbanneee.Text = "";
            cmbgroup.Text = "";
            dgv.Columns.Clear();
        }

        private void btnrech_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select nom from inscStd where #cin='{0}' or nom like '{0}%'",txtcinornom.Text));
            if(dt.Rows.Count!=0)
            {
                dgv.Hide();
                dataGridView1.Show();
                dataGridView1.Size = new Size(471,146);
                dataGridView1.Location = new Point(152,364);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtnomprenomeleve.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }




   
        
        //687; 213
    
}
