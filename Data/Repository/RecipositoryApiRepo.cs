using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<Recipe>  GetRecipe(int? id)
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

        public async Task<int?>     SaveRecipe(Recipe recipe)
        {
            var obj = await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
            return obj?.Entity?.Id;
        }

        public async Task<bool>     DeleteRecipeById(int id)
        {
            bool result = false;

            var rec = await _context.Recipes.Where(r => r.Id == id).FirstOrDefaultAsync();
            if(rec != null)
            {
                _context.Remove(rec);
                await _context.SaveChangesAsync();
            }

            return result;
        }

        public Task<IEnumerable<Recipe>> GetRecipeAsync(int? id = null)
        {
            return Task.Run(() => GetRecipe(id));
        }
    }
}

