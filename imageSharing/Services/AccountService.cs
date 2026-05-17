using imageSharing.Entities;
using Microsoft.EntityFrameworkCore;

namespace imageSharing.Services
{
    public class AccountService(ImagesharingContext ctx)
    {
        public async Task<bool> CheckIfAccountExist(string email, string nickname)
        {
            bool check = await ctx.Users.AnyAsync(u => u.Email == email || u.Nickname == nickname);
            if (check) return true;
            else return false;
        }
        public async Task<User?> FindUser(string email)
        {
            User? user = await ctx.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user is null) return null;
            else return user;
        }
    }
}
