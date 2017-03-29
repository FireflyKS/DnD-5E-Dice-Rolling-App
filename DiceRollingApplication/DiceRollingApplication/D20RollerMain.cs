// Programmer/Designer: John Julian
// Personnal Project
/* This program is designed to let the user roll dice electronically for Dungeons and Dragons 5E.
   It allows the user to select the type of dice to roll, how many of that type of dice to roll,
   if the roll has advantage or disadvantage, and any modifiers that should be added to the roll.
   It then display the results of the indvidual rolls to the user and the total roll result.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollingApplication
{
    public partial class D20RollerMain : Form
    {
        public D20RollerMain()
        {
            InitializeComponent();

            // Sets default values for the options and hides the roll result labels
            d100RadioButton.Checked = false;
            d20RadioButton.Checked = false;
            d12RadioButton.Checked = false;
            d10RadioButton.Checked = false;
            d8RadioButton.Checked = false;
            d6RadioButton.Checked = false;
            d4RadioButton.Checked = false;
            d2RadioButton.Checked = false;
            selectNumberDiceUpDown.Value = 1;
            advantageRadioButton.Checked = false;
            disadvantageRadioButton.Checked = false;
            modifierUpDownSelect.Value = 0;
            individualRollResultsLabel.Visible = false;
            totalRollResultLabel.Visible = false;
        }

        // Method that is called when the user clicks on the roll button
        private void rollButton_Click(object sender, EventArgs e)
        {
            int diceType;

            diceType = determineDiceType(); // calls the determineDice method and assigns the returned value to diceType
            rollDice(diceType);
        }

        // Method that determines what type of dice the user wants to roll
        private int determineDiceType()
        {
            int sidesOfDice = 0;

            if (d100RadioButton.Checked == true)
                sidesOfDice = 100;
            else if (d20RadioButton.Checked == true)
                sidesOfDice = 20;
            else if (d12RadioButton.Checked == true)
                sidesOfDice = 12;
            else if (d10RadioButton.Checked == true)
                sidesOfDice = 10;
            else if (d8RadioButton.Checked == true)
                sidesOfDice = 8;
            else if (d6RadioButton.Checked == true)
                sidesOfDice = 6;
            else if (d4RadioButton.Checked == true)
                sidesOfDice = 4;
            else if (d2RadioButton.Checked == true)
                sidesOfDice = 2;
            else
            {
                // Informs the user that they need to make a choice of dice
                totalRollResultLabel.Visible = true;
                totalRollResultLabel.Text = "Invalid choice, please select the type of dice you wish to roll.";
            }

            return sidesOfDice;
        }

        // Method that processes the dice rolls
        private void rollDice(int diceType)
        {
            int numberOfDice = Decimal.ToInt32(selectNumberDiceUpDown.Value);
            int[] diceRolls = new int[numberOfDice];

            if (advantageRadioButton.Checked == true) // determines if the roll should be done with advantage
                rollWithAdvantage(diceType, numberOfDice);
            else if (disadvantageRadioButton.Checked == true) // determines if the roll should be done with disadvantage
                rollWithDisadvantage(diceType, numberOfDice);
            else
            {
                for (int a = 0; a < numberOfDice; a++)
                {
                    diceRolls[a] = generateDiceRoll(diceType);
                }
            }
        }

        // Method that rolls dice with advantage
        private void rollWithAdvantage(int diceType, int numberOfDice)
        {

        }

        // Method that rolls dice with disadvantage
        private void rollWithDisadvantage(int diceType, int numberOfDice)
        {

        }

        // Randomly generates the dice roll
        private int generateDiceRoll(int diceType)
        {
            int diceRoll = 0;

            return diceRoll;
        }
    }
}
