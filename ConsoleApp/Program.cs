using System.IO.Pipes;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Введення даних
            Console.WriteLine("Input of number`s player");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                //значення нашої зміної (number)
                case 4:
                    Console.WriteLine("Jordan");
                    break;
                case 6:
                    Console.WriteLine("Duncan");
                    break;
                case 8:
                    Console.WriteLine("Carry");
                    break;
                case 10:
                    Console.WriteLine("Lebron");
                    break;
                case 2:
                    Console.WriteLine("O’Neal");
                    break;
                default:
                    Console.WriteLine("Uknown PLAYER");
                    break;
            }
            
        }
    }
}
