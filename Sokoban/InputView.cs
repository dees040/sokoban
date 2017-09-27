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

            int mazeNumber;

            try
            {
                mazeNumber = int.Parse(input);
            } catch
            {
                return true;
            }

            return mazeNumber < 1 || mazeNumber > 4;
        }

        private void PrintWelcomeMessage()
        {
            string message = "" +
            "┌────────────────────────────────────────────────────┐\n" +
            "│ Welkom bij Sokoban                                 │\n" +
            "│                                                    │\n" +
            "│ Betekenis van de symbolen   │   Doel van het spel  │\n" +
            "│                             │                      │\n" +
            "│ spatie : outerspace         │   Duw met de truck   │\n" +
            "│      █ : muur               │   de krat(ten)       │\n" +
            "│      . : vloer              │   naar de bestemming │\n" +
            "│      # : krat               │                      │\n" +
            "│      0 : krat op bestemming │                      │\n" +
            "│      x : bestemming         │                      │\n" +
            "│      @ : truck              │                      │\n" +
            "└─────────────────────────────┴──────────────────────┘\n";

            Console.WriteLine(message);
        }
    }
}