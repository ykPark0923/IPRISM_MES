using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteMES.Helpers
{
    public class TryParseHelper
    {
        public static int TryParseInt(string input, int defaultValue = 0)
        {
            //return int.TryParse(input, out int result) ? result : defaultValue;

            //
            bool result = int.TryParse(input, out int value);

            if(result == true)
            {
                return value;
            }
            else
            {
                MessageBox.Show("정수로 치환할수 없는 값입니다.");
                return -1;
            }
        }

        public static DateTime TryParseDateTime(string input, DateTime defaultValue = default)
        {
            //return DateTime.TryParse(input, out DateTime result) ? result : defaultValue;

            bool result = DateTime.TryParse(input, out DateTime value);

            if (result == true)
            {
                return value;
            }
            else
            {
                MessageBox.Show("날짜로 치환할수 없는 값입니다.");
                return default;
            }
        }
    }
}
