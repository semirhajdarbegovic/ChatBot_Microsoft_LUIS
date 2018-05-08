namespace Bot_Stats_UI_Forms.Answer
{
    partial class QnAReceivedData
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
            this.dgv_QnAData = new System.Windows.Forms.DataGridView();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_IntentFilter = new System.Windows.Forms.ComboBox();
            this.btn_FilgerQnAData = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QnAData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QnAData
            // 
            this.dgv_QnAData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QnAData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QnAData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionId,
            this.AnswerId,
            this.DateTime,
            this.Intent,
            this.UserInput,
            this.Answer});
            this.dgv_QnAData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_QnAData.Location = new System.Drawing.Point(0, 84);
            this.dgv_QnAData.Name = "dgv_QnAData";
            this.dgv_QnAData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QnAData.Size = new System.Drawing.Size(912, 457);
            this.dgv_QnAData.TabIndex = 0;
            // 
            // QuestionId
            // 
            this.QuestionId.DataPropertyName = "QuestionId";
            this.QuestionId.HeaderText = "QuestionId";
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.Visible = false;
            // 
            // AnswerId
            // 
            this.AnswerId.DataPropertyName = "AnswerId";
            this.AnswerId.HeaderText = "AnswerId";
            this.AnswerId.Name = "AnswerId";
            this.AnswerId.Visible = false;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "Date-Time ";
            this.DateTime.Name = "DateTime";
            // 
            // Intent
            // 
            this.Intent.DataPropertyName = "Intent";
            this.Intent.HeaderText = "Intent";
            this.Intent.Name = "Intent";
            // 
            // UserInput
            // 
            this.UserInput.DataPropertyName = "UserInput";
            this.UserInput.HeaderText = "User Input";
            this.UserInput.Name = "UserInput";
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Bot Answer";
            this.Answer.Name = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtriraj po intentu :";
            // 
            // cmb_IntentFilter
            // 
            this.cmb_IntentFilter.FormattingEnabled = true;
            this.cmb_IntentFilter.Location = new System.Drawing.Point(109, 18);
            this.cmb_IntentFilter.Name = "cmb_IntentFilter";
            this.cmb_IntentFilter.Size = new System.Drawing.Size(152, 21);
            this.cmb_IntentFilter.TabIndex = 2;
            // 
            // btn_FilgerQnAData
            // 
            this.btn_FilgerQnAData.Location = new System.Drawing.Point(282, 18);
            this.btn_FilgerQnAData.Name = "btn_FilgerQnAData";
            this.btn_FilgerQnAData.Size = new System.Drawing.Size(75, 23);
            this.btn_FilgerQnAData.TabIndex = 3;
            this.btn_FilgerQnAData.Text = "Filtriraj";
            this.btn_FilgerQnAData.UseVisualStyleBackColor = true;
            this.btn_FilgerQnAData.Click += new System.EventHandler(this.btn_FilgerQnAData_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Location = new System.Drawing.Point(374, 18);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAll.TabIndex = 4;
            this.btn_ShowAll.Text = "Prikazi sve";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(825, 18);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 5;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // QnAReceivedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 541);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_FilgerQnAData);
            this.Controls.Add(this.cmb_IntentFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_QnAData);
            this.Name = "QnAReceivedData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QnAReceivedData";
            this.Load += new System.EventHandler(this.QnAReceivedData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QnAData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QnAData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_IntentFilter;
        private System.Windows.Forms.Button btn_FilgerQnAData;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intent;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.Button btn_Print;
    }
}