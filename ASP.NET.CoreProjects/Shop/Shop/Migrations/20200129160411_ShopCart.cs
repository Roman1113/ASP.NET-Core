using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopCarItems_Car_carid",
                table: "shopCarItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopCarItems",
                table: "shopCarItems");

            migrationBuilder.RenameTable(
                name: "shopCarItems",
                newName: "ShopCarItems");

            migrationBuilder.RenameIndex(
                name: "IX_shopCarItems_carid",
                table: "ShopCarItems",
                newName: "IX_ShopCarItems_carid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopCarItems",
                table: "ShopCarItems",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarItems_Car_carid",
                table: "ShopCarItems",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarItems_Car_carid",
                table: "ShopCarItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopCarItems",
                table: "ShopCarItems");

            migrationBuilder.RenameTable(
                name: "ShopCarItems",
                newName: "shopCarItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarItems_carid",
                table: "shopCarItems",
                newName: "IX_shopCarItems_carid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopCarItems",
                table: "shopCarItems",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_shopCarItems_Car_carid",
                table: "shopCarItems",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
