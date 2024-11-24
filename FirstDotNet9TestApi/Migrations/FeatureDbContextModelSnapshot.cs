﻿// <auto-generated />
using FirstDotNet9TestApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstDotNet9TestApi.Migrations
{
    [DbContext(typeof(FeatureDbContext))]
    partial class FeatureDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstDotNet9TestApi.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Improved support for Kubernetes, managed database services, and streamlined deployment.",
                            Name = "Cloud-Native Development"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Integration with OpenAI and OSS models for AI-powered applications.",
                            Name = "Intelligent App Development"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Enhanced tooling in Visual Studio and improved diagnostics for developers.",
                            Name = "Productivity Enhancements"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Runtime optimizations and robust security measures, including new cryptographic APIs.",
                            Name = "Performance and Security"
                        },
                        new
                        {
                            Id = 5,
                            Description = "New TimeSpan.From* overloads to address floating-point precision issues.",
                            Name = "TimeSpan Precision Fix"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Improved handling of certificates for cross-platform compatibility.",
                            Name = "X.509 Certificate Improvements"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Support for modern cryptographic key management and virtualization-based security on Windows.",
                            Name = "OpenSSL and CNG Updates"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
