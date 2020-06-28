using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Drill2
    {
        //make private TODODODODODODODODODO
        public int FourYears(int starterYear, int enderYear, int seconds, int scoreGoal)
        {
            // quiz any year
            int yearDiff = (enderYear + 1) - starterYear;
            List<int> yearList = new List<int>();
            int starterYearInc = starterYear;

            for (int i = 0; i < yearDiff; i++)
            {
                yearList.Add(starterYearInc);
                starterYearInc++;
            }

            int[] yearArr = yearList.ToArray();
            //dsdss

            int[] month31 = { 1, 3, 5, 7, 8, 10, 12 };
            int[] month30 = { 9, 4, 6, 11 };

            Station.RandClear();
            Station.RandClear1();
            Station.RandClear2();

            int score = 0;

            //int startYear = starterYear;
            //int endYear = enderYear + 1;
            //initialize timer 
            DateTime instant;
            string time;
            DateTime now = DateTime.Now;

            do
            {
                Console.Clear();
                
                int yearinter = Station.Randomer(0, yearArr.Length);
                int year = yearArr[yearinter];
                int month = Station.Randomer1(1,12);
                int day = 0;

                if (month31.Contains(month))
                {
                                      
                  day = Station.Randomer2(1, 31);
                    
                }
                else if (month30.Contains(month))
                {
                    day = Station.Randomer2(1, 30);
                }
                else if(month == 2 && DateTime.IsLeapYear(year))
                {
                    day = Station.Randomer2(1, 29);
                }
                else if (month == 2 && !DateTime.IsLeapYear(year))
                {
                    day = Station.Randomer2(1, 28);
                }

                DateTime guessDateTime = new DateTime(year, month, day);
                var guessDate = guessDateTime.Date;
                string dayOfWeekWord = guessDate.DayOfWeek.ToString();

                string dayOfWeek = dayOfWeekWord;

                if (dayOfWeek == "Sunday")
                {
                    dayOfWeek = "s";
                }
                else if (dayOfWeek == "Monday")
                {
                    dayOfWeek = "m";
                }
                else if (dayOfWeek == "Tuesday")
                {
                    dayOfWeek = "t";
                }
                else if (dayOfWeek == "Wednesday")
                {
                    dayOfWeek = "w";
                }
                else if (dayOfWeek == "Thursday")
                {
                    dayOfWeek = "h";
                }
                else if (dayOfWeek == "Friday")
                {
                    dayOfWeek = "f";
                }
                else if (dayOfWeek == "Saturday")
                {
                    dayOfWeek = "a";
                }

                string toGuess = guessDate.ToString("dd/MM/yyyy");

                Station.WriteLine("\n\nyour current score is " + score.ToString() + "\n");
                instant = DateTime.Now;
                time = Station.TimeDifference(now).ToString();
                Station.WriteLine("You have used : " + time + " Seconds");
                Station.WriteLine("You have to score : " + scoreGoal + " to win");
                Station.WriteLine("You must finish the whole activity in " + seconds + " seconds");

                Station.WriteLine("What is : " + toGuess);

                ///debug==================================
                Station.WriteLine("\nDebug=====");
                Station.WriteLine("pure date = " + toGuess);
                Station.WriteLine("Day of week = " + dayOfWeekWord);
                Station.WriteLine("Word code : " + dayOfWeek);
                Station.WriteLine("\nDebug=====\n");
                //========================================

                string answer = Station.Readletter();

                if (answer == dayOfWeek)
                {
                    score++;
                }
                else
                {
                    score--;
                }


            }
            while (score < scoreGoal);

            
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

        //make private TODODODODODODODODODO
        public int MultiplesType(string[] multiples,int seconds)
        {
                       

            List<string> answerList = new List<string>();
            int score = 0;
            DateTime instant;
            string time;
            DateTime now = DateTime.Now;
            Station.Write("\n\nType a multiple that is not above");
            do
            {
                if (answerList.Count == 17)
                {
                    break;
                }

                Console.Clear();
                Station.Write("you Have typed : ");
                foreach(var item in answerList)
                {
                    Station.Write(item + ", ");
                }
                                
                Station.WriteLine("\n\nyour current score is " + score.ToString() + "\n");
                instant = DateTime.Now;
                time = Station.TimeDifference(now).ToString();
                Station.WriteLine("You have used : " + time + " Seconds");

                string answer = Station.Read();

                if (multiples.Contains(answer) && !answerList.Contains(answer))
                {
                    answerList.Add(answer);
                    score++;

                }
                else
                {
                    Station.WriteLine("Nope try again");
                    //score--;
                }

                

            } while (true);

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

        public int MultiplesGuess(int startValue, int endValue, string[] valueArr, int seconds,int scoreGoal)
        {
            int score = 0;
            Station.RandClear();
            Station.WriteLine("Press T for true and F for false");
            //initialize timer 
            DateTime instant;
            string time;
            DateTime now = DateTime.Now;
            do
            {

                int guessInt = Station.Randomer(startValue, endValue);
                string guess = guessInt.ToString();

                Console.Clear();
                Station.WriteLine("\n\nyour current score is " + score.ToString() + "\n");
                instant = DateTime.Now;
                time = Station.TimeDifference(now).ToString();
                Station.WriteLine("You have used : " + time + " Seconds");
                Station.WriteLine("You must finish the whole activity in " + seconds + " seconds");

                Station.WriteLine("The Number below is a multiple:");
                Station.WriteLine(guess);

                string answer = Station.Readletter();

                if (answer == "t" && valueArr.Contains(guess))
                {
                    score++;
                }
                else if(answer == "t" && !valueArr.Contains(guess))
                {
                    score--;
                }
                else if (answer == "f" && !valueArr.Contains(guess))
                {
                    score++;
                }
                else if (answer == "f" && valueArr.Contains(guess))
                {
                    score--;
                }


            } while (score < scoreGoal);

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
