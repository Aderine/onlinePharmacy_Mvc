using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onlinePharmacy_Mvc.Migrations
{
    /// <inheritdoc />
    public partial class seedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductID", "Brand", "ImageUrl", "Price", "ProductCategory", "ProductDescription", "ProductName", "QuantityInStock", "SpecialTag" },
                values: new object[] { new Guid("15fa9514-c105-4ae3-b1b8-316114242d4e"), "Opella Healthcare", "https://firebasestorage.googleapis.com/v0/b/aspdotnet-c24e2.appspot.com/o/onlinePharmacy%2Ftelfast-180mg-tablet-10s-strip.jpg?alt=media&token=3991f954-4063-4910-a221-490b2a0656fe", 17.989999999999998, "Medicine", "This medicine is for oral use only. Swallow this medication as a whole with water. Do not chew, crush or break it. It is better to take this medication at a fixed time each day if it is indicated for everyday use. Take one tablet of Telfast 180mg once a day, with a glass of water.", "Telfast 180mg Tablet 10s (strip)", 22, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: new Guid("15fa9514-c105-4ae3-b1b8-316114242d4e"));
        }
    }
}
