using System;
using System.Linq;

namespace Tippekupong
{
    class TwelveMatches
    {
        public string[] Bets;
        public Match[] Matches;

        public TwelveMatches(string betsText)
        {
            Bets = betsText.Split(',');
            Matches = new Match[12];
            for (var i = 0; i < 12; i++)
            {
                Matches[i] = new Match(Bets[i]);
            }
        }
        public void AddGoal(int matchNo, string team)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = Matches[selectedIndex];
            selectedMatch.AddGoal(team);
        }

        public void ShowAllScores()
        {
            for (var index = 0; index < Matches.Length; index++)
            {
                var match = Matches[index];
                var matchNo = index + 1;
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }
        }
        public void ShowCorrectCount()
        {
            var correctCount = Matches.Count(match => match.IsBetCorrect());
            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}
