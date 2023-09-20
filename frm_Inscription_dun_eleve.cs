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
            MemberGlobal.cnxstring = "";
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbeleve_Enter(object sender, EventArgs e)
        {

        }
    }
}
