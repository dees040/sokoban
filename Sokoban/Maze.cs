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

        public Maze(Field forkliftLocation)
        {
            _forklift = new Forklift(forkliftLocation);
        }

        public void Push(Box box, Direction direction)
        {
            throw new System.NotImplementedException();
        }

        public void Print()
        {
            throw new System.NotImplementedException();
        }

        private Field GetTopLeftField()
        {
            throw new System.NotImplementedException();
        }
    }
}