
using Foundation;
using System.Collections;
using UIKit;

namespace ShareMauiSample;

[Preserve(AllMembers = true)]
internal static class ObjectExtensions
{        
    public static NSDictionary<NSString, NSObject> ToNSDictionaryFromNonGeneric(this IReadOnlyDictionary<string, object> dictionary)
    {
        if(dictionary.Count > 0) {
            var nsDictionary = new NSMutableDictionary<NSString, NSObject>();

            foreach(var entry in dictionary) {
                PutIntoNSDictionary(new KeyValuePair<string, object>(entry.Key.ToString(), entry.Value), ref nsDictionary);
            }
            return NSDictionary<NSString, NSObject>.FromObjectsAndKeys(
                nsDictionary.Values.ToArray(),
                nsDictionary.Keys.ToArray(),
                (nint) nsDictionary.Count);
        } else {
            return new NSDictionary<NSString, NSObject>();
        }
    }

    public static NSDictionary<NSString, NSObject> ToNSDictionaryFromNonGeneric(this IDictionary dictionary)
    {
        if(dictionary.Count > 0) {
            var nsDictionary = new NSMutableDictionary<NSString, NSObject>();

            foreach(DictionaryEntry entry in dictionary) {
                PutIntoNSDictionary(new KeyValuePair<string, object>(entry.Key.ToString(), entry.Value), ref nsDictionary);
            }
            return NSDictionary<NSString, NSObject>.FromObjectsAndKeys(
                nsDictionary.Values.ToArray(),
                nsDictionary.Keys.ToArray(),
                (nint) nsDictionary.Count);
        } else {
            return new NSDictionary<NSString, NSObject>();
        }
    }

    private static void PutIntoNSDictionary(KeyValuePair<string, object> pair, ref NSMutableDictionary<NSString, NSObject> nsDictionary)
    {
        switch(pair.Value) {
            case bool x:
                nsDictionary.Add((NSString) pair.Key, new NSNumber(x));
                break;
            case double x:
                nsDictionary.Add((NSString) pair.Key, new NSNumber(x));
                break;
            case float x:
                nsDictionary.Add((NSString) pair.Key, new NSNumber(x));
                break;
            case long x:
                nsDictionary.Add((NSString) pair.Key, new NSNumber(x));
                break;
            case int x:
                nsDictionary.Add((NSString) pair.Key, new NSNumber(x));
                break;
            case short x:
                nsDictionary.Add((NSString) pair.Key, new NSNumber(x));
                break;
            case string x:
                nsDictionary.Add((NSString) pair.Key, new NSString(x));
                break;
            case NSObject x:
                nsDictionary.Add((NSString) pair.Key, x);
                break;
            default:
                if(pair.Value is Enum @enum) {
                    nsDictionary.Add((NSString) pair.Key, new NSNumber(Convert.ToInt64(@enum)));
                    break;
                } else if(pair.Value == null) {
                    nsDictionary.Add((NSString) pair.Key, new NSNull());
                    break;
                } else {
                    throw new ArgumentException($"Couldn't put object of type {pair.Value.GetType()} into NSDictionary");
                }
        }
    }

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

    public static byte[]? ToBytes(this UIImage image)
    {
        using var data = image.AsPNG();

        return data?.ToArray();
    }

    public static byte[]? ToShareData(this NSData? data)
    {
        return data?.ToArray();
    }
}