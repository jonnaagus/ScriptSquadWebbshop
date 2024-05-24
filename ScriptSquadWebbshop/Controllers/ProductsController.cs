using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptSquadWebbshop.Data;
using ScriptSquadWebbshop.Models;

namespace ScriptSquadWebbshop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Description,Price,Quantity,ImageUrl")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProductSide));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Description,Price,Quantity")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ProductSide));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ProductSide));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }

        // GET: Product
        public async Task<IActionResult> ProductSide()
        {
            // Mock data
            var products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Apple TV", Description = "Apple TV 4K (2022) – all underhållning på ett ställe med skarp bild, tillgång till appar, filmer, musik och spel och en ännu mer lättanvänd fjärrkontroll.", Price = 1995.00f, Quantity = 5, ImageUrl = "/images/appletv.jpg" },
                new Product { ProductId = 2, ProductName = "Electrolux luftrenare", Description = "Electrolux Pure 300 luftrenare erbjuder avancerad luftrening för hem upp till 46 m². Med dess smarta design och kraftfulla filtreringssystem andas du renare och friskare luft varje dag.", Price = 1499.00f, Quantity = 1, ImageUrl = "/images/luftrenare.jpg" },
                new Product { ProductId = 3, ProductName = "Woods luftrenare", Description = "Rena luften tyst och effektivt i små rum som sovrum eller i en liten lägenhet. Svensktillverkade Woods AL310 luftrenare med joniserande filtreringsteknologi tar bort 99,98 procent av alla skadliga partiklar. För rum upp till 55 kvm.", Price = 4990.00f, Quantity = 3, ImageUrl = "/images/luftrenare1.jpg" },
                new Product { ProductId = 4, ProductName = "TP-Link router", Description = "TP-Link Deco BE65 är en avancerad mesh-router som levererar blixtsnabba hastigheter och stabil uppkoppling i hela hemmet. Med WiFi 7 är du rustad för framtidens internethastigheter.", Price = 6490.00f, Quantity = 7, ImageUrl = "/images/router.jpg" },
                new Product { ProductId = 5, ProductName = "Asus router", Description = "Asus RT-AX53U är en högpresterande router med stöd för framtidens trådlösa standard (WiFi 6). Upp till 1,8 Gbps hastighet, hög säkerhet med inbyggt virussystem och föräldrakontroll.", Price = 849.00f, Quantity = 5, ImageUrl = "/images/router1.jpg" },
                new Product { ProductId = 6, ProductName = "Starlink router", Description = "Starlink Business High Performance kit – koppla upp företaget eller användare med höga krav till ett snabbt och pålitligt internet 24/7. Med Starlink Business har du alltid bästa prestanda oavsett belastningen på nätverket. (Abonnemang krävs och säljs separat.)", Price = 27999.00f, Quantity = 2, ImageUrl = "/images/routerkit.jpg" },
                new Product { ProductId = 7, ProductName = "Nexa fjärrströmbrytare", Description = "Nexa MYC-4 plug-in-kit med fjärrkontroll och 3 trådlösa plug-in-mottagare. Tänd och släck lampor hemma med fjärrkontroll. Plugga in i vägguttaget och anslut lampans stickpropp.", Price = 199.90f, Quantity = 5, ImageUrl = "/images/uttag.jpg" },
                new Product { ProductId = 8, ProductName = "Yale Doorman L3S", Description = "Yale Doorman L3S Flex är det digitala dörrlåset som gör livet enklare. Lås upp med kod, nyckeltag, app eller låt låset låsa upp dörren åt dig med hjälp av geofencing. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare.", Price = 5990.00f, Quantity = 7, ImageUrl = "/images/yale.jpg" },
                new Product { ProductId = 9, ProductName = "Yale Doorman Classic", Description = "Yale Doorman Classic digitalt lås – lås upp med sifferkod, nyckeltagg eller en kombination av båda. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare. Upp till 10 nyckelbrickor och upp till 10 unika användarkoder. Låsklass 2A.", Price = 3499.00f, Quantity = 12, ImageUrl = "/images/yale1.jpg" }
            };

            return View(await _context.Product.ToListAsync());
        }
    }
}
