using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptSquadWebbshop.Data;
using ScriptSquadWebbshop.Models;
using ScriptSquadWebbshop.Utility;

namespace ScriptSquadWebbshop.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ApiService _apiService;

        public OrdersController(ApplicationDbContext context, ApiService apiService)
        {
            _context = context;
            _apiService = apiService;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {


            return View(await _context.Order.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.Include(u => u.User).Include(o => o.ProductOrders).ThenInclude(po => po.Product)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,FkUserId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,FkUserId")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order != null)
            {
                _context.Order.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }

        // GET: Weather statistics
        public async Task<IActionResult> Dashboard()
        {
            //get dates orders are placed
            List<Order> orders = await _context.Order.ToListAsync();

            //change dateTime to dateOnly
            List<DateOnly> dates = new List<DateOnly>();
            foreach (var order in orders)
            {
                dates.Add(DateOnly.FromDateTime(order.OrderDate));
            }

            //get weather data
            var apiUrl = "https://archive-api.open-meteo.com/v1/archive?latitude=62&longitude=15&end_date=2024-05-05&daily=weather_code&timezone=auto&start_date=2024-04-16";
            var apiData = await _apiService.GetApiDataAsync(apiUrl);

            List<int> weather = new List<int>();

            //loop each order date and get weather code
            foreach (var date in dates)
            {
                apiData.TryGetValue(date.ToString(), out int weathercode);
                weather.Add(weathercode);
            }

            //adds weathercodes to viewbag
            ViewBag.Weather = weather;


            //Get products where stock is less than 5
            var products = await _context.Procuct.Where(p => p.Quantity < 5).ToListAsync();
            ViewBag.LowStock = products;


            //daily summary
            //var summary = _context.Order
            //    .GroupBy(o => o.OrderDate.Date)
            //    .Select(s => new DailySummaryViewModel
            //    {
            //        OrderDate = s.Key,
            //        Ordercount = s.Count(),

            //        TotalPrice = s.
            //    })
            //    .OrderBy(ds => ds.OrderDate)
            //    .ToList();


            var summary = _context.Order
            .SelectMany(o => o.ProductOrders, (o, po) => new
            {
                o.OrderDate,
                po.Product.Price,
                po.Amount
            })
            .GroupBy(x => x.OrderDate.Date)
            .Select(g => new DailySummaryViewModel
            {
                OrderDate = g.Key,
                Ordercount = g.Count(),
                TotalPrice = g.Sum(x => x.Price * x.Amount)
            })
            .OrderBy(ds => ds.OrderDate)
            .ToList();


            ViewBag.Summary = summary;

            return View();
        }
    }
}
