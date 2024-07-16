using System.ComponentModel;
using System.Reflection;

namespace Flex.Common.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static int GetNumericValue(this Enum value)
        {
            return Convert.ToInt32(value);
        }
    }
}
