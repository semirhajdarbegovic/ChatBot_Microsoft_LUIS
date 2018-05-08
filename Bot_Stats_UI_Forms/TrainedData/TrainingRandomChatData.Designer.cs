namespace Bot_Stats_UI_Forms.TrainedData
{
    partial class TrainingRandomChatData
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
            this.trained_randon_data_dgv = new System.Windows.Forms.DataGridView();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pitanje_tq = new System.Windows.Forms.TextBox();
            this.tb_odgovor_tq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_spasi_tq = new System.Windows.Forms.Button();
            this.btn_uredi_tq = new System.Windows.Forms.Button();
            this.btn_testiraj_tq = new System.Windows.Forms.Button();
            this.tb_odgovor_test_tq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pitanje_test_tq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PitanjeInsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_DodajPitanje = new System.Windows.Forms.Button();
            this.txt_OdgovorInsert = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trained_randon_data_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trained_randon_data_dgv
            // 
            this.trained_randon_data_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trained_randon_data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trained_randon_data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionId,
            this.AnswerId,
            this.Question,
            this.Answer});
            this.trained_randon_data_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trained_randon_data_dgv.Location = new System.Drawing.Point(0, 285);
            this.trained_randon_data_dgv.Name = "trained_randon_data_dgv";
            this.trained_randon_data_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trained_randon_data_dgv.Size = new System.Drawing.Size(1117, 341);
            this.trained_randon_data_dgv.TabIndex = 0;
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
            // Question
            // 
            this.Question.DataPropertyName = "Question";
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pitanje";
            // 
            // txt_pitanje_tq
            // 
            this.txt_pitanje_tq.Location = new System.Drawing.Point(9, 55);
            this.txt_pitanje_tq.Name = "txt_pitanje_tq";
            this.txt_pitanje_tq.Size = new System.Drawing.Size(224, 20);
            this.txt_pitanje_tq.TabIndex = 2;
            // 
            // tb_odgovor_tq
            // 
            this.tb_odgovor_tq.Location = new System.Drawing.Point(9, 121);
            this.tb_odgovor_tq.Name = "tb_odgovor_tq";
            this.tb_odgovor_tq.Size = new System.Drawing.Size(224, 20);
            this.tb_odgovor_tq.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odgovor";
            // 
            // btn_spasi_tq
            // 
            this.btn_spasi_tq.Location = new System.Drawing.Point(9, 170);
            this.btn_spasi_tq.Name = "btn_spasi_tq";
            this.btn_spasi_tq.Size = new System.Drawing.Size(224, 30);
            this.btn_spasi_tq.TabIndex = 5;
            this.btn_spasi_tq.Text = "Sacuvaj";
            this.btn_spasi_tq.UseVisualStyleBackColor = true;
            this.btn_spasi_tq.Click += new System.EventHandler(this.btn_spasi_tq_Click);
            // 
            // btn_uredi_tq
            // 
            this.btn_uredi_tq.Location = new System.Drawing.Point(12, 256);
            this.btn_uredi_tq.Name = "btn_uredi_tq";
            this.btn_uredi_tq.Size = new System.Drawing.Size(92, 23);
            this.btn_uredi_tq.TabIndex = 6;
            this.btn_uredi_tq.Text = "Uredi";
            this.btn_uredi_tq.UseVisualStyleBackColor = true;
            this.btn_uredi_tq.Click += new System.EventHandler(this.btn_uredi_tq_Click);
            // 
            // btn_testiraj_tq
            // 
            this.btn_testiraj_tq.Location = new System.Drawing.Point(9, 163);
            this.btn_testiraj_tq.Name = "btn_testiraj_tq";
            this.btn_testiraj_tq.Size = new System.Drawing.Size(224, 30);
            this.btn_testiraj_tq.TabIndex = 11;
            this.btn_testiraj_tq.Text = "Testiraj";
            this.btn_testiraj_tq.UseVisualStyleBackColor = true;
            this.btn_testiraj_tq.Click += new System.EventHandler(this.btn_testiraj_tq_Click);
            // 
            // tb_odgovor_test_tq
            // 
            this.tb_odgovor_test_tq.Location = new System.Drawing.Point(9, 114);
            this.tb_odgovor_test_tq.Name = "tb_odgovor_test_tq";
            this.tb_odgovor_test_tq.Size = new System.Drawing.Size(224, 20);
            this.tb_odgovor_test_tq.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Odgovor";
            // 
            // tb_pitanje_test_tq
            // 
            this.tb_pitanje_test_tq.Location = new System.Drawing.Point(9, 48);
            this.tb_pitanje_test_tq.Name = "tb_pitanje_test_tq";
            this.tb_pitanje_test_tq.Size = new System.Drawing.Size(224, 20);
            this.tb_pitanje_test_tq.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pitanje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_pitanje_tq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_odgovor_tq);
            this.groupBox1.Controls.Add(this.btn_spasi_tq);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uredjivanje Pitanje/Odgovor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_pitanje_test_tq);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_testiraj_tq);
            this.groupBox2.Controls.Add(this.tb_odgovor_test_tq);
            this.groupBox2.Location = new System.Drawing.Point(314, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 215);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testiranje Podataka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pitanje";
            // 
            // txt_PitanjeInsert
            // 
            this.txt_PitanjeInsert.Location = new System.Drawing.Point(9, 48);
            this.txt_PitanjeInsert.Name = "txt_PitanjeInsert";
            this.txt_PitanjeInsert.Size = new System.Drawing.Size(224, 20);
            this.txt_PitanjeInsert.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Odgovor";
            // 
            // btn_DodajPitanje
            // 
            this.btn_DodajPitanje.Location = new System.Drawing.Point(9, 163);
            this.btn_DodajPitanje.Name = "btn_DodajPitanje";
            this.btn_DodajPitanje.Size = new System.Drawing.Size(224, 30);
            this.btn_DodajPitanje.TabIndex = 19;
            this.btn_DodajPitanje.Text = "Dodaj novo pitanje/odgovor";
            this.btn_DodajPitanje.UseVisualStyleBackColor = true;
            this.btn_DodajPitanje.Click += new System.EventHandler(this.btn_DodajPitanje_Click);
            // 
            // txt_OdgovorInsert
            // 
            this.txt_OdgovorInsert.Location = new System.Drawing.Point(9, 114);
            this.txt_OdgovorInsert.Name = "txt_OdgovorInsert";
            this.txt_OdgovorInsert.Size = new System.Drawing.Size(224, 20);
            this.txt_OdgovorInsert.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_OdgovorInsert);
            this.groupBox3.Controls.Add(this.txt_PitanjeInsert);
            this.groupBox3.Controls.Add(this.btn_DodajPitanje);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(613, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 215);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodavanje novog pitanja";
            // 
            // TrainingRandomChatData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_uredi_tq);
            this.Controls.Add(this.trained_randon_data_dgv);
            this.Name = "TrainingRandomChatData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Random Chat Data";
            this.Load += new System.EventHandler(this.TrainingRandomChatData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trained_randon_data_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView trained_randon_data_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pitanje_tq;
        private System.Windows.Forms.TextBox tb_odgovor_tq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_spasi_tq;
        private System.Windows.Forms.Button btn_uredi_tq;
        private System.Windows.Forms.Button btn_testiraj_tq;
        private System.Windows.Forms.TextBox tb_odgovor_test_tq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pitanje_test_tq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PitanjeInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DodajPitanje;
        private System.Windows.Forms.TextBox txt_OdgovorInsert;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}