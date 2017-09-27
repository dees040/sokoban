using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {
        public void PrintMaze(Field field, Field forkliftLocation)
        {
            Clear();

            while (field != null)
            {
                Field rightField = field;
                String line = "";

                while (rightField != null)
                {
                    line += (rightField == forkliftLocation) ? "@" : rightField.ToString();

                    rightField = rightField.RightNeighbour;
                }

                field = field.BottomNeighbour;
                Console.WriteLine(line);
            }
        }

        public void Clear()
        {
            Console.Clear();
            Console.WriteLine("");
        }
    }
}