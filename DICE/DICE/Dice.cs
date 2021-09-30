using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICE
{
    class Dice
    {
        public int Side { get; set; }

        public Dice() { this.Side = 6; }
        public Dice(int side) { this.Side = side; }
    }
}
