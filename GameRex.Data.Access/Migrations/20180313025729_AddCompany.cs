using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameRex.Data.Access.Migrations
{
    public partial class AddCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deck",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GB_GUID",
                table: "Platforms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Platforms",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GB_GUID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SiteDetailUrl = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_CompanyId",
                table: "Platforms",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Platforms_Companies_CompanyId",
                table: "Platforms",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Platforms_Companies_CompanyId",
                table: "Platforms");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_CompanyId",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Deck",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "GB_GUID",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Platforms");
        }
    }
}
