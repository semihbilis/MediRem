using System;
using System.Collections.Generic;
using System.Text;

namespace MediRem.Extensions
{
    public static class ExtArray
    {
        public static List<string> ToList(this string[] array)
        {
            List<string> result = new List<string>();
            result.AddRange(array);
            return result;
        }

        public static Stack<string> ToStack(this string[] array)
        {
            Stack<string> result = new Stack<string>();
            foreach (string item in array)
            {
                result.Push(item);
            }
            return result;
        }
    }
}
