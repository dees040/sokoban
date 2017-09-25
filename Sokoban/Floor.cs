using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Floor : StandableField
    {

        public override string Character
        {
            get { return "."; }
        }
    }
}