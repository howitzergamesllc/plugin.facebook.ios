
using Foundation;
using System.Globalization;

namespace LoginMauiSample;

[Preserve(AllMembers = true)]
internal static class DataExtensions
{
    internal static DateTimeOffset ToDateTimeOffset(this NSDate date)
    {
        var reference = new DateTimeOffset(2001, 1, 1, 0, 0, 0, TimeSpan.Zero);

        return reference.AddSeconds(date.SecondsSinceReferenceDate);
    }
    
    internal static NSDate? ToNSDate(this DateTimeOffset? dateTimeOffset)
    {
        if (dateTimeOffset is null)
            return null;

        return NSDate.FromTimeIntervalSince1970(dateTimeOffset.Value.ToUnixTimeSeconds());
    }

    internal static TimeSpan ToTimeSpanFromSeconds(this nuint seconds)
    {
        return TimeSpan.FromSeconds(seconds);
    }
}