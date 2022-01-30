﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission04HW.Models;

namespace Mission04HW.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission04HW.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Category = "Sci-Fi",
                            Director = "Danny Boyle",
                            Edited = false,
                            Lent_To = "",
                            Notes = "This movie is incredible",
                            Rating = "R",
                            Title = "Sunshine",
                            Year = "2007"
                        },
                        new
                        {
                            ApplicationId = 2,
                            Category = "Drama",
                            Director = "Denis Villeneuve",
                            Edited = false,
                            Lent_To = "",
                            Notes = "Excellent",
                            Rating = "R",
                            Title = "Prisoners",
                            Year = "2013"
                        },
                        new
                        {
                            ApplicationId = 3,
                            Category = "Thriller",
                            Director = "Steven Spielberg",
                            Edited = false,
                            Lent_To = "",
                            Notes = "Paved the way for so many great films",
                            Rating = "PG",
                            Title = "Jaws",
                            Year = "1975"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
