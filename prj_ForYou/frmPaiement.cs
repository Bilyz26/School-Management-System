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
    public partial class frmPaiement : Form
    {
        public frmPaiement()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select nom as'Nom et Prenom',#cin as'CIN',Raff.#codegrp as'Nom groupe' , Raff.#nomprof as'Professeur',grp.#idmat as'Matiére',grp.#codeNiv as 'Niveau'"+
 "from inscStd inner join Raff on nom =#nom  inner join grp on #codegrp=codegrp where #cin='{0}' or #nom like '%{0}%' ", txtcin_nom.Text));
            if (dt.Rows.Count != 0)
            {
                dgvelevegrp.Hide();
                dgv.Show();
                dgv.DataSource = dt;
                btnrechercherPaiement.Enabled = true;

            }
            else
            { 
                MemberGlobal.messageBox(new frmMessagboxFaile(), "y'a aucun élève avec les donnée vous saisire");
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            txtnomeleve.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtgrp.Text= dgv.CurrentRow.Cells[2].Value.ToString();
            txtMat.Text= dgv.CurrentRow.Cells[4].Value.ToString();
            txtNiv.Text= dgv.CurrentRow.Cells[5].Value.ToString();
            txtprof.Text= dgv.CurrentRow.Cells[3].Value.ToString();
            btnAjouter.Enabled = true;



        }
        SqlDataAdapter da_Annee = new SqlDataAdapter("select*from Annee", MemberGlobal.cnxstring);
        DataTable dt_annee = new DataTable();
        private void frmPaiement_Load(object sender, EventArgs e)
        {
            dtpp.Format = DateTimePickerFormat.Custom;
            dtpp.CustomFormat = "yyyy/MM/dd";
            da_Annee.Fill(dt_annee);
            cmbAnnee.DataSource = dt_annee;
            cmbAnnee.ValueMember = "annee";
            btnrechercherPaiement.Enabled = false;
                btnrechercherPaiement.Enabled = false;
            btnAjouter.Enabled = false;
            btnmodifier.Enabled = false;
            dgvelevegrp.Hide();
        }

        private void btnrechercherPaiement_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format(" select #nom as'Nom et Prenom',#codegrp as'Nom groupe' , #nomprof as'Professeur',#idmat as'Matiére',#codeNiv as 'Niveau',datep as'Date de Paiement',monthp as 'Mois Payé' ,prix as 'Prix Payé' from  pay where #nom='{0}'"+
" and  #codegrp='{1}' and #codeNiv='{2}' and #idmat='{3}' and #nomprof='{4}' and #annee='{5}' ", txtnomeleve.Text,txtgrp.Text,txtNiv.Text,txtMat.Text,txtprof.Text,cmbAnnee.Text));
            
            if (dt.Rows.Count != 0)
            {
                dgv.Hide();
                dgvelevegrp.SelectionChanged -= new EventHandler(dgvelevegrp_SelectionChanged);
                dgvelevegrp.DataSource = dt;
                dgvelevegrp.SelectionChanged += new EventHandler(dgvelevegrp_SelectionChanged);

                dgvelevegrp.Size = new Size(605, 150);
                dgvelevegrp.Location = new Point(45, 330);
                dgvelevegrp.Show();
                btnmodifier.Enabled = true;
            }
            else
            {

                MemberGlobal.messageBox(new frmMessagboxFaile(), "Paiement introuvable");
            }
        }

        private void dgvelevegrp_SelectionChanged(object sender, EventArgs e)
        {
            txtnomeleve.Text = dgvelevegrp.CurrentRow.Cells[0].Value.ToString();
                txtgrp.Text = dgvelevegrp.CurrentRow.Cells[1].Value.ToString();
            txtNiv.Text = dgvelevegrp.CurrentRow.Cells[4].Value.ToString();
            txtMat.Text = dgvelevegrp.CurrentRow.Cells[3].Value.ToString();
            txtprof.Text = dgvelevegrp.CurrentRow.Cells[2].Value.ToString();
            dtpp.Text = dgvelevegrp.CurrentRow.Cells[5].Value.ToString();
            cmbmnth.Text = dgvelevegrp.CurrentRow.Cells[6].Value.ToString();
            mtxtPrix.Text = dgvelevegrp.CurrentRow.Cells[7].Value.ToString();
            btnmodifier.Enabled = true;
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format(" select * from pay where #nom='{0}'" +
" and  #codegrp='{1}' and #codeNiv='{2}' and #idmat='{3}' and #nomprof='{4}' and monthp='{5}' and #annee='{6}'", txtnomeleve.Text, txtgrp.Text, txtNiv.Text, txtMat.Text, txtprof.Text, cmbmnth.Text,cmbAnnee.Text));
            if (dt.Rows.Count == 0)
            {
                if (cmbmnth.Text != "" && mtxtPrix.Text != "")
                {
                    bool i = MemberGlobal.Insert_Edit_Delete(string.Format("insert into pay values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", txtnomeleve.Text, txtgrp.Text,txtprof.Text, txtMat.Text,cmbAnnee.Text, txtNiv.Text,dtpp.Value,  cmbmnth.Text,mtxtPrix.Text));
                    if (i == true)
                    {
                        
                        MemberGlobal.messageBox(new frmMssageboxSucces(), "Payé avec succée");
                    }

                }
                else
                {

                  
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "Vous avez oublié un ou plus champs vide");

                }



            }
            else
            {
               
                MemberGlobal.messageBox(new frmMessagboxFaile(), "Paiement  deja payé");

            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            string s= string.Format(" select * from pay where #nom='{0}' and  #codegrp='{1}' and #codeNiv='{2}'" +
                " and #idmat='{3}' and #nomprof='{4}' and monthp='{5}' and #annee='{6}' "
                , txtnomeleve.Text, txtgrp.Text, txtNiv.Text, txtMat.Text, txtprof.Text, dgvelevegrp.Rows[0].Cells[7].Value.ToString(),cmbAnnee.Text);
            DataTable dt = MemberGlobal.rechercher(s);
            MessageBox.Show(s);
            if (dt.Rows.Count != 0)
            {
                string f= string.Format("Update pay set  #nom='{0}' , #codegrp='{1}' ,#codeNiv='{2}' ,#nomprof='{3}',monthp='{4}',#idmat='{5}',datep='{6}',prix={7},#annee='{13}' " +
                    " where #nom='{8}' and #codegrp='{9}' and #nomprof='{10}' and #idmat='{11}' and monthp='{12}' and #annee='{14}'", txtnomeleve.Text, txtgrp.Text, txtNiv.Text, txtprof.Text, cmbmnth.Text, txtMat.Text, dtpp.Value, mtxtPrix.Text, dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][7].ToString(),cmbAnnee.Text, dt.Rows[0][4].ToString());
                MessageBox.Show(f);
                bool i = MemberGlobal.Insert_Edit_Delete(f);
                if (i == true)
                {
                    MessageBox.Show("modifier avec succée");
                    MemberGlobal.messageBox(new frmMssageboxSucces(), "modifier avec succée");

                }
                else { 
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "modification echoué");
                }
            }
            else
            {

               
                MemberGlobal.messageBox(new frmMessagboxFaile(), "y'a aucun élève avec les donnée vous saisire");

            }
        }

        private void btnFinan_Click(object sender, EventArgs e)
        {
            frmfinannce f = new frmfinannce();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmExplorerpaiment f = new frmExplorerpaiment();
            f.Show(); 
        }

        private void txtcin_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcin_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
