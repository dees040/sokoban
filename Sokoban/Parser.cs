using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Sokoban
{
    public class Parser
    {
        public Maze Handle(int mazeToLoad)
        {
            string[] lines = ReadFile(mazeToLoad);

            Field forkliftLocation = null, left = null, above = null;

            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    Field field = CharToField(c);

                    if (field.HasForkLift)
                    {
                        forkliftLocation = field;
                    }

                    SetFieldNeighbours(field, above, left);

                    left = field;
                    above = GetNextAbove(above);
                }

                above = GetFirstOfCurrentRow(left);
                left = null;
            }

            return new Maze(forkliftLocation);
        }

        private void SetFieldNeighbours(Field newField, Field top, Field left)
        {
            if (top != null)
            {
                newField.TopNeighbour = top;
                top.BottomNeighbour = newField;
            }

            if (left != null)
            {
                newField.LeftNeighbour = left;
                left.RightNeighbour = newField;
            }
        }

        private Field GetFirstOfCurrentRow(Field field)
        {
            while (field.LeftNeighbour != null)
            {
                field = field.LeftNeighbour;
            }

            return field;
        }

        private Field GetNextAbove(Field above)
        {
            if (above == null)
            {
                return null;
            }

            return above.RightNeighbour;
        }

        private Field CharToField(char c)
        {
            switch (c)
            {
                case ' ':
                    return new Outerspace();
                case '#':
                    return new Wall();
                case '.':
                    return new Floor();
                case 'o':
                    Field box = new Floor();
                    box.HasBox = true;

                    return box;
                case 'x':
                    return new Destination();
                case '@':
                    Field forkLift = new Floor();
                    forkLift.HasForkLift = true;

                    return forkLift;
                case '~':
                    return new Trap();
                default:
                    throw new Exception("Unkonwn character.");
            }
        }

        private string[] ReadFile(int id)
        {
            string fileName = "doolhof" + id + ".txt";
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            string[] lines = File.ReadAllLines(path + "\\Mazes\\" + fileName);

            return lines;
        }
    }
}