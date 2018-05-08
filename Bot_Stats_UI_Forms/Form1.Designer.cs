namespace Bot_Stats_UI_Forms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.answerInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intentInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intentDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainedIntentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainedRandomQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersQuestionsAndAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionIntentScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.answerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.diagramsToolStripMenuItem,
            this.trainedDataToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 12, 0, 12);
            this.menuStrip1.Size = new System.Drawing.Size(708, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.answerInsertToolStripMenuItem,
            this.intentInsertToolStripMenuItem,
            this.entityInsertToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // answerInsertToolStripMenuItem
            // 
            this.answerInsertToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.answerInsertToolStripMenuItem.Name = "answerInsertToolStripMenuItem";
            this.answerInsertToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.answerInsertToolStripMenuItem.Text = "Answer Insert";
            this.answerInsertToolStripMenuItem.Click += new System.EventHandler(this.answerInsertToolStripMenuItem_Click);
            // 
            // intentInsertToolStripMenuItem
            // 
            this.intentInsertToolStripMenuItem.Name = "intentInsertToolStripMenuItem";
            this.intentInsertToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.intentInsertToolStripMenuItem.Text = "Intent Insert";
            this.intentInsertToolStripMenuItem.Click += new System.EventHandler(this.intentInsertToolStripMenuItem_Click);
            // 
            // entityInsertToolStripMenuItem
            // 
            this.entityInsertToolStripMenuItem.Name = "entityInsertToolStripMenuItem";
            this.entityInsertToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.entityInsertToolStripMenuItem.Text = "Entity Insert";
            this.entityInsertToolStripMenuItem.Click += new System.EventHandler(this.entityInsertToolStripMenuItem_Click);
            // 
            // diagramsToolStripMenuItem
            // 
            this.diagramsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intentDiagramToolStripMenuItem,
            this.questionIntentScoreToolStripMenuItem});
            this.diagramsToolStripMenuItem.Name = "diagramsToolStripMenuItem";
            this.diagramsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.diagramsToolStripMenuItem.Text = "Diagrams";
            // 
            // intentDiagramToolStripMenuItem
            // 
            this.intentDiagramToolStripMenuItem.Name = "intentDiagramToolStripMenuItem";
            this.intentDiagramToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.intentDiagramToolStripMenuItem.Text = "Intent Diagram";
            this.intentDiagramToolStripMenuItem.Click += new System.EventHandler(this.intentDiagramToolStripMenuItem_Click);
            // 
            // trainedDataToolStripMenuItem
            // 
            this.trainedDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainedIntentsToolStripMenuItem,
            this.trainedRandomQuestionToolStripMenuItem});
            this.trainedDataToolStripMenuItem.Name = "trainedDataToolStripMenuItem";
            this.trainedDataToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.trainedDataToolStripMenuItem.Text = "Trained Data";
            // 
            // trainedIntentsToolStripMenuItem
            // 
            this.trainedIntentsToolStripMenuItem.Name = "trainedIntentsToolStripMenuItem";
            this.trainedIntentsToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.trainedIntentsToolStripMenuItem.Text = "Trained Intents";
            this.trainedIntentsToolStripMenuItem.Click += new System.EventHandler(this.trainedIntentsToolStripMenuItem_Click);
            // 
            // trainedRandomQuestionToolStripMenuItem
            // 
            this.trainedRandomQuestionToolStripMenuItem.Name = "trainedRandomQuestionToolStripMenuItem";
            this.trainedRandomQuestionToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.trainedRandomQuestionToolStripMenuItem.Text = "Trained Random Question";
            this.trainedRandomQuestionToolStripMenuItem.Click += new System.EventHandler(this.trainedRandomQuestionToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersQuestionsAndAnswersToolStripMenuItem,
            this.questionsStatsToolStripMenuItem,
            this.answerStatsToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // usersQuestionsAndAnswersToolStripMenuItem
            // 
            this.usersQuestionsAndAnswersToolStripMenuItem.Name = "usersQuestionsAndAnswersToolStripMenuItem";
            this.usersQuestionsAndAnswersToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.usersQuestionsAndAnswersToolStripMenuItem.Text = "Users Questions And Answers";
            this.usersQuestionsAndAnswersToolStripMenuItem.Click += new System.EventHandler(this.usersQuestionsAndAnswersToolStripMenuItem_Click);
            // 
            // questionsStatsToolStripMenuItem
            // 
            this.questionsStatsToolStripMenuItem.Name = "questionsStatsToolStripMenuItem";
            this.questionsStatsToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.questionsStatsToolStripMenuItem.Text = "Questions Stats";
            this.questionsStatsToolStripMenuItem.Click += new System.EventHandler(this.questionsStatsToolStripMenuItem_Click);
            // 
            // questionIntentScoreToolStripMenuItem
            // 
            this.questionIntentScoreToolStripMenuItem.Name = "questionIntentScoreToolStripMenuItem";
            this.questionIntentScoreToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.questionIntentScoreToolStripMenuItem.Text = "Question Intent Score";
            this.questionIntentScoreToolStripMenuItem.Click += new System.EventHandler(this.questionIntentScoreToolStripMenuItem_Click);
            // 
            // answerStatsToolStripMenuItem
            // 
            this.answerStatsToolStripMenuItem.Name = "answerStatsToolStripMenuItem";
            this.answerStatsToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.answerStatsToolStripMenuItem.Text = "Answer Stats";
            this.answerStatsToolStripMenuItem.Click += new System.EventHandler(this.answerStatsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(708, 384);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Bot Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem answerInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intentInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entityInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intentDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainedIntentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainedRandomQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersQuestionsAndAnswersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionsStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionIntentScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem answerStatsToolStripMenuItem;
    }
}

