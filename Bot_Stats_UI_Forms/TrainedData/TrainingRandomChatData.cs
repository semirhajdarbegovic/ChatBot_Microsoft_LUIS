using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatBot;
using Equin.ApplicationFramework;

namespace Bot_Stats_UI_Forms.TrainedData
{
    public partial class TrainingRandomChatData : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();
        TrainedRandomDataModel trainedRandomData = new TrainedRandomDataModel();

        public TrainingRandomChatData()
        {
            InitializeComponent();
        }

        private void TrainingRandomChatData_Load(object sender, EventArgs e)
        {
            GenerateTrainingData();
        }

        private void GenerateTrainingData()
        {
            trained_randon_data_dgv.DataSource = null;
            trained_randon_data_dgv.Rows.Clear();
            trained_randon_data_dgv.Refresh();
            List<TrainedRandomDataModel> trainedQuestions = new List<TrainedRandomDataModel>(
                );
            foreach (var odg in db.TrainedQuestion)
            {
                foreach (TrainedAnswer answer in db.TrainedAnswer)
                {
                    if (answer.TrainedQuestionId == odg.TrainedQuestionId)
                    {
                        trainedQuestions.Add(new TrainedRandomDataModel(){Answer = answer.TrainedAnswer1, AnswerId = answer.TrainedAnswerId,Question = odg.TrainedQuestion1, QuestionId = odg.TrainedQuestionId});
                    }
                }
            }
            trained_randon_data_dgv.AutoGenerateColumns = false;
            BindingListView<TrainedRandomDataModel> view = new BindingListView<TrainedRandomDataModel>(trainedQuestions);
            trained_randon_data_dgv.DataSource = view;
            
        }

        private void btn_uredi_tq_Click(object sender, EventArgs e)
        {
            if (trained_randon_data_dgv.Rows.Count == 0)
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
            else
            {
                int QuestionId = Convert.ToInt32(trained_randon_data_dgv.SelectedRows[0].Cells[0].Value.ToString());
                int AnswerId = Convert.ToInt32(trained_randon_data_dgv.SelectedRows[0].Cells[1].Value.ToString());
                string question = trained_randon_data_dgv.SelectedRows[0].Cells[2].Value.ToString();
                string answer = trained_randon_data_dgv.SelectedRows[0].Cells[3].Value.ToString();
                if (QuestionId > 0 && AnswerId > 0)
                {
                    txt_pitanje_tq.Text = question;
                    tb_odgovor_tq.Text = answer;

                    trainedRandomData.QuestionId = QuestionId;
                    trainedRandomData.Question = question;
                    trainedRandomData.AnswerId = AnswerId;
                    trainedRandomData.Answer = answer;
                }
                else
                    MessageBox.Show("Greska u konekciji, pokusajte opet.");
            }
        }

        private void btn_spasi_tq_Click(object sender, EventArgs e)
        {
            if (txt_pitanje_tq.Text.Length > 0 && tb_odgovor_tq.Text.Length > 0)
            {
                trainedRandomData.Question = txt_pitanje_tq.Text;
                trainedRandomData.Answer = tb_odgovor_tq.Text;
                
                db.EditTrainedQnA(trainedRandomData.QuestionId, trainedRandomData.AnswerId, trainedRandomData.Question,
                    trainedRandomData.Answer);

                GenerateTrainingData();
                txt_pitanje_tq.Text = "";
                tb_odgovor_tq.Text = "";
            }
        }

        private void btn_testiraj_tq_Click(object sender, EventArgs e)
        {
            var s = db.sp_GetTrainedAnswer(tb_pitanje_test_tq.Text);
            TrainedAnswerResultModel answer = new TrainedAnswerResultModel();
            foreach (var a in s)
            {
                answer.TrainedAnswer = a.TrainedAnswer;
                answer.TrainedAnswerId = a.TrainedAnswerId;
                answer.TrainedQuestion = a.TrainedQuestion;
            }
            tb_odgovor_test_tq.Text = answer.TrainedAnswer;
        }

        private void btn_DodajPitanje_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_PitanjeInsert.Text.Length > 0 && txt_OdgovorInsert.Text.Length > 0)
                {
                    TrainedQuestion trainedQuestion = new TrainedQuestion();
                    trainedQuestion.TrainedQuestion1 = txt_PitanjeInsert.Text;

                    int tQuestionId = db.TrainedQuestion.OrderByDescending(x=>x.TrainedQuestionId).FirstOrDefault().TrainedQuestionId + 1;

                    db.TrainedQuestion.Add(trainedQuestion);
                    db.SaveChanges();
                    if (tQuestionId > 0)
                    {
                        TrainedAnswer trainedAnswer = new TrainedAnswer();
                        trainedAnswer.TrainedAnswer1 = txt_OdgovorInsert.Text;
                        trainedAnswer.TrainedQuestionId = tQuestionId;

                        db.TrainedAnswer.Add(trainedAnswer);
                        db.SaveChanges();
                        GenerateTrainingData();
                        txt_PitanjeInsert.Text = "";
                        txt_OdgovorInsert.Text = "";
                    }
                    else
                        MessageBox.Show("Greška u konekciji, pokušajte ponovo!");
                }
                else
                    MessageBox.Show("Greška u konekciji, pokušajte ponovo!");
            }
            catch
            {
                MessageBox.Show("Greška u konekciji, pokušajte ponovo!");
            }

        }
    }
}
