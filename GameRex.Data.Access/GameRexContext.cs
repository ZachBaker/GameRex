﻿using GameRex.Data.Access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GameRex.Data.Access
{
    public class GameRexContext : DbContext
    {
        public GameRexContext(DbContextOptions<GameRexContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Platform> Platforms { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GameRexContext>
    {
        public GameRexContext CreateDbContext(string[] args)
        {
            var  configuration = new ConfigurationBuilder()
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