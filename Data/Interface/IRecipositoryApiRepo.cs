using System.Collections.Generic;
using System.Linq;
using RecipositoryApi.Models;

namespace RecipositoryApi.Data
{
    public interface IRecipositoryApiRepo
    {
        IEnumerable<Recipe> GetRecipe(int? id = null);
        int SaveRecipe(Recipe recipe);
        int DeleteRecipe(int id);
    }
}