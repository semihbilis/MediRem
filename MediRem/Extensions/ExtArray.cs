using System;
using System.Collections.Generic;
using System.Text;

namespace MediRem.Extensions
{
    public static class extArray
    {
        public static List<string> ToList(this string[] array)
        {
            List<string> result = new List<string>();
            result.AddRange(array);
            return result;
        }
    }
}
