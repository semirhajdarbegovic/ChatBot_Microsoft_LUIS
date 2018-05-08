using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot_Stats_UI_Forms.Reports;
using ChatBot;
using Equin.ApplicationFramework;

namespace Bot_Stats_UI_Forms.Answer
{
    public partial class QnAReceivedData : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public QnAReceivedData()
        {
            InitializeComponent();
        }

        private void QnAReceivedData_Load(object sender, EventArgs e)
        {
            GenerateQnAData();
            GenerateFilterData();
        }

        private void GenerateFilterData()
        {
            try
            {
                List<ChatBot.Intent> intents = new List<ChatBot.Intent>();
                intents = db.Intent.ToList();
                intents.Insert(0, new ChatBot.Intent() { IntentId = 0, Name = "" });
                cmb_IntentFilter.DataSource = intents;
                cmb_IntentFilter.DisplayMember = "Name";
                cmb_IntentFilter.ValueMember = "IntentId";
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(e);
            }
        }

        private void GenerateQnAData()
        {
            try
            {
                dgv_QnAData.AutoGenerateColumns = false;
               
                BindingListView<sp_GetQnAbyIntent_Result> view = new BindingListView<sp_GetQnAbyIntent_Result>(db.sp_GetQnAbyIntent(null).ToList());
                dgv_QnAData.DataSource = view;
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(e);
            }
        }

        private void btn_FilgerQnAData_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_QnAData.AutoGenerateColumns = false;
                dgv_QnAData.DataSource = db.sp_GetQnAbyIntent(Convert.ToInt32(cmb_IntentFilter.SelectedValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(exception);
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            GenerateQnAData();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int? id = null;

            if (Convert.ToInt32(cmb_IntentFilter.SelectedValue) != null &&
                Convert.ToInt32(cmb_IntentFilter.SelectedValue) > 0)
            {
                id = Convert.ToInt32(cmb_IntentFilter.SelectedValue);
            }

            Rpt_BotQuestionAnswerStatistics report = new Rpt_BotQuestionAnswerStatistics(id);
            report.Show();
        }
    }
}
