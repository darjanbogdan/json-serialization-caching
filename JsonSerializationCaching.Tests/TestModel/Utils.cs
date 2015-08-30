using System;
using System.Globalization;
using System.Text;

namespace JsonSerializationCaching.Tests.TestModel
{
    public static class Utils
    {
        public static string GetRandomString(int maxLength = 40)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int length = random.Next(maxLength);
            for (int i = 0; i < length; i++)
            {
                builder.Append((char)random.Next('a', 'z' + 1));
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(builder.ToString());
        }

        public static int GetRandomNumber(int maxValue)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(maxValue);
        }

        public static T GetRandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random(new Guid().GetHashCode()).Next(v.Length));
        }

        public static DateTime GetRandomDate()
        {
            DateTime toDate = DateTime.UtcNow;
            DateTime fromDate = toDate.AddMonths(-1);
            var range = toDate - fromDate;
            var randTimeSpan = new TimeSpan((long)(new Random(new Guid().GetHashCode())).NextDouble() * range.Ticks);
            return fromDate + randTimeSpan;
        }
    }
}
