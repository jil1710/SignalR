using Microsoft.EntityFrameworkCore;
using SignalR_POC.Data;
using SignalR_POC.Models;

namespace SignalR_POC.Repos
{
    public class UserRepo
    {
        private readonly ApplicationDBContext dbContext;   

        public UserRepo(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TblUser> GetUserDetails(string username, string password)
        {
            return await dbContext.TblUser.FirstOrDefaultAsync(user => user.Username == username && user.Password == password);
        }
    }
}
