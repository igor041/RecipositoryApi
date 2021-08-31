using Microsoft.EntityFrameworkCore.Migrations;

namespace recipositoryApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into Ingredients(Name) values ('Salt');" +
                "insert into Ingredients(Name) values('Pepper'); " +
                "insert into Ingredients(Name) values('Oil'); " +
                "insert into Ingredients(Name) values('Vinegar'); " +
                "insert into Ingredients(Name) values('Chicken'); " +
                "insert into Ingredients(Name) values('Beef'); " +
                "insert into Ingredients(Name) values('Fish'); " +
                "insert into Ingredients(Name) values('Shrimp'); " +
                "insert into Ingredients(Name) values('Olive Oil'); " +
                "insert into Ingredients(Name) values('Mashed Potatoes'); " +
                "insert into Ingredients(Name) values('Carrots'); " +
                "insert into Ingredients(Name) values('Peas'); " +
                "insert into Ingredients(Name) values('Potatoes'); " +
                "insert into Ingredients(Name) values('Mayo'); " +
                "insert into Ingredients(Name) values('Mustard'); " +
                "insert into Ingredients(Name) values('Heavy Whipping Cream'); " +
                "insert into Ingredients(Name) values('Rice'); ");
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<decimal>(type: "decimal", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Ingredient = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
