using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSComMariaDB.Migrations
{
    /// <inheritdoc />
    public partial class PrecoStringToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produto",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Produto",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldMaxLength: 1000)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Preco",
                table: "Produto",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Imagem",
                keyValue: null,
                column: "Imagem",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Produto",
                type: "varchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
