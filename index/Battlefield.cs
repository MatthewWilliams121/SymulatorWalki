using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    internal class Battlefield
    {
        public static List<Unit> attacker = new List<Unit> { };
        public static List<Unit> defender = new List<Unit> { };
        //static public Unit[] attacker = new Unit[];
        //static public Unit[] defender;
        static private float get_attacker_value() { return 0; }
        static private float get_defender_value() { return 0; }
        static public void resolve() { }
    }
}
