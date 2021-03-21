﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DrozdArtStore.DataAccess.Migrations
{
    public partial class AddedMissingDisplayOrderPropertyToItemType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "ItemType",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "ItemType");
        }
    }
}
