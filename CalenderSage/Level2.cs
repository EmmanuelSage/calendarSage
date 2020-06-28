using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Level2
    {
        public void Start()
        {
            Console.Clear();

            Station.WriteLine("Welcome to Formula");
            Station.WriteLine("Ready for the formula? Here it is: ");
            Station.WriteLine("[Month Code + Date + Year Code = Day of Week Code.] ");
            Station.WriteLine("We haven't covered year codes yet,");
            Station.WriteLine("so I'm just going to teach you four ");
            Station.WriteLine("simple ones with which to start out:");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);

            //////////////////////////////////
            Console.Clear();
            Station.WriteLine("2000 = 0");
            Station.WriteLine("2001 = 1");
            Station.WriteLine("2002 = 2");
            Station.WriteLine("2003 = 3");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);

            ///////////////////////
            Console.Clear();
            Station.WriteLine("Let's figure out May 1, 2000. ");
            Station.WriteLine("The mnemonic is MAY-0, so May is a 0.");
            Station.WriteLine("The date itself is the first, so we use 1.");
            Station.WriteLine("The year code for 2000 is 0, so our problem is");
            Station.WriteLine("0 + 1 + 0 = 1.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);

            
            ///////////////////////
            Console.Clear();
            Station.WriteLine("Which weekday has a code of 1 ? ONEday is MONday, ");
            Station.WriteLine("so Monday is the day of the week on which May 1, 2000 fell.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);


            /////////////////////
            Console.Clear();
            Station.WriteLine("Let's try a date that's a little more challenging. ");
            Station.WriteLine("Our next date is October 4, 2000. October is 6 (remember “SIX or treat”?),");
            Station.WriteLine("and 2000 is still 0, so that gives us 6 + 4 + 0 = 10.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);

            /////////////////////
            Console.Clear();
            Station.WriteLine("Wait a minute, the weekday codes only range from 0 to 6! ");
            Station.WriteLine("What do we do with a 10, or any result higher than 6 for that matter?");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);

            /////////////////////
            Console.Clear();
            Station.WriteLine("If you look on a calendar, ");
            Station.WriteLine("the 10th of any month will always fall on the");
            Station.WriteLine("same day of the week as the 3rd,");
            Station.WriteLine("because the 3rd is 7 days earlier.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);

            /////////////////////
            Console.Clear();
            Station.WriteLine("Hence we can subtract 7, or any multiples of 7 to reduce the answer.");
            Station.WriteLine("we are now going to learn a little about the multiples of 7.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
                    
            
            

            Console.Clear();
            Station.WriteLine("Welcome to the Multiple of 7 Dril");
            Station.WriteLine("Here are some of the multiples of seven");
            Station.WriteLine("\n\n7,14,21,28,35,42,49,56,63,70,77,84,91,98,105,\n" +
                                "112, 119, 126, 133, 140, 147, 154, 161, 168, 175, 182, 189, \n" +
                                "196, 203, 210, 217, 224, 231, 238, 245, 252, 259, 266, 273, \n" +
                                "280, 287, 294, 301, 308, 315, 322, 329, 336, 343.");

            Station.WriteLine("\n Press any key to continue");
            //Console.ReadKey(true);

            Console.Clear();
            Station.WriteLine("\n\nYou will mostly encounter the first 15 ");
            Station.WriteLine("in this drill you are to type the first 17 multiples of 7 in " + 20 + " seconds");
            Station.WriteLine("that means 7 to 119 ");
            Station.WriteLine("there are two rounds ");

            Station.WriteLine("\n Press any key to Begin Drill");
            Console.ReadKey(true);

            Console.Clear();

            int score;
            Drill2 d2 = new Drill2();
            string[] multiples7 = { "7", "14", "21", "28", "35", "42", "49", "56","63", "70", "77", "84", "91", "98",
                "105", "112","119"};
            do
            {
                score = d2.MultiplesType(multiples7,20);
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
                score = d2.MultiplesGuess(0,120,multiples7,30,20);
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
            Station.WriteLine("In our October 4, 2000 example,");
            Station.WriteLine("we got 10 as a result,");
            Station.WriteLine("so we can reduce that by 7. 10 - 7 = 3, ");
            Station.WriteLine("so our result boils down to 3.");
            Station.WriteLine(" Which day of the week is 3 ? Since 3 fingers looks like the letter W, ");
            Station.WriteLine("that's Wednesday. Once again, you can check that here.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////


            /////////////////////
            Console.Clear();
            Station.WriteLine("This reduction of the multiples of 7 can make the problem itself easier,");
            Station.WriteLine("as well. Let's try figuring out the day of the week for Halloween 2001,");
            Station.WriteLine("or October 31, 2001. October is 6, and 2001 is a 1,");
            Station.WriteLine("so the problem works out to be 6 + 31 + 1 = 38.");
            Station.WriteLine("The closest multiple of 7 to 38 is 35, so we do 38 - 35 = 3,");
            Station.WriteLine("which gives us another Wednesday.");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////
            
            /////////////////////
            Console.Clear();
            Station.WriteLine("That approach works, but it could be made simpler.");
            Station.WriteLine("When you hear that the date is the 31st,");
            Station.WriteLine("you can reduce that right away by working out that 31 - 28");
            Station.WriteLine("(the closest multiple of 7 to 31) = 3, and doing 6 + 3 + 1 = 10. ");
            Station.WriteLine("True, you would still need to reduce that 10 to 3 again to get Wednesday,");
            Station.WriteLine("but you'd need to subtract multiples of 7 either way.");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////


            /////////////////////
            Console.Clear();
            Station.WriteLine("Note that, by bringing the dates down by multiples of 7,");
            Station.WriteLine("you're making the problem you have to add much simpler.");
            Station.WriteLine("If 6 + 31 + 1 and 6 + 3 + 1 will both give you the same results,");
            Station.WriteLine("wouldn't you prefer to make it easier on yourself?");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            /////////////////////
            Console.Clear();
            Station.WriteLine("Let's try this with Valentine's Day in 2003.");
            Station.WriteLine("We start by making sure of the date, February 14, 2003.");
            Station.WriteLine("February is a 2 (remember the mnemonic?), and 2003 is a 3.");
            Station.WriteLine(" The problem then becomes 2 + 14 + 3. However,");
            Station.WriteLine("if you spotted that 14 was already a multiple of 7,");
            Station.WriteLine("you should realize that you can drop it out completely! 14,");
            Station.WriteLine("or any multiple of 7, is the same as 0, so you can ignore them.");
            Station.WriteLine("For February 14, 2003, all you really need to add is 2 + 3 = 5. 5 is a FIVEday,");
            Station.WriteLine("or rather a Friday, so that's our answer!");

            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            /////////////////////
            Console.Clear();
            Station.WriteLine(@"What about February 2, 2000 (Groundhog Day)? 
February is 2, and 2000 is 0, 
so the problem we get is 2 + 2 + 0 = 4. 4 is a Thursday (remember FOURSday?),
 so February 2, 2000 should be a Thursday.
 Once again, we verify that information here and...OOPS! 
but a calendar says February 2, 2000 is a Wednesday! What went wrong?");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            /////////////////////
            Console.Clear();
            Station.WriteLine(@"I briefly mentioned this at the end of the previous tab, 
but it needs to be repeated now.
 Whenever you're working in January or February dates in a leap year,
 you need to reduce the month code by 1 to compensate. Effectively the extra day,
 February 29, hasn't happened yet, so we're subtracting one to adjust for that fact.
 January becomes 5 (6 - 1) and February becomes 1 (2 - 1).");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            /////////////////////
            Console.Clear();
            Station.WriteLine(@"Since February 2, 2000 is a February date in a leap year, 
the code for February needs to be 1, not 2. Let's try the equation again,
 with that in mind. February in a leap year is 1, and 2000 is 0, 
so the equation is 1 + 2 + 0 = 3, which you should know by now is a Wednesday.
 As we saw when we originally made the error, Wednesday is indeed the correct day of the week.");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            /////////////////////
            Console.Clear();
            Station.WriteLine(@"
Practice the Dates: 2000 to 2003 quiz here,
 making sure to keep an eye out for January and February dates in 2000, 
and adjusting your calculations accordingly.
 Practice these dates until you can calculate them with little trouble,
 and don't forget to subtract multiples of 7 to make your work easier!");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            /////////////////////
            Console.Clear();
            Station.WriteLine(@"
Practice the Dates: 2000 to 2003 quiz here,
 making sure to keep an eye out for January and February dates in 2000, 
and adjusting your calculations accordingly.
 Practice these dates until you can calculate them with little trouble,
 and don't forget to subtract multiples of 7 to make your work easier!");


            Station.WriteLine("\n Press any key to continue");
            Console.ReadKey(true);
            /////////////////////

            
            do
            {
                score = d2.FourYears(2000, 2003,100,10);
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
            Station.WriteLine("Congratulations you have passed Level 2");
            Station.WriteLine("instead of pressing enter");
            Station.WriteLine("type 'leap years' to go to level three");
            Station.WriteLine("it will be invisible, just type it");
            Station.WriteLine("Pres any key to continue");
            Console.ReadKey(true);
            StartCalendar sc = new StartCalendar();
            sc.Start();


        }

    }
}

