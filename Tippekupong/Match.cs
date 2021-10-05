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
            MatchIsRunning = true;
        }

        public void IsBetCorrectText()
        {
            var isBetCorrect = IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }

        private void StopMatch()
        {
            MatchIsRunning = false;
        }

        public void AddGoal(string command)
        {
            switch (command)
            {
                case "H":
                    HomeGoals++;
                    break;
                case "B":
                    AwayGoals++;
                    break;
                case "X":
                    StopMatch();
                    break;
            }
            GetScore();
        }

        private bool IsBetCorrect()
        {
            var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
            var isBetCorrect = Bet.Contains(result);
            return isBetCorrect;
        }

        private void GetScore()
        {
            Console.WriteLine($"Stillingen er {HomeGoals}-{AwayGoals}.");
        }
    }
}
