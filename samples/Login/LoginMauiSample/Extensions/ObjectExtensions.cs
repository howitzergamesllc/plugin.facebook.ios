
using Foundation;

namespace LoginMauiSample;

[Preserve(AllMembers = true)]
internal static class ObjectExtensions
{
    public static Dictionary<string, object?> ToDictionary(this NSDictionary dictionary)
    {
        var result = new Dictionary<string, object?>();

        foreach (var key in dictionary.Keys)
        {
            if (key is NSString nsKey)
            {
                result[nsKey.ToString()] = ConvertNSObject(dictionary.ObjectForKey(key));
            }
        }

        return result;
    }

    private static object? ConvertNSObject(NSObject? value)
    {
        switch (value)
        {
            case null:
                return null;

            case NSNull:
                return null;

            case NSString s:
                return s.ToString();

            case NSNumber n:
                return n;

            case NSDictionary dict:
                return dict.ToDictionary();

            case NSArray array:
            {
                var list = new List<object?>();

                foreach (NSObject item in array)
                    list.Add(ConvertNSObject(item));

                return list;
            }

            default:
                return value;
        }
    }
    
    internal static Uri? ToUri(this NSUrl? url)
    {
        if(url is null || String.IsNullOrEmpty(url.AbsoluteString))
            return null;

        return new Uri(url.AbsoluteString);
    }
}