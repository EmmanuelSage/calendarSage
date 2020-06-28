using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
    
namespace CalenderSage
{
    class StartCalendar
    {

        public void Start()
        {
            Console.Clear();
            Station.WriteLine("Welcome to the Calender Sage");
            Station.WriteLine("Enter your Level Password");
            Station.WriteLine("There are six levels in total");
            Station.WriteLine("press the [enter] key 'only' to start");

            string pass = Station.Read();

            if (pass == "")
            {
                Level1 l1 = new Level1();
                l1.Start();
            }
            else if (pass == "formula")
            {
                Level2 l2 = new Level2();
                l2.Start();
            }
            else if (pass == "leap years")
            {
                Level3 l3 = new Level3();
                l3.Start();
            }
            else if (pass == "all years")
            {
                Level4 l4 = new Level4();
                l4.Start();
            }
            
            else if (pass == "other centuries")
            {
                Level5 l5 = new Level5();
                l5.Start();
            }
            else if (pass == "master")
            {
                FinalLevel fl = new FinalLevel();
                fl.Start();
            }
            else
            {
                Station.WriteLine("Wrong Password");
            }


        }

      

        
    }
}
