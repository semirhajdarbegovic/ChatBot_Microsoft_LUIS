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

namespace Bot_Stats_UI_Forms.Intent
{
    public partial class IntentInsert : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public IntentInsert()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIntentSave_Click(object sender, EventArgs e)
        {
            try
            {
                ChatBot.Intent intent = new ChatBot.Intent();
                intent.Name = txtIntentName.Text.ToString();

                db.Intent.Add(intent);
                db.SaveChanges();

                txtIntentName.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Uspjesno obavljeno!");
                Console.WriteLine(exception);
            }
        }

        private void IntentInsert_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_Intents.AutoGenerateColumns = false;
                dgv_Intents.DataSource = db.Intent.ToList();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(exception);
            }
        }
    }
}
