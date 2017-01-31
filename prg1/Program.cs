using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using myclass;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {

            // myclass.home();
            /*
            int x, y;
            x = 7;
            y = x + 3;

            Console.WriteLine("Hello World");
            Console.WriteLine(y);
            Console.Write("enter ur first and last name: ");

            string first=Console.ReadLine();

            string second = Console.ReadLine();

            Console.WriteLine("hello, " + first + " " + second);
            Console.ReadLine();
            
            Console.Write("the if statement: choose 1 or 2: ");
            string choose= Console.ReadLine();

            if(choose == "1")
            {
                Console.WriteLine("haha");
            }
            else
            {
                Console.Write("blah");
            }

            string msg = (choose == "1") ? "wow" : "hmmm";
            Console.Write("hey ashik {0}, congrats {1}", msg, choose);
            
            Console.WriteLine("for loop");
            for (int myvalue = 0; i < 10; i++)
                Console.WriteLine(i);
            
            Console.WriteLine("arrays");
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[3]);
            string blah = "asckbbbbbkjn anskjnka asjnknas";
            char[] boo = blah.ToCharArray();
            Array.Reverse(boo);

            foreach (var x in boo)
            {
                Console.Write(x);
            }
            
            Console.Write("enter ur first and last name: ");

            string first = Console.ReadLine();
            string second = Console.ReadLine();
             
            string[] results = new string[] {};
            display(show(first)+" "+show(second));

            
            Console.ReadLine();
        }

        private static string show(string take)
        {
            char[] taken = take.ToCharArray();
            Array.Reverse(taken);
            return String.Concat(taken);
        }

        private static void display(string take)
        {
            Console.WriteLine(take);
        }
        
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine(value);
            Console.ReadLine();
            

            Random mynum = new Random();
            int rand = mynum.Next(1, 11); // means that it should be less than 10

            Console.WriteLine(rand);

            string jaa = string.Format("{0:P},{1:N},{2:(###) ###-####}", 0.123, 111111111, 1111111111);
            Console.WriteLine(jaa);
           

            StringBuilder mystring = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                mystring.Append(i + " ");
            }
            Console.WriteLine(mystring);

            
            DateTime mydate = DateTime.Parse("1/24/2017");
            Console.WriteLine(mydate.ToLongDateString());
            DateTime mybday = new DateTime(1995, 10, 28);
            Console.WriteLine(mybday.ToLongDateString());
            TimeSpan born = DateTime.Now.Subtract(mybday);
            Console.WriteLine(born.TotalDays);
            
            myclass one = new myclass();
            one.date = 28;
            one.MyProperty = "blah";
            Console.WriteLine("{0} {1}", one.date, one.MyProperty);
            
            myclass two;
            two = one;
            two.date = 24;
            two.MyProperty = "hahah";

            Console.WriteLine("{0} {1}", one.date, one.MyProperty);*/
            /*    string send = "writing to a file. haha excitng";
            


             WebClient client = new WebClient();
             string reply = client.DownloadString("http://www.gonnawatch.comli.com");
             Console.WriteLine(reply);
             File.WriteAllText(@"C:\learn\test.txt", reply);
             scrape van = new scrape();
             string wow = van.getcode("http://www.gonnawatch.comli.com");
            string wow2 = van.getcode("http://www.google.com", @"C:\learn\test.txt");
            Console.WriteLine(wow2);
           
            myclass one = new myclass();
            one.date = 28;
            one.MyProperty = "mmmmmmmmmmmmmm";

            myclass two = new myclass();
            two.date = 28;
            two.MyProperty = "mmmmmmmmmmmmmm";

            List<myclass> haa = new List<myclass>();
            haa.Add(one);
            haa.Add(two);

            List<myclass> hoo = new List<myclass>()
            {
                new myclass {date = 1, MyProperty="text1" },
                new myclass {date = 2, MyProperty="text2" },
                 new myclass {date = 3, MyProperty="text1" },
                new myclass {date = 4, MyProperty="text2" }
            };

            //link query way
            var find = from myclass in hoo
                       where myclass.date == 3
                       select myclass;
            //or

            //link method way
            var found = hoo.Where(p => p.date == 3 && p.MyProperty == "text1");

            myclass class1 = new myclass() { date = 26 }; // diectly initializing the elements , a substitute for constructors
            myclass class2 = new myclass() { date = 16 };

            foreach (myclass item in hoo)
            {
                Console.WriteLine(item.date);
            }

            hoo.ForEach(p => Console.WriteLine("{0} {1}", p.date, p.MyProperty));// printd all
           */
            // todo mine = new todo();

            /*  List<todo> dolist = new List<todo>()
              {
                 new todo( age = 21, desc="waiting",  )
              };
              */
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("asdb badcbaJH JHBajbcJBAJH");
            Console.SetWindowSize(50, 50);
            Console.ReadLine();

        }

        class myclass
        {
            public int date { get; set; }
            public string MyProperty { get; set; }

            public static void home()
            {
                Console.WriteLine("a static method called");
            }

        }
    }
    class todo
    {
        public int age { get; set; }
        public string desc { get; set; }

        public string status { get; set; }
    }
    enum woah
    {
        sleeping,
        playing,
        studying,
        eating
    }


}