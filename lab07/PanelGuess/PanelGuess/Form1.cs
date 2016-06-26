using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/*
A 'Simon Says' style guessing game of coloured panels
Created by: Matthew Casiro
Created on: June 9 2016
*/
namespace PanelGuess
{
    public partial class Form1: Form
    {
        // Constants
        private const int intPanelWidth = 30;
        private const int intPanelHeight = 30;
        private const int intPanelDistance = 1;
        private const int intRoundBonus = 6;
        // Class Variables
        bool blnEasyMode, blnReadyToGuess;
        bool[,] selected;
        Panel[,] panels;
        int intNumSpots, intCount, intClickCountCorrect, intClickCountIncorrect,
            intPoints, intNumSidePanels, intPctPanelsPicked;
        Random rndSpot;
        HashSet<Tuple<int, int>> panelsToGuess;

        // Initialize game state 
        public Form1()
        {
            InitializeComponent();
            // Hide play again button
            btnPlayAgain.Visible = false;
            btnPlayAgain.Enabled = false;
            // Set default menu selections
            hardToolStripMenuItem.Checked = true;
            blnEasyMode = false;
            toolStripMenuItem20pct.Checked = true;
            // Initialize remaining variables
            panelsToGuess = new HashSet<Tuple<int, int>>();
            timer1.Interval = 500;
            rndSpot = new Random();
            lstbGridSize.SelectedIndex = 1;
            PctSelectedHandler(toolStripMenuItem20pct, EventArgs.Empty);
            intPoints = 0;
            setScore();
        }

        // Start a round
        private void btnStart_Click(object sender, EventArgs e)
        {
            blnReadyToGuess = false;
            btnStart.Enabled = false;
            lstbGridSize.Enabled = false;
            intCount = 0;
            timer1.Start();
        }

        // Randomly select squares until the required number is reached
        // In hard mode - wait one second before hiding squares
        // In easy mode - wait until the user closes a message box before hiding squares
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Randomly select a square until the correct number are chosen
            if (intCount < intNumSpots)
            {
                Tuple<int, int> selection = getSelection();
                selected[selection.Item1, selection.Item2] = true;
                panels[selection.Item1, selection.Item2].BackColor = Color.Aqua;
                panelsToGuess.Add(selection);
                intCount++;
            }
            // Display a message box to stall the game, if in easy mode
            else if (blnEasyMode)
            {
                timer1.Stop();
                MessageBox.Show("Click 'OK' when you are ready to guess.", "Mode: Easy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetPanels();
                blnReadyToGuess = true;
            } // Tick twice to delay hiding the squares, if in hard mode
            else if (intCount < intNumSpots + 2)
            {
                intCount++;
            } // End the timer and reset panel colours
            else
            {
                timer1.Stop();
                resetPanels();
                blnReadyToGuess = true;
            }

        }

        // Re-colour the randomly selected panels to the original colour
        private void resetPanels()
        {
            foreach (Tuple<int,int> tpl in panelsToGuess)
            {
                panels[tpl.Item1, tpl.Item2].BackColor = Color.Gray;
            }
        }

        // Update the percent of tiles to select based on the total number of tiles
        // and the percentage selected
        private void PctSelectedHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            unCheckPcts();
            item.Checked = true;
            
            if (!Int32.TryParse(item.Text.Substring(1,2), out intPctPanelsPicked))
            {
                MessageBox.Show("Unable to parse integer from percentage selection.\n"+intPctPanelsPicked+"\n"+ item.Text.Substring(0, 2), "FATAL ERROR");
                Application.Exit();
                Environment.Exit(1);
            }
            // Update number of spots to select
            updateNumSpots();
        }

        // Update the number of spots to select and the label indicating such to the user
        private void updateNumSpots()
        {
            intNumSpots = (int)((double)(intNumSidePanels * intNumSidePanels) * ((double)intPctPanelsPicked / 100));
            int tmp = intNumSpots - intClickCountCorrect;
            lblNumSpots.Text = "Panels to Select : " + (tmp > 10 ? tmp.ToString() : ("0" + tmp.ToString()));
        }

        // Clear checkmarks on percent selectors
        private void unCheckPcts()
        {
            foreach (ToolStripMenuItem item in selectionCountToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
        }

        // Randomly select two integer values, without selecting
        // a previously selected panel
        private Tuple<int, int> getSelection()
        {
            int i, j;
            do
            {
                i = rndSpot.Next(intNumSidePanels);
                j = rndSpot.Next(intNumSidePanels);
            } while (selected[i, j] == true);
            return new Tuple<int, int>(i, j);
        }

        // Update the game difficulty when a selection is made
        private void DifficultyChangeHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Equals(easyToolStripMenuItem))
            {
                easyToolStripMenuItem.Checked = blnEasyMode = true;
                hardToolStripMenuItem.Checked = false;
            } else if (item.Equals(hardToolStripMenuItem))
            {
                easyToolStripMenuItem.Checked = blnEasyMode = false;
                hardToolStripMenuItem.Checked = true;
            }
        }

        // Update the score label
        private void setScore()
        {
            lblScore.Text = intPoints.ToString();
        }

        // Exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Instantiate the panels based on the selected grid size
        private void SetUpPanels()
        {
            DestroyPanels();
            int i, j;
            int intNumPanels = (intNumSidePanels * intNumSidePanels);
            // Instantiate the array of panels.
            panels = new Panel[intNumSidePanels, intNumSidePanels];
            selected = new bool[intNumSidePanels, intNumSidePanels];

            // Calculate amount of blank space on left side of panels to center them in the form.
            int intLeftSpace = groupBox1.Width + ((this.Width - groupBox1.Width) - intNumSidePanels *
                                (intPanelWidth + intPanelDistance)) / 2;

            // Add each new panel to the list and set up the add handlers (Row x Col)
            for (i = 0; i < intNumSidePanels; i++)
            {
                for (j = 0; j < intNumSidePanels; j++)
                {
                    Panel pnlNewPanel = new Panel();

                    int intX, intY;

                    intX = i * (intPanelWidth + intPanelDistance);

                    intX += intLeftSpace;

                    intY = 55 + (j * (intPanelHeight + intPanelDistance));

                    pnlNewPanel.Location = new Point(intX, intY);

                    pnlNewPanel.Size = new Size(intPanelHeight, intPanelWidth);

                    pnlNewPanel.BackColor = Color.Gray;
                    pnlNewPanel.Name = "Panel" + j + i;

                    this.Controls.Add(pnlNewPanel);

                    panels[i,j] = pnlNewPanel;

                    pnlNewPanel.Click += new EventHandler(Panel1_Click);
                }
            }
        }

        // If the game is in the guessing stage, accept the user's selection
        // and log the result in the results texbox
        private void Panel1_Click(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            if (blnReadyToGuess && pnl.BackColor == Color.Gray)
            {
                if (intClickCountCorrect < intNumSpots)
                {
                    tbMessage.Text += "Guess #" + (intClickCountCorrect + intClickCountIncorrect + 1).ToString() +
                        " is " + (checkGuess(pnl) ? "correct!\r\n" : "incorrect\r\n");
                    tbMessage.SelectionLength = 0;
                    tbMessage.SelectionStart = (tbMessage.Text).Length;
                    tbMessage.ScrollToCaret();
                }
                if (intClickCountCorrect >= intNumSpots)
                {
                    endGame();
                }
                updateNumSpots();
            }

        }

        // Calculate the result and output the final score
        private void endGame()
        {
            blnReadyToGuess = false;
            
            // Output results
            tbMessage.Text += "Correct Score:\t" + intClickCountCorrect.ToString() + "\r\n";
            tbMessage.Text += "Incorrect Penalty:\t" + (-intClickCountIncorrect).ToString() + "\r\n";
            tbMessage.Text += "Round Bonus:\t" + intRoundBonus.ToString() + "\r\n";
            tbMessage.Text += "ROUND TOTAL:\t" + (intClickCountCorrect + intRoundBonus - intClickCountIncorrect).ToString() + "\r\n";
            tbMessage.Text += "- - - - - - - - - - - - - - - - - - - -\r\n";
            tbMessage.SelectionLength = 0;
            tbMessage.SelectionStart = (tbMessage.Text).Length;
            tbMessage.ScrollToCaret();

            // Update score
            intPoints += (intClickCountCorrect + intRoundBonus - intClickCountIncorrect);
            setScore();

            btnPlayAgain.Visible = true;
            btnPlayAgain.Enabled = true;
        }

        // Reset the game state and allow user to play again
        private void PlayAgainHandler(object sender, EventArgs e)
        {
            btnPlayAgain.Visible = false;
            btnPlayAgain.Enabled = false;
            SetUpPanels();
            intCount = 0;
            intClickCountCorrect = 0;
            intClickCountIncorrect = 0;
            btnStart.Enabled = true;
            lstbGridSize.Enabled = true;
            updateNumSpots();
        }

        // Verify if the user guessed a valid square or not
        private bool checkGuess(Panel pnl)
        {
            int i, j;
            // Parse the guess from the panel name
            if (!Int32.TryParse(pnl.Name.Substring(5, 1), out j))
            {
                MessageBox.Show("FATAL ERROR OCCURED WHILE EVALUATING SELECTION");
                Application.Exit();
            }
            if (!Int32.TryParse(pnl.Name.Substring(6, 1), out i))
            {
                MessageBox.Show("FATAL ERROR OCCURED WHILE EVALUATING SELECTION");
                Application.Exit();
            }
            // Compare the panel coordinates to the selected grid and
            // color the panel accordingly
            if (selected[i, j])
            {
                pnl.BackColor = Color.Green;
                intClickCountCorrect++;
                panelsToGuess.Remove(new Tuple<int, int>(i, j));
                return true;
            }else
            {
                pnl.BackColor = Color.Yellow;
                intClickCountIncorrect++;
                return false;
            }
        }

        // Update the grid based on the user-selected grid size
        private void lbGridSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable selected box percentages that would result in too easy of a game
            if (lstbGridSize.SelectedIndex == 0)
            {
                toolStripMenuItem10pct.Enabled = false;
                toolStripMenuItem20pct.Enabled = false;
                // Default to 30% if 10% or 20% was selected
                if (toolStripMenuItem10pct.Checked || toolStripMenuItem20pct.Checked)
                {
                    PctSelectedHandler(toolStripMenuItem30pct, EventArgs.Empty);
                }
            }
            else if (lstbGridSize.SelectedIndex < 4)
            {
                toolStripMenuItem10pct.Enabled = false;
                toolStripMenuItem20pct.Enabled = true;
                // Default to 20% if 10% was selected
                if (toolStripMenuItem10pct.Checked)
                {
                    PctSelectedHandler(toolStripMenuItem20pct, EventArgs.Empty);
                }
            }else
            {
                toolStripMenuItem10pct.Enabled = true;
                toolStripMenuItem20pct.Enabled = true;
            }
                    
            // Set the number of panels on each side (first index is 4, increments by one from there)
            intNumSidePanels = lstbGridSize.SelectedIndex + 4;
            SetUpPanels();
            updateNumSpots();
        }

        // Remove the current panels from the form
        private void DestroyPanels()
        {
            if (panels != null && panels.Length > 0)
            {
                foreach (Panel panel in panels)
                {
                    panel.Click -= new EventHandler(Panel1_Click);
                    this.Controls.Remove(panel);
                    panel.Dispose();
                }
            }
        }
    }
}
