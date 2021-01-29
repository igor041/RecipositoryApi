using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipositoryApi.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        [Required]
        public IEnumerable<RecipeIngridient> RecipeIngredients { get; set; }
    }
}