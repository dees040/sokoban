using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Destination : StandableField
    {
        public override string Character
        {
            get { return HasBox ? "0" : "x"; }
        }
    }
}