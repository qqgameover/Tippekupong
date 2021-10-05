using System;

namespace Tippekupong
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new Match();
            match.StartMatch();
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            match.Bet = Console.ReadLine().ToUpper();
            while (match.MatchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine().ToUpper();
                match.AddGoal(command);
            }
            match.IsBetCorrectText();
        }
    }
}
