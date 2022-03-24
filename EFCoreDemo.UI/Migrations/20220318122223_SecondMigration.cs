using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo.UI.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblDotnetFellows_States_StateId",
                table: "tblDotnetFellows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "tblStates");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "tblDotnetFellows",
                type: "int",
                nullable: false,
                defaultValue: 3,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblStates",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStates",
                table: "tblStates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblDotnetFellows_tblStates_StateId",
                table: "tblDotnetFellows",
                column: "StateId",
                principalTable: "tblStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblDotnetFellows_tblStates_StateId",
                table: "tblDotnetFellows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStates",
                table: "tblStates");

            migrationBuilder.RenameTable(
                name: "tblStates",
                newName: "States");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "tblDotnetFellows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "States",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblDotnetFellows_States_StateId",
                table: "tblDotnetFellows",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
