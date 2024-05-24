using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptSquadWebbshop.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? Quantity { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public float Total { get; set; }
    }
}
