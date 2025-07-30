using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;
using Transport.Models;

namespace Transport.Data
{
    public class TransportDbContext : DbContext
    {
        public TransportDbContext(DbContextOptions<TransportDbContext> options) : base(options) { }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<SubBranch> SubBranches { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Bilty> Bilties { get; set; }
        public DbSet<BiltyItem> BiltyItems { get; set; }
        public DbSet<Manifest> Manifests { get; set; }
        public DbSet<ManifestItem> ManifestItems { get; set; }
        public DbSet<MoneyReceipt> MoneyReceipts { get; set; }

    }

}
