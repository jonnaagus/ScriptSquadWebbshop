using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptSquadWebbshop.Models
{
    public class ProductOrder
    {
        [Key]
        public int ProductOrderId { get; set; }
        [ForeignKey("ProductId")]
        public int FkProductId { get; set; }
        [ForeignKey("OrderId")]
        public int FkOrderId { get; set; }
        public int Amount { get; set; }

    }
}
