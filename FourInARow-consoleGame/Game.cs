using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Game
    {
        BoardGrid _grid = new BoardGrid();
        public Game()
        {
            GetGrid();

            FindSpot(1);

            GetGrid();

            FindSpot(1);

            GetGrid();
        }

        /// <summary>
        /// checks grid column for empty cell - uses SetSingleValue to change value
        /// </summary>
        /// <param name="col">Column choice</param>
        public void FindSpot(int col)
        {
            for (int i = _grid.ColLength - 1; i >= 0; i--)
            {
                if (_grid.TwoDimensionalArray[i, col].Equals('o'))
                {
                    _grid.SetSingleValue(i, col, 'x');
                    break;
                }
            }
        }

        /// <summary>
        /// Does what it says on the tin
        /// </summary>
        public void GetGrid()
        {
            Console.WriteLine(_grid);
        }
    }
}
