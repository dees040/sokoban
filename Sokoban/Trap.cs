using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Trap : Field
    {
        private int health = 3;

        public Trap(Field top, Field right, Field bottom, Field left) : base(top, right, bottom, left)
        {

        }

        public override string Character
        {
            get
            {
                return health == 0 ? " " : "~";
            }
        }

        public override bool Standable()
        {
            throw new NotImplementedException();
        }
    }
}