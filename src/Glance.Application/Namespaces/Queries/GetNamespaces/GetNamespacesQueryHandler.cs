using Glance.Application.Common.Interfaces;
using Glance.Domain.Entities.Kubernetes;
using MediatR;

namespace Glance.Application.Namespaces.Queries.GetNamespaces;

internal sealed class GetNamespacesQueryHandler : IRequestHandler<GetNamespacesQuery, IEnumerable<NamespaceDto>>
{
    private readonly IKubernetesNamespaceClient _kubernetesNamespaceClient;

    public GetNamespacesQueryHandler(IKubernetesNamespaceClient kubernetesNamespaceClient)
    {
        _kubernetesNamespaceClient = kubernetesNamespaceClient;
    }

    public async Task<IEnumerable<NamespaceDto>> Handle(GetNamespacesQuery request, CancellationToken cancellationToken)
    {
        var namespaces = await _kubernetesNamespaceClient.GetNamespaces(cancellationToken);

        return namespaces.Select(Map);
    }

    private static NamespaceDto Map(Namespace @namespace)
        => new()
        {
            Name = @namespace.Metadata?.Name,
            Labels = @namespace.Metadata?.Labels,
            Annotations = @namespace.Metadata?.Annotations,
        };
}
