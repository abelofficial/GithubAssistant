using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.Core;
using Application.Queries;
using Domain;

namespace Api
{
    public class Users : BaseEndpoint
    {

        [LambdaFunction()]
        [HttpApi(LambdaHttpMethod.Get, "/users")]
        public async Task<User> Get([FromBody] GetCurrentUserQuery request, ILambdaContext context)
        {
            context.Logger.LogInformation($"Request for username  {request.Username}");
            return await new GetCurrentUserHandler().Handle(request);
        }

    }
}
