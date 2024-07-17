using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanoFitApi.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Plano",
                table: "Plano");

            migrationBuilder.RenameTable(
                name: "Plano",
                newName: "Planos");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Users",
                newName: "Password");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "TEXT",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planos",
                table: "Planos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Planos",
                table: "Planos");

            migrationBuilder.RenameTable(
                name: "Planos",
                newName: "Plano");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Senha");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plano",
                table: "Plano",
                column: "Id");
        }
    }
}
