using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Game
    {
        private Player _playerOne = new Player();
        private Player _playerTwo = new Player();
        BoardGrid _grid = new BoardGrid(); //opretter instans af BoardGrid så det eksisterer i scope (giver adgang til metoder i klassen)
        public Game()
        {
            bool continueGame = true; //TODO flyt
            SetPlayer(_playerOne);
            SetPlayer(_playerTwo);
            GetGrid();

            while (continueGame)
            {
                Turn(_playerOne);
                Turn(_playerTwo);
            }
        }

        /// <summary>
        /// plays a turn of the game
        /// </summary>
        /// <param name="player">Denotes which players turn is it</param>
        public void Turn(Player player)
        {
            int choice = 0;
            while (choice < 1 || choice > 6) //checker om bruger input er mellem 1 og 6
            {
                Console.WriteLine($"{player.Name} choose a column: (1-6)");
                choice = Convert.ToInt16(Console.ReadLine());
                if (choice < 1 || choice > 6)
                {
                    Console.Write("Invalid, try again: ");
                }
            }
            FindSpot(choice, player); //kalder findspot med brugerens input og den specifikke brugers token
            GetGrid(); //TODO: win conditions / full column
        }

        /// <summary>
        /// promts user for input and changes player accordingly
        /// </summary>
        /// <param name="player">which player</param>
        private void SetPlayer(Player player) //sætter player info ud fra input
        {
            Console.Write("Please choose a name: ");
            player.Name = Console.ReadLine();
            string input = "";
            while (input == null || input.Length != 1) //checker om imput er tom string eller mere end en character
            {
                Console.Write("Please choose a token: ");
                input = Console.ReadLine();
                if (input == null || input.Length != 1)
                {
                    Console.Write("Invalid, try again: ");
                }
            }
            player.Token = Convert.ToChar(input);
            Console.WriteLine($"{player.Name} [{player.Token}]");
        }

        /// <summary>
        /// checks grid column for empty cell - uses SetSingleValue to change value
        /// </summary>
        /// <param name="col">Column choice</param>
        /// <param name="player">Denotes which players turn it is</param>
        public void FindSpot(int col, Player player)
        {
            col = col - 1;
            for (int i = _grid.ColLength - 1; i >= 0; i--) //looper kolonne ud fra bruger input - 1 (0 baseret index) nedefra
            {
                if (_grid.TwoDimensionalArray[i, col].Equals('o')) //hvis værdien i grid er 'o' ændres den til spillerens værdi/karakter
                {
                    _grid.SetSingleValue(i, col, player.Token); 
                    break;
                }
            }
        }

        /// <summary>
        /// Does what it says on the tin
        /// </summary>
        public void GetGrid() //kalder ToString() metoden i BoardGrid.cs og udskriver til konsollen
        {
            Console.WriteLine(_grid);
        }
    }
}
