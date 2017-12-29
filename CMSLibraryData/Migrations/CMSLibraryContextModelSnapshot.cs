﻿// <auto-generated />
using CMSLibraryData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace CMSLibraryData.Migrations
{
    [DbContext(typeof(CMSLibraryContext))]
    partial class CMSLibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMSLibraryData.DBModels.BranchHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BranchId");

                    b.Property<int>("CloseTime");

                    b.Property<int>("DayOfWeek");

                    b.Property<int>("OpenTime");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchHours");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LibraryAssetId");

                    b.Property<int?>("LibraryCardId");

                    b.Property<DateTime>("Since");

                    b.Property<DateTime>("Until");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Checkout");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.CheckoutHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CheckedIn");

                    b.Property<DateTime>("CheckedOut");

                    b.Property<int>("LibraryAssetId");

                    b.Property<int>("LibraryCardId");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("CheckoutHistory");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.CMSLibraryAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Index")
                        .IsRequired();

                    b.Property<int?>("LocationId");

                    b.Property<int>("NumberOfCopies");

                    b.Property<DateTime?>("PublishDate")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("StatusId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("StatusId");

                    b.ToTable("CMSLibraryAsset");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CMSLibraryAsset");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.CMSLibraryBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("OpenDate");

                    b.Property<string>("Telephone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CMSLibraryBranch");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.CMSLibraryCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<decimal>("Fees");

                    b.HasKey("Id");

                    b.ToTable("CMSLibraryCard");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Hold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("HoldPlaced");

                    b.Property<int?>("LibraryAssetId");

                    b.Property<int?>("LibraryCardId");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Hold");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Gender");

                    b.Property<int?>("HomeLibraryBranchId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("LibraryCardId");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("HomeLibraryBranchId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Book", b =>
                {
                    b.HasBaseType("CMSLibraryData.DBModels.CMSLibraryAsset");

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("ISBN")
                        .IsRequired();

                    b.ToTable("Book");

                    b.HasDiscriminator().HasValue("Book");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Magazine", b =>
                {
                    b.HasBaseType("CMSLibraryData.DBModels.CMSLibraryAsset");

                    b.Property<string>("Agency")
                        .IsRequired();

                    b.ToTable("Magazine");

                    b.HasDiscriminator().HasValue("Magazine");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.NewsPaper", b =>
                {
                    b.HasBaseType("CMSLibraryData.DBModels.CMSLibraryAsset");

                    b.Property<string>("Publisher")
                        .IsRequired();

                    b.ToTable("NewsPaper");

                    b.HasDiscriminator().HasValue("NewsPaper");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Video", b =>
                {
                    b.HasBaseType("CMSLibraryData.DBModels.CMSLibraryAsset");

                    b.Property<string>("Director")
                        .IsRequired();

                    b.ToTable("Video");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.BranchHours", b =>
                {
                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryBranch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Checkout", b =>
                {
                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryCard", "LibraryCard")
                        .WithMany("Checkouts")
                        .HasForeignKey("LibraryCardId");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.CheckoutHistory", b =>
                {
                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.CMSLibraryAsset", b =>
                {
                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryBranch", "Location")
                        .WithMany("LibraryAssets")
                        .HasForeignKey("LocationId");

                    b.HasOne("CMSLibraryData.DBModels.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Hold", b =>
                {
                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId");

                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");
                });

            modelBuilder.Entity("CMSLibraryData.DBModels.Subscriber", b =>
                {
                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryBranch", "HomeLibraryBranch")
                        .WithMany("Subscriber")
                        .HasForeignKey("HomeLibraryBranchId");

                    b.HasOne("CMSLibraryData.DBModels.CMSLibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
