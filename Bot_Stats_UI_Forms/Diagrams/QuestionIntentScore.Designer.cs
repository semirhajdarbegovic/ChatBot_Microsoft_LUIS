namespace Bot_Stats_UI_Forms.Diagrams
{
    partial class QuestionIntentScore
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch_QIScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_ShowAlls = new System.Windows.Forms.Button();
            this.btn_FilgerQnADatas = new System.Windows.Forms.Button();
            this.cmb_IntentFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ch_QIScore)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_QIScore
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_QIScore.ChartAreas.Add(chartArea1);
            this.ch_QIScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.ch_QIScore.Legends.Add(legend1);
            this.ch_QIScore.Location = new System.Drawing.Point(0, 84);
            this.ch_QIScore.Name = "ch_QIScore";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "IntentScore";
            this.ch_QIScore.Series.Add(series1);
            this.ch_QIScore.Size = new System.Drawing.Size(955, 459);
            this.ch_QIScore.TabIndex = 0;
            this.ch_QIScore.Text = "chart1";
            // 
            // btn_ShowAlls
            // 
            this.btn_ShowAlls.Location = new System.Drawing.Point(618, 24);
            this.btn_ShowAlls.Name = "btn_ShowAlls";
            this.btn_ShowAlls.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAlls.TabIndex = 17;
            this.btn_ShowAlls.Text = "Prikazi sve";
            this.btn_ShowAlls.UseVisualStyleBackColor = true;
            this.btn_ShowAlls.Click += new System.EventHandler(this.btn_ShowAlls_Click);
            // 
            // btn_FilgerQnADatas
            // 
            this.btn_FilgerQnADatas.Location = new System.Drawing.Point(526, 24);
            this.btn_FilgerQnADatas.Name = "btn_FilgerQnADatas";
            this.btn_FilgerQnADatas.Size = new System.Drawing.Size(75, 23);
            this.btn_FilgerQnADatas.TabIndex = 16;
            this.btn_FilgerQnADatas.Text = "Filtriraj";
            this.btn_FilgerQnADatas.UseVisualStyleBackColor = true;
            this.btn_FilgerQnADatas.Click += new System.EventHandler(this.btn_FilgerQnADatas_Click);
            // 
            // cmb_IntentFilters
            // 
            this.cmb_IntentFilters.FormattingEnabled = true;
            this.cmb_IntentFilters.Location = new System.Drawing.Point(353, 24);
            this.cmb_IntentFilters.Name = "cmb_IntentFilters";
            this.cmb_IntentFilters.Size = new System.Drawing.Size(152, 21);
            this.cmb_IntentFilters.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtriraj po intentu :";
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(868, 22);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 18;
            this.btn_Print.Text = "Printaj";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // QuestionIntentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 543);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_ShowAlls);
            this.Controls.Add(this.btn_FilgerQnADatas);
            this.Controls.Add(this.cmb_IntentFilters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_QIScore);
            this.Name = "QuestionIntentScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionIntentScore";
            this.Load += new System.EventHandler(this.QuestionIntentScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_QIScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_QIScore;
        private System.Windows.Forms.Button btn_ShowAlls;
        private System.Windows.Forms.Button btn_FilgerQnADatas;
        private System.Windows.Forms.ComboBox cmb_IntentFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Print;
    }
}