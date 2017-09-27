using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {
        public void PrintMaze(Field field)
        {
            while (field.BottomNeighbour != null)
            {
                Field nextBottom = field.BottomNeighbour;
                String line = "";

                while (field.RightNeighbour != null)
                {
                    line += field.ToString();

                    field = field.RightNeighbour;
                }

                field = nextBottom;
                Console.WriteLine(line + "\n");
            }
        }
    }
}