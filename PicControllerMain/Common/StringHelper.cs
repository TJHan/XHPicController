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
    }
}
