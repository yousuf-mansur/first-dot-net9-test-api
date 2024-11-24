using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstDotNet9TestApi.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Improved support for Kubernetes, managed database services, and streamlined deployment.", "Cloud-Native Development" },
                    { 2, "Integration with OpenAI and OSS models for AI-powered applications.", "Intelligent App Development" },
                    { 3, "Enhanced tooling in Visual Studio and improved diagnostics for developers.", "Productivity Enhancements" },
                    { 4, "Runtime optimizations and robust security measures, including new cryptographic APIs.", "Performance and Security" },
                    { 5, "New TimeSpan.From* overloads to address floating-point precision issues.", "TimeSpan Precision Fix" },
                    { 6, "Improved handling of certificates for cross-platform compatibility.", "X.509 Certificate Improvements" },
                    { 7, "Support for modern cryptographic key management and virtualization-based security on Windows.", "OpenSSL and CNG Updates" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
