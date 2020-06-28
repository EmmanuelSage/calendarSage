using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class FinalLevel
    {
        public void Start()
        {
            Console.Clear();

            Station.WriteLine("welcome this is master level");
            Station.WriteLine("in this place you set your");
            Station.WriteLine("time limit and target score");
            Station.WriteLine("you can pace yourself to master");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            //////////////////////

            Console.Clear();

            Station.WriteLine("enter your target score");

            string targetScore = Station.Read();
            int targetScoreInt = Int32.Parse(targetScore);

            Station.WriteLine("Enter your Time Limit ");

            string timeLimit = Station.Read();
            int timeLimitInt = Int32.Parse(timeLimit);

            Station.WriteLine("enter the year to start from");

            string startYear = Station.Read();
            int startYearInt = Int32.Parse(startYear);

            Station.WriteLine("Enter the end year");
            string endYear = Station.Read();
            int endYearInt = Int32.Parse(endYear);

            Station.WriteLine("Press any key to begin");
            Console.ReadKey();

            //////////////////////

            int score;
            Drill2 d2 = new Drill2();

            do
            {
                score = d2.FourYears(startYearInt, endYearInt, timeLimitInt, targetScoreInt);
                if (score == -1)
                {
                    Console.Clear();
                    Station.WriteLine("Sorry but you did not reach your goal");
                    Station.WriteLine("You would have to start again");
                    Station.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }

            while (score == -1);

            Station.WriteLine("Congratulations your score was " + score.ToString());
            Station.WriteLine("you reached your goal");
            Station.WriteLine("now set another");
            Station.WriteLine("press any key to proceed");
            Console.ReadKey(true);
            Start();

            ////////////////////////////


            
        }
    }
}
