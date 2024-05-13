using I41I.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace I41I.Data
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\msaqllocaldb; 
                    Database=MdDatabase; Trusted_Connection=Turue");
        }
        */
    }
}
