﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesCanada;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230921203013_Review656513636")]
    partial class Review656513636
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

                    b.Property<int>("relatedCuisinesid")
                        .HasColumnType("INTEGER");

                    b.HasKey("recommandedResturantsid", "relatedCuisinesid");

                    b.HasIndex("relatedCuisinesid");

                    b.ToTable("CuisineResturant");
                });

            modelBuilder.Entity("RazorPagesAccommodation.Models.Accommodation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Destinationid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("priceRange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("starRating")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Destinationid");

                    b.ToTable("Accommodations");
                });

            modelBuilder.Entity("RazorPagesCanada.Models.Resturant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CuisineType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("photoAddress")
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

                    b.Property<string>("activities")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

                    b.Property<string>("regions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("RazorPagesReview.Models.Review", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("resturantid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("review")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("resturantid");

                    b.ToTable("Reviews");
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
                        .HasForeignKey("relatedCuisinesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RazorPagesAccommodation.Models.Accommodation", b =>
                {
                    b.HasOne("RazorPagesDestination.Models.Destination", null)
                        .WithMany("accommodations")
                        .HasForeignKey("Destinationid");
                });

            modelBuilder.Entity("RazorPagesReview.Models.Review", b =>
                {
                    b.HasOne("RazorPagesCanada.Models.Resturant", "resturant")
                        .WithMany("reviews")
                        .HasForeignKey("resturantid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resturant");
                });

            modelBuilder.Entity("RazorPagesCanada.Models.Resturant", b =>
                {
                    b.Navigation("reviews");
                });

            modelBuilder.Entity("RazorPagesDestination.Models.Destination", b =>
                {
                    b.Navigation("accommodations");
                });
#pragma warning restore 612, 618
        }
    }
}
