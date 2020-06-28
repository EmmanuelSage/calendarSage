using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Program
    {
        /*
        static List<int> randList = new List<int>();
        static int randNum = 0;
        static Random rand = new Random();
        */
        static void Main(string[] args)
        {
            Console.Title = "Sage Calendar";
            Console.ForegroundColor = ConsoleColor.Cyan;
            StartCalendar sc = new StartCalendar();
            sc.Start();
            

            //Drill2 d2 = new Drill2();
            //d2.FourYears(2000,2003);

            //Level1 l1 = new Level1();
            //l1.Start();

            //FinalLevel l1 = new FinalLevel();
            //l1.Start();

            Console.ReadKey();


        }


        
    }
}
