using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "VALUES('Pao', 'Pao Ovo', 'Pao ovo hamburguer', 12.50, '', '', 1, 1, 1);");
            migrationBuilder.Sql("INSERT INTO lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "VALUES('Pao2', 'Pao Ovo', 'Pao ovo hamburguer', 12.90, '', '', 1, 1, 2);");
            migrationBuilder.Sql("INSERT INTO lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "VALUES('Pao3', 'Pao Ovo', 'Pao ovo hamburguer', 12.49, '', '', 1, 1, 2);");
            migrationBuilder.Sql("INSERT INTO lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "VALUES('Pao4', 'Pao Ovo', 'Pao ovo hamburguer', 12.00, '', '', 1, 1, 1);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM LANCHES");

        }
    }
}
