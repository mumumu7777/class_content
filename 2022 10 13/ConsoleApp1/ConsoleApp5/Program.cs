using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string = null , string.empty , 

            string value1= null;
            string value3= string.Empty;
            string value2= "";
            string value4= "     ";


            bool isNull = (value1 == null ); // true
            bool isNull2 = (value2 == null); //false

            isNull = string.IsNullOrEmpty( value1 ) ;
            isNull = string.IsNullOrEmpty ( value2 ) ;

           // null, 空字串,連續空白，都傳true

            bool isnull4 = string.IsNullOrEmpty(value4);

            //字串內雙引號  " abc  use\ and \\

            string mama = "abc \\\" qq ";


            string qq = "\\ adad \"";
            Console.WriteLine( qq );














        }
    }
}
