using Glance.Domain.Entities.Kubernetes;

namespace Glance.Application.Common.Interfaces;

public interface IKubernetesNamespaceClient
{
    Task<IEnumerable<Namespace>> GetNamespaces(CancellationToken cancellationToken);
}
