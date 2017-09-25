using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Field
    {
        private Field _topNeighbour;
        private Field _rightNeighbour;
        private Field _bottomNeighbour;
        private Field _leftNeighbour;

        protected bool hasBox;

        public abstract string Character { get; }

        public Field(Field top, Field right, Field bottom, Field left)
        {
            _topNeighbour = top;
            _rightNeighbour = right;
            _bottomNeighbour = bottom;
            _leftNeighbour = left;
        }

        public abstract bool Standable();

        public override string ToString()
        {
            if (hasBox && this.GetType().Name != "Destination")
            {
                return "#";
            }

            return Character;
        }
    }
}