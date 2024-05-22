using System.ComponentModel.DataAnnotations;

namespace ScriptSquadWebbshop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
}
