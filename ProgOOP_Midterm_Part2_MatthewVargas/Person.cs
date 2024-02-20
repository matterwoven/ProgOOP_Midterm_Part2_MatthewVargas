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
        internal Person(OuterWear outerWear, InnerWear innerWear)
        {
            //Person person = new Person(outerWear, innerWear);
            _outerWear = outerWear;
            _innerWear = innerWear;
        }
        public void SetIdentifiersOuter(OuterWear outerWear)
        {
            _outerWear = outerWear;    
        }
        public void SetIdentifiersInner(InnerWear innerWear) 
        {
            _innerWear = innerWear;
        }

    }
}
