using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatBot;
using Microsoft.Reporting.WinForms;

namespace Bot_Stats_UI_Forms.Reports
{
    public partial class Rpt_Intent_Statistics : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public Rpt_Intent_Statistics()
        {
            InitializeComponent();
        }

        private void Rpt_Intent_Statistics_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Bot_Stats_UI_Forms.Reports.Rpt_Intent_Statistics.rdlc";

            bindingSource.DataSource = db.sp_Get_Intent_Statistics().ToList();

            ReportDataSource rds = new ReportDataSource("ds_IntentStatistics",
                bindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
