using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RecipositoryApi.Models;

namespace RecipositoryApi.Data
{
    public class RecipositoryApiRepo : IRecipositoryApiRepo
    {
        private RecipositoryApiContext _context;

        public RecipositoryApiRepo(RecipositoryApiContext context)
        {
            _context = context;
        }

        public IEnumerable<Recipe> GetRecipe(int? id)
        {
            if (id == null)
            {
                return _context.Recipes;
            }
            else
            {
                return (IEnumerable<Recipe>)_context.Recipes.FirstOrDefaultAsync(r => r.Id == id);
            }
        }

        public int SaveRecipe(Recipe recipe)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteRecipe(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}