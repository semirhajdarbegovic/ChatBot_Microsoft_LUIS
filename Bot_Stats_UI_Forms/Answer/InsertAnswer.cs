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

namespace Bot_Stats_UI_Forms.Answer
{
    public partial class InsertAnswer : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public InsertAnswer()
        {
            InitializeComponent();
        }

        private void InsertAnswer_Load(object sender, EventArgs e)
        {
            DoPopulateIntent();
        }

        private void DoPopulateIntent()
        {
            List<ChatBot.Intent> intents = new List<ChatBot.Intent>();
            intents = db.Intent.ToList();

            if (intents.Count > 0)
            {
                cmbIntent.DataSource = intents;
                cmbIntent.DisplayMember = "Name";
                cmbIntent.ValueMember = "IntentId";
            }
            else
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ChatBot.Answer ans = new ChatBot.Answer();
                ans.IntentId = Convert.ToInt32(cmbIntent.SelectedValue);
                ans.Answer1 = answerTextBox.Text;
                db.Answer.Add(ans);
                db.SaveChanges();
                MessageBox.Show("Uspjesno izvrsena operacija!");
                answerTextBox.Text = "";
                cmbIntent.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(exception);
            }

        }
    }
}
