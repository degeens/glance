using Glance.Application.Namespaces.Queries.GetNamespaces;
using Glance.Contracts.Namespace;
using Mapster;

namespace Glance.Api.Common.Mapping;

public sealed class NamespaceMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<NamespaceDto, GetNamespacesResponse>();
    }
}
