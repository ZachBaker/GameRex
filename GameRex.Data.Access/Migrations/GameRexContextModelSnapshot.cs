﻿// <auto-generated />
using System;
using GameRex.Data.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace GameRex.Data.Access.Migrations
{
    [DbContext(typeof(GameRexContext))]
    partial class GameRexContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameRex.Data.Access.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name");

                    b.Property<string>("SiteDetailUrl");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("GameRex.Data.Access.Entities.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Deck");

                    b.Property<string>("Description");

                    b.Property<string>("ExternalId");

                    b.Property<int>("InstallBase");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("SiteDetailIUrl");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("GameRex.Data.Access.Entities.Platform", b =>
                {
                    b.HasOne("GameRex.Data.Access.Entities.Company", "Company")
                        .WithMany("Platforms")
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
