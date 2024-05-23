using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ScriptSquadWebbshop.Models;
using ScriptSquadWebbshop.Data;

namespace ScriptSquadWebbshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private List<ShoppingCartItem> _cartItems;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
			_cartItems = new List<ShoppingCartItem>();
		}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart(int id)
        {
            var productToAdd = _context.Product.Find(id);

            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            var existingCartItem = cartItems.FirstOrDefault(item => item.Product.ProductId == id);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity++;
            }
            else
            {
                cartItems.Add(new ShoppingCartItem
                {
                    Product = productToAdd,
                    Quantity = 1
                });
            }

            HttpContext.Session.Set("Cart", cartItems);

            return RedirectToAction("ViewCart");
        }

        public IActionResult ViewCart()
        {

            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            var cartViewModel = new ShoppingCartViewModel
            {
                CartItems = cartItems,
				TotalPrice = cartItems.Sum(item => (item.Product?.Price ?? 0) * item.Quantity)
			};

            return View(cartViewModel);
        }
    }
}