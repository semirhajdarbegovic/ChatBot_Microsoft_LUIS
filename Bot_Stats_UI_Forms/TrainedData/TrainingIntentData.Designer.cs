namespace Bot_Stats_UI_Forms.TrainedData
{
    partial class TrainingIntentData
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
            this.trainedIntent_data = new System.Windows.Forms.DataGridView();
            this.trained_intent_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odgovor_trained_data = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_uredi_trained_data = new System.Windows.Forms.Button();
            this.btn_izbrisi_trained_data = new System.Windows.Forms.Button();
            this.btn_spasi_trained_data = new System.Windows.Forms.Button();
            this.btn_refreshData = new System.Windows.Forms.Button();
            this.IntentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainedIntent_data)).BeginInit();
            this.SuspendLayout();
            // 
            // trainedIntent_data
            // 
            this.trainedIntent_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainedIntent_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainedIntent_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntentId,
            this.IntentName,
            this.Answer,
            this.AnswerId});
            this.trainedIntent_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trainedIntent_data.Location = new System.Drawing.Point(0, 201);
            this.trainedIntent_data.Name = "trainedIntent_data";
            this.trainedIntent_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainedIntent_data.Size = new System.Drawing.Size(825, 258);
            this.trainedIntent_data.TabIndex = 0;
            // 
            // trained_intent_txt
            // 
            this.trained_intent_txt.Location = new System.Drawing.Point(12, 46);
            this.trained_intent_txt.Name = "trained_intent_txt";
            this.trained_intent_txt.Size = new System.Drawing.Size(166, 20);
            this.trained_intent_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv intenta:";
            // 
            // odgovor_trained_data
            // 
            this.odgovor_trained_data.Location = new System.Drawing.Point(12, 99);
            this.odgovor_trained_data.Name = "odgovor_trained_data";
            this.odgovor_trained_data.Size = new System.Drawing.Size(166, 96);
            this.odgovor_trained_data.TabIndex = 3;
            this.odgovor_trained_data.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odgovor :";
            // 
            // btn_uredi_trained_data
            // 
            this.btn_uredi_trained_data.Location = new System.Drawing.Point(223, 39);
            this.btn_uredi_trained_data.Name = "btn_uredi_trained_data";
            this.btn_uredi_trained_data.Size = new System.Drawing.Size(100, 23);
            this.btn_uredi_trained_data.TabIndex = 5;
            this.btn_uredi_trained_data.Text = "Uredi";
            this.btn_uredi_trained_data.UseVisualStyleBackColor = true;
            this.btn_uredi_trained_data.Click += new System.EventHandler(this.btn_uredi_trained_data_Click);
            // 
            // btn_izbrisi_trained_data
            // 
            this.btn_izbrisi_trained_data.Location = new System.Drawing.Point(223, 80);
            this.btn_izbrisi_trained_data.Name = "btn_izbrisi_trained_data";
            this.btn_izbrisi_trained_data.Size = new System.Drawing.Size(100, 23);
            this.btn_izbrisi_trained_data.TabIndex = 6;
            this.btn_izbrisi_trained_data.Text = "Izbrisi";
            this.btn_izbrisi_trained_data.UseVisualStyleBackColor = true;
            this.btn_izbrisi_trained_data.Click += new System.EventHandler(this.btn_izbrisi_trained_data_Click);
            // 
            // btn_spasi_trained_data
            // 
            this.btn_spasi_trained_data.Location = new System.Drawing.Point(223, 118);
            this.btn_spasi_trained_data.Name = "btn_spasi_trained_data";
            this.btn_spasi_trained_data.Size = new System.Drawing.Size(100, 23);
            this.btn_spasi_trained_data.TabIndex = 7;
            this.btn_spasi_trained_data.Text = "Sacuvaj";
            this.btn_spasi_trained_data.UseVisualStyleBackColor = true;
            this.btn_spasi_trained_data.Click += new System.EventHandler(this.btn_spasi_trained_data_Click);
            // 
            // btn_refreshData
            // 
            this.btn_refreshData.Location = new System.Drawing.Point(223, 162);
            this.btn_refreshData.Name = "btn_refreshData";
            this.btn_refreshData.Size = new System.Drawing.Size(100, 23);
            this.btn_refreshData.TabIndex = 8;
            this.btn_refreshData.Text = "Osvjezi rezultate";
            this.btn_refreshData.UseVisualStyleBackColor = true;
            this.btn_refreshData.Click += new System.EventHandler(this.btn_refreshData_Click);
            // 
            // IntentId
            // 
            this.IntentId.DataPropertyName = "IntentId";
            this.IntentId.HeaderText = "IntentId";
            this.IntentId.Name = "IntentId";
            // 
            // IntentName
            // 
            this.IntentName.DataPropertyName = "IntentName";
            this.IntentName.HeaderText = "Intent Name";
            this.IntentName.Name = "IntentName";
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            // 
            // AnswerId
            // 
            this.AnswerId.DataPropertyName = "AnswerId";
            this.AnswerId.HeaderText = "AnswerId";
            this.AnswerId.Name = "AnswerId";
            this.AnswerId.Visible = false;
            // 
            // TrainingIntentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.btn_refreshData);
            this.Controls.Add(this.btn_spasi_trained_data);
            this.Controls.Add(this.btn_izbrisi_trained_data);
            this.Controls.Add(this.btn_uredi_trained_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odgovor_trained_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trained_intent_txt);
            this.Controls.Add(this.trainedIntent_data);
            this.Name = "TrainingIntentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Intent Data";
            this.Load += new System.EventHandler(this.TrainingIntentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainedIntent_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView trainedIntent_data;
        private System.Windows.Forms.TextBox trained_intent_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox odgovor_trained_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_uredi_trained_data;
        private System.Windows.Forms.Button btn_izbrisi_trained_data;
        private System.Windows.Forms.Button btn_spasi_trained_data;
        private System.Windows.Forms.Button btn_refreshData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerId;
    }
}