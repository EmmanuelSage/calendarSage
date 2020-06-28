using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Station
    {
        public static List<int> randList = new List<int>();
        static int randNum = 0;
        static Random rand = new Random();

        public static List<int> randList1 = new List<int>();
        static int randNum1 = 0;
        static Random rand1 = new Random();

        public static List<int> randList2 = new List<int>();
        static int randNum2 = 0;
        static Random rand2 = new Random();

        public static int Randomer(int start,int arrLength)
        {

            if (randList.Count == arrLength)
            {
                RandClear();
            }
            do
            {
                //arrLength - 1 is to make sure last letter isnt randomized
                randNum = rand.Next(start, arrLength - 1);
                //
                if (randList.Count == arrLength - 2 && !randList.Contains(randNum))
                {
                    randNum = arrLength - 1;
                    break;
                }
            }
            while (randList.Contains(randNum));

            randList.Add(randNum);

            return randNum;
        }

        /*Quickly save Random no algorithm
        
            if (randList.Count == arrLength)
            {
                RandClear();
            }
            do
            {
                //arrLength - 1 is to make sure last letter isnt randomized
                randNum = rand.Next(start, arrLength - 1);
                //
                if (randList.Count == arrLength - 2 && !randList.Contains(randNum))
                {
                    randNum = arrLength - 1;
                    break;
                }
            }
            while (randList.Contains(randNum));

            randList.Add(randNum);

            return randNum;
            
            */
        public static void RandClear()
        {
            randList = new List<int>();
        }

        public static int Randomer1(int start, int arrLength)
        {
            //make entrance arraylengh equal
            if (randList1.Count == arrLength)
            {
                RandClear1();
            }
            do
            {
                //arrlength + 1 to make it up to
                randNum1 = rand1.Next(start, arrLength + 1);
                //!randList.COntains(no) and arrLength - 1
                if (randList1.Count == arrLength - 1 && !randList1.Contains(randNum1))
                {
                    //just arrLength so its the last no
                    randNum1 = arrLength;
                    break;
                }
            }
            while (randList1.Contains(randNum1));

            randList1.Add(randNum1);

            return randNum1;
        }

        public static void RandClear1()
        {
            randList1 = new List<int>();
        }

        public static int Randomer2(int start, int arrLength)
        {

            if (randList2.Count == arrLength)
            {
                RandClear2();
            }
            do
            {
                randNum2 = rand2.Next(start, arrLength + 1);
                if (randList2.Count == arrLength - 1 && !randList2.Contains(randNum2))
                {
                    randNum2 = arrLength;
                    break;
                }
            }
            while (randList2.Contains(randNum2));

            randList2.Add(randNum2);

            return randNum2;
        }

        public static void RandClear2()
        {
            randList2 = new List<int>();
        }

        public static int TimeDifference(DateTime initial)
        {
            DateTime final = DateTime.Now;
            TimeSpan lapse = final.Subtract(initial);
            int timeSec = lapse.Seconds;
            int timeMin = lapse.Minutes;

            int timeDiff = (timeMin * 60) + timeSec;

            return timeDiff;
        }

        public static void Write(string text)
        {
            Console.Write(text);
        }
        public static void WriteLine(string text)
        {            
            Console.WriteLine(text);
        }

        public static string Read()
        {
            string text = Console.ReadLine();
            return text;
        }

        public static string Readletter()
        {            
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);

            char letter = key.KeyChar;

            string text = letter.ToString();

            return text;
        }
    }
}
