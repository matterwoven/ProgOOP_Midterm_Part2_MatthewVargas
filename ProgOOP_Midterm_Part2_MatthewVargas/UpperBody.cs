using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    public class UpperBody
    {
        private string _color;
        private string _name;

        public string color { get => _color; protected set => _color = value; }
        public string name { get => _name; protected set => _name = value; }

        public UpperBody(string color, string name)
        {
            _color = color;
            _name = name;




        }
    }
}
