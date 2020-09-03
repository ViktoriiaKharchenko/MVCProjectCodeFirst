using Microsoft.EntityFrameworkCore;
using InsuranceDatabase;

namespace InsuranceDatabase
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext() { }
                

        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            
            //Database.Migrate();
        }
        public DbSet<Brokers> Brokers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<BrokersCategories> BrokersCategories { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Documents> Documents { get; set; }
        


    }
}