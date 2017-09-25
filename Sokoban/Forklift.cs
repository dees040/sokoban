using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Forklift
    {
        public Field _location;

        public Forklift(Field location)
        {
            _location = location;
        }

        public bool Move(Direction direction)
        {
            throw new System.NotImplementedException();
        }
    }
}