namespace Bot_Stats_UI_Forms
{
    partial class EntityStatDiagram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.intent_diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_IntentPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intent_diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // intent_diagram
            // 
            chartArea2.Name = "ChartArea1";
            this.intent_diagram.ChartAreas.Add(chartArea2);
            this.intent_diagram.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.intent_diagram.Legends.Add(legend2);
            this.intent_diagram.Location = new System.Drawing.Point(0, 58);
            this.intent_diagram.Name = "intent_diagram";
            this.intent_diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Intent";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.intent_diagram.Series.Add(series2);
            this.intent_diagram.Size = new System.Drawing.Size(1079, 417);
            this.intent_diagram.TabIndex = 1;
            this.intent_diagram.Text = "chat_prikaz";
            this.intent_diagram.Click += new System.EventHandler(this.intent_diagram_Click);
            // 
            // btn_IntentPrint
            // 
            this.btn_IntentPrint.Location = new System.Drawing.Point(973, 13);
            this.btn_IntentPrint.Name = "btn_IntentPrint";
            this.btn_IntentPrint.Size = new System.Drawing.Size(94, 29);
            this.btn_IntentPrint.TabIndex = 2;
            this.btn_IntentPrint.Text = "Print";
            this.btn_IntentPrint.UseVisualStyleBackColor = true;
            this.btn_IntentPrint.Click += new System.EventHandler(this.btn_IntentPrint_Click);
            // 
            // EntityStatDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 475);
            this.Controls.Add(this.btn_IntentPrint);
            this.Controls.Add(this.intent_diagram);
            this.Name = "EntityStatDiagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intent Diagram";
            this.Load += new System.EventHandler(this.EntityStatDiagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intent_diagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart intent_diagram;
        private System.Windows.Forms.Button btn_IntentPrint;
    }
}