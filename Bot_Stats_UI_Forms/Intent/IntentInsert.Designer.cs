namespace Bot_Stats_UI_Forms.Intent
{
    partial class IntentInsert
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
            this.btnIntentSave = new System.Windows.Forms.Button();
            this.dgv_Intents = new System.Windows.Forms.DataGridView();
            this.IntentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Intent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Intents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIntentSave
            // 
            this.btnIntentSave.Location = new System.Drawing.Point(16, 101);
            this.btnIntentSave.Name = "btnIntentSave";
            this.btnIntentSave.Size = new System.Drawing.Size(189, 53);
            this.btnIntentSave.TabIndex = 2;
            this.btnIntentSave.Text = "Add Intent";
            this.btnIntentSave.UseVisualStyleBackColor = true;
            this.btnIntentSave.Click += new System.EventHandler(this.btnIntentSave_Click);
            // 
            // dgv_Intents
            // 
            this.dgv_Intents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Intents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Intents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntentId,
            this.Name_Intent});
            this.dgv_Intents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Intents.Location = new System.Drawing.Point(0, 214);
            this.dgv_Intents.Name = "dgv_Intents";
            this.dgv_Intents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Intents.Size = new System.Drawing.Size(733, 300);
            this.dgv_Intents.TabIndex = 3;
            // 
            // IntentId
            // 
            this.IntentId.DataPropertyName = "IntentId";
            this.IntentId.HeaderText = "IntentId";
            this.IntentId.Name = "IntentId";
            // 
            // Name_Intent
            // 
            this.Name_Intent.DataPropertyName = "Name";
            this.Name_Intent.HeaderText = "Name";
            this.Name_Intent.Name = "Name_Intent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txtIntentName
            // 
            this.txtIntentName.Location = new System.Drawing.Point(12, 58);
            this.txtIntentName.Name = "txtIntentName";
            this.txtIntentName.Size = new System.Drawing.Size(189, 20);
            this.txtIntentName.TabIndex = 1;
            this.txtIntentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IntentInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 514);
            this.Controls.Add(this.dgv_Intents);
            this.Controls.Add(this.btnIntentSave);
            this.Controls.Add(this.txtIntentName);
            this.Controls.Add(this.label1);
            this.Name = "IntentInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intent Insert";
            this.Load += new System.EventHandler(this.IntentInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Intents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIntentSave;
        private System.Windows.Forms.DataGridView dgv_Intents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Intent;
    }
}