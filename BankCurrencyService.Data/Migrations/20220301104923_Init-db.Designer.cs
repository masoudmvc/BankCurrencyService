// <auto-generated />
using System;
using BankCurrencyService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankCurrencyService.Data.Migrations
{
    [DbContext(typeof(BankCurrencyDbContext))]
    [Migration("20220301104923_Init-db")]
    partial class Initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("BCS")
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BankCurrencyService.Domain.Entities.Audit.Audit", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Action")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creator")
                        .HasMaxLength(301)
                        .HasColumnType("nvarchar(301)");

                    b.Property<Guid?>("CreatorKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatorUserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EntityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdater")
                        .HasMaxLength(301)
                        .HasColumnType("nvarchar(301)");

                    b.Property<Guid?>("LastUpdaterKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastUpdaterUserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("Audit", "BCS");
                });
#pragma warning restore 612, 618
        }
    }
}
