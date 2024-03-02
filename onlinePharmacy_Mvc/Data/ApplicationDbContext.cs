using Microsoft.EntityFrameworkCore;
using onlinePharmacy_Mvc.Models;

namespace onlinePharmacy_Mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> products { get; set; }

    }
}
