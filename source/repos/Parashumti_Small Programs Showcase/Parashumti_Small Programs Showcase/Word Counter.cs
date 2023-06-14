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
    public partial class WordCount : Form
    {
        public WordCount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                string[] words;
                List<string> sortedwords = new List<string>();
                Dictionary<string, int> wordfreq = new Dictionary<string, int>();

                //turns every word to lower case so we can count upper and lower words as the same
                line = rtStory.Text.ToLower();
                words = line.Split(' ');
                foreach (string word in words)
                {

                    sortedwords.Add(word);
                }

                //stores the words in a list so we can sort it, for extra credit :)
                sortedwords.Sort();
                //counts the frequency of words in the list
                for (int i = 0; i < sortedwords.Count; i++)
                {
                    if (wordfreq.ContainsKey(sortedwords[i]))
                    {
                        wordfreq[sortedwords[i]]++;
                    }
                    else
                    {
                        wordfreq[sortedwords[i]] = 1;
                    }
                }
                lisWords.Items.Clear();
                       
                foreach (var pair in wordfreq)
                {
                    string wordsAndNum = (pair.Key + "  " + pair.Value);
                    lisWords.Items.Add(wordsAndNum);
                }
                
            }
            catch (Exception ex)
            {
                
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
