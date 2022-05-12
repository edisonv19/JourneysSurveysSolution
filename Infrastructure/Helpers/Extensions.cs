﻿using System.Runtime.CompilerServices;

namespace Infrastructure.Helpers
{
    public static class Extensions
    {
        public static string? NameOf(this object o)
        {
            return o.GetType().Name;
        }

        public static string? GetMethodName(this object o, [CallerMemberName] string? memberName = null)
        {
            return memberName;
        }

        public static double? GetDouble(this object value)
        {
            return double.TryParse(value.ToString(), out double lat_o) ? (double?)lat_o : null;
        }

        public static string? GetString(this object value)
        {
            return value?.ToString();
        }

        public static int? GetInt(this object value)
        {
            return int.TryParse(value.ToString(), out int lat_o) ? (int?)lat_o : null;
        }

        public static TimeSpan? GetTimeSpan(this object value)
        {
            try
            {
                return TimeSpan.FromDays((double)value);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DateTime? GetDateTime(this object value)
        {
            return DateTime.TryParse(value.ToString(), out DateTime lat_o) ? (DateTime?)lat_o : null;
        }
    }
}
