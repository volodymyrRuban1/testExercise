using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactProj.Data.Migrations
{
    public partial class changednamegenerationtry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Incident",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "NEWID()",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Incident",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "NEWID()");
        }
    }
}
