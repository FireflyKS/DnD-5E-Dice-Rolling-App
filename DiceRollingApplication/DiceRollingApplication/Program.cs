// Programmer/Designer: John Julian
// Personnal Project
/* This program is designed to let the user roll dice electronically for Dungeons and Dragons 5E.
   It allows the user to select the type of dice to roll, how many of that type of dice to roll,
   if the roll has advantage or disadvantage, and any modifiers that should be added to the roll.
   It then display the results of the indvidual rolls to the user and the total roll result.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollingApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new D20RollerMain());
        }
    }
}
