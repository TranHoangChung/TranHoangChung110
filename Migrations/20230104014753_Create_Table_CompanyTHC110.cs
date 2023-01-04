using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranHoangChung110.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableCompanyTHC110 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyTHC110",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTHC110", x => x.CompanyID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyTHC110");
        }
    }
}
