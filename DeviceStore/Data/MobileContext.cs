using DeviceStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeviceStore.Data
{
    public class MobileContext:IdentityDbContext<ApplicationUser>
    {
        public MobileContext(DbContextOptions<MobileContext> options):base(options)
        {

        }
        public DbSet<Mobile> Mobiles { get; set; }
    }
}
