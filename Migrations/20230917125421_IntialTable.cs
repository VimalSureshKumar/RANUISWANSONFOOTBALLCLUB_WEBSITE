using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Migrations
{
    /// <inheritdoc />
    public partial class IntialTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Transaction_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transaction_Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Transaction_ID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Player_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionsTransaction_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Player_ID);
                    table.ForeignKey(
                        name: "FK_Players_Transactions_TransactionsTransaction_ID",
                        column: x => x.TransactionsTransaction_ID,
                        principalTable: "Transactions",
                        principalColumn: "Transaction_ID");
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Coaches_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coach_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach_Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayersPlayer_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Coaches_ID);
                    table.ForeignKey(
                        name: "FK_Coaches_Players_PlayersPlayer_ID",
                        column: x => x.PlayersPlayer_ID,
                        principalTable: "Players",
                        principalColumn: "Player_ID");
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Positions_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position_Name = table.Column<int>(type: "int", nullable: false),
                    PlayersPlayer_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Positions_ID);
                    table.ForeignKey(
                        name: "FK_Positions_Players_PlayersPlayer_ID",
                        column: x => x.PlayersPlayer_ID,
                        principalTable: "Players",
                        principalColumn: "Player_ID");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Team_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayersPlayer_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Team_ID);
                    table.ForeignKey(
                        name: "FK_Teams_Players_PlayersPlayer_ID",
                        column: x => x.PlayersPlayer_ID,
                        principalTable: "Players",
                        principalColumn: "Player_ID");
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Manager_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manager_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manger_Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamsTeam_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Manager_ID);
                    table.ForeignKey(
                        name: "FK_Managers_Teams_TeamsTeam_ID",
                        column: x => x.TeamsTeam_ID,
                        principalTable: "Teams",
                        principalColumn: "Team_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_PlayersPlayer_ID",
                table: "Coaches",
                column: "PlayersPlayer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_TeamsTeam_ID",
                table: "Managers",
                column: "TeamsTeam_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TransactionsTransaction_ID",
                table: "Players",
                column: "TransactionsTransaction_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PlayersPlayer_ID",
                table: "Positions",
                column: "PlayersPlayer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PlayersPlayer_ID",
                table: "Teams",
                column: "PlayersPlayer_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
