using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Controller
    {
        private InputView inputView = new InputView();
        private OutputView outputView = new OutputView();

        private Maze _maze;
        private Parser _parser = new Parser();

        public Controller()
        {
            string action = inputView.GetAction();

            if (action.ToLower() == "s")
            {
                Console.WriteLine("> Sokoban is being stopped. Press enter to leave.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            _maze = _parser.Handle(int.Parse(action), HandleBoxMovement);
        }
        
        public void Play(string message = "> Feed me a new direction, please.")
        {
            outputView.PrintMaze(_maze.GetTopLeftField(), _maze.ForkLift);

            if (_maze.isFinished())
            {
                return;
            }

            if (message != "")
            {
                Console.WriteLine(message);
            }

            Move(inputView.ReadDirectionKey());
        }

        /// <summary>
        /// Handle key event.
        /// </summary>
        /// <param name="direction"></param>
        public void Move(Direction direction)
        {
            Field toGo = _maze.ForkLift.GetNeighbour(direction);

            if (toGo.HasBox)
            {
                MoveWithBox(direction, toGo);

                return;
            }

            if (toGo.Standable())
            {
                _maze.ForkLift = toGo;

                Play();
            }
            else
            {
                Play("> You cannot go here.");
            }
        }

        public void MoveWithBox(Direction direction, Field box)
        {
            Field toGo = box.GetNeighbour(direction);

            if (toGo.HasBox)
            {
                Play("> Their is another box in the way.");

                return;
            }

            if (toGo.Standable())
            {
                _maze.ForkLift = box;
                box.HasBox = false;
                toGo.HasBox = true;

                Play();
            }
            else
            {
                Play("The box cannot go there.");
            }
        }

        public void HandleBoxMovement(object sender, EventArgs args)
        {
            Field field = (Field)sender;

            if (field.HasBox)
            {
                _maze.DesitnationReached++;
            }
            else
            {
                _maze.DesitnationReached--;
            }
        }
    }
}