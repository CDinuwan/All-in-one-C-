using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharp_Begining_to_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            //Variable
            int x;
            int y;
            int xy = 10;
            Console.WriteLine(xy);

            
            Console.ReadLine();

            Console.WriteLine("What is your fitst name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int val = 9;
            if(val==9)
            {
                Console.WriteLine(val);
            }
            else if(val==6)
            {
                Console.WriteLine(val - 3);
            }
            else
            {
                Console.WriteLine("Value Error");
            }
            

            //Expression made up with one or operators and operands
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            int[] numbers = new int[5];

            numbers[0] = 9;
            numbers[1] = 10;
            numbers[2] = 20;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            int[] number = new int[] { 4, 5, 8, 65 };
            string[] str = new string[] { "Chanuka", "Dinuwan" };

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            foreach(int items in number){
                Console.WriteLine(items);
            }

            string zig = "You can get what you want out of life if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (char zigchar in charArray)
            {
                Console.Write(zigchar);
            }

            //Methods

            HelloWorld();
            HelloWorld("Method overloading");
            refe();


            //While

            Random myRand = new Random();//Random number
            int ran = myRand.Next(1, 11);
            Console.WriteLine(ran);

            string myString = "Hello \"world\"";
            Console.WriteLine(myString);

            string str = "Hello \nnew Line";

            string stri = "I want to go C:\\ Drive";

            string stri = @"I want to go C:\ Drive";

            string stri = String.Format("{1} = {0}", "First", "Second");

            string stri = string.Format("{0:C}", 123.45);

            string stri = String.Format("{0:N}",12341546463413544);

            string stri = String.Format("{0:P}", 0.12);

            string stri = String.Format("{0:(###) ###-####}", 0767115744);*/

            //string stri = "It's cool for looking";
            //stri = stri.Substring(6, 10);
            //stri = stri.ToUpper();
            //stri = stri.Replace("t", "V");
            //stri = stri.Remove(2, 4);

            //string mstri = stri.Trim();
            //Console.WriteLine(stri.Length);
            //Console.WriteLine(mstri.Length);
            //Console.WriteLine(stri);

            //StringBuilder myString = new StringBuilder();
            //for (int i = 0; i < 100; i++)
            //{
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            //Console.WriteLine(myString);

            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddDays(3).ToString());
            //Console.WriteLine(myValue.AddHours(3).ToString());
            //Console.WriteLine(myValue.AddHours(-3).ToString());//Subtact Days

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthDay = new DateTime(1997, 11, 12);
            //Console.WriteLine(myBirthDay.ToShortDateString());

            //DateTime myBDay = DateTime.Parse("12/11/1997");
            //TimeSpan myAge = DateTime.Now.Subtract(myBDay);
            //Console.WriteLine(myAge.TotalDays);



        }

        /*
                private static void HelloWorld()
                {
                    Console.WriteLine("Hello World");
                    Console.WriteLine("Enter your name?");
                    string name = Console.ReadLine();

                    Console.WriteLine(name);
                }

                private static void HelloWorld(string val)
                {
                    Console.WriteLine(val);
                }


                private static void refe()
                {
                    string rev = ReverseString("Hello World");
                    Console.WriteLine(rev);
                }
                private static string ReverseString(string message)
                {
                    char[] Arr = message.ToCharArray();
                    Array.Reverse(Arr);
                    return String.Concat(Arr);
                }*/




    }
}
