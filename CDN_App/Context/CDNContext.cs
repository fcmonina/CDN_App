using CDN_App.Models;
using Microsoft.EntityFrameworkCore;
namespace CDN_App.Context
{
    public class CDNContext : DbContext
    {
        public CDNContext(DbContextOptions<CDNContext> options) : base(options)
        {
        }
        public DbSet<UserInfos> Users { get; set; }
    }
}
