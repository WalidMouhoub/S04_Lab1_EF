using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class AjoutHuntingLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuntingLogZombie_HuntingLog_HuntingLogsId",
                table: "HuntingLogZombie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HuntingLog",
                table: "HuntingLog");

            migrationBuilder.RenameTable(
                name: "HuntingLog",
                newName: "HuntingLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HuntingLogs",
                table: "HuntingLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntingLogZombie_HuntingLogs_HuntingLogsId",
                table: "HuntingLogZombie",
                column: "HuntingLogsId",
                principalTable: "HuntingLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuntingLogZombie_HuntingLogs_HuntingLogsId",
                table: "HuntingLogZombie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HuntingLogs",
                table: "HuntingLogs");

            migrationBuilder.RenameTable(
                name: "HuntingLogs",
                newName: "HuntingLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HuntingLog",
                table: "HuntingLog",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntingLogZombie_HuntingLog_HuntingLogsId",
                table: "HuntingLogZombie",
                column: "HuntingLogsId",
                principalTable: "HuntingLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
