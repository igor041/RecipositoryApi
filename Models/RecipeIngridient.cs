using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Compression;
namespace RecipositoryApi.Models
{
    public class RecipeIngridient
    {
        public int Id {get;set;}
        [Required]
        [Column("Quantity", TypeName="decimal")]
        public decimal Quantity {get;set;}
        [Required]
        public int Unit { get; set; } // MeasuringUnit
        [Required]
        public int Ingredient { get; set; }
    }
}