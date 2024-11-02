using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.Home;
namespace PurpleBuzz.Controllers;

public class HomeController : Controller
{
    readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var works = _context.RecentWorks.ToList();

        var recentWorks = works.Select(work => new HomeVM
        {
            Title = work.Title,
            Description = work.Description,
            ImageUrl = work.ImageUrl
        }).ToList();

        ViewData["Title"] = "Home";
        return View(recentWorks);
    }
}
