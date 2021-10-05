using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tippekupong
{ 
    class Match
    {

        public int HomeGoals;
        public int AwayGoals;
        public bool MatchIsRunning;
        public string Bet;

        public Match()
        {
            HomeGoals = 0;
            AwayGoals = 0;
            MatchIsRunning = false;
        }

        public void StartMatch()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            MatchIsRunning = true;
            Bet = Console.ReadLine();
            while (MatchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                MatchIsRunning = command != "X";
                if (command == "H") HomeGoals++;
                else if (command == "B") AwayGoals++;
                Console.WriteLine($"Stillingen er {HomeGoals}-{AwayGoals}.");
            }
        }
    }
}
