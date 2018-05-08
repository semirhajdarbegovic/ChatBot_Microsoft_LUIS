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

namespace Bot_Stats_UI_Forms.Statistics
{
    public partial class BotsAnswer : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public BotsAnswer()
        {
            InitializeComponent();
        }

        private void BotsAnswer_Load(object sender, EventArgs e)
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
                intents.Insert(0, new ChatBot.Intent() {IntentId = 0, Name = ""});
                cmb_AnsIntentFilters.DataSource = intents;
                cmb_AnsIntentFilters.DisplayMember = "Name";
                cmb_AnsIntentFilters.ValueMember = "IntentId";
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
                dgv_Answ_Stat.AutoGenerateColumns = false;
                BindingListView<sp_GetAnswerIntentStatistics_Result> view = new BindingListView<sp_GetAnswerIntentStatistics_Result> (db.sp_GetAnswerIntentStatistics(null).ToList());
                dgv_Answ_Stat.DataSource = view;
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(e);
            }
        }

        private void btn_AnsFilterData_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Answ_Stat.AutoGenerateColumns = false;
                dgv_Answ_Stat.DataSource = db.sp_GetAnswerIntentStatistics(Convert.ToInt32(cmb_AnsIntentFilters.SelectedValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(exception);
            }
        }

        private void btn_AnsShowAll_Click(object sender, EventArgs e)
        {
            GenerateQnAData();
        }

        private void btn_Print_BAnsData_Click(object sender, EventArgs e)
        {
            int? id = null;

            if (Convert.ToInt32(cmb_AnsIntentFilters.SelectedValue) != null &&
                Convert.ToInt32(cmb_AnsIntentFilters.SelectedValue) > 0)
            {
                id = Convert.ToInt32(cmb_AnsIntentFilters.SelectedValue);
            }

            Rpt_GetAnswerIntentStatistics report = new Rpt_GetAnswerIntentStatistics(id);
            report.Show();
        }
    }
}
