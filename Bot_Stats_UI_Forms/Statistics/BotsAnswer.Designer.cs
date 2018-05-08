namespace Bot_Stats_UI_Forms.Statistics
{
    partial class BotsAnswer
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
            this.dgv_Answ_Stat = new System.Windows.Forms.DataGridView();
            this.IntentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AnsShowAll = new System.Windows.Forms.Button();
            this.btn_AnsFilterData = new System.Windows.Forms.Button();
            this.cmb_AnsIntentFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Print_BAnsData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Answ_Stat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Answ_Stat
            // 
            this.dgv_Answ_Stat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Answ_Stat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Answ_Stat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntentId,
            this.Name,
            this.AnswerId,
            this.Answer});
            this.dgv_Answ_Stat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Answ_Stat.Location = new System.Drawing.Point(0, 86);
            this.dgv_Answ_Stat.Name = "dgv_Answ_Stat";
            this.dgv_Answ_Stat.Size = new System.Drawing.Size(874, 388);
            this.dgv_Answ_Stat.TabIndex = 0;
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
            // AnswerId
            // 
            this.AnswerId.DataPropertyName = "AnswerId";
            this.AnswerId.HeaderText = "AnswerId";
            this.AnswerId.Name = "AnswerId";
            this.AnswerId.Visible = false;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            // 
            // btn_AnsShowAll
            // 
            this.btn_AnsShowAll.Location = new System.Drawing.Point(375, 24);
            this.btn_AnsShowAll.Name = "btn_AnsShowAll";
            this.btn_AnsShowAll.Size = new System.Drawing.Size(75, 23);
            this.btn_AnsShowAll.TabIndex = 17;
            this.btn_AnsShowAll.Text = "Prikazi sve";
            this.btn_AnsShowAll.UseVisualStyleBackColor = true;
            this.btn_AnsShowAll.Click += new System.EventHandler(this.btn_AnsShowAll_Click);
            // 
            // btn_AnsFilterData
            // 
            this.btn_AnsFilterData.Location = new System.Drawing.Point(283, 24);
            this.btn_AnsFilterData.Name = "btn_AnsFilterData";
            this.btn_AnsFilterData.Size = new System.Drawing.Size(75, 23);
            this.btn_AnsFilterData.TabIndex = 16;
            this.btn_AnsFilterData.Text = "Filtriraj";
            this.btn_AnsFilterData.UseVisualStyleBackColor = true;
            this.btn_AnsFilterData.Click += new System.EventHandler(this.btn_AnsFilterData_Click);
            // 
            // cmb_AnsIntentFilters
            // 
            this.cmb_AnsIntentFilters.FormattingEnabled = true;
            this.cmb_AnsIntentFilters.Location = new System.Drawing.Point(110, 24);
            this.cmb_AnsIntentFilters.Name = "cmb_AnsIntentFilters";
            this.cmb_AnsIntentFilters.Size = new System.Drawing.Size(152, 21);
            this.cmb_AnsIntentFilters.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filtriraj po intentu :";
            // 
            // btn_Print_BAnsData
            // 
            this.btn_Print_BAnsData.Location = new System.Drawing.Point(787, 23);
            this.btn_Print_BAnsData.Name = "btn_Print_BAnsData";
            this.btn_Print_BAnsData.Size = new System.Drawing.Size(75, 23);
            this.btn_Print_BAnsData.TabIndex = 18;
            this.btn_Print_BAnsData.Text = "Print";
            this.btn_Print_BAnsData.UseVisualStyleBackColor = true;
            this.btn_Print_BAnsData.Click += new System.EventHandler(this.btn_Print_BAnsData_Click);
            // 
            // BotsAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 474);
            this.Controls.Add(this.btn_Print_BAnsData);
            this.Controls.Add(this.btn_AnsShowAll);
            this.Controls.Add(this.btn_AnsFilterData);
            this.Controls.Add(this.cmb_AnsIntentFilters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Answ_Stat);
            this.Name.Name = "BotsAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bots Answers Data";
            this.Load += new System.EventHandler(this.BotsAnswer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Answ_Stat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Answ_Stat;
        private System.Windows.Forms.Button btn_AnsShowAll;
        private System.Windows.Forms.Button btn_AnsFilterData;
        private System.Windows.Forms.ComboBox cmb_AnsIntentFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.Button btn_Print_BAnsData;
    }
}