using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class group5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jamolar_teachers_TeacherId",
                table: "jamolar");

            migrationBuilder.DropForeignKey(
                name: "FK_JamolarStudent_jamolar_groupsId",
                table: "JamolarStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jamolar",
                table: "jamolar");

            migrationBuilder.RenameTable(
                name: "jamolar",
                newName: "group");

            migrationBuilder.RenameIndex(
                name: "IX_jamolar_TeacherId",
                table: "group",
                newName: "IX_group_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_group",
                table: "group",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_group_teachers_TeacherId",
                table: "group",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JamolarStudent_group_groupsId",
                table: "JamolarStudent",
                column: "groupsId",
                principalTable: "group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_group_teachers_TeacherId",
                table: "group");

            migrationBuilder.DropForeignKey(
                name: "FK_JamolarStudent_group_groupsId",
                table: "JamolarStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_group",
                table: "group");

            migrationBuilder.RenameTable(
                name: "group",
                newName: "jamolar");

            migrationBuilder.RenameIndex(
                name: "IX_group_TeacherId",
                table: "jamolar",
                newName: "IX_jamolar_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jamolar",
                table: "jamolar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_jamolar_teachers_TeacherId",
                table: "jamolar",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JamolarStudent_jamolar_groupsId",
                table: "JamolarStudent",
                column: "groupsId",
                principalTable: "jamolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
