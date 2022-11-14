using System.Text;

namespace File_IO___New___Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EventScore> eventScore = new List<EventScore>();

            int count = 0;
            string name = "";
            string eventName = "";
            double score = 0;
            foreach (string line in File.ReadLines(@"results.txt", Encoding.UTF8))
            {
                count++;
                if(count == 1)
                {
                    name = line;
                }
                else if (count == 2)
                {
                    eventName= line;
                }
                else if (count > 2)
                {
                    double.TryParse(line, out double tempScore);
                    score += tempScore;
                }
                if (count == 7)
                {
                    eventScore.Add( new EventScore(name,eventName,Math.Round(score, 2)));
                    score = 0;
                    count = 0;
                }
            }

            while (true)
            {
                Console.WriteLine("1 – Print Scores.\r\n2 – Highest Score.\r\n3 – Lowest Score.\r\n4 - Quit.");
                string menu_choice = Console.ReadLine();
                Console.Clear();
                if (menu_choice.Contains("1"))
                {
                    foreach(EventScore i in eventScore)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine();
                    }
                }
                else if (menu_choice.Contains("2"))
                {
                    EventScore topScore = null;
                    double topScoreDouble = 0;
                    foreach (EventScore i in eventScore)
                    {
                        
                        if (i.GetTotalScore() > topScoreDouble)
                        {
                            topScore = i;
                            topScoreDouble = i.GetTotalScore();
                        }
                    }
                    Console.WriteLine(topScore.ToString());
                }
                else if (menu_choice.Contains("3"))
                {
                    EventScore bottemScore = null;
                    double bottemScoreDouble = 9999999999999999999;
                    foreach (EventScore i in eventScore)
                    {

                        if (i.GetTotalScore() < bottemScoreDouble)
                        {
                            bottemScore = i;
                            bottemScoreDouble = i.GetTotalScore();
                        }
                    }
                    Console.WriteLine(bottemScore.ToString());
                }
                else if (menu_choice.Contains("4"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{menu_choice}, is not a vaild choice.");
                }

                Console.WriteLine("Press ENTER to Close");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}