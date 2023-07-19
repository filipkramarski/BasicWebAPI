using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationshipsRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Country_CountryId",
                table: "Contact");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Country_CountryId",
                table: "Contact",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Country_CountryId",
                table: "Contact");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Country_CountryId",
                table: "Contact",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
