using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 8+8;
            int number2 = 8-28;
            int number3 = (2+3)*2+5+6*2 ;
//餘數

            int number4 = 10%5;

            // += , -= , *= , /=
            number2+=2; // 等於 number1 = bumber 1+2  = 18
            number1 *=3; // 48

          

            // ++

            number1 = 10;
            number1++; //等於number1+1

            number1 = 10;
            number2 = number1++; // number2 = 10 


            number1 = 10;

            number2 = ++number1; //

            Console.WriteLine(number1);







        }
    }
}
