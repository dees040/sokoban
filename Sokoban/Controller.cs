﻿using System;
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
                return;
            }

            _maze = _parser.Handle(int.Parse(action));
        }

        /// <summary>
        /// Handle key event.
        /// </summary>
        /// <param name="direction"></param>
        public void Move(string direction)
        {
            throw new System.NotImplementedException();
        }
    }
}