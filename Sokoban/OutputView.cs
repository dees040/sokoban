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
                String line = "";

                while (field.RightNeighbour != null)
                {
                    line += field.ToString();

                    field = field.RightNeighbour;
                }

                field = field.BottomNeighbour;
                Console.WriteLine(line);
            }
        }
    }
}