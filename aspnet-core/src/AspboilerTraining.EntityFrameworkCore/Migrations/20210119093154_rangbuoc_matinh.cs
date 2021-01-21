using Microsoft.EntityFrameworkCore.Migrations;

namespace AspboilerTraining.Migrations
{
    public partial class rangbuoc_matinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tentinh",
                table: "QuanHuyens");

            migrationBuilder.AddColumn<string>(
                name: "matinh",
                table: "QuanHuyens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuanHuyens_matinh",
                table: "QuanHuyens",
                column: "matinh");

            migrationBuilder.AddForeignKey(
                name: "FK_QuanHuyens_TinhThanhs_matinh",
                table: "QuanHuyens",
                column: "matinh",
                principalTable: "TinhThanhs",
                principalColumn: "matinh",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuanHuyens_TinhThanhs_matinh",
                table: "QuanHuyens");

            migrationBuilder.DropIndex(
                name: "IX_QuanHuyens_matinh",
                table: "QuanHuyens");

            migrationBuilder.DropColumn(
                name: "matinh",
                table: "QuanHuyens");

            migrationBuilder.AddColumn<string>(
                name: "tentinh",
                table: "QuanHuyens",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
