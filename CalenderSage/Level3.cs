using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Level3
    {
        public void Start()
        {
            Console.Clear();
            Station.WriteLine("Here we would learn about leap years");
            Station.WriteLine("basically any year that the last two digits");
            Station.WriteLine("is divisible by four is a leap year");
            Station.WriteLine("hence we would learn the multiples of 4 from 4 to 96");

            Station.WriteLine(" Press any key to Continue");
            Console.ReadKey(true);

            Console.Clear();
            Station.WriteLine("an easy pattern that occurs from 4 - 96 is");
            Station.WriteLine("if the first letter is even then the multiples of 4 are");
            Station.WriteLine("that it ends in 0, 4 or 8");
            Station.WriteLine("if odd, then ends in 2 or 6");

            Station.WriteLine(" Press any key to Continue");
            Console.ReadKey(true);

            Console.Clear();
            Station.WriteLine("96 is the highest you will need ");
            Station.WriteLine("in this drill you are to type the first  multiples of 4 in " + 20 + " seconds");
            Station.WriteLine("that means 4 to 96 ");
            Station.WriteLine("there are two rounds ");

            Station.WriteLine("\n Press any key to Begin Drill");
            Console.ReadKey(true);

            Console.Clear();

            int score;
            Drill2 d2 = new Drill2();
            string[] multiples4 = { "4", "8", "12", "16", "20", "24", "28", "32", "36", "40", "44", "48", "52", "56",
                                    "60","64","68","72","76","80","84","88","92","96",};
            do
            {
                score = d2.MultiplesType(multiples4, 35);
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

            /////
            Console.Clear();
            Station.WriteLine("\n\nNow lets try another drill");
            Station.WriteLine("in this drill you are to type true or false");
            Station.WriteLine("if the number is a multiple or not");

            Station.WriteLine("\n Press any key to Begin Drill");
            Console.ReadKey(true);

            Console.Clear();

            do
            {
                score = d2.MultiplesGuess(0, 120, multiples4, 35, 20);
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


            Console.Clear();
            Station.WriteLine("Years ending in 00 are only leap years if they're divisible by 400.");
            Station.WriteLine("So, 1600, 2000, and 2400 are leap years, while 1800, 1900, and 2100 are not.");
            Station.WriteLine("press any key to proceed");
            Console.ReadKey(true);

            Console.Clear();
            Station.WriteLine("Congratulations you have passed Level 3");
            Station.WriteLine("instead of pressing enter");
            Station.WriteLine("type 'all years' to go to level three");
            Station.WriteLine("it will be invisible, just type it");
            Station.WriteLine("Pres any key to continue");
            Console.ReadKey(true);
            StartCalendar sc = new StartCalendar();
            sc.Start();


        }
    }
}

