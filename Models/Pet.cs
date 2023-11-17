using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAlgebraProject.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string? Image { get; set; }


        [NotMapped]
        [StringLength(500, MinimumLength = 2)]
        [DataType(DataType.ImageUrl)]

        public string ImageFile { get; set; }


        [ForeignKey("PetId")]
        public virtual ICollection<PetCategory> PetCategories { get; set; }


        [ForeignKey("PetId")]
        public virtual ICollection<PetStatus> PetStatus { get; set; }
    }
}
