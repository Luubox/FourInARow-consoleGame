using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Player
    {
        private string _name;
        private char _token;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public char Token
        {
            get { return _token; }
            set { _token = value; }
        }
    }
}
