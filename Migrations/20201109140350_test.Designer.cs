﻿// <auto-generated />
using System;
using MPPIS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MPPIS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201109140350_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("MPPIS.Domain.Entities.DayPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValue(0m)
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("DayPrice");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("district");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("street");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Village")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("vilage");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Lviv",
                            District = "Mostisky",
                            HouseNumber = "53",
                            Street = "Sagaydachnogo",
                            UserId = 1,
                            Village = "Tvirzha"
                        },
                        new
                        {
                            Id = 2,
                            City = "Lviv",
                            District = "Mostisky",
                            HouseNumber = "53",
                            Street = "Sagaydachnogo",
                            UserId = 2,
                            Village = "Tvirzha"
                        });
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.RouteDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("route");

                    b.HasKey("Id");

                    b.ToTable("RouteDay");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.StorageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<decimal>("CountProduction")
                        .HasColumnType("decimal")
                        .HasColumnName("count_production");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("date_added")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("DayPriceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DayPriceId");

                    b.HasIndex("UserId");

                    b.ToTable("StorageData");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("firstname");

                    b.Property<bool>("IsEmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("is_email_confirmed");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("lastname");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("middlename");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("passwordhash");

                    b.Property<DateTime>("RegisteredDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("registered_date")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@gmail.com",
                            FirstName = "Tester",
                            IsEmailConfirmed = false,
                            LastName = "Testerovich",
                            MiddleName = "Test",
                            PasswordHash = "AQAAAAEAACcQAAAAEIbcLzNrkH71ioIV78ORrt+rAHZMhNjusmitvNthkkZBaeAH4Ckt83lOUxMosjgUoA==",
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            IsEmailConfirmed = false,
                            LastName = "Adminovich",
                            MiddleName = "Adminovski",
                            PasswordHash = "AQAAAAEAACcQAAAAEO+c05wGToAZiXQBi/A/tvOuOzcY5yrEy8JFouicbSBpIdbCVQcV2QRcErOPJCf0/Q==",
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.Location", b =>
                {
                    b.HasOne("MPPIS.Domain.Entities.User", "User")
                        .WithOne("Location")
                        .HasForeignKey("MPPIS.Domain.Entities.Location", "UserId")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.StorageData", b =>
                {
                    b.HasOne("MPPIS.Domain.Entities.DayPrice", "DayPrice")
                        .WithMany("StorageData")
                        .HasForeignKey("DayPriceId")
                        .IsRequired();

                    b.HasOne("MPPIS.Domain.Entities.User", "User")
                        .WithMany("StorageData")
                        .HasForeignKey("UserId")
                        .IsRequired();

                    b.Navigation("DayPrice");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.User", b =>
                {
                    b.HasOne("MPPIS.Domain.Entities.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.DayPrice", b =>
                {
                    b.Navigation("StorageData");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("MPPIS.Domain.Entities.User", b =>
                {
                    b.Navigation("Location");

                    b.Navigation("StorageData");
                });
#pragma warning restore 612, 618
        }
    }
}
