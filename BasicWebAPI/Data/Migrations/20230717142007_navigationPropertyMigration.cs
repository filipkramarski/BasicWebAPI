using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class navigationPropertyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_CompanyId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CountryId",
                table: "Contact");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CompanyId",
                table: "Contact",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CountryId",
                table: "Contact",
                column: "CountryId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_CompanyId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CountryId",
                table: "Contact");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CompanyId",
                table: "Contact",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CountryId",
                table: "Contact",
                column: "CountryId");
        }
    }
}
