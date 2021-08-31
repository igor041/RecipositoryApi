using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipositoryApi.Models;

namespace RecipositoryApi.Data
{
    public interface IRecipositoryApiRepo
    {
        IEnumerable<Recipe> GetRecipe(int? id = null);

        Task<IEnumerable<Recipe>> GetRecipeAsync(int? id = null);
        Task<bool> DeleteRecipeById(int id);
        Task<int?> SaveRecipe(Recipe recipe);
    }
}