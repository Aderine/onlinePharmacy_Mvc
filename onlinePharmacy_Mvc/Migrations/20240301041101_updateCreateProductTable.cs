using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace onlinePharmacy_Mvc.Migrations
{
    /// <inheritdoc />
    public partial class updateCreateProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: new Guid("601a78b1-0bf9-411a-b9fa-682e599a60c8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: new Guid("fbb5821f-0dae-4afc-81c6-053d4d3ead9d"));

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductID", "Brand", "ImageUrl", "Price", "ProductCategory", "ProductDescription", "ProductName", "QuantityInStock", "SpecialTag" },
                values: new object[,]
                {
                    { new Guid("8a6708d3-882a-4b86-9601-7454c0c62990"), "Opella Healthcare", "https://firebasestorage.googleapis.com/v0/b/aspdotnet-c24e2.appspot.com/o/onlinePharmacy%2Ftelfast-180mg-tablet-10s-strip.jpg?alt=media&token=3991f954-4063-4910-a221-490b2a0656fe", 17.989999999999998, "Medicine", "This medicine is for oral use only. Swallow this medication as a whole with water. Do not chew, crush or break it. It is better to take this medication at a fixed time each day if it is indicated for everyday use. Take one tablet of Telfast 180mg once a day, with a glass of water.", "Telfast 180mg Tablet 10s (strip)", 22, null },
                    { new Guid("f895cd06-3580-4b93-9ab8-cee21ec4b23e"), "Blackmores", "https://firebasestorage.googleapis.com/v0/b/aspdotnet-c24e2.appspot.com/o/onlinePharmacy%2FBlackmores%20Grape%20Seed%20Forte%2012000%20Tablet%2030s.jpg?alt=media&token=3a6899ec-dca2-45c8-9b54-a5a5ae32ed93", 95.5, "Supplement", "Blackmores Grape Seed Forte is a natural antioxidant that helps protect bodily cells from free radical damage. It contains a high concentration of flavonoids, which help prevent skin elastin from degradation and promote collagen health and development.", "Blackmores Grape Seed Forte 12000 Tablet 30s", 16, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: new Guid("8a6708d3-882a-4b86-9601-7454c0c62990"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: new Guid("f895cd06-3580-4b93-9ab8-cee21ec4b23e"));

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductID", "Brand", "ImageUrl", "Price", "ProductCategory", "ProductDescription", "ProductName", "QuantityInStock", "SpecialTag" },
                values: new object[,]
                {
                    { new Guid("601a78b1-0bf9-411a-b9fa-682e599a60c8"), "Opella Healthcare", "https://firebasestorage.googleapis.com/v0/b/aspdotnet-c24e2.appspot.com/o/onlinePharmacy%2Ftelfast-180mg-tablet-10s-strip.jpg?alt=media&token=3991f954-4063-4910-a221-490b2a0656fe", 17.989999999999998, "Medicine", "This medicine is for oral use only. Swallow this medication as a whole with water. Do not chew, crush or break it. It is better to take this medication at a fixed time each day if it is indicated for everyday use. Take one tablet of Telfast 180mg once a day, with a glass of water.", "Telfast 180mg Tablet 10s (strip)", 22, null },
                    { new Guid("fbb5821f-0dae-4afc-81c6-053d4d3ead9d"), "Blackmores", "https://firebasestorage.googleapis.com/v0/b/aspdotnet-c24e2.appspot.com/o/onlinePharmacy%2FBlackmores%20Grape%20Seed%20Forte%2012000%20Tablet%2030s.jpg?alt=media&token=3a6899ec-dca2-45c8-9b54-a5a5ae32ed93", 95.5, "Supplement", "Blackmores Grape Seed Forte is a natural antioxidant that helps protect bodily cells from free radical damage. It contains a high concentration of flavonoids, which help prevent skin elastin from degradation and promote collagen health and development.", "Blackmores Grape Seed Forte 12000 Tablet 30s", 16, null }
                });
        }
    }
}
