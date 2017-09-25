using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Parser
    {
        public Maze Handle(int mazeToLoad)
        {
            Field field = new EmptyField(null, null, null, null);

            return new Maze(field);
        }

        private String readFile()
        {
            return "";
        }
    }
}