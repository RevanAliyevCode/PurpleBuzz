using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Entities;
using PurpleBuzz.Models.Contact;

namespace PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();

            var contactsList = contacts.Select(contact => new ContactVM
            {
                Title = contact.Title,
                Name = contact.Name,
                IconTag = contact.IconTag,
                Phone = contact.Phone,
            }).ToList();

            ViewData["Title"] = "Contact";
            return View(contactsList);
        }

    }
}
