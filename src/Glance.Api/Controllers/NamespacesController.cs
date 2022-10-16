using Glance.Application.Namespaces.Queries.GetNamespaces;
using Glance.Contracts.Namespace;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Glance.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class NamespacesController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public NamespacesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<GetNamespacesResponse>> GetNamespaces(CancellationToken cancellationToken)
    {
        var namespaces = await _mediator.Send(new GetNamespacesQuery(), cancellationToken);

        return namespaces.Select(n => _mapper.Map<GetNamespacesResponse>(n));
    }
}
