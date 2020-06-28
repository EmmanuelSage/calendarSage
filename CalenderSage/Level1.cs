using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Level1
    {
        public void Start()
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", };
            string[] daysNum = { "0", "1", "2", "3", "4", "5", "6" };
            string[] daysAlpha = { "s", "m", "t", "w", "h", "f", "a" };

            Console.Clear();
            Station.WriteLine("Memory is tricky, here you'll learn");
            Station.WriteLine("to memorize the whole calendar from the year 1600 to 2399");

            Station.WriteLine("first memorize the code for the week days\n");
            Station.WriteLine("Sunday   = 0     i.e None day");
            Station.WriteLine("Monday   = 1     i.e One-day");
            Station.WriteLine("Tuesday  = 2     i.e Twos-day");
            Station.WriteLine("Wednesday= 3     i.e W looks like 3");
            Station.WriteLine("Thursday = 4     i.e Fours-Day");
            Station.WriteLine("Friday   = 5     i.e Five-Day");
            Station.WriteLine("Saturday = 6     i.e Six-Turday");

            
            Station.WriteLine("Once You've Memorized this press C to continue");

            Console.CursorVisible = false;
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.C)
            {
                Drill1 q = new Drill1();
                int score;
                do
                {
                    score = q.Level1Drill(days, daysNum, daysAlpha, 7, 28, 70,true, true );
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
                Level1Stage2();
            }
            else
            {
                Start();
            }
        }

        
        private void Level1Stage2()
        {
            string[] days = { "January", "February", "March", "April", "May", "June","July", "August",
                            "September", "October", "November", "December"
                            };
            string[] daysNum = { "6", "2", "2", "5", "0", "3", "5", "1", "4", "6", "2", "4" };
            string[] daysAlpha = { "j", "f", "m", "a", "y", "u", "l", "g", "s", "o", "n", "d" };

            Console.Clear();
            Station.WriteLine("Next you have to learn the codes for months\n " +
                "This will enable you in your journey");

            Station.WriteLine("first memorize the code for the Months\n");

            Station.WriteLine("January: 6       i.e WINTER has 6 letters");
            Station.WriteLine("February: 2      i.e February is 2nd month");
            Station.WriteLine("March: 2         i.e March 2 the beat.");
            Station.WriteLine("April: 5         i.e APRIL has 5 letters(&FOOLS!)");
            Station.WriteLine("May: 0           i.e MAY - 0");
            Station.WriteLine("June: 3          i.e June BUG(BUG has 3 letters)");
            Station.WriteLine("July: 5          i.e FIVERworks");
            Station.WriteLine("August: 1        i.e A - 1 Steak Sauce at picnic");
            Station.WriteLine("September: 4     i.e FALL has 4 letters");
            Station.WriteLine("October: 6       i.e SIX or treat!y");
            Station.WriteLine("November: 2      i.e 2 legs on 2rkey");
            Station.WriteLine("December: 4      i.e LAST(or XMAS) has 4 letter");

            Station.WriteLine("Note: It's important to note that, in leap years, \n" +
                            "January reduces by one to 5, and February reduces by one to 1. \n" +
                            " The other months don't change in leap years.\n");


            Station.WriteLine("\nOnce You've Memorized this press C to continue");

            Console.CursorVisible = false;
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.C)
            {
                Drill1 q = new Drill1();
                int score;
                do
                {
                    score = q.Level1Drill(days, daysNum, daysAlpha, 36, 0, 70, true, false);

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
                FinalStage();
            }
            else
            {
                Level1Stage2();
            }
        }

        public void FinalStage()
        {
            string[] days = { "January", "February", "March", "April", "May", "June","July", "August",
                            "September", "October", "November", "December"
                            };
            string[] daysNum = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] daysAlpha = { "j", "f", "m", "a", "y", "u", "l", "g", "s", "o", "n", "d" };

            Console.Clear();
            Station.WriteLine("Finally The months in this application are\n " +
                "asked in numbers hence lets make sure youre familiar");

            Station.WriteLine("with say what the fifth month or seventh month is\n");

            Station.WriteLine("January:     1       ");
            Station.WriteLine("February:    2      ");
            Station.WriteLine("March:       3         ");
            Station.WriteLine("April:       4         ");
            Station.WriteLine("May:         5           ");
            Station.WriteLine("June:        6          ");
            Station.WriteLine("July:        7          ");
            Station.WriteLine("August:      8        ");
            Station.WriteLine("September:   9     ");
            Station.WriteLine("October:     10       ");
            Station.WriteLine("November:    11     ");
            Station.WriteLine("December:    12     ");

            Station.WriteLine("\nOnce You've Memorized this press C to continue");

            Console.CursorVisible = false;
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.C)
            {
                Drill1 q = new Drill1();
                int score;
                do
                {
                    score = q.Level1Drill(days, daysNum, daysAlpha, 0, 24, 80,false, true);

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
                PassedLevel1();
            }
            else
            {
                FinalStage();
            }

        }

        private void PassedLevel1()
        {
            Console.Clear();
            Station.WriteLine("Congratulations you have passed Level 1");
            Station.WriteLine("instead of pressing enter");
            Station.WriteLine("type 'formula' to go to level two");
            Station.WriteLine("it will be invisible, just type it");
            Station.WriteLine("Pres any key to continue");
            Console.ReadKey(true);
            StartCalendar sc = new StartCalendar();
            sc.Start();
        }
    }
}
