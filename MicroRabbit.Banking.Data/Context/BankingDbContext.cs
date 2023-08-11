using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Account> Accounts { get; set; }

    }

    public class BankingDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=banking;User Id=SA;Password=YourStrong@Passw0rd;TrustServerCertificate=True;");

            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}
