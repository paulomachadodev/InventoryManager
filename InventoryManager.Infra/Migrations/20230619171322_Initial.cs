using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManager.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MERCHANDISE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    REGISTER_NUMBER = table.Column<int>(type: "int", nullable: false),
                    MANUFACTURER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TYPE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MERCHANDISE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TRANSACTION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MerchandiseInboundTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QUANTITY = table.Column<int>(type: "int", nullable: false),
                    DATETIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LOCAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MERCHANDISE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TYPE = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSACTION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TRANSACTION_MERCHANDISE_MERCHANDISE_ID",
                        column: x => x.MERCHANDISE_ID,
                        principalTable: "MERCHANDISE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACTION_MERCHANDISE_ID",
                table: "TRANSACTION",
                column: "MERCHANDISE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRANSACTION");

            migrationBuilder.DropTable(
                name: "MERCHANDISE");
        }
    }
}
