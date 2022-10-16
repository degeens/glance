using k8s;

namespace Glance.Infrastructure.Kubernetes;

internal abstract class KubernetesClient
{
    protected k8s.Kubernetes Kubernetes { get; } = new(KubernetesClientConfiguration.BuildConfigFromConfigFile());
}
