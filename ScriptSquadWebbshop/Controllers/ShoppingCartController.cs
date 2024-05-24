using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ScriptSquadWebbshop.Models;
using ScriptSquadWebbshop.Data;
using Microsoft.AspNetCore.Identity;
using NuGet.Packaging.Signing;

namespace ScriptSquadWebbshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private List<ShoppingCartItem> _cartItems;

        public ShoppingCartController(ApplicationDbContext context, UserManager<User> userManager )
        {
            _context = context;
            _userManager = userManager;
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

            TempData["CartMessage"] = $"{productToAdd.ProductName} tillagd i kundvagnen";

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

            ViewBag.CartMessage = TempData["CartMessage"];

            return View(cartViewModel);
        }

        public IActionResult RemoveItem(int id)
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            var itemToRemove = cartItems.FirstOrDefault(item => item.Product.ProductId == id);

            if(itemToRemove != null)
            {
               if(itemToRemove.Quantity > 1)
                {
                    itemToRemove.Quantity--;
                }
               else
                {
                    cartItems.Remove(itemToRemove);
                }
            }

            HttpContext.Session.Set("Cart", cartItems);

            TempData["CartMessage"] = $"{itemToRemove.Product.ProductName} borttagen från kundvagnen";


            return RedirectToAction("ViewCart");
        }
        public async Task<IActionResult> PurchaseItems()
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            var order = new Order {OrderDate = DateTime.Now, UserId = _userManager.GetUserId(User)};

            _context.Order.Add(order);
            _context.SaveChanges();
       

            foreach(var item in cartItems)
            {
                _context.ProductOrder.Add(new ProductOrder
                {
                    OrderId = order.OrderId,
                    ProductId = item.Product.ProductId, 
                    Amount = item.Quantity,
                  
                });
            }

            _context.SaveChanges();

            HttpContext.Session.Set("Carts", new List<ShoppingCartItem>());

            return RedirectToAction("Index", "Home");

        }
    }
}