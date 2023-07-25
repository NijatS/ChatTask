using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexts
{
    public class ChatDbContext:IdentityDbContext<AppUser>
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> option):base(option)
        {
        }
    }
}
