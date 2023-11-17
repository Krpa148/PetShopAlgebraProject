namespace PetShopAlgebraProject.Models
{
    public class PetStatus
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string? StatusId { get; set; }
        public bool Sold { get; set; }
        public bool Reserved { get; set; }
    }
}
