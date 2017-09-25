using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class InputView
    {
        public string GetAction()
        {
            PrintWelcomeMessage();

            return ReadActionLine();
        }

        private String ReadActionLine()
        {
            Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");

            String action = Console.ReadLine();

            while (IncorrectInput(action))
            {
                Console.WriteLine("> U kunt alleen dolhoof 1 t/m 4 kiezen, of 's' om te stoppen. Kies opnieuw.");

                action = Console.ReadLine();
            }

            return action;
        }

        private bool IncorrectInput(String input)
        {
            if (input.ToLower() == "s")
            {
                return false;
            }

            int mazeNumber = int.Parse(input);

            return mazeNumber < 1 && mazeNumber > 4;
        }

        private void PrintWelcomeMessage()
        {

        }
    }
}