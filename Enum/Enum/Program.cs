using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class ToDo
    {
        public string Description { get; set; }
        public int EstimateHours { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted

    } 
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> todos = new List<ToDo>()
            {
                new ToDo{Description="Task1",EstimateHours=4,Status=Status.Completed},
                new ToDo{Description="Task2",EstimateHours=9,Status=Status.Deleted},
                new ToDo{Description="Task3",EstimateHours=6,Status=Status.InProgress},
                new ToDo{Description="Task4",EstimateHours=5,Status=Status.NotStarted},
                new ToDo{Description="Task5",EstimateHours=7,Status=Status.OnHold},
                new ToDo{Description="Task6",EstimateHours=2,Status=Status.Completed}
            };
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintAssessment(todos);
            Console.ReadLine();
        }
        public static void PrintAssessment(List<ToDo> todos)
        {
            foreach (var todo in todos)
            {
                switch(todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                }
            }
        }
    }
}
