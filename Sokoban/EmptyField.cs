using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class EmptyField : Field
    {
        public EmptyField(Field top, Field right, Field bottom, Field left) : base(top, right, bottom, left)
        {

        }

        public override string Character
        {
            get { return "."; }
        }

        public override bool Standable()
        {
            return true;
        }
    }
}