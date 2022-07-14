﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPV2.Data;

namespace TPV2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220112154811_AddUniqueScoreClient2")]
    partial class AddUniqueScoreClient2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TPV2.Models.AplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TPV2.Models.Properties", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FuncionarioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProprietarioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("PropertyId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("TPV2.Models.PropertiesImages", b =>
                {
                    b.Property<int>("PropImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PropertyID")
                        .HasColumnType("int");

                    b.HasKey("PropImageId");

                    b.HasIndex("PropertyID");

                    b.ToTable("PropertiesImages");
                });

            modelBuilder.Entity("TPV2.Models.PropertyCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("PropertyCategories");
                });

            modelBuilder.Entity("TPV2.Models.ReserveStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("StatusId");

                    b.ToTable("ReserveStatus");
                });

            modelBuilder.Entity("TPV2.Models.Reserves", b =>
                {
                    b.Property<int>("ReserveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("ReserveId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("StatusId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("TPV2.Models.ScoreClient", b =>
                {
                    b.Property<int>("ScoreClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FuncionarioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProprietarioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ReserveId")
                        .HasColumnType("int");

                    b.Property<int>("ScoreFuncionário")
                        .HasColumnType("int");

                    b.Property<int>("ScorePropriedade")
                        .HasColumnType("int");

                    b.Property<int>("ScoreProprietario")
                        .HasColumnType("int");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("ScoreClientId");

                    b.HasIndex("ClientId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProprietarioId");

                    b.HasIndex("ReserveId")
                        .IsUnique()
                        .HasFilter("[ReserveId] IS NOT NULL");

                    b.ToTable("ScoreClient");
                });

            modelBuilder.Entity("TPV2.Models.ScoreGestor", b =>
                {
                    b.Property<int>("ScoreGestorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("GestorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ReserveId")
                        .HasColumnType("int");

                    b.Property<int>("ScoreClient")
                        .HasColumnType("int");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("ScoreGestorId");

                    b.HasIndex("ClientId");

                    b.HasIndex("GestorId");

                    b.HasIndex("ReserveId");

                    b.ToTable("ScoreGestor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TPV2.Models.AplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TPV2.Models.AplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPV2.Models.AplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TPV2.Models.AplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPV2.Models.Properties", b =>
                {
                    b.HasOne("TPV2.Models.PropertyCategories", "CProperty")
                        .WithMany("Properties")
                        .HasForeignKey("CategoryId");

                    b.HasOne("TPV2.Models.AplicationUser", "PFuncionarioID")
                        .WithMany("PropertiesFuncionario")
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("TPV2.Models.AplicationUser", "PProprietarioID")
                        .WithMany("PropertiesUsers")
                        .HasForeignKey("ProprietarioId");

                    b.Navigation("CProperty");

                    b.Navigation("PFuncionarioID");

                    b.Navigation("PProprietarioID");
                });

            modelBuilder.Entity("TPV2.Models.PropertiesImages", b =>
                {
                    b.HasOne("TPV2.Models.Properties", "PropertyImage")
                        .WithMany("PropertyImag")
                        .HasForeignKey("PropertyID");

                    b.Navigation("PropertyImage");
                });

            modelBuilder.Entity("TPV2.Models.Reserves", b =>
                {
                    b.HasOne("TPV2.Models.AplicationUser", "RClientIdReserve")
                        .WithMany("ReservesUsers")
                        .HasForeignKey("ClientId");

                    b.HasOne("TPV2.Models.Properties", "Property")
                        .WithMany("Reserves")
                        .HasForeignKey("PropertyId");

                    b.HasOne("TPV2.Models.ReserveStatus", "Status")
                        .WithMany("Reserves")
                        .HasForeignKey("StatusId");

                    b.Navigation("Property");

                    b.Navigation("RClientIdReserve");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TPV2.Models.ScoreClient", b =>
                {
                    b.HasOne("TPV2.Models.AplicationUser", "SCClientID")
                        .WithMany("ScoreClientUserID")
                        .HasForeignKey("ClientId");

                    b.HasOne("TPV2.Models.AplicationUser", "SCFuncionarioID")
                        .WithMany("ScoreClientFuncionarioID")
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("TPV2.Models.AplicationUser", "SCProprietarioID")
                        .WithMany("ScoreClientProprietarioID")
                        .HasForeignKey("ProprietarioId");

                    b.HasOne("TPV2.Models.Reserves", "Reserves")
                        .WithMany("ScoreClient")
                        .HasForeignKey("ReserveId");

                    b.Navigation("Reserves");

                    b.Navigation("SCClientID");

                    b.Navigation("SCFuncionarioID");

                    b.Navigation("SCProprietarioID");
                });

            modelBuilder.Entity("TPV2.Models.ScoreGestor", b =>
                {
                    b.HasOne("TPV2.Models.AplicationUser", "SGUserID")
                        .WithMany("ScoreGestorUserID")
                        .HasForeignKey("ClientId");

                    b.HasOne("TPV2.Models.AplicationUser", "SGGestorID")
                        .WithMany("ScoreGestorGestorID")
                        .HasForeignKey("GestorId");

                    b.HasOne("TPV2.Models.Reserves", "Reserves")
                        .WithMany("ScoreGestor")
                        .HasForeignKey("ReserveId");

                    b.Navigation("Reserves");

                    b.Navigation("SGGestorID");

                    b.Navigation("SGUserID");
                });

            modelBuilder.Entity("TPV2.Models.AplicationUser", b =>
                {
                    b.Navigation("PropertiesFuncionario");

                    b.Navigation("PropertiesUsers");

                    b.Navigation("ReservesUsers");

                    b.Navigation("ScoreClientFuncionarioID");

                    b.Navigation("ScoreClientProprietarioID");

                    b.Navigation("ScoreClientUserID");

                    b.Navigation("ScoreGestorGestorID");

                    b.Navigation("ScoreGestorUserID");
                });

            modelBuilder.Entity("TPV2.Models.Properties", b =>
                {
                    b.Navigation("PropertyImag");

                    b.Navigation("Reserves");
                });

            modelBuilder.Entity("TPV2.Models.PropertyCategories", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("TPV2.Models.ReserveStatus", b =>
                {
                    b.Navigation("Reserves");
                });

            modelBuilder.Entity("TPV2.Models.Reserves", b =>
                {
                    b.Navigation("ScoreClient");

                    b.Navigation("ScoreGestor");
                });
#pragma warning restore 612, 618
        }
    }
}
