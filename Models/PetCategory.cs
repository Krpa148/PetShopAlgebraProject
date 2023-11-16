using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopAlgebraProject.Models
{
    public class PetCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public int PetId { get; set; }
        [NotMapped]
        public string PetName { get; set; }
        [NotMapped]
        public string CategoryTitle { get; set;}
    }
}
