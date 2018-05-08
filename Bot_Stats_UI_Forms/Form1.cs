using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot_Stats_UI_Forms.Answer;
using Bot_Stats_UI_Forms.Diagrams;
using Bot_Stats_UI_Forms.Entity;
using Bot_Stats_UI_Forms.Intent;
using Bot_Stats_UI_Forms.Statistics;
using Bot_Stats_UI_Forms.TrainedData;

namespace Bot_Stats_UI_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void answerInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertAnswer answerInsert = new InsertAnswer();
            answerInsert.MdiParent = this;
            answerInsert.Show();
        }

        private void intentInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntentInsert intentInsert = new IntentInsert();
            intentInsert.MdiParent = this;
            intentInsert.Show();
        }

        private void entityInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntityInsert entityInsert = new EntityInsert();
            entityInsert.MdiParent = this;
            entityInsert.Show();
        }

        private void intentDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntityStatDiagram entityStatDiagram = new EntityStatDiagram();
            entityStatDiagram.MdiParent = this;
            entityStatDiagram.Show();
        }

        private void trainedIntentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingIntentData entityStatDiagram = new TrainingIntentData();
            entityStatDiagram.MdiParent = this;
            entityStatDiagram.Show();
        }

        private void trainedRandomQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingRandomChatData entityStatDiagram = new TrainingRandomChatData();
            entityStatDiagram.MdiParent = this;
            entityStatDiagram.Show();
        }

        private void usersQuestionsAndAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QnAReceivedData qnAReceivedData = new QnAReceivedData();
            qnAReceivedData.MdiParent = this;
            qnAReceivedData.Show();
        }

        private void questionsStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botQuestStats botsQuestions = new botQuestStats();
            botsQuestions.MdiParent = this;
            botsQuestions.Show();
        }

        private void questionIntentScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionIntentScore questionIntentScore = new QuestionIntentScore();
            questionIntentScore.MdiParent = this;
            questionIntentScore.Show();
        }

        private void answerStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BotsAnswer botsAnswer = new BotsAnswer();
            botsAnswer.MdiParent = this;
            botsAnswer.Show();
        }
    }
}
