using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteMES.Helpers
{
    public class Helper
    {
        public static int TryParseInt(string input, int defaultValue = 0)
        {
            return int.TryParse(input, out int result) ? result : defaultValue;
        }
        public static DateTime TryParseDateTime(string input, DateTime defaultValue = default)
        {
            return DateTime.TryParse(input, out DateTime result) ? result : defaultValue;
        }
    }
}
