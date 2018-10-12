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

        StringBuilder _stringBuilder = new StringBuilder();


    }
}
