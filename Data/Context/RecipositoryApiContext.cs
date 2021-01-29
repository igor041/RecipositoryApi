using Microsoft.EntityFrameworkCore;

using RecipositoryApi.Models;

namespace RecipositoryApi.Data{
    public class RecipositoryApiContext : DbContext
    {
        public RecipositoryApiContext(DbContextOptions<RecipositoryApiContext> opt): base(opt){ }
        public DbSet<Recipe> Recipes {get;set;}
        public DbSet<RecipeIngridient> RecipeIngredients { get; set; } 
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}