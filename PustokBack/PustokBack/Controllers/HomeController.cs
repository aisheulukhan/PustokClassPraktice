using Microsoft.AspNetCore.Mvc;
using PustokBack.DAL;
using PustokBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokBack.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
