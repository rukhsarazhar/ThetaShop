using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ThetaShop.Data
{
    public class theta2023dbContext : IdentityDbContext
    {
        public theta2023dbContext(DbContextOptions<theta2023dbContext> options)
            : base(options)
        {
        }

        public object Purchases { get; internal set; }
    }
}