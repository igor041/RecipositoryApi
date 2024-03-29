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

// Sample
//[Table("Persons", Schema = "dbo")]
//public class Person
//{
//    [Key]
//    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//    public int Id { get; set; }

//    [Required]
//    [Display(Name = "UserName")]
//    public string UserName { get; set; }

//    [Required]
//    [Display(Name = "UserPassword")]
//    public string UserPassword { get; set; }
//    [Required]
//    [Display(Name = "UserEmail")]
//    public string UserEmail { get; set; }

//    [Required]
//    [Display(Name = "CreatedOn")]
//    public DateTime CreatedOn { get; set; } = DateTime.Now;

//    [Required]
//    [Display(Name = "IsDeleted")]
//    public bool IsDeleted { get; set; } = false;

//}