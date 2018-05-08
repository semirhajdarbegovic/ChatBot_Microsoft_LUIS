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

namespace Bot_Stats_UI_Forms.Entity
{
    public partial class EntityInsert : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public EntityInsert()
        {
            InitializeComponent();
        }

        private void EntityInsert_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ChatBot.Entity ent = new ChatBot.Entity();
                ent.IntentId = Convert.ToInt32(cmbIntent.SelectedValue);
                ent.Value = txtValue.Text.ToString();
                ent.Type = txtValue.Text.ToString();
                db.Entity.Add(ent);
                db.SaveChanges();
                MessageBox.Show("Uspjesno obavljeno!");
                txtValue.Text = "";
                txtType.Text = "";
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
