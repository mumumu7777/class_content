using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystemDemo.extensiontool
{
    public static class stringExtension
  {
    	public static int Toint(this string source, int defaultvalue)
    	{
    		bool isint = int.TryParse(source, out int number);
    		return isint ? number : defaultvalue;
    	}
    }

}