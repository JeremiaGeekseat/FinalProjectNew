using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FinalProject.DomainData;

namespace FinalProject.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20170607030423_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.DomainData.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("FinalProject.DomainData.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Message");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("FinalProject.DomainData.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<int>("MovieId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("FinalProject.DomainData.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BackgroundUrl");

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("Released")
                        .HasColumnType("date");

                    b.Property<string>("ThumbnailUrl");

                    b.Property<string>("Title");

                    b.Property<int>("Viewed");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("FinalProject.DomainData.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<int>("MovieId");

                    b.Property<int>("Rate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("FinalProject.DomainData.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActivated");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FinalProject.DomainData.Contact", b =>
                {
                    b.HasOne("FinalProject.DomainData.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FinalProject.DomainData.Favorite", b =>
                {
                    b.HasOne("FinalProject.DomainData.Movie", "Movie")
                        .WithMany("Favorites")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.DomainData.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.DomainData.Movie", b =>
                {
                    b.HasOne("FinalProject.DomainData.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("FinalProject.DomainData.Review", b =>
                {
                    b.HasOne("FinalProject.DomainData.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.DomainData.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
