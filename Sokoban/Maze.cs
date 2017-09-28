using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private Field _forkLift;
        private int _desitnationAmount = 0;
        private int _desitnationReached = 0;

        public Field ForkLift {
            get { return _forkLift; }
            set
            {
                if (_forkLift != null)
                {
                    _forkLift.HasForkLift = false;
                }

                _forkLift = value;
                _forkLift.HasForkLift = true;
            }
        }
        public int DesitnationAmount { get; set; }
        public int DesitnationReached { get; set; }


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

        public bool isFinished()
        {
            return DesitnationAmount == DesitnationReached;
        }
    }
}