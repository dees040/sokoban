using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private Field _forkLift;
        private int _movements = 0;

        public Field ForkLift { get; set; }

        public Maze(Field forkliftLocation)
        {
            ForkLift = forkliftLocation;
        }

        public Field GetTopLeftField()
        {
            Field field = ForkLift;

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