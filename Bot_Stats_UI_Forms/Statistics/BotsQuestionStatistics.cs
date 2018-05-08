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
    public partial class botQuestStats : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public botQuestStats()
        {
            InitializeComponent();
        }

        private void botQuestStats_Load(object sender, EventArgs e)
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
                cmb_IntentFilters.DataSource = intents;
                cmb_IntentFilters.DisplayMember = "Name";
                cmb_IntentFilters.ValueMember = "IntentId";
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
                dgv_QuestStatists.AutoGenerateColumns = false;
                BindingListView<sp_GetQuestionIntentScore_Result> view = new BindingListView<sp_GetQuestionIntentScore_Result>(db.sp_GetQuestionIntentScore(null).ToList());
                dgv_QuestStatists.DataSource = view;
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(e);
            }
            
        }

        private void btn_FilgerQnADatas_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_QuestStatists.AutoGenerateColumns = false;
                dgv_QuestStatists.DataSource = db.sp_GetQuestionIntentScore(Convert.ToInt32(cmb_IntentFilters.SelectedValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(exception);
            }
            
        }

        private void btn_ShowAlls_Click(object sender, EventArgs e)
        {
            GenerateQnAData();
        }

        private void btn_PrintBQuestStats_Click(object sender, EventArgs e)
        {
            int? id = null;

            if (Convert.ToInt32(cmb_IntentFilters.SelectedValue) != null &&
                Convert.ToInt32(cmb_IntentFilters.SelectedValue) > 0)
            {
                id = Convert.ToInt32(cmb_IntentFilters.SelectedValue);
            }

            Rpt_BotQuestionStatistics report = new Rpt_BotQuestionStatistics(id);
            report.Show();
        }
    }
}
