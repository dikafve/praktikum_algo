using Microsoft.AspNetCore.Mvc;
using GudangWebApp.Models;

namespace GudangWebApp.Controllers
{
    public class BarangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Bab 9: Tampilkan semua barang dari database
        public IActionResult Index()
        {
            var data = _context.Barang.ToList();
            return View(data);
        }

        // GET: /Barang/Create
        public IActionResult Create() => View();

        // POST: /Barang/Create — langsung pakai model Barang (bab 9, belum ViewModel)
        [HttpPost]
        public IActionResult Create(Barang barang)
        {
            if (ModelState.IsValid)
            {
                _context.Barang.Add(barang);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(barang);
        }
    }
}
