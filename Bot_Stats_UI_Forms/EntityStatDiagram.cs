using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Bot_Stats_UI_Forms.Reports;
using ChatBot;

namespace Bot_Stats_UI_Forms
{
    public partial class EntityStatDiagram : Form
    {
        private db_ChatBot_Entities db = new db_ChatBot_Entities();

        public EntityStatDiagram()
        {
            InitializeComponent();
        }

        private void EntityStatDiagram_Load(object sender, EventArgs e)
        {
            try
            {
                intent_diagram.Titles.Clear();
                var podaci = db.sp_Get_Intent_Statistics();
                intent_diagram.DataSource = podaci;

                intent_diagram.Series["Intent"].XValueMember = "Name";
                intent_diagram.Series["Intent"].YValueMembers = "Number";

                intent_diagram.Titles.Add("Ukupan broj traženih namjera (Intent)");

                intent_diagram.ChartAreas[0].AxisX.Interval = 1;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Greska u konekciji, pokusajte opet.");
                Console.WriteLine(exception);
            }
        }

        private void intent_diagram_Click(object sender, EventArgs e)
        {

        }

        private void btn_IntentPrint_Click(object sender, EventArgs e)
        {
            Rpt_Intent_Statistics reStatistics = new Rpt_Intent_Statistics();
            reStatistics.Show();
        }
    }
}
