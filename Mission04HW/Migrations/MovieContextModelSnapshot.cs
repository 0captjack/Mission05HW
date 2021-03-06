// <auto-generated />
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

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

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

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            CategoryId = 5,
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
                            CategoryId = 3,
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
                            CategoryId = 4,
                            Director = "Steven Spielberg",
                            Edited = false,
                            Lent_To = "",
                            Notes = "Paved the way for so many great films",
                            Rating = "PG",
                            Title = "Jaws",
                            Year = "1975"
                        });
                });

            modelBuilder.Entity("Mission04HW.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Crime"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Undefined"
                        });
                });

            modelBuilder.Entity("Mission04HW.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission04HW.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
