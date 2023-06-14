using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parashumti_Small_Programs_Showcase
{
    public partial class PassGenerator : Form
    {
        public PassGenerator()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgBrowse = new OpenFileDialog();
            dlgBrowse.InitialDirectory = "c:\\temp";
            dlgBrowse.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgBrowse.FilterIndex = 2;
            dlgBrowse.RestoreDirectory = true;
            if (dlgBrowse.ShowDialog() == DialogResult.OK)
            {
                txtfName.Text = dlgBrowse.FileName;
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string filename;
            string[] parts;
            string word1;
            string word2;
            string word3;
            List<string> words = new List<string>();
            Random random = new Random();

            filename = txtfName.Text;
            try
            {
                //check if the file exists if not return a message
                if (File.Exists(filename))
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        ;
                        string line;
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            parts = line.Split(' ');
                            foreach (string part in parts)
                            {
                                words.Add(part);
                            }

                        }
                        reader.Close();
                    }

                    int nu = int.Parse(txtpassNum.Text);
                    int num = Convert.ToInt32(txtpassNum.Text);

                    lisPass.Items.Clear();
                    
                    //gets random words from the list and replaces the letters as required
                    for (int i = 0; i < num; i++)
                    {
                        word1 = words[random.Next(0, words.Count)];
                        word2 = words[random.Next(0, words.Count)];
                        word3 = words[random.Next(0, words.Count)];

                        word1 = word1.Replace("i", "!");
                        word1 = word1.Replace('s', '$');

                        word2 = word2.Replace("i", "!");
                        word2 = word2.Replace('s', '$');
                        word2 = word2.ToUpper();

                        word3 = word3.Replace("i", "!");
                        word3 = word3.Replace('s', '$');

                        string password = word1 + word2 + word3;

                        
                        lisPass.Items.Add(password);
                        Refresh();

                    }
                    
                }
                else
                {
                    MessageBox.Show("The file does no exist.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The number of words must be an integer.");  
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
