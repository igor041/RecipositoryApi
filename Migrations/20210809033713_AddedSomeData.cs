using Microsoft.EntityFrameworkCore.Migrations;

namespace recipositoryApi.Migrations
{
    public partial class AddedSomeData : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
