using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dresslerAssign2
{
    public partial class hangmanForm : Form
    {
        String[] words = { "programming", "network", "website", "linux", "windows", "internet" };
        string targetWord;
        int ctr;
        string[] hyphens = new string[15];
        int winsCtr, lossesCtr, wrongCtr;
        Bitmap[] pictures = { dresslerAssign2.Properties.Resources.hangman0,
                              dresslerAssign2.Properties.Resources.hangman1,
                              dresslerAssign2.Properties.Resources.hangman2,
                              dresslerAssign2.Properties.Resources.hangman3,
                              dresslerAssign2.Properties.Resources.hangman4,
                              dresslerAssign2.Properties.Resources.hangman5,
                              dresslerAssign2.Properties.Resources.hangman6};

        

        public hangmanForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //Clearing the screen
            targetTB.Clear();
            guessesTB.Clear();

            //Code that generates a number for the array position to grab the value from
            Random randomNumberGenerator = new Random();
            Int64 randNum = randomNumberGenerator.Next(words.Length);
            targetWord = words[randNum];

            
            
            //Create hyphens
            for (ctr = 0; ctr <= targetWord.Length; ctr++)
            {
                hyphens[ctr] = "-";
                targetTB.Text += hyphens[ctr];
                
            }



        }

        private void guessesTB_TextChanged(object sender, EventArgs e)
        {

            try
            {

                char guess = guessesTB.Text[guessesTB.Text.Length - 1];

                string txt = guessesTB.Text;


                if (targetWord.Contains(guess))
                {
                    MessageBox.Show("Found letter in target word");
                  
                    
                }
                else
                {
                    wrongCtr++;
                    MessageBox.Show("Did not find letter in target word");
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("No word has been selected");
            }
            hangmanPictureBox.Image = pictures[wrongCtr];

            if (wrongCtr == 6)
            {
                lossesCtr++;
                targetTB.Clear();
                wrongCtr = 0;
            }

            string lossesCtrInt = Convert.ToString(lossesCtr);
            lossesTB.Text = lossesCtrInt;
        }



        private void hangmanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
