using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatBot;
using Equin.ApplicationFramework;

namespace Bot_Stats_UI_Forms.TrainedData
{
    public partial class TrainingIntentData : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();
        private TrainedDataModel trainedDataModel = new TrainedDataModel();

        public TrainingIntentData()
        {
            InitializeComponent();
        }

        private void TrainingIntentData_Load(object sender, EventArgs e)
        {
            GenerateTrainingData();
        }

        private void GenerateTrainingData()
        {
            try
            {
                List<TrainedDataModel> trainedData = new List<TrainedDataModel>();

                foreach (ChatBot.Answer answer in db.Answer)
                {
                    if (answer.TrainedAnswer == true && !answer.IsDeleted)
                    {
                        trainedData.Add(new TrainedDataModel() { IntentId = answer.IntentId, Answer = answer.Answer1, IntentName = answer.Intent.Name, AnswerId = answer.AnswerId});
                    }
                }
                trainedIntent_data.Refresh();
                trainedIntent_data.AutoGenerateColumns = false;
                BindingListView<TrainedDataModel> view = new BindingListView<TrainedDataModel>(trainedData);
                trainedIntent_data.DataSource = view;
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u komunikaciji, pokusajte opet.");
                Console.WriteLine(e);
            }
        }

        private void btn_uredi_trained_data_Click(object sender, EventArgs e)
        {
            if (trainedIntent_data.Rows.Count == 0)
                MessageBox.Show("Greska u komunikaciji, pokusajte opet.");
            else
            {
                int intentId = Convert.ToInt32(trainedIntent_data.SelectedRows[0].Cells[0].Value.ToString());
                string intentName =trainedIntent_data.SelectedRows[0].Cells[1].Value.ToString();
                string answer =trainedIntent_data.SelectedRows[0].Cells[2].Value.ToString();
                int answerId = Convert.ToInt32(trainedIntent_data.SelectedRows[0].Cells[3].Value.ToString());

                if (intentId > 0)
                {
                    trainedDataModel.IntentId = intentId;
                    trainedDataModel.IntentName = intentName;
                    trainedDataModel.Answer = answer;
                    trainedDataModel.AnswerId = answerId;
                    GenerateTrainingData();
                    trained_intent_txt.Text = intentName;
                    odgovor_trained_data.Text = answer;
                }
                else
                    MessageBox.Show("Greska u komunikaciji, pokusajte opet.");
            }
        }

        private void btn_spasi_trained_data_Click(object sender, EventArgs e)
        {
            try
            {
                if (trained_intent_txt.Text.Length > 0 && odgovor_trained_data.Text.Length > 0)
                {
                    trainedDataModel.IntentName = trained_intent_txt.Text;
                    trainedDataModel.Answer = odgovor_trained_data.Text;

                    db.EditIntentAnswer(trainedDataModel.AnswerId, trainedDataModel.Answer);

                    GenerateTrainingData();
                    trained_intent_txt.Text = "";
                    odgovor_trained_data.Text = "";

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u komunikaciji, pokusajte opet.");
                Console.WriteLine(exception);
            }
        }

        private void btn_refreshData_Click(object sender, EventArgs e)
        {
            GenerateTrainingData();
        }

        private void btn_izbrisi_trained_data_Click(object sender, EventArgs e)
        {
            int answerId = Convert.ToInt32(trainedIntent_data.SelectedRows[0].Cells[3].Value.ToString());

            if (answerId > 0)
            {
                db.DeleteIntentAnswer(answerId);
                GenerateTrainingData();
            }
            else
                MessageBox.Show("Greska u komunikaciji, pokusajte opet.");
        
        }
    }
}
