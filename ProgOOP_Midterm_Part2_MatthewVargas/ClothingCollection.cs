using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Jacket(string color, double cost, string name) : InnerWear(color, cost, name)
    {
    }

    internal class Sweater(string color, double cost, string name) : OuterWear(color, cost, name)
    {
    }

    internal class Tshirt(string color, double cost, string name) : InnerWear(color, cost, name)
    {
        //private readonly string name = name;
    }
    internal class Suit(string color, double cost, string name) : InnerWear(color, cost, name)
    {
    }
    internal class LongSleeve(string color, double cost, string name) : InnerWear(color, cost, name)
    {
    }
}
