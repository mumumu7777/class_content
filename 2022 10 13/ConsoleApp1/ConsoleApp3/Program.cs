using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please input your age:");
            string input = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("what's your age?" + input);


            //Console.WriteLine("email");

            //Console.ReadKey();

            int age = Convert.ToInt32(input);

           int after5years = age+5;
            Console.WriteLine("您五年後的年紀是"+ after5years+"歲");



            




        }
    }
}
