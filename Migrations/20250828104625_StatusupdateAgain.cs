using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEmployeeCRUD.Migrations
{
    /// <inheritdoc />
    public partial class StatusupdateAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER SEQUENCE \"Employee_Id_seq\" RESTART WITH 100;");
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
