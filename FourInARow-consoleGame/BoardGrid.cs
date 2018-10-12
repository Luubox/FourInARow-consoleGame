using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class BoardGrid
    {
        public char[,] TwoDimensionalArray = new char[6, 6]; //opretter nyt tomt 2d array
        public int RowLength;
        public int ColLength;

        public BoardGrid()
        {
            RowLength = TwoDimensionalArray.GetLength(0);
            ColLength = TwoDimensionalArray.GetLength(1);

            for (int i = 0; i < RowLength; i++) //looper array og fylder med 'o' char
            {
                for (int j = 0; j < ColLength; j++)
                {
                    SetSingleValue(i,j,'o');
                }
            }
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
            TwoDimensionalArray[x, y] = value; //sætter værdi på kordinat ud fra input x / y
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < RowLength; i++) //TODO Split loop til ny metode
            {
                for (int j = 0; j < ColLength; j++) //looper array og udskriver hver værdi efterfulgt af ' ' 
                {
                    sb.Append($"{TwoDimensionalArray[i, j]} ");
                }
                sb.Append(Environment.NewLine.ToString()); //tilføjer ny linje efter hver række
            }
            return sb.ToString();
        }
    }
}
