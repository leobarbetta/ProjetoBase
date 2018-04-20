using System;
using System.ComponentModel;
using System.Reflection;

namespace ProjetoBase.Extensions.Common
{
    public static class EnumExtensions
    {
        public static string DisplayDescription(this Enum value)
        {
            if (value == null)
                return null;

            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
