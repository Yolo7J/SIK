using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedRealEstateOwnership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RealEstatesOwnerships",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "RealEstatesOwnerships");
        }
    }
}
