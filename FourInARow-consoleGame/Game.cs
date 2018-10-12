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

        public void GetGrid()
        {
            Console.WriteLine(_grid);
        }
    }
}
