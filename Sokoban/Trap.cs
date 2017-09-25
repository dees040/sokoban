using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Trap : StandableField
    {
        private int health = 3;

        public override string Character
        {
            get
            {
                return health == 0 ? " " : "~";
            }
        }
    }
}