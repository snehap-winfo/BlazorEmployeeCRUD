using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEmployeeCRUD.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Employee",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employee");
        }
    }
}
