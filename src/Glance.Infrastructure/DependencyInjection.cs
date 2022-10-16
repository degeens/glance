using Glance.Application.Common.Interfaces;
using Glance.Infrastructure.Kubernetes;
using Microsoft.Extensions.DependencyInjection;

namespace Glance.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IKubernetesNamespaceClient, KubernetesNamespaceClient>();

        return services;
    }
}
