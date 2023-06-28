using System.Runtime.InteropServices;

namespace Atena.Domain.Core.Extensions
{
    public static class DateTimeExtension
    {
        const string C_TIME_ZONE_BY_ID_WINDOWS = "E. South America Standard Time";
        const string C_TIME_ZONE_BY_ID_GENERIC = "America/Sao_Paulo";
        public static DateTime ToBrasilianTimezone(this DateTime dateTime)
        {
            TimeZoneInfo targetTimeZone;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(C_TIME_ZONE_BY_ID_WINDOWS);
            } 
            else
            {
                targetTimeZone = TimeZoneInfo.FindSystemTimeZoneById(C_TIME_ZONE_BY_ID_GENERIC);
            }

            var targetDateTime = TimeZoneInfo.ConvertTime(dateTime, targetTimeZone);

            return targetDateTime;
        }
    }
}
