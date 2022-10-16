using Glance.Domain.Entities.Kubernetes.Common;

namespace Glance.Domain.Entities.Kubernetes;

/// <summary>
/// See <see href="https://kubernetes.io/docs/reference/kubernetes-api/cluster-resources/namespace-v1/">Kubernetes Reference</see>.
/// </summary>
public sealed class Namespace
{
    public string? ApiVersion { get; set; }
    public string? Kind { get; set; }
    public ObjectMeta? Metadata { get; set; }
}
