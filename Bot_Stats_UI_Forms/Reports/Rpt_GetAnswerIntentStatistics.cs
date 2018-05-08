﻿using System;
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
    public partial class Rpt_GetAnswerIntentStatistics : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public Rpt_GetAnswerIntentStatistics(int? id)
        {
            InitializeComponent();
            bindingSource.DataSource = db.sp_GetAnswerIntentStatistics(id).ToList();
        }

        private void Rpt_GetAnswerIntentStatistics_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Bot_Stats_UI_Forms.Reports.Rpt_GetAnswerIntentStatistics.rdlc";

            ReportDataSource rds = new ReportDataSource("ds_AnswerIntentStatistics",
                bindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}