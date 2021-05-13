using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingProject.DataAccess.Migrations
{
    public partial class Request : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Customers_CostumerId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Customers_CostumerId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_CostumerId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Loans_CostumerId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CostumerId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "CostumerId",
                table: "Loans");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Transactions",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Requests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Loans",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "BankAccounts",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "BankAccountMetaDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BankAccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccountMetaDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardMetaData",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    CardId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardMetaData", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CustomerId",
                table: "Loans",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Customers_CustomerId",
                table: "Loans",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Customers_CustomerId",
                table: "Requests",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Customers_CustomerId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Customers_CustomerId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "BankAccountMetaDatas");

            migrationBuilder.DropTable(
                name: "CardMetaData");

            migrationBuilder.DropIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Loans_CustomerId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Loans");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AddColumn<Guid>(
                name: "CostumerId",
                table: "Requests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CostumerId",
                table: "Loans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "BankAccounts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CostumerId",
                table: "Requests",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CostumerId",
                table: "Loans",
                column: "CostumerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Customers_CostumerId",
                table: "Loans",
                column: "CostumerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Customers_CostumerId",
                table: "Requests",
                column: "CostumerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
