

namespace Application.Queries
{
    using System.Threading.Tasks;
    using Domain;

    public class GetCurrentUserHandler
    {

        public async Task<User> Handle(GetCurrentUserQuery request)
        {
            return await Task.FromResult(new User { Username = request.Username, Email = "" });
        }
    }
}