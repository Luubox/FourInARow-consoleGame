using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class BoardGrid
    {
        public char[,] TwoDimensionalArray = new char[6, 6];
        public int RowLength;
        public int ColLength;

        public BoardGrid()
        {
            RowLength = TwoDimensionalArray.GetLength(0);
            ColLength = TwoDimensionalArray.GetLength(1);

            for (int i = 0; i < RowLength; i++)
            {
                for (int j = 0; j < ColLength; j++)
                {
                    SetSingleValue(i,j,'o');
                }
            }

        }

        /// <summary>
        /// get a singel value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char GetSingleValue(int x, int y)
        {
            return TwoDimensionalArray[x, y];
        }

        /// <summary>
        /// Set a single value our two dimensional array
        /// </summary>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="value">the char you want to set</param>
        /// <returns></returns>
        public void SetSingleValue(int x, int y, char value)
        {
            TwoDimensionalArray[x, y] = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < RowLength; i++)
            {
                for (int j = 0; j < ColLength; j++)
                {
                    sb.Append($"{TwoDimensionalArray[i, j]} ");
                }
                sb.Append(Environment.NewLine.ToString());
            }
            return sb.ToString();
        }
    }
}
