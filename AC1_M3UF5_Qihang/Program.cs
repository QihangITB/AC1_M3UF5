namespace AC1_M3UF5_Qihang
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Welcome to the ranking generator!";
            const string AskPlayer = "Enter the player's name (only alphabetic characters):";
            const string AskMission = "Enter the mission (greek prefix - 3 digit number):";
            const string AskScore = "Enter the score [0-500]:";
            const string MsgInvalidScore = "Invalid score. Please try again.";
            const string Lines = "------------------------------------------------------";
            const string MsgRegisteredList = "Registered scores:";
            const string MsgRankingList = "Ranking scores:";

            const int MaxInput = 10;

            string player, mission;
            int score;
            List<Score> scores = new List<Score>();

            Console.WriteLine(MsgWelcome);

            for (int i = 0; i < MaxInput; i++)
            {
                Console.WriteLine(AskPlayer);
                player = Console.ReadLine();
                player = Score.CheckPlayer(player) ? player : null;

                Console.WriteLine(AskMission);
                mission = Console.ReadLine();
                mission = Score.CheckMission(mission) ? mission : null;

                Console.WriteLine(AskScore);
                score = Convert.ToInt32(Console.ReadLine());
                score = Score.CheckScoring(score) ? score : -1;

                if (string.IsNullOrEmpty(player) || string.IsNullOrEmpty(mission) || score == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MsgInvalidScore);
                    Console.ResetColor();
                    i--;
                }
                else
                {
                    scores.Add(new Score(player, mission, score));
                }
                Console.WriteLine(Lines);
            }

            //Muestra la lista de los datos que se han introducido
            Console.WriteLine(MsgRegisteredList);
            Ranking.PrintRanking(scores);

            List<Score> ranking = Ranking.GenerateUniqueRanking(scores);

            //Muestra el ranking final con las puntuaciones unicas
            Console.WriteLine(MsgRankingList);
            Ranking.PrintRanking(ranking);

        }
    }
}