using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models.About;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var team = _context.TeamMembers.ToList();
            var priorites = _context.Priorites.ToList();

            var teamMemberVMs = team.Select(member => new TeamMemberVM
            {
                Name = member.Name,
                Surname = member.Surname,
                Position = member.Position,
                ImageUrl = member.ImageUrl
            }).ToList();

            var prioritesVMs = priorites.Select(priorite => new PrioritesVM
            {
                Title = priorite.Title,
                Description = priorite.Description,
                IconTag = priorite.IconTag
            }).ToList();

            AboutVM aboutVM = new AboutVM
            {
                TeamMembers = teamMemberVMs,
                Priorites = prioritesVMs
            };

            ViewData["Title"] = "About";
            return View(aboutVM);
        }

    }
}
