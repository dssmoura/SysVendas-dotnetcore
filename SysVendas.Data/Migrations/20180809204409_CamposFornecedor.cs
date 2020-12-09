using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SysVendas.Data.Migrations
{
    public partial class CamposFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "FORNECEDOR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "FORNECEDOR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FORNECEDOR",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "FORNECEDOR",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "FORNECEDOR",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "FORNECEDOR",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "FORNECEDOR");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "FORNECEDOR");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "FORNECEDOR");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "FORNECEDOR");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "FORNECEDOR");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "FORNECEDOR");
        }
    }
}
