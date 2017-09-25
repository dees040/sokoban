using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class StandableField : Field
    {
        public override bool Standable()
        {
            return true;
        }
    }
}