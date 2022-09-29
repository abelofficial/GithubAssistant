using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.Core;
using Domain;

namespace Api
{
    /// <summary>
    /// A collection of sample Lambda functions that provide a REST api for doing simple math calculations. 
    /// </summary>
    public class Users : BaseEndpoint
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Users()
        {
        }
        /// <summary>
        /// Perform x + y
        ///
        /// PackageType is currently required to be set to LambdaPackageType.Image till the upcoming .NET 6 managed
        /// runtime is available. Once the .NET 6 managed runtime is available PackageType will be optional and will
        /// default to Zip.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Sum of x and y.</returns>
        [LambdaFunction()]
        [HttpApi(LambdaHttpMethod.Get, "/{username}")]
        public User Get(string username, ILambdaContext context)
        {
            context.Logger.LogInformation($"Request for username  {username}");
            return new User { Username = username, Email = "" };
        }

    }
}
