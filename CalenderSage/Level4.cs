using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderSage
{
    class Level4
    {
        public void Start()
        {
            Console.Clear();

            Station.WriteLine("Here we would learn all the years");
            Station.WriteLine("we would be using your knowledge of the ");
            Station.WriteLine("major system it is a phonetic system");
            Station.WriteLine("we still give the image peg name for a standard class");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();

            Station.WriteLine("you use the Phonetic Peg System for images to represent the");
            Station.WriteLine("last two digits of the year (0 to 99), ");
            Station.WriteLine("and the Shape Peg system for the year code (from 0 to 6).");
            Station.WriteLine("You then use the Link System to mentally link");
            Station.WriteLine("those two images together.");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();
            Station.WriteLine("Learn the Shapes first\n");
            Station.WriteLine(@"shape
0 = donut 
1 = spear
2 = swan
3 = mac donalds
4 = yatch
5 = hook
6 = yoyo");

            Station.WriteLine("\nPress any key to continue");
            Console.ReadKey();


            Console.Clear();

            Station.WriteLine("you use the Phonetic Peg System for images to represent the");
            Station.WriteLine("last two digits of the year (0 to 99), ");
            Station.WriteLine("and the Shape Peg system for the year code (from 0 to 6).");
            Station.WriteLine("You then use the Link System to mentally link");
            Station.WriteLine("those two images together.");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();


            Console.Clear();

            Station.WriteLine("lets learn the first 20");
            Station.WriteLine(@"Year	Year Code   Major Mnemonic
2000    0       Sys
2001    1       set
2002    2       sun
2003    3       sim
2004    5       sore
2005    6       seal
2006    0       surge
2007    1       sock
2008    3       sieve
2009    4       swab
2010    5       toes
2011    6       tot
2012    1       tin
2013    2       tomb
2014    3       tire
2015    4       towel
2016    6       dish
2017    0       tack
2018    1       dove
2019    2       tub
2020    4       nose");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();



            Console.Clear();

            Station.WriteLine("Lets us do some drills");
            Station.WriteLine("lets see your recall of the year codes");
            Station.WriteLine("We are going to practice with some real years");
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

            int score;
            Drill2 d2 = new Drill2();
            do
            {
                score = d2.FourYears(2000, 2020, 40, 10);
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

            //////////////////////////////////////
            Console.Clear();

            Station.WriteLine("lets learn the first 20");
            Station.WriteLine(@"Year	Year Code   Major Mnemonic
2021	5		net
2022	6		nun
2023	0		nemo
2024	2		naira(20)
2025	3		nail
2026	4		notch
2027	5		neck
2028	0		knife
2029	1		knob
2030	2		mice
2031	3		mat
2032	5		moon
2033	6		mummy
2034	0		mower
2035	1		mail
2036	3		match
2037	4		mack
2038	5		movie
2039	6		mop
2040	1		rose");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();



            Console.Clear();

            Station.WriteLine("Lets us do some drills");
            Station.WriteLine("lets see your recall of the year codes");
            Station.WriteLine("We are going to practice with some real years");
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();

                        
            do
            {
                score = d2.FourYears(2021, 2040, 40, 10);
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
            /////////////////////


            //////////////////////////////////////
            Console.Clear();

            Station.WriteLine("lets learn the first 20");
            Station.WriteLine(@"Year	Year Code   Major Mnemonic
2041	2		rat
2042	3		rain
2043	4		ram
2044	6		rower
2045	0		roll
2046	1		roach
2047	2		rock
2048	4		roof
2049	5		rob
2050	6		lace
2051	0		lot
2052	2		lion
2053	3		lime
2054	4		lure
2055	5		lilly
2056	0		leech
2057	1		log
2058	2		lava
2059	3		lip
2060	5		cheese");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();



            Console.Clear();

            Station.WriteLine("Lets us do some drills");
            Station.WriteLine("lets see your recall of the year codes");
            Station.WriteLine("We are going to practice with some real years");
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();


            do
            {
                score = d2.FourYears(2041, 2060, 40, 10);
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


            //////////////////////////////////////
            Console.Clear();

            Station.WriteLine("lets learn the first 20");
            Station.WriteLine(@"Year	Year Code   Major Mnemonic
2061	6		chat(whatsapp)
2062	0		chain
2063	1		gem
2064	3		cherry
2065	4		jail
2066	5		choo choo
2067	6		chuck(spy glasses)
2068	1		chef
2069	2		cheap (aba cloth sellers)
2070	3		case
2071	4		cot
2072	6		coin
2073	0		comb
2074	1		car
2075	2		coal
2076	4		cash
2077	5		coke
2078	6		cave
2079	0		cob
2080	2		fez");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();



            Console.Clear();

            Station.WriteLine("Lets us do some drills");
            Station.WriteLine("lets see your recall of the year codes");
            Station.WriteLine("We are going to practice with some real years");
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();


            do
            {
                score = d2.FourYears(2061, 2080, 40, 10);
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

            //////////////////////////////////////
            Console.Clear();

            Station.WriteLine("lets learn the first 20");
            Station.WriteLine(@"Year	Year Code   Major Mnemonic
2081	3		fit
2082	4		phone
2083	5		foam
2084	0		fur
2085	1		file
2086	2		fish
2087	3		fog
2088	5		fife
2089	6		fob
2090	0		bus
2091	1		bat
2092	3		bone
2093	4		bum
2094	5		bear
2095	6		bell
2096	1		beach
2097	2		book
2098	3		puff
2099	4		pipe");

            Station.WriteLine("Press any key to continue");
            Console.ReadKey();



            Console.Clear();

            Station.WriteLine("Lets us do some drills");
            Station.WriteLine("lets see your recall of the year codes");
            Station.WriteLine("We are going to practice with some real years");
            Station.WriteLine("Press any key to continue");
            Console.ReadKey();


            do
            {
                score = d2.FourYears(2081, 2099, 40, 10);
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
            Station.WriteLine("Congratulations you have passed Level 4");
            Station.WriteLine("instead of pressing enter");
            Station.WriteLine("type 'other centuries' to go to level five");
            Station.WriteLine("it will be invisible, just type it");
            Station.WriteLine("Pres any key to continue");
            Console.ReadKey(true);
            StartCalendar sc = new StartCalendar();
            sc.Start();
        }
    }
}
