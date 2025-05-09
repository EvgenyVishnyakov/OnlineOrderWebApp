﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineOrder.Db.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIsActiv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActiv",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActiv",
                table: "Orders");
        }
    }
}
