namespace Bot_Stats_UI_Forms.Answer
{
    partial class InsertAnswer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIntent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intent :";
            // 
            // cmbIntent
            // 
            this.cmbIntent.FormattingEnabled = true;
            this.cmbIntent.Location = new System.Drawing.Point(12, 42);
            this.cmbIntent.Name = "cmbIntent";
            this.cmbIntent.Size = new System.Drawing.Size(278, 21);
            this.cmbIntent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer text : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 3;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(12, 128);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(278, 151);
            this.answerTextBox.TabIndex = 4;
            this.answerTextBox.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 312);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(278, 53);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Answer";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // InsertAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 409);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIntent);
            this.Controls.Add(this.label1);
            this.Name = "InsertAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertAnswer";
            this.Load += new System.EventHandler(this.InsertAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIntent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox answerTextBox;
        private System.Windows.Forms.Button saveBtn;
    }
}