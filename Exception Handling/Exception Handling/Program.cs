using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string content = File.ReadAllText(@"D:\writeText.txt");
            //    Console.WriteLine(content);
            //}
            //catch(DirectoryNotFoundException er)
            //{
            //    Console.WriteLine(er.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Closing the Application");
            //}

            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();
            Console.WriteLine("Press enter to remove red one");

            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed {0:HH:MM:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed {0:HH:MM:ss.fff}",e.SignalTime);
        }
    }
}
