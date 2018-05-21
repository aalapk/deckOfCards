using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCardsDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Injects a DeckOfCards object with number of decks.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu(new DeckOfCards(1))); //Argument "1" can be changed to the number of 52 card decks needed in the master deck
        }
    }
}
