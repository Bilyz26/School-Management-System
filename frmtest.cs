using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_ForYou.DSSTableAdapters;

namespace prj_ForYou
{
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private void frmtest_Load(object sender, EventArgs e)
        {
            //string grp = "mathA";
            //int annee = 2022;
            //string prof = "nouhayla zahouani";
            //DA_Raff da = new ();

            //DS ds = new DS();
            //da.FillByGrp(ds.Raff,grp,annee,prof);
            //dataGridView1.DataSource = ds.Raff;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
