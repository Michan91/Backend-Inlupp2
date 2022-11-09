namespace Inlupp2.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ItemNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
    }
}
