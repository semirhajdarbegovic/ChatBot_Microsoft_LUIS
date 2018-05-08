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

namespace Bot_Stats_UI_Forms.Diagrams
{
    public partial class QuestionIntentScore : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public QuestionIntentScore()
        {
            InitializeComponent();
        }

        private void QuestionIntentScore_Load(object sender, EventArgs e)
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
                ch_QIScore.Titles.Clear();
                var podaci = db.sp_GetQuestionIntentScore(null).ToList();

                ch_QIScore.DataSource = podaci;

                ch_QIScore.Series["IntentScore"].XValueMember = "Name";
                ch_QIScore.Series["IntentScore"].YValueMembers = "IntentScore";

                ch_QIScore.Titles.Add("Ukupan broj traženih namjera (Intent)");

                ch_QIScore.ChartAreas[0].AxisX.Interval = 1;
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
                ch_QIScore.Titles.Clear();
                var podaci = db.sp_GetQuestionIntentScore(Convert.ToInt32(cmb_IntentFilters.SelectedValue)).ToList();

                ch_QIScore.DataSource = podaci;

                ch_QIScore.Series["IntentScore"].XValueMember = "Name";
                ch_QIScore.Series["IntentScore"].YValueMembers = "IntentScore";

                ch_QIScore.Titles.Add("Ukupan broj traženih namjera (Intent)");

                ch_QIScore.ChartAreas[0].AxisX.Interval = 1;
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int? id = null;

            if (Convert.ToInt32(cmb_IntentFilters.SelectedValue) != null &&
                Convert.ToInt32(cmb_IntentFilters.SelectedValue) > 0)
            {
                id = Convert.ToInt32(cmb_IntentFilters.SelectedValue);
            }

            Rpt_QuestionIntentScore report = new Rpt_QuestionIntentScore(id);
            report.Show();
        }
    }
}
