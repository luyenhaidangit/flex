using MediatR;
using System.Reflection;

namespace Flex.Common.Extensions
{
    public static class MessageExtension
    {
        public static T FormatTrimUpperProperties<T>(this T obj) where T : IRequest
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var stringProperties = obj.GetType()
                                      .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(p => p.PropertyType == typeof(string) && p.CanRead && p.CanWrite);

            foreach (var property in stringProperties)
            {
                var value = (string)property.GetValue(obj);
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Trim().ToUpper();
                    property.SetValue(obj, value);
                }
            }

            return obj;
        }
    }
}
