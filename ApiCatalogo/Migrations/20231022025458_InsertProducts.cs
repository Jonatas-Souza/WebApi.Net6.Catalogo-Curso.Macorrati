using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class InsertProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, ImageUrl, Stock, CreateDate,CategoryId) " +
                "                           Values('Coca-Cola Diet','Refrigerante de Cola 350 ml',5.45,'CocaCola.jpg',50,getdate(),1)," +
                "                                 ('Lanche de Atum','Lanche de Atum com maionese',8.50,'Atum.jpg',10,getdate(),2)," +
                "                                 ('Pudim 100g','Pudim de leite condensado 100g',6.75,'Pudim.jpg',20,getdate(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
