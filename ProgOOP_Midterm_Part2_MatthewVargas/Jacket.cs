using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Jacket(string color, double cost, string name) : InnerWear(color, cost, name)
    {
        private readonly string name = name;
    }
}
