
namespace LoginMauiSample;

/// <inheritdoc />
public sealed class AgeRange : IAgeRange
{
    /// <inheritdoc />
    public int? Min { get; }
    
    /// <inheritdoc />
    public int? Max { get; }

    internal AgeRange(int? min, int? max)
    {
        if (min.HasValue && min.Value < 0) 
            return;

        if (max.HasValue && max.Value < 0) 
            return;

        if (min.HasValue && max.HasValue && min > max) 
            return;

        Min = min;
        Max = max;
    }

    internal static AgeRange? FromDictionary(IReadOnlyDictionary<string, int> dictionary)
    {
        if (dictionary == null)
            return null;

        dictionary.TryGetValue("min", out var minValue);
        dictionary.TryGetValue("max", out var maxValue);

        int? min = dictionary.ContainsKey("min") ? minValue : null;
        int? max = dictionary.ContainsKey("max") ? maxValue : null;

        if (!min.HasValue && !max.HasValue)
            return null;

        return new AgeRange(min, max);
    }

    /// <inheritdoc />
    public string DebugDescription() => $"Min={Min}, Max={Max}";
}