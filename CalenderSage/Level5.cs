using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Level5
    {
        public void Start()
        {
            Console.Clear();

            Station.WriteLine("Here we would learn to do it for other centuries");
            Station.WriteLine("there's a simple pattern to alter the day for other centuries: ");
            Station.WriteLine(@"2300 to 2399 = add 1
2200 to 2299 = add 3
2100 to 2199 = add 5
2000 to 2099 = add 0
1900 to 1999 = add 1
1800 to 1899 = add 3
1700 to 1799 = add 5
1600 to 1699 = add 0
");
            
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            //////////////////////
            Console.Clear();

            Station.WriteLine(@"There is one VERY important note here for 
January and February dates in the years ending in 00: 
If a year ends in 00, it's only a leap year if it's divisible by 400.
 The years 1600, 2000, and 2400, and so on are leap years,
while years like 1900, 1800, and 2100 are not. 
If you're given a January or February 
date in a year ending in 
double check whether it's a leap year 
before you make the leap year adjustment.");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            //////////////////////
            Console.Clear();

            Station.WriteLine(" here we are going to practice all the years");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            /////////////////////////////
            Console.Clear();

            Station.WriteLine("Lets us do some drills");
            Station.WriteLine("this wpuld contain 1600 to 2399");
            Station.WriteLine("We are going to practice with all years");
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            int score;
            Drill2 d2 = new Drill2();
            do
            {
                score = d2.FourYears(1600, 2399, 40, 10);
                if (score == -1)
                {
                    Console.Clear();
                    Station.WriteLine("Sorry but you did not complete the drill in time");
                    Station.WriteLine("You would have to start again");
                    Station.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }

            while (score == -1);

            Station.WriteLine("Congratulations your score was " + score.ToString());
            Station.WriteLine("press any key to proceed");
            Console.ReadKey(true);


            ////////////////////////////


            Console.Clear();
            Station.WriteLine("Congratulations you have passed Level 5");
            Station.WriteLine("instead of pressing enter");
            Station.WriteLine("type 'master' to go to final level");
            Station.WriteLine("it will be invisible, just type it");
            Station.WriteLine("Pres any key to continue");
            Console.ReadKey(true);
            StartCalendar sc = new StartCalendar();
            sc.Start();
        }
    }
}
