namespace System
{
    internal static class TimeSpanExtension
    {
        public static double TotalYears(this TimeSpan thisObj)
        {
            return thisObj.TotalDays / 365;
        }
    }
}
