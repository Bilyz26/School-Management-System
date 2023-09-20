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
    public partial class frmBD_prof : Form
    {
        public frmBD_prof()
        {
            InitializeComponent();
        }

        private void frmBD_prof_Load(object sender, EventArgs e)
        {
            
        }
        DataTable dt;
        private void btncharger_Click(object sender, EventArgs e)
        {
            dt = MemberGlobal.rechercher("select * from prof");
            
        }

        private void btnimporter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=dt.Rows.Count- 1; i++)
            {
                string qr = string.Format("insert into prof values('{0}','{1}','{2}')", dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString());
                SqlConnection cnx = new SqlConnection(@"data source =.\sqlexpress;initial catalog=DB_proff;integrated security=true");

                SqlCommand cmd = new SqlCommand(qr, cnx);
                cnx.Open();
                int n = cmd.ExecuteNonQuery();
                cnx.Close();
            }

        }
    }
}
