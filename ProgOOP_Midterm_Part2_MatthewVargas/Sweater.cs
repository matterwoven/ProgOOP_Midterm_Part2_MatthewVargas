using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Sweater(string color, double cost, string name) : OuterWear(color, cost, name)
    {
        private readonly string name = name;
    }
}
