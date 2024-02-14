using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class OuterWear(string color, double cost, string name) : UpperBody(color, name)
    {
        private double _cost = cost;
        public double cost { get => _cost; protected set => _cost = value; } }
           

    }

