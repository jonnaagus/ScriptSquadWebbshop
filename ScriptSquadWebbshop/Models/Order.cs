using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptSquadWebbshop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
      
    }
}
