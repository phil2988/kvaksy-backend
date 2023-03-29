﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kvaksy_backend.Data;

#nullable disable

namespace kvaksy_backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kvaksy_backend.models.ImageUrl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReportSessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportSessionId");

                    b.ToTable("ImageUrl");
                });

            modelBuilder.Entity("kvaksy_backend.models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Field1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("kvaksy_backend.models.ReportSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<Guid>("ReportId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.ToTable("ReportSessions");
                });

            modelBuilder.Entity("kvaksy_backend.models.ImageUrl", b =>
                {
                    b.HasOne("kvaksy_backend.models.ReportSession", null)
                        .WithMany("ImageUrls")
                        .HasForeignKey("ReportSessionId");
                });

            modelBuilder.Entity("kvaksy_backend.models.ReportSession", b =>
                {
                    b.HasOne("kvaksy_backend.models.Report", "Report")
                        .WithMany()
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Report");
                });

            modelBuilder.Entity("kvaksy_backend.models.ReportSession", b =>
                {
                    b.Navigation("ImageUrls");
                });
#pragma warning restore 612, 618
        }
    }
}
