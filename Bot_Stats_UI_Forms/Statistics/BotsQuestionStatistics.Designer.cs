namespace Bot_Stats_UI_Forms.Statistics
{
    partial class botQuestStats
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
            this.btn_ShowAlls = new System.Windows.Forms.Button();
            this.btn_FilgerQnADatas = new System.Windows.Forms.Button();
            this.cmb_IntentFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_QuestStatists = new System.Windows.Forms.DataGridView();
            this.IntentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PrintBQuestStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuestStatists)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowAlls
            // 
            this.btn_ShowAlls.Location = new System.Drawing.Point(378, 14);
            this.btn_ShowAlls.Name = "btn_ShowAlls";
            this.btn_ShowAlls.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAlls.TabIndex = 13;
            this.btn_ShowAlls.Text = "Prikazi sve";
            this.btn_ShowAlls.UseVisualStyleBackColor = true;
            this.btn_ShowAlls.Click += new System.EventHandler(this.btn_ShowAlls_Click);
            // 
            // btn_FilgerQnADatas
            // 
            this.btn_FilgerQnADatas.Location = new System.Drawing.Point(286, 14);
            this.btn_FilgerQnADatas.Name = "btn_FilgerQnADatas";
            this.btn_FilgerQnADatas.Size = new System.Drawing.Size(75, 23);
            this.btn_FilgerQnADatas.TabIndex = 12;
            this.btn_FilgerQnADatas.Text = "Filtriraj";
            this.btn_FilgerQnADatas.UseVisualStyleBackColor = true;
            this.btn_FilgerQnADatas.Click += new System.EventHandler(this.btn_FilgerQnADatas_Click);
            // 
            // cmb_IntentFilters
            // 
            this.cmb_IntentFilters.FormattingEnabled = true;
            this.cmb_IntentFilters.Location = new System.Drawing.Point(113, 14);
            this.cmb_IntentFilters.Name = "cmb_IntentFilters";
            this.cmb_IntentFilters.Size = new System.Drawing.Size(152, 21);
            this.cmb_IntentFilters.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtriraj po intentu :";
            // 
            // dgv_QuestStatists
            // 
            this.dgv_QuestStatists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QuestStatists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuestStatists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntentId,
            this.Name,
            this.QuestionId,
            this.UserInput,
            this.IntentScore});
            this.dgv_QuestStatists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_QuestStatists.Location = new System.Drawing.Point(0, 114);
            this.dgv_QuestStatists.Name = "dgv_QuestStatists";
            this.dgv_QuestStatists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QuestStatists.Size = new System.Drawing.Size(1001, 367);
            this.dgv_QuestStatists.TabIndex = 9;
            // 
            // IntentId
            // 
            this.IntentId.DataPropertyName = "IntentId";
            this.IntentId.HeaderText = "IntentId";
            this.IntentId.Name = "IntentId";
            this.IntentId.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Intent Name";
            this.Name.Name = "Name";
            // 
            // QuestionId
            // 
            this.QuestionId.DataPropertyName = "QuestionId";
            this.QuestionId.HeaderText = "QuestionId";
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.Visible = false;
            // 
            // UserInput
            // 
            this.UserInput.DataPropertyName = "UserInput";
            this.UserInput.HeaderText = "User Input";
            this.UserInput.Name = "UserInput";
            // 
            // IntentScore
            // 
            this.IntentScore.DataPropertyName = "IntentScore";
            this.IntentScore.HeaderText = "Intent Score";
            this.IntentScore.Name = "IntentScore";
            // 
            // btn_PrintBQuestStats
            // 
            this.btn_PrintBQuestStats.Location = new System.Drawing.Point(914, 17);
            this.btn_PrintBQuestStats.Name = "btn_PrintBQuestStats";
            this.btn_PrintBQuestStats.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintBQuestStats.TabIndex = 14;
            this.btn_PrintBQuestStats.Text = "Print";
            this.btn_PrintBQuestStats.UseVisualStyleBackColor = true;
            this.btn_PrintBQuestStats.Click += new System.EventHandler(this.btn_PrintBQuestStats_Click);
            // 
            // botQuestStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 481);
            this.Controls.Add(this.btn_PrintBQuestStats);
            this.Controls.Add(this.btn_ShowAlls);
            this.Controls.Add(this.btn_FilgerQnADatas);
            this.Controls.Add(this.cmb_IntentFilters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_QuestStatists);
            this.Name.Name = "botQuestStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bots Question Statistics";
            this.Load += new System.EventHandler(this.botQuestStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuestStatists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowAlls;
        private System.Windows.Forms.Button btn_FilgerQnADatas;
        private System.Windows.Forms.ComboBox cmb_IntentFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_QuestStatists;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentScore;
        private System.Windows.Forms.Button btn_PrintBQuestStats;
    }
}