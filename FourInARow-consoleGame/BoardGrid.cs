using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class BoardGrid
    {
        char[,] _twoDimensionalArray = new char[6, 6];

        /// <summary>
        /// get a singel value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char GetSingleValue(int x, int y)
        {
            return _twoDimensionalArray[x, y];
        }

        /// <summary>
        /// Set a single value our two dimensional array
        /// </summary>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="value">the char you want to set</param>
        /// <returns></returns>
        public char SetSingleValue(int x, int y, char value)
        {
            return _twoDimensionalArray[x, y] = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int rowLength = _twoDimensionalArray.GetLength(0);
            int colLength = _twoDimensionalArray.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    _twoDimensionalArray[i, j] = 'o';
                    sb.Append($"{_twoDimensionalArray[i, j]} ");
                }
                sb.Append(Environment.NewLine.ToString());
            }
            return sb.ToString();
        }
    }
}
