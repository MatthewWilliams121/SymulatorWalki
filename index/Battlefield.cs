using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    internal class Battlefield
    {
        static public Unit[] attacker = new Unit[3];
        static public Unit[] defender = new Unit[3];
        static private float get_attacker_value() { return 0; }
        static private float get_defender_value() { return 0; }
        static public void resolve() { }
    }
}
