using Microsoft.EntityFrameworkCore.Migrations;

namespace AspboilerTraining.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuanHuyens",
                columns: table => new
                {
                    mahuyen = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    tenhuyen = table.Column<string>(nullable: true),
                    ghichu = table.Column<string>(nullable: true),
                    tentinh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHuyens", x => x.mahuyen);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanhs",
                columns: table => new
                {
                    matinh = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    tentinh = table.Column<string>(nullable: true),
                    ghichu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanhs", x => x.matinh);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuanHuyens");

            migrationBuilder.DropTable(
                name: "TinhThanhs");
        }
    }
}
