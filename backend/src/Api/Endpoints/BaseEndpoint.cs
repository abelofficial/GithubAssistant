using Amazon.Lambda.Core;
using Api.Config;
using AutoMapper;
using MediatR;

[assembly: LambdaSerializer(typeof(CustomJsonSerializer))]
namespace Api.Endpoints;

public abstract class BaseEndpoint
{
    protected readonly IMediator _mediator;
    protected readonly IMapper _mapper;

    public BaseEndpoint(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
}