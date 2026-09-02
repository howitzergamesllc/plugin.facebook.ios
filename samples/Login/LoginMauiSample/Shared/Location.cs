namespace LoginMauiSample;

/// <inheritdoc />
public sealed class Location : ILocation
{
    /// <inheritdoc />
    public string? Id { get; }

    /// <inheritdoc />
    public string? Name { get; }

    internal Location(string? id, string? name)
    {
        Id = id;
        Name = name;
    }
    
    internal static Location? FromDictionary(IReadOnlyDictionary<string, string> dictionary)
    {
        if (dictionary == null)
            return null;

        if (!dictionary.TryGetValue("id", out var id) ||
            !dictionary.TryGetValue("name", out var name))
        {
            return null;
        }

        return new Location(id, name);
    }

    /// <inheritdoc />
    public string DebugDescription() => $"Id={Id}, Name={Name}";
}