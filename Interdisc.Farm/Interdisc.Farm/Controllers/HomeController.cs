using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Interdisc.Farm.Data;
using Interdisc.Farm.Models;

namespace Interdisc.Farm.Controllers
{
    public class HomeController : Controller
    {
        private readonly InterdiscFarmContext _context;

        public HomeController(InterdiscFarmContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.ProductGroupModel.ToList());
        }
    }
}