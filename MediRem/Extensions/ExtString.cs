using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediRem.Extensions
{
    public static class ExtString
    {
        public static string RemoveFirstChar(this string source, char character)
        {
            int number = source.IndexOf(character);
            return source.Remove(number, 1);
        }
    }
}
