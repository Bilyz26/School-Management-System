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
    public partial class Frmafichage : Form
    {
        public Frmafichage()
        {
            InitializeComponent();
        }

        private void Frmafichage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MemberGlobal.dt;
        }
    }
}
