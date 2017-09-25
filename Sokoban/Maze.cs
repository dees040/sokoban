using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        Forklift _forklift;
        private int _movements = 0;

        public Forklift ForkLift { get; }

        public Maze(Field forkliftLocation)
        {
            _forklift = new Forklift(forkliftLocation);
        }

        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public Field GetTopLeftField()
        {
            Field field = _forklift._location;

            while (field.LeftNeighbour != null)
            {
                field = field.LeftNeighbour;
            }

            while (field.TopNeighbour != null)
            {
                field = field.TopNeighbour;
            }

            return field;
        }
    }
}