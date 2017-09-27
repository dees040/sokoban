using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class Field
    {
        protected Field _topNeighbour;
        protected Field _rightNeighbour;
        protected Field _bottomNeighbour;
        protected Field _leftNeighbour;

        protected bool _hasBox;
        protected bool _hasForkLift;

        public abstract string Character { get; }

        public Field TopNeighbour { get; set; }
        public Field RightNeighbour { get; set; }
        public Field BottomNeighbour { get; set; }
        public Field LeftNeighbour { get; set; }

        public bool HasBox { get; set; }
        public bool HasForkLift { get; set; }

        public abstract bool Standable();

        public override string ToString()
        {
            if (HasForkLift)
            {
                return "@";
            }
            else if (HasBox && this.GetType().Name != "Destination")
            {
                return "o";
            }

            return Character;
        }
    }
}