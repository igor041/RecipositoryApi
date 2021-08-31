using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecipositoryApi.Models;
using System;

namespace RecipositoryApi.Data{
    public class RecipositoryApiContext : DbContext
    {
        public readonly ILoggerFactory MyLoggerFactory;

        public RecipositoryApiContext(DbContextOptions<RecipositoryApiContext> opt): base(opt){
            MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        public DbSet<Recipe> Recipes {get;set;}

        public DbSet<RecipeIngridient> RecipeIngredients { get; set; } 

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}