using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactModel());
        }
        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", contact);
            }
            return View("Create", contact);
        }
    }
}