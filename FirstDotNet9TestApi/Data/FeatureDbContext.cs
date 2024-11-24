using FirstDotNet9TestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstDotNet9TestApi.Data
{
    public class FeatureDbContext:DbContext
    {
        public FeatureDbContext(DbContextOptions<FeatureDbContext>options):base(options)
        {
            
        }

        public virtual DbSet<Feature> Features => Set<Feature>();//for best practice

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Feature>().HasData(
                 new Feature { Id = 1, Name = "Cloud-Native Development", Description = "Improved support for Kubernetes, managed database services, and streamlined deployment." },
            new Feature { Id = 2, Name = "Intelligent App Development", Description = "Integration with OpenAI and OSS models for AI-powered applications." },
            new Feature { Id = 3, Name = "Productivity Enhancements", Description = "Enhanced tooling in Visual Studio and improved diagnostics for developers." },
            new Feature { Id = 4, Name = "Performance and Security", Description = "Runtime optimizations and robust security measures, including new cryptographic APIs." },
            new Feature { Id = 5, Name = "TimeSpan Precision Fix", Description = "New TimeSpan.From* overloads to address floating-point precision issues." },
            new Feature { Id = 6, Name = "X.509 Certificate Improvements", Description = "Improved handling of certificates for cross-platform compatibility." },
            new Feature { Id = 7, Name = "OpenSSL and CNG Updates", Description = "Support for modern cryptographic key management and virtualization-based security on Windows." }

                );
        }
    }
}
