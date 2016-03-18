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
        // The maximum number of guesses before the player loses the game.
        private const int MaxGuesses = 6;

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

        private List<char> guesses = new List<char>(); 

        

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
            // Clearing the screen
            targetTB.Clear();
            guessesTB.Clear();
            hangmanPictureBox.Image = pictures[0];

            // Code that generates a number for the array position to grab the value from
            Random randomNumberGenerator = new Random();
            int randNum = randomNumberGenerator.Next(words.Length); // jhallam: changed Int64 to int
            targetWord = words[randNum];

            // Create hyphens
            targetTB.Text = new string('-', targetWord.Length);

            // Clear previous guesses
            guesses.Clear();

            // Enable the input box
            guessesTB.ReadOnly = false;
        }

        private void guessesTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                char input = e.KeyChar;
                guesses.Add(input);

                // Get the masked target word.
                string maskedWord = GetMaskedWord();
                targetTB.Text = maskedWord;

                // wrong guess
                if (!targetWord.Contains(input))
                {
                    // handle the wrong guess
                    wrongCtr++;
                    hangmanPictureBox.Image = pictures[wrongCtr];

                    // run out of guesses?
                    if (wrongCtr == MaxGuesses)
                    {
                        MessageBox.Show("Sorry, you lost.");
                        guessesTB.ReadOnly = true;
                        lossesTB.Text = (++lossesCtr).ToString();
                    }
                }
                // good guess, did the player win?
                else if (!maskedWord.Contains('-'))
                {
                    MessageBox.Show("Congratulations! You Won!");
                    guessesTB.ReadOnly = true;
                    wonTB.Text = (++winsCtr).ToString();
                }
            }
        }

        private void hangmanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        // This method takes the target word and replaces characters with '-' if that character
        // hasn't been guessed correctly.
        private string GetMaskedWord()
        {
            string result = "";

            foreach (char c in targetWord)
            {
                if (guesses.Contains(c))
                {
                    result += c;
                }
                else
                {
                    result += '-';
                }
            }
            return result;
        }

        private void hangmanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
