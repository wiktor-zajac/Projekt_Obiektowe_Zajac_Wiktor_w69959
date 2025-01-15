using Microsoft.EntityFrameworkCore;
using WebAPI.Generic.Repositories;
using WebAPI.Users.Models;

namespace WebAPI.Users.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(WebAPIContext context) : base(context)
        {
        }
    }
}
