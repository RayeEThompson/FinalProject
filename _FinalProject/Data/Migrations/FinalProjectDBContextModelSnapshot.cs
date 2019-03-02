﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _FinalProject.Data.Context;

namespace Data.Migrations
{
    [DbContext(typeof(FinalProjectDBContext))]
    partial class FinalProjectDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_FinalProject.Model.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<int?>("LetterId");

                    b.Property<int>("PostId");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LetterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Letter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClosedDate");

                    b.Property<int>("CommentId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("PostId");

                    b.Property<int>("RobinId");

                    b.Property<int>("SubmissionId");

                    b.Property<DateTime>("SubmittedDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Letters");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latutude");

                    b.Property<double>("Longitute");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<int?>("LetterId");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LetterId");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Robin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("DisableDate");

                    b.Property<string>("InviteCode");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Robins");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.SubmissionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LetterId");

                    b.Property<string>("SubmissionState");

                    b.HasKey("Id");

                    b.HasIndex("LetterId");

                    b.ToTable("SubmissionStatuses");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageURL");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.UsersByRobin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersByRobins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "66ccd4ec-e6ca-4c9f-86e4-24f08a7f3c62", ConcurrencyStamp = "1ef3ff21-1ed0-4672-99d5-609e00b1e094", Name = "GeneralUser", NormalizedName = "GENERALUSER" },
                        new { Id = "989f9d1a-cd0c-45e8-9c69-98366bf68de2", ConcurrencyStamp = "4d59f3ef-91d6-4d02-9774-6b3b45809636", Name = "RobinAdmin", NormalizedName = "ROBINADMIN" },
                        new { Id = "5f41c5c6-d7af-4317-8884-1b340bc8d73e", ConcurrencyStamp = "cc00506d-6ce0-4552-8b48-c4ca4c0bf315", Name = "SuperAdmin", NormalizedName = "SUPERADMIN" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Model.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Attending");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EventComment");

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.Property<int>("eventId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Calendar", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Comment", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Letter")
                        .WithMany("Comments")
                        .HasForeignKey("LetterId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Letter", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany("Letters")
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Map", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Post", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Letter")
                        .WithMany("Posts")
                        .HasForeignKey("LetterId");

                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Robin", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.User")
                        .WithMany("Robins")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.SubmissionStatus", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Letter")
                        .WithMany("SubmissionStatuses")
                        .HasForeignKey("LetterId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.UsersByRobin", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Models.Event", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
