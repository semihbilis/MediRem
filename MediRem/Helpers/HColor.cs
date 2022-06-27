using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace MediRem.Helpers
{
    public class HColor
    {
        private readonly static PropertyInfo[] _colorInfos = typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public);

        public static Stack<string> ToStack()
        {
            Stack<string> resultColors = new Stack<string>();
            foreach (PropertyInfo item in _colorInfos)
                resultColors.Push(item.Name);
            return resultColors;
        }

        public static List<string> ToList()
        {
            List<string> resultColors = new List<string>();
            foreach (PropertyInfo item in _colorInfos)
                resultColors.Add(item.Name);
            return resultColors;
        }
    }
}
