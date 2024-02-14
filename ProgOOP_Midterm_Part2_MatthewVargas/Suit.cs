using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Suit(string color, double cost, string tiecolor, string name) : InnerWear(color, cost, name)
    {
        string _tiecolor = tiecolor;
    }
}
