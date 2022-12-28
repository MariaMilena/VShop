using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                " VALUES('Caderno', 7.55, 'Caderno Espiral', 10, 'Caderno1.jpg', 1");

            mb.Sql("INSERT INTO products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                " VALUES('Lápis', 3.45, 'Lápis Preto', 20, 'lapis1.jpg', 1");

            mb.Sql("INSERT INTO products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                " VALUES('Clips', 5.33, 'Clips para papel', 50, 'Clips1.jpg', 2");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM products"); 
        }
    }
}
