using System;

namespace Tippekupong
{
    class Program
    {
        static void Main(string[] args)
        {
            var match = new Match();
            match.StartMatch();
            var result = match.HomeGoals == match.AwayGoals ? "U" : match.HomeGoals > match.AwayGoals ? "H" : "B";
            var isBetCorrect = match.Bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
