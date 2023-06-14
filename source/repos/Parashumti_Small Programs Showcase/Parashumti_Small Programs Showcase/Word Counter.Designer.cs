namespace Parashumti_Small_Programs_Showcase
{
    partial class WordCount
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
            this.lblInstruct = new System.Windows.Forms.Label();
            this.rtStory = new System.Windows.Forms.RichTextBox();
            this.lisWords = new System.Windows.Forms.ListBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Location = new System.Drawing.Point(12, 24);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(220, 13);
            this.lblInstruct.TabIndex = 0;
            this.lblInstruct.Text = "Type your story below, and then press Count.";
            this.lblInstruct.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtStory
            // 
            this.rtStory.Location = new System.Drawing.Point(15, 40);
            this.rtStory.Name = "rtStory";
            this.rtStory.Size = new System.Drawing.Size(463, 132);
            this.rtStory.TabIndex = 1;
            this.rtStory.Text = "";
            // 
            // lisWords
            // 
            this.lisWords.FormattingEnabled = true;
            this.lisWords.Location = new System.Drawing.Point(532, 40);
            this.lisWords.Name = "lisWords";
            this.lisWords.Size = new System.Drawing.Size(182, 303);
            this.lisWords.TabIndex = 2;
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCount.Location = new System.Drawing.Point(195, 178);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(107, 34);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(579, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 396);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lisWords);
            this.Controls.Add(this.rtStory);
            this.Controls.Add(this.lblInstruct);
            this.Name = "WordCount";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.RichTextBox rtStory;
        private System.Windows.Forms.ListBox lisWords;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClose;
    }
}