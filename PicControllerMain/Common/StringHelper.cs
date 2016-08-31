using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicControllerMain.Common
{
    public static class StringHelper
    {
        public static int ToInt(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            int result = 0;
            if (int.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        public static Decimal ToDecimal(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            decimal result = 0;
            if (decimal.TryParse(str, out result))
            {
                return result;
            }
            else {
                return 0;
            }
        }

        public static DateTime ToDateTime(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return DateTime.MinValue;
            }
            DateTime result = DateTime.Now;
            if (DateTime.TryParse(str, out result))
            {
                return result;
            }
            else {
                return DateTime.MinValue;
            }
        }
    }
}
