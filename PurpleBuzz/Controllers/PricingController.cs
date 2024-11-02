using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Data;
using PurpleBuzz.Models.Pricing;

namespace PurpleBuzz.Controllers
{
    public class PricingController : Controller
    {
        readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var prices = _context.Pricings.Include(p => p.PricingAdventages).ToList();

            var pricingList = prices.Select(price => new PricingVM
            {
                Title = price.Title,
                Price = price.Price,
                PricingAdventages = price.PricingAdventages.Select(adventage => new PricingAdventagesVM
                {
                    Title = adventage.Title,
                }).ToList()
            }).ToList();


            ViewData["Title"] = "Pricing";
            return View(pricingList);
        }
    }
}
