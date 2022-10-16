using MediatR;

namespace Glance.Application.Namespaces.Queries.GetNamespaces;

public sealed class GetNamespacesQuery : IRequest<IEnumerable<NamespaceDto>>
{

}
