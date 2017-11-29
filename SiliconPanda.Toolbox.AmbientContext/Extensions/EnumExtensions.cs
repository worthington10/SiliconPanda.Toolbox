using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SiliconPanda.Toolbox.AmbientContext.Extensions
{
    public static class EnumExtensions
    {
        public static string Description(this Enum value)
        {
            return !(value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .SingleOrDefault() is DisplayAttribute attribute) ? value.ToString() : attribute.Description;
        }
    }
}
