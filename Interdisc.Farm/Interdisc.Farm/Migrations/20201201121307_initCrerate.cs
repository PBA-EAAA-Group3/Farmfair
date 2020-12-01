using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Interdisc.Farm.Migrations
{
    public partial class initCrerate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerModel",
                columns: table => new
                {
                    CustomerModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModel", x => x.CustomerModelId);
                });

            migrationBuilder.CreateTable(
                name: "FarmModel",
                columns: table => new
                {
                    FarmModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmModel", x => x.FarmModelId);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroupModel",
                columns: table => new
                {
                    ProductGroupModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroupModel", x => x.ProductGroupModelId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceModel",
                columns: table => new
                {
                    InvoiceModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerModelId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceModel", x => x.InvoiceModelId);
                    table.ForeignKey(
                        name: "FK_InvoiceModel_CustomerModel_CustomerModelId",
                        column: x => x.CustomerModelId,
                        principalTable: "CustomerModel",
                        principalColumn: "CustomerModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    ProductModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupModelId = table.Column<int>(nullable: false),
                    Batch = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    FarmModelId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => x.ProductModelId);
                    table.ForeignKey(
                        name: "FK_ProductModel_FarmModel_FarmModelId",
                        column: x => x.FarmModelId,
                        principalTable: "FarmModel",
                        principalColumn: "FarmModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductModel_ProductGroupModel_ProductGroupModelId",
                        column: x => x.ProductGroupModelId,
                        principalTable: "ProductGroupModel",
                        principalColumn: "ProductGroupModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemsModel",
                columns: table => new
                {
                    OrderItemsModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    InvoiceModelId = table.Column<int>(nullable: false),
                    ProductModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemsModel", x => x.OrderItemsModelId);
                    table.ForeignKey(
                        name: "FK_OrderItemsModel_InvoiceModel_InvoiceModelId",
                        column: x => x.InvoiceModelId,
                        principalTable: "InvoiceModel",
                        principalColumn: "InvoiceModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemsModel_ProductModel_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "ProductModel",
                        principalColumn: "ProductModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceModel_CustomerModelId",
                table: "InvoiceModel",
                column: "CustomerModelId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemsModel_InvoiceModelId",
                table: "OrderItemsModel",
                column: "InvoiceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemsModel_ProductModelId",
                table: "OrderItemsModel",
                column: "ProductModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_FarmModelId",
                table: "ProductModel",
                column: "FarmModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModel_ProductGroupModelId",
                table: "ProductModel",
                column: "ProductGroupModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItemsModel");

            migrationBuilder.DropTable(
                name: "InvoiceModel");

            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.DropTable(
                name: "CustomerModel");

            migrationBuilder.DropTable(
                name: "FarmModel");

            migrationBuilder.DropTable(
                name: "ProductGroupModel");
        }
    }
}
