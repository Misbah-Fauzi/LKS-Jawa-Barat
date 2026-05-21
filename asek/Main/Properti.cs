using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asek.Main
{
    public class Properti
    {
        public static string stringkenum(string str)
        {
            return decimal.Parse(str).ToString("N0", CultureInfo.CurrentCulture.NumberFormat);
        }
        public static string kodefaktur()
        {
           return "FTR" + DateTime.Now.ToString("yyyyMMddhhmmss");
        }
    }
}
