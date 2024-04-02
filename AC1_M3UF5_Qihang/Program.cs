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
            const string MsgInvalidInput = "Invalid input. Please try again.";
            /*List<Score> scores = new List<Score>
            {
                new Score("Carlos", "Alfa-001", 10),
                new Score("Carlos", "Alfa-001", 200),
                new Score("Carlos", "Beta-002", 300),
                new Score("Mario", "Alfa-001", 400),
                new Score("Mario", "Beta-002", 499),
                new Score("Mario", "Beta-002", 231),
                new Score("Paula", "Alfa-001", 423),
                new Score("Paula", "Beta-002", 122),
                new Score("Paula", "Beta-002", 422)
            };*/

            List<Score> scores = new List<Score>();

            Console.WriteLine(MsgWelcome);

            //BUCLE DE INPUT CON SISTEMA DE ERRORES

            List<Score> ranking = Ranking.GenerateUniqueRanking(scores);

            Ranking.PrintRanking(ranking);
        }
    }
}