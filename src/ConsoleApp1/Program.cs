using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var something = Console.ReadLine();
            //Console.WriteLine(something);
            //Console.ReadLine();

            var rand = new Random;
            Console.WriteLine(rand.Next(10));
            Console.ReadLine();
        }
    }
}