namespace PetShopAlgebraProject.Models
{
    public class PetStatus
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public bool Sold { get; set; }
        public bool Reserved { get; set; }
    }
}
