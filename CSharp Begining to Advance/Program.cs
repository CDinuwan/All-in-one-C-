using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Begining_to_Advance
{
    class Car
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        //public int Year { get; set; }
        //public string Color { get; set; }

        //public Car()
        //{
        //    this.Make = "Nissan";
        //}
        //public Car(string Model,string Make,int Year,string Color)
        //{
        //    this.Model = Model;
        //    this.Make = Make;
        //    this.Year = Year;
        //    this.Color = Color;
        //}
        //public static void StaticClass()
        //{
        //    Console.WriteLine("Call the static method");
        //}
    }
    class Book
    {
        public string bookTitle { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        //double time = 5.52;
        //private static decimal DetermineValue(Car car)
        //{
        //    decimal carValue = 100.0M;
        //    return carValue;
        //}
        //private static string k="Method";
        //static void Helper()
        //{
        //    Console.WriteLine(k + "Helper");
        //}
        static void Main(string[] args)
        {

            //WebClient client = new WebClient();
            //string reply = client.DownloadString("http://www.google.com");

            //Console.WriteLine(reply);
            //File.WriteAllText(@"D:\writeText.txt", reply);
            //Helper();
            //string j = "Num is ";//global variable
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(j+i);//local variable
            //}
            //Console.WriteLine(k);
            //Car.StaticClass();
            //Car myCar = new Car("Toyota", "OldModel", 2000, "Red");
            //Console.WriteLine(myCar.Year);

            //Car myCar = new Car();
            //myCar.Vin = "AI";
            //myCar.Make = "Honda";

            //Dictionary<string,Car>myDictionary=new Dictionary<string, Car>();
            //myDictionary.Add(myCar.Vin, myCar);

            //Console.WriteLine(myDictionary["AI"].Make);

            //Car car1 = new Car()
            //{
            //    Make = "BMW",
            //    Model = "Honda",
            //    Vin = "C3"
            //};

            //List<Car> myList = new List<Car>()
            //{
            //    new Car{Make="oldModel",Model="Honda",Vin="Es"},
            //    new Car{Make="Nissan",Model="Saloon",Vin="Ess"}
            //};

            //var Nissan = from car in myList
            //             where car.Make == "Nissan"
            //             && car.Vin== "Ess"
            //             select car;

            //foreach (var car in Nissan)
            //{
            //    Console.WriteLine("{0} {1}",car.Make, car.Model, car.Vin);
            //}

            //var oldmodel = myList.Where(p => p.Make == "oldModel");
            //foreach (var item in oldmodel)
            //{
            //    Console.WriteLine("{0} {1}", item.Make, item.Model, item.Vin);
            //}

            //var FirstCar = myList.First(p => p.Make == "oldModel");
            //Console.WriteLine(FirstCar.Vin);

            //List<Car> myList = new List<Car>();
            //myList.Add(myCar);
            //foreach (Car mycar in myList)
            //{
            //    Console.WriteLine(myCar.Model);
            //}

            //Book b1 = new Book();
            //b1.bookTitle = "Harry Potter";
            //b1.Author = "Lianado";

            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(myCar);
            //myArrayList.Add(b1);
            //myArrayList.Remove(b1);

            //foreach (Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Make);
            //}
            //myCar.Year = 2020; 
            //myCar.Color = "Brown";

            //Car myOtherCar = null;
            //myOtherCar.Model = "98";//Change value also myCar

            //Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            /*Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            decimal Val = DetermineValue(myCar);
            Console.WriteLine("{0:C}",Val);

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
