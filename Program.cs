using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a value:");
            number = int.Parse(Console.ReadLine());

            switch(number){
                
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
                default:
                    Console.WriteLine("The number is nothing! (Because I live in a binary world)");
                    break;
            }

            Console.WriteLine("Do you enjoy C# ? (yes/no/maybe)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {

                case "yes":
                case "maybe":
                    Console.WriteLine("Alright!");
                    break;
                case "no":
                    Console.WriteLine("pfft,w/e");
                    break;
                default:
                    Console.WriteLine("This might be a personal failing, but I didn't understand you");
                    break;
            }

            Console.ReadLine();
        }
    }
}
