using System;

namespace MediRem.Models.CustomAttributes
{
    public class CAEnumToString : Attribute
    {
        private readonly string _value;

        public CAEnumToString(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }
    }
}
