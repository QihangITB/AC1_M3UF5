using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AC1_M3UF5_Qihang
{
    public class Score
    {
        private const int firstPosition = 0, secondPosition = 1, MinScoring = 0,MaxScoring = 500;

        private string? player;
        private string? mission;
        private int scoring;

        public string Player
        {
            get { return this.player; }
            set { this.player = CheckPlayer(value) ? value : null; }
        }
        public string Mission
        {
            get { return this.mission; }
            set { this.mission = CheckMission(value) ? value : null; }
        }
        public int Scoring
        {
            get { return this.scoring; }
            set { this.scoring = CheckScoring(value) ? value : -1; }
        }

        public Score(string player, string mission, int scoring)
        {
            Player = player;
            Mission = mission;
            Scoring = scoring;
        }

        public bool CheckPlayer(string player)
        {
            string pattern = "[a-zA-Z]";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(player);
        }

        public bool CheckMission(string mission)
        {
            string[] prefixes = {"Alfa", "Beta", "Gamma", "Delta", "Epsilon",
                "Zeta", "Eta", "Theta", "Iota", "Kappa", "Lambda", "Mi", 
                "Ni", "Ksi", "Omicron", "Pi", "Ro", "Sigma", "Tau", "Ipsilon", 
                "Fi", "Khi", "Psi", "Omega"};

            string[] arrayName = mission.Trim().Split('-');

            bool validPrefix = prefixes.Contains(arrayName[firstPosition]);

            string number = arrayName[secondPosition];

            string pattern = "[0-9]{3}";
            Regex rg = new Regex(pattern);

            return rg.IsMatch(number) && validPrefix;
        }

        public bool CheckScoring(int scoring)
        {
            return scoring >= MinScoring && scoring <= MaxScoring;
        }

    }
}
