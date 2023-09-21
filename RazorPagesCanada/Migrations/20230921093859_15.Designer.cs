﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesCanada;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230921093859_15")]
    partial class _15
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("CuisineResturant", b =>
                {
                    b.Property<int>("recommandedResturantsid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("relatedCuisisnesid")
                        .HasColumnType("INTEGER");

                    b.HasKey("recommandedResturantsid", "relatedCuisisnesid");

                    b.HasIndex("relatedCuisisnesid");

                    b.ToTable("CuisineResturant");
                });

            modelBuilder.Entity("RazorPagesCanada.Models.Resturant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Resturants");
                });

            modelBuilder.Entity("RazorPagesCuisine.Models.Cuisine", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("culturalSignificance")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("pictureAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("preparation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("RazorPagesDestination.Models.Destination", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("moreDetails")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("pictureAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("CuisineResturant", b =>
                {
                    b.HasOne("RazorPagesCanada.Models.Resturant", null)
                        .WithMany()
                        .HasForeignKey("recommandedResturantsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPagesCuisine.Models.Cuisine", null)
                        .WithMany()
                        .HasForeignKey("relatedCuisisnesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
