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
    public partial class frmExplorerpaiment : Form
    {
        public frmExplorerpaiment()
        {
            InitializeComponent();
            rbpeleve.Checked = true;
        }

        private void rbpeleve_CheckedChanged(object sender, EventArgs e)
        {
           
            grppG.Hide();
            grppE.Location = new Point(128, 40);
            grppE.Show();
            gro.Show();
        }

        private void rbpgroupe_CheckedChanged(object sender, EventArgs e)
        {
            
           grppE.Hide();
            grppG.Show();
            gro.Hide();
        } 

        private void frmExplorerpaiment_Load(object sender, EventArgs e)
        {
            this.Size = new Size(605, 489);
            DataTable dt = MemberGlobal.rechercher("select idmat from matier");
            if (dt.Rows.Count != 0)
            {
                cmbmatpG.SelectedIndexChanged -= new EventHandler(cmbmatpG_SelectedIndexChanged);
                cmbmatpG.DataSource = dt;
                cmbmatpG.ValueMember = "idmat";
                cmbmatpG.SelectedIndexChanged += new EventHandler(cmbmatpG_SelectedIndexChanged);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbmatpG_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dtt = MemberGlobal.rechercher(string.Format("select * from niveauMat where #idmat='{0}'", cmbmatpG.Text));
            if (dtt.Rows.Count != 0)
            {
                cmbnivpG.DataSource = dtt;
                cmbnivpG.ValueMember = "nomMat";
            }

            DataTable dt = MemberGlobal.rechercher(string.Format("select * from prof where #idmat='{0}'", cmbmatpG.Text));
            if (dt.Rows.Count != 0)
            {
                cmbpropG.SelectedIndexChanged -= new EventHandler(cmbpropG_SelectedIndexChanged);
                cmbpropG.DataSource = dt;
                cmbpropG.ValueMember = "nomprof";
                cmbpropG.SelectedIndexChanged += new EventHandler(cmbpropG_SelectedIndexChanged);

            }
        }

        private void cmbnivpG_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct grp.codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}' and #codeNiv='{1}' and Raff.#nomprof='{2}' and Raff.annee='{3}'", cmbmatpG.Text, cmbnivpG.Text, cmbpropG.Text, cmbAnnpG.Text));
            if (dt.Rows.Count != 0)
            {
                cmbgrppG.DataSource = dt;
                cmbgrppG.ValueMember = "codegrp";
            }
        }

        private void cmbpropG_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct grp.codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}' and #codeNiv='{1}' and Raff.#nomprof='{2}' and Raff.annee='{3}'", cmbmatpG.Text, cmbnivpG.Text, cmbpropG.Text, cmbAnnpG.Text));
            if (dt.Rows.Count != 0)
            {
                cmbgrppG.DataSource = dt;
                cmbgrppG.ValueMember = "codegrp";
            }
        }

        private void cmbAnnpG_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct grp.codegrp from grp inner join Raff on codegrp=#codegrp where #idmat='{0}' and #codeNiv='{1}' and Raff.#nomprof='{2}' and Raff.annee='{3}'", cmbmatpG.Text, cmbnivpG.Text, cmbpropG.Text, cmbAnnpG.Text));
            if (dt.Rows.Count != 0)
            {
                cmbgrppG.DataSource = dt;
                cmbgrppG.ValueMember = "codegrp";
            }
        }

        private void cmbannepE_SelectedIndexChanged(object sender, EventArgs e)
        {
          DataTable dt=  MemberGlobal.rechercher(string.Format("select distinct codegrp from grp inner join Raff on codegrp=Raff.#codegrp where Raff.#nom='{0}' and Raff.annee='{1}' ", txtnompE.Text,cmbannepE.Text));
            if(dt.Rows.Count!=0)
            {
                cmbEGpE.DataSource = dt;
                cmbEGpE.ValueMember = "codegrp";


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select nom as'Nom et Prenom',#cin as'CIN' from inscStd where #cin='{0}' or nom like '{0}%' ", txtcin_nom.Text));
            if (dt.Rows.Count != 0)
            {
               
                dgvpE.DataSource = dt;
            

            }

        }

        private void dgvpE_SelectionChanged(object sender, EventArgs e)
        {
            txtnompE.Text = dgvpE.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnrechpG_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct Raff.#nom as'Nom et Prenom',grp.#idmat as'Matière',Raff.#codegrp as'Group',grp.#codeNiv as'Niveau',"+
"Raff.#nomprof as'Nom et Prenom de Formateur',Raff.annee as'année d Etude' from"+
" Raff inner join grp on #codegrp=codegrp  " +
"where Raff.#codegrp='{0}'and Raff.#nomprof='{1}'and grp.#idmat='{2}' and grp.#codeNiv='{3}'"+
"and Raff.#nom not in(select pay.#nom from pay   where pay.#codegrp='{0}'and pay.#codeNiv='{3}'" +
"and pay.#idmat='{2}' and pay.#nomprof='{1}' and pay.#annee='{4}' and monthp='{5}')",cmbgrppG.Text,cmbpropG.Text,cmbmatpG.Text,cmbnivpG.Text,cmbAnnpG.Text,cmbmnthpG.Text));
            if (dt.Rows.Count != 0)
            {

                MemberGlobal.dt = dt;
                Frmafichage f = new Frmafichage();
                f.Show();


            }
            else
            {
                MemberGlobal.messageBox(new frmMssageboxSucces(), "Tout a payé");
            }
        }

        private void btnrechpE_Click(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select distinct Raff.#nom as'Nom et Prenom',grp.#idmat as'Matière',Raff.#codegrp as'Group',grp.#codeNiv as'Niveau'," +
"Raff.#nomprof as'Nom et Prenom de Formateur',Raff.annee as'année d Etude' from" +
" Raff inner join grp on #codegrp=codegrp  " +
"where Raff.#nom='{0}'" +
"and Raff.#nom not in(select #nom from pay where  #nom='{0}'and" +
" #annee='{1}' and monthp='{2}')",txtnompE.Text,cmbannepE.Text,cmbmonthpE.Text ));


            if (dt.Rows.Count != 0)
            {

                MemberGlobal.dt = dt;
                Frmafichage f = new Frmafichage();
                f.Show();


            }
            else
            {
                MemberGlobal.messageBox(new frmMssageboxSucces(), "Tout a payé");
            }
        }

        private void txtcin_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }
    }
}
