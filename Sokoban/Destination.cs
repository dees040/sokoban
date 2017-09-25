using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Destination : Field
    {
        public Destination(Field top, Field right, Field bottom, Field left) : base(top, right, bottom, left)
        {

        }

        public override string Character
        {
            get { return hasBox ? "0" : "O"; }
        }

        public override bool Standable()
        {
            return true;
        }
    }
}