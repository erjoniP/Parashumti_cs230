using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parashumti_Small_Programs_Showcase
{
    public partial class Form1 : Form
    {
        private MenuStrip mainMenu;
        public Form1()
        {
            InitializeComponent();
            mainMenu = new MenuStrip();
            this.MainMenuStrip = mainMenu;
            this.Controls.Add(mainMenu);
            ToolStripMenuItem mnuFile = new ToolStripMenuItem("File");
            mainMenu.Items.Add(mnuFile);
            ToolStripMenuItem miBMICalc = new ToolStripMenuItem("BMI Calculator");
            ToolStripMenuItem miPassGenerator = new ToolStripMenuItem("Password Generator");
            ToolStripMenuItem miWordCount= new ToolStripMenuItem("Word Counter");
            ToolStripMenuItem miExit = new ToolStripMenuItem("Exit");
            mnuFile.DropDownItems.Add(miBMICalc);
            mnuFile.DropDownItems.Add(miPassGenerator);
            mnuFile.DropDownItems.Add(miWordCount);
            mnuFile.DropDownItems.Add(miExit);
            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Help");
            mainMenu.Items.Add(mnuHelp);
            ToolStripMenuItem miAbout = new ToolStripMenuItem("About");
            mnuHelp.DropDownItems.Add(miAbout);



            miAbout.Click += MiAbout_Click;
            miBMICalc.Click += MiBMICalc_Click;
            miPassGenerator.Click += MiPassGenerator_Click;
            miWordCount.Click += MiWordCount_Click;
            miExit.Click += MiExit_Click

        }

        private void MiWordCount_Click(object sender, EventArgs e)
        {
            WordCount wordCount = new WordCount();
            wordCount.ShowDialog();
        }

        private void MiPassGenerator_Click(object sender, EventArgs e)
        {
            PassGenerator passGenerator = new PassGenerator();
            passGenerator.ShowDialog();
        }

        private void MiBMICalc_Click(object sender, EventArgs e)
        {
            FBMI bmiCalculator = new FBMI();
            bmiCalculator.ShowDialog();

        }

        private void MiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Small Programs Showcase' by Erjon Parashumti for CPSC 23000 Summer 2023");
        }
        
        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit()
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
