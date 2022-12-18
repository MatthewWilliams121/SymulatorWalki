using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    abstract class Unit
    {
        string name = "1. Independent Brigade";
        string size;
        float org = 100;
        bool side;
        protected abstract float get_soft_attack();
        protected abstract float get_hard_attack();
    }
    internal class Infantry : Unit
    {
       // equipment inventory[]
        
        override protected float get_soft_attack() { return 6; }
        override protected float get_hard_attack() { return 2; }
    }

    internal class equipment
    {

    }
}
