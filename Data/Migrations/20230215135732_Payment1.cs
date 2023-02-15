using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Payment1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_students_studentId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_teachers_TeacherId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "payment");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_TeacherId",
                table: "payment",
                newName: "IX_payment_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_studentId",
                table: "payment",
                newName: "IX_payment_studentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payment",
                table: "payment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_payment_students_studentId",
                table: "payment",
                column: "studentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_teachers_TeacherId",
                table: "payment",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payment_students_studentId",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_teachers_TeacherId",
                table: "payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payment",
                table: "payment");

            migrationBuilder.RenameTable(
                name: "payment",
                newName: "Payment");

            migrationBuilder.RenameIndex(
                name: "IX_payment_TeacherId",
                table: "Payment",
                newName: "IX_Payment_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_payment_studentId",
                table: "Payment",
                newName: "IX_Payment_studentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_students_studentId",
                table: "Payment",
                column: "studentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_teachers_TeacherId",
                table: "Payment",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id");
        }
    }
}
