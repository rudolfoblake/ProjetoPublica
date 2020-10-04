using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class CriacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaJogo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placar = table.Column<int>(nullable: false),
                    MinimoTemporada = table.Column<int>(nullable: false),
                    MaximoTemporada = table.Column<int>(nullable: false),
                    QuebraRecordeMinimo = table.Column<int>(nullable: false),
                    QuebraRecordeMaximo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaJogo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaJogo");
        }
    }
}
