using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Person
    {
        OuterWear _outerWear;
        InnerWear _innerWear;
        
        //Can be used as a preset
        internal Person(UpperBody outerWear, UpperBody innerWear)
        {
            Person person = new Person(outerWear, innerWear);
        }

        internal static void SetIdentifiers() 
        {
            

        }
        internal void DisplayCurrentAttire()
        {
            Console.WriteLine($"Current Upper Body:\n" +
                     $" (Inner Wear) - {this._outerWear.name}\n" +
                     $" (Outer Wear) - {this._innerWear.name}\n");
        }


    }
}
