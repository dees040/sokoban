using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Wall : Field
    {
        public override string Character
        {
            get { return "#"; }
        }

        public override bool Standable()
        {
            return false;
        }
    }
}