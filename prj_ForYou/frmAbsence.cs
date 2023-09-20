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
    public partial class frmAbsence : Form
    {
        public frmAbsence()
        {
            InitializeComponent();
        }

        private void frmAbsence_Load(object sender, EventArgs e)
        {
            raffTableAdapter1.Connection.ConnectionString = MemberGlobal.cnxstring;
            raffTableAdapter1.FillByGrp(ds1.Raff, frmImprimer.groupe, int.Parse(frmImprimer.Annee), frmImprimer.prof);
            CR cr = new CR();
            cr.SetDataSource(ds1);

            cr.SetParameterValue("Groupe", frmImprimer.groupe);
            cr.SetParameterValue("Niveau", frmImprimer.Niveau);
            cr.SetParameterValue("prof", frmImprimer.prof);
            cr.SetParameterValue("Matiere", frmImprimer.Matiere);
            cr.SetParameterValue("Annee", frmImprimer.Annee);

            crystalReportViewer1.ReportSource = cr;
        }
    }
}
