using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC1_M3UF5_Qihang
{
    public class Ranking
    {
        public static List<Score> GenerateUniqueRanking(List<Score> scoreList)
        {
            List<Score> ranking = new List<Score>();

            var scoreQuery = from score in scoreList
                        group score by new { score.Player, score.Mission } into g
                        orderby g.Max(x => x.Scoring) descending
                        select new
                        {
                            Player = g.Key.Player,
                            Mission = g.Key.Mission,
                            Scoring = g.Max(x => x.Scoring)
                        };

            foreach (var score in scoreQuery)
            {
                ranking.Add(new Score(score.Player, score.Mission, score.Scoring));
            }

            return ranking;
        }

        public static void PrintRanking(List<Score> rankingList)
        {
            foreach (Score score in rankingList)
            {
                Console.WriteLine($"Name: {score.Player}, Mission: {score.Mission}, Score: {score.Scoring}");
            }
        }
    }
}
