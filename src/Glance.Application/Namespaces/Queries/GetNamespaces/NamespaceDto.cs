namespace Glance.Application.Namespaces.Queries.GetNamespaces;

public sealed class NamespaceDto
{
    public string? Name { get; set; }
    public IDictionary<string, string>? Labels { get; set; }
    public IDictionary<string, string>? Annotations { get; set; }
}
