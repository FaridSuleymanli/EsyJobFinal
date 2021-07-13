using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsyJob.DAL;
using EsyJob.Models;
using EsyJob.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EsyJob.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.ContactInfos.FirstOrDefault());
        }
       

        [HttpPost]

        public IActionResult Create([FromForm] ContactSendVM contactSendVM)
        {
            Contact contact = new Contact
            {
                Name = contactSendVM.Name,
                Email = contactSendVM.Email,
                Subject = contactSendVM.Subject,
                Message = contactSendVM.Message
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok();

        }

    }
}
