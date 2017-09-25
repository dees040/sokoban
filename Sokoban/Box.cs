using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Box : Field
    {
        public Box(Field top, Field right, Field bottom, Field left) : base(top, right, bottom, left)
        {

        }

        public override bool Standable()
        {
            return false;
        }

        public bool Movable()
        {
            return true;
        }

        public void MoveTo(Direction direction)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}