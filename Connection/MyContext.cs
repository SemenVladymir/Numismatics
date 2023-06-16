using Microsoft.EntityFrameworkCore;
using Numismatics.Models;


namespace Numismatics.Connection
{
    internal class MyContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public DbSet<Blogging> Blogs { get; set; }

        public DbSet<Trading> Tradings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MV43C0T;Database=Numismatics;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}