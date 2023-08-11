using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions<TransferDbContext> options) : base(options) { }


        public DbSet<TransferLog> TransferLogs { get; set; }
    }

    public class TransferDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=Transfer;User Id=SA;Password=YourStrong@Passw0rd;TrustServerCertificate=True;");

            return new TransferDbContext(optionsBuilder.Options);
        }
    }
}
