using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAlgebraProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<PetCategory> PetCategories { get; set; }
    }
}
