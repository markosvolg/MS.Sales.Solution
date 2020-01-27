using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesSolution.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, "Forma de Pagamento Boleto", "Boleto" },
                    { 2, "Forma de Pagamento Cartão de Cretido", "Cartão de Crédito" },
                    { 3, "Forma de Pagamento Depósito", "Despósito " },
                    { 4, "Forma de Pagamento Débito", "Cartão de Débito " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FormaPagamento",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
