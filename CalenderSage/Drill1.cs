using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Drill1
    {
        

        public int Level1Drill(string[] days, string[] daysNum, string[] daysAlpha,
            int test1Score, int test2Score, int seconds, bool useFirstTest, bool useSecondTest)
        {
            Console.Clear();
            
            int score = 0;

            Station.WriteLine("Welcome to the Day of week Dril");
            Station.WriteLine("Here we test your memory of days of the week");
            Station.WriteLine("You must finish the whole activity in " + seconds + " seconds");

            Station.WriteLine("\n\n");
            
            Station.WriteLine("Press Any key to begin");
            Console.ReadKey(true);

            //initialize timer 
            DateTime instant;
            string time;
            DateTime now = DateTime.Now;


            if (useFirstTest)
            {
                Station.RandClear();
                do
                {
                    Console.Clear();
                    Station.WriteLine("\n\nyour current score is " + score.ToString() + "\n");
                    instant = DateTime.Now;
                    time = Station.TimeDifference(now).ToString();
                    Station.WriteLine("You have used : " + time + " Seconds");
                    Station.WriteLine("You must finish the whole activity in " + seconds + " seconds");
                    Station.WriteLine("\nWhat is the number Equivalent for:");

                    int randNum = Station.Randomer(0, days.Length);
                    string day = days[randNum];

                    Station.WriteLine(day);

                    string answer = Station.Read();

                    if (answer == daysNum[randNum])
                    {
                        score++;
                        Station.WriteLine("Correct");
                    }
                    else
                    {
                        score--;
                        Station.WriteLine("Incorrect");
                    }

                }
                while (score < test1Score);
            }

            if (useSecondTest)
            {
                Station.RandClear();
                do
                {
                    Console.Clear();
                    Station.WriteLine("\nNice now you have to practice as in real life");
                    Station.WriteLine("You must finish the whole activity in " + seconds + " seconds");
                    Station.WriteLine("press :");

                    for (int i = 0; i < days.Length; i++)
                    {
                        Station.WriteLine(daysAlpha[i] + " for " + days[i]);
                    }

                    Station.WriteLine("your current score is " + score.ToString() + "\n");

                    instant = DateTime.Now;
                    time = Station.TimeDifference(now).ToString();
                    Station.WriteLine("You have used : " + time + " Seconds");

                    Station.WriteLine("\nWhat is the Equivalent for:");

                    int randNum = Station.Randomer(0,days.Length);
                    string day = daysNum[randNum];

                    Station.WriteLine(day);

                    string answer = Station.Readletter();

                    if (answer == daysAlpha[randNum])
                    {
                        score++;
                        Station.WriteLine("Correct");
                    }
                    else
                    {
                        score--;
                        Station.WriteLine("Incorrect");
                    }

                }
                while (score < test2Score + 1);
            }

            instant = DateTime.Now;            
            int timeInt = Station.TimeDifference(now);

            if (timeInt > seconds)
            {
                return -1;
            }
            else
            {
                return score;
            }
           
            
        }

        
           

       
        
    }
}
