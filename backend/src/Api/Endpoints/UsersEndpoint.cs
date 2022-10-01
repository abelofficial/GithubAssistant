using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.Core;
using Application.Contracts.Requests;
using Application.Queries;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Api.Endpoints;

public class UsersEndpoint : BaseEndpoint
{
    public UsersEndpoint(IMediator mediator, IMapper mapper) : base(mediator, mapper)
    { }

    [LambdaFunction()]
    [HttpApi(LambdaHttpMethod.Get, "/users")]
    public async Task<User> Get([FromBody] GetCurrentUserDto dto, ILambdaContext context)
    {
        var query = _mapper.Map<GetCurrentUserQuery>(dto);
        context.Logger.LogInformation($"Request {dto.Username} mapped to {query.Username}");
        return await _mediator.Send(query);
    }

}
