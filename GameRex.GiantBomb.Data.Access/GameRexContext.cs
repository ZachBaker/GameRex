using GameRex.GiantBomb.Data.Access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GameRex.GiantBomb.Data.Access
{
    public class GameRexContext : DbContext
    {
        public GameRexContext(DbContextOptions<GameRexContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Game> Games { get; set; }
        
        public DbSet<Platform> Platforms { get; set; }

        public DbSet<UserReview> UserReviews { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GameRexContext>
    {
        public GameRexContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<GameRexContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new GameRexContext(builder.Options);
        }
    }
}