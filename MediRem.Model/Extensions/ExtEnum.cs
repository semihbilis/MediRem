using MediRem.Models.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MediRem.Models.Extensions
{
    public static class ExtEnum
    {
        public static string EnumToDisplayName(this Enum tEnum)
        {
            CAEnumToString caEnumToString = tEnum.GetType().GetField(tEnum.ToString()).GetCustomAttribute<CAEnumToString>(false);
            if (!String.IsNullOrEmpty(caEnumToString.Value))
                return caEnumToString.Value.ToString();
            return String.Empty;
        }
    }
}
