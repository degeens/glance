namespace Glance.Contracts.Namespace;

public sealed class GetNamespacesResponse
{
    public string? Name { get; set; }
    public IDictionary<string, string>? Labels { get; set; }
    public IDictionary<string, string>? Annotations { get; set; }
}
