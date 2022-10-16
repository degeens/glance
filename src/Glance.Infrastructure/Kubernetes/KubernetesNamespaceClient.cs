using Glance.Application.Common.Interfaces;
using Glance.Domain.Entities.Kubernetes;
using Glance.Domain.Entities.Kubernetes.Common;
using k8s;
using k8s.Models;

namespace Glance.Infrastructure.Kubernetes;

internal sealed class KubernetesNamespaceClient : KubernetesClient, IKubernetesNamespaceClient
{
    public async Task<IEnumerable<Namespace>> GetNamespaces(CancellationToken cancellationToken)
    {
        var namespaces = await Kubernetes.ListNamespaceAsync(cancellationToken: cancellationToken);

        return namespaces.Items.Select(Map);
    }

    private static Namespace Map(V1Namespace @namespace)
        => new()
        {
            ApiVersion = @namespace.ApiVersion,
            Kind = @namespace.Kind,
            Metadata = new ObjectMeta
            {
                Name = @namespace.Metadata.Name,
                Namespace = @namespace.Metadata.Namespace(),
                Labels = @namespace.Metadata.Labels,
                Annotations = @namespace.Metadata.Annotations,
            },
        };
}
