using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodTabla
{
    class Utilities
    {
        public int hex2int(string hex)
        {
            return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }
        public string int2hex(int num)
        {
            return num.ToString("X");
        }
    }
}
