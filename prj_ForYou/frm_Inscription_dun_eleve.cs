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
    public partial class frm_Inscription_dun_eleve : Form
    {
        public frm_Inscription_dun_eleve()
        {
            InitializeComponent();
           
        }

      
        private void frm_Inscription_dun_eleve_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);

            dtpdatedebut.Format = DateTimePickerFormat.Custom;
            dtpdatedebut.CustomFormat =  "yyyy/MM/dd";
            cbcin.Checked = false;
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbeleve_Enter(object sender, EventArgs e)
        {

        }
        decimal fri;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtcineleve.Text != "" && qui != "" && txtnomprenomeleve.Text != "" && mtxtteleleve.Text != "" && dtpdatedebut.Text != "")
            {
               
                DataTable b = MemberGlobal.rechercher(string.Format("select*from inscStd where nom='{0}' ", txtnomprenomeleve.Text));
                if (b.Rows.Count == 0)
                {
                    if (txtfrinscr.Text == "")
                    {
                        fri = 0;
                    }
                    else
                    { fri = decimal.Parse(txtfrinscr.Text); }



                    string s = string.Format("insert into inscStd values('{0}','{1}','{2}','{3}',{4},'{5}' )",
                            txtcineleve.Text, qui, txtnomprenomeleve.Text, mtxtteleleve.Text, fri, dtpdatedebut.Value);
                    bool i = MemberGlobal.Insert_Edit_Delete(s);
                    if (i == true)

                    { MemberGlobal.messageBox(new frmMssageboxSucces(), " Ajouter avec succée");              /* MessageBox.Show("Ajouter avec succée");*/
                        MemberGlobal.vider(this);
                    }

                }
                else
                { MemberGlobal.messageBox(new frmMessagboxFaile(), "Le Nom d'éléve éxist Deja"); }
            }
        }
        string qui = "élève";
        private void cbcin_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcin.Checked==false)
            { qui = "élève"; }
            else
            { qui = "Paren"; }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        DataTable dt;
        private void btnrechercher_Click(object sender, EventArgs e)
        {
            if (txtrech.Text != "")
            {
                dt = MemberGlobal.rechercher(string.Format("select nom as'Nom et Prenom',#cin as'CIN', qui as'Le propriétaire de Cin',tele as'numéro de telephone',frinsc as'Frais d inscription',dateD as'date  d inscription' from inscStd where #cin='{0}' or nom like '{1}%' ", txtrech.Text,txtrech.Text));

                if (dt.Rows.Count != 0)
                {
                    //txtcineleve.Text = dt.Rows[0][0].ToString();
                    //txtnomprenomeleve.Text= dt.Rows[0][2].ToString();
                    //mtxtteleleve.Text= dt.Rows[0][3].ToString();
                    //txtfrinscr.Text= dt.Rows[0][4].ToString();
                    //dtpdatedebut.Text= dt.Rows[0][5].ToString();
                    //if(dt.Rows[0][1].ToString()=="P")
                    //{ cbcin.Checked = true; }
                    //else { cbcin.Checked = false; }

                    ////dataGridView1.DataSource = dt;
                    //btnmodifier.Enabled = true;

                    dataGridView1.DataSource = dt;
                }
                else
                {
                    
                    MemberGlobal.messageBox(new frmMessagboxFaile(), "y'a aucun élève avec les données vous saisir");
                }
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            //DataTable dt = MemberGlobal.rechercher(string.Format("select*from inscStd where nom='{0}'", txtnomprenomeleve.Text));
            try
            {
                if (dt.Rows.Count != 0)
                {

                    decimal f;
                    if (txtfrinscr.Text == "")
                    {
                        f = 0;
                    }
                    else { f = decimal.Parse(txtfrinscr.Text); }
                    string s = string.Format("update inscStd set #cin='{0}',nom='{1}',tele='{2}'" + ",frinsc={3},dateD='{4}',qui='{6}' where nom='{5}' "
                     , txtcineleve.Text, txtnomprenomeleve.Text, mtxtteleleve.Text, f, dtpdatedebut.Value, dt.Rows[pos][0].ToString(), qui);
                    bool i = MemberGlobal.Insert_Edit_Delete(s);
                    //MessageBox.Show(s);
                    if (i == true)
                    {
                        
                        MemberGlobal.messageBox(new frmMssageboxSucces(), "modifier avec succées ");
                    }
                    else
                    { MemberGlobal.messageBox(new frmMessagboxFaile(), "y'a aucun élève avec les données vous saisir"); }

                }
            }
            catch 
            {
                //MessageBox.Show("");
            }

           
           
        }
        int pos;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {try
            {
                //DataTable dt = MemberGlobal.rechercher(string.Format("select*from inscStd where #cin='{0}' ", txtcineleve.Text));
                //dataGridView1.DataSource = dt;
                if (dt.Rows.Count != 0)
                { 

                    pos = dataGridView1.CurrentRow.Index;
                    if (pos == dataGridView1.Rows.Count - 1)
                    { pos = pos - 1; }
                    txtcineleve.Text = dt.Rows[pos][1].ToString();
                    txtnomprenomeleve.Text = dt.Rows[pos][0].ToString();
                    mtxtteleleve.Text = dt.Rows[pos][3].ToString();
                    txtfrinscr.Text = dt.Rows[pos][4].ToString();
                    dtpdatedebut.Text = dt.Rows[pos][5].ToString();
                    if (dt.Rows[pos][2].ToString() == "Parent")
                    { cbcin.Checked = true; }
                    else { cbcin.Checked = false; }




                }
               
            }
            catch
            {


            }

        }

        private void frm_Inscription_dun_eleve_MaximumSizeChanged(object sender, EventArgs e)
        {

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbcin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbcin.Checked == false)
            { qui = "élève"; }
            else
            { qui = "Paren"; }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtcineleve.Text = string.Empty;
            txtfrinscr.Text = string.Empty;
            txtnomprenomeleve.Text = "";
            mtxtteleleve.Text = string.Empty;
            cbcin.Checked = false;
            dtpdatedebut.Text = string.Empty;
            
            txtrech.Text = string.Empty;
            if (txtnomprenomeleve.Text == string.Empty)
            {  dataGridView1.Columns.Clear();
                txtcineleve.Text = string.Empty;
                txtfrinscr.Text = string.Empty;
                txtnomprenomeleve.Text = "";
                mtxtteleleve.Text = string.Empty;
                cbcin.Checked = false;
                dtpdatedebut.Text = string.Empty;

                txtrech.Text = string.Empty;
            }
               
        }
     
        private void txtrech_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                btnrechercher_Click(sender, e);  
            }
        }
    }
}
