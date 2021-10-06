using System;

namespace Tippekupong
{ 
    class Match
    {

        public int HomeGoals;
        public int AwayGoals;
        public bool MatchIsRunning;
        public string Bet;

        public Match(string betstr)
        {
            HomeGoals = 0;
            AwayGoals = 0;
            Bet = betstr;
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

            Console.WriteLine(GetScore());
        }

        public bool IsBetCorrect()
        {
            var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
            var isBetCorrect = Bet.Contains(result);
            return isBetCorrect;
        }

        public string GetScore()
        {
            return $"Stillingen er {HomeGoals}-{AwayGoals}.";
        }

        public bool IsMatchRunning()
        {
            if (MatchIsRunning) return true;
            return false;
        }
    }
}
