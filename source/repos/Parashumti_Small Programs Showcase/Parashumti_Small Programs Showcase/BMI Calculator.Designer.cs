namespace Parashumti_Small_Programs_Showcase
{
    partial class FBMI
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
            this.rtIntro = new System.Windows.Forms.RichTextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBmi = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rtBmi = new System.Windows.Forms.RichTextBox();
            this.rtStatus = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtIntro
            // 
            this.rtIntro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtIntro.Location = new System.Drawing.Point(0, 12);
            this.rtIntro.Name = "rtIntro";
            this.rtIntro.Size = new System.Drawing.Size(448, 35);
            this.rtIntro.TabIndex = 0;
            this.rtIntro.Text = "Enter your weight in pounds and height in inches below. \nThen click Calculate.\n";
            this.rtIntro.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(23, 90);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 13);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight (lb)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(26, 131);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(55, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (in)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(110, 87);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(112, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(110, 128);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(112, 20);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Location = new System.Drawing.Point(26, 197);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(73, 13);
            this.lblBmi.TabIndex = 5;
            this.lblBmi.Text = "Your BMI is ...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(26, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Your status is ...";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(288, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 25);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(159, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 25);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtBmi
            // 
            this.rtBmi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtBmi.Location = new System.Drawing.Point(110, 189);
            this.rtBmi.Name = "rtBmi";
            this.rtBmi.Size = new System.Drawing.Size(83, 21);
            this.rtBmi.TabIndex = 11;
            this.rtBmi.Text = "";
            this.rtBmi.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // rtStatus
            // 
            this.rtStatus.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtStatus.Location = new System.Drawing.Point(110, 229);
            this.rtStatus.Name = "rtStatus";
            this.rtStatus.Size = new System.Drawing.Size(148, 22);
            this.rtStatus.TabIndex = 12;
            this.rtStatus.Text = "";
            this.rtStatus.TextChanged += new System.EventHandler(this.rtStatus_TextChanged_1);
            // 
            // FBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 341);
            this.Controls.Add(this.rtStatus);
            this.Controls.Add(this.rtBmi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.rtIntro);
            this.Name = "FBMI";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtIntro;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox rtBmi;
        private System.Windows.Forms.RichTextBox rtStatus;
    }
}