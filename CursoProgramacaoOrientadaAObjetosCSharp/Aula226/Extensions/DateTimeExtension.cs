using System;
using System.Globalization;

namespace System
{
    internal static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan timeSpan = DateTime.Now.Subtract(thisObj);
            if (timeSpan.TotalHours < 24.0) return $"{timeSpan.TotalHours.ToString("f1", CultureInfo.InvariantCulture)} hours";
            else if (timeSpan.TotalDays < 365) return $"{timeSpan.TotalDays.ToString("f1", CultureInfo.InvariantCulture)} days";
            else return $"{timeSpan.TotalYears().ToString("f1", CultureInfo.InvariantCulture)} years";
        }
    }
}
