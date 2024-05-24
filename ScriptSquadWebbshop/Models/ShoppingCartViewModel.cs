namespace ScriptSquadWebbshop.Models
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItem>  CartItems { get; set; }
        public float? TotalPrice { get; set; }
        public int? TotalQuantity { get; set; }
    }
}
