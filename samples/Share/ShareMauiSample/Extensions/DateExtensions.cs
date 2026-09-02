
using Foundation;
using System.Globalization;

namespace ShareMauiSample;

[Preserve(AllMembers = true)]
internal static class DataExtensions
{        
    internal static decimal ToDecimal(this NSDecimalNumber number)
    {
        if (number == null) return new decimal(0);
        return decimal.Parse(number.StringValue, CultureInfo.InvariantCulture);
    }

    internal static DateTime ToDateTime(this NSDate date)
    {
        if(date == null)
            return DateTime.MinValue;
        
        var reference = new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        return reference.AddSeconds(date.SecondsSinceReferenceDate);
    }
}