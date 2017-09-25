using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Wall : Field
    {
        public Wall(Field top, Field right, Field bottom, Field left) : base(top, right, bottom, left)
        {

        }

        public override string Character
        {
            get { return "█"; }
        }

        public override bool Standable()
        {
            return false;
        }
    }
}