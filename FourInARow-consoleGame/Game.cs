using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Game
    {
        BoardGrid _grid = new BoardGrid(); //opretter instans af BoardGrid så det eksisterer i scope (giver adgang til metoder i klassen)
        public Game()
        {
            GetGrid();

            FindSpot(1);

            GetGrid();

            FindSpot(5);

            GetGrid();
        }

        /// <summary>
        /// checks grid column for empty cell - uses SetSingleValue to change value
        /// </summary>
        /// <param name="col">Column choice</param>
        public void FindSpot(int col)
        {
            col = col - 1;
            for (int i = _grid.ColLength - 1; i >= 0; i--) //looper kolonne ud fra bruger input - 1 (0 baseret index) nedefra
            {
                if (_grid.TwoDimensionalArray[i, col].Equals('o')) //hvis værdien i grid er 'o' ændres den til spillerens værdi/karakter
                {
                    _grid.SetSingleValue(i, col, 'x');
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
