namespace Glance.Domain.Entities.Kubernetes.Common;

/// <summary>
/// See <see href="https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/object-meta/#ObjectMeta">Kubernetes Reference</see>.
/// </summary>
public sealed class ObjectMeta
{
    public string? Name { get; set; }
    public string? Namespace { get; set; }
    public IDictionary<string, string>? Labels { get; set; }
    public IDictionary<string, string>? Annotations { get; set; }
}