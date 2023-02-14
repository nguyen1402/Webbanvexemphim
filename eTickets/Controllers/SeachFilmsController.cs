using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class SeachFilmsController : Controller
    {
        private readonly AppDbContext _context;
        public SeachFilmsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Timkiem(string tkf)
        {
            List<Movie> _lsProductsList1 = new List<Movie>();
            List<Movie> _lsProductsList2 = new List<Movie>();
            _lsProductsList1 = _context.Movies.Include(c => c.Cinema).ToList();
            if (string.IsNullOrEmpty(tkf) || tkf.Length < 1)
            {
                return PartialView("_partialTK_view", _lsProductsList1);
            }

            _lsProductsList2 = _context.Movies.Include(c=>c.Cinema)
                .Where(c => c.Name.Contains(tkf))
                .ToList();
            return PartialView("_partialTK_view", _lsProductsList2);
        }
    }
}
