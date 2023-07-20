using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassRoomBackDomain.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewFieldToSubjectClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassCode",
                table: "Classes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassCode",
                table: "Classes");
        }
    }
}
