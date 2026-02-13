using _2024_08E_Web_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2024_08E_Web_App.Controllers
{
    public class VoucherController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        private readonly ApplicationDbContext _context;
        public VoucherController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]

        public IActionResult Create(Voucher abc)
        { 
            //abc.Id = 1;
            abc.Status = "paid";

            _context.Vouchers.Add(abc);
            _context.SaveChanges();

            ViewBag.Message="Voucher Created Successfully";
            ViewBag.ShowPreview = true;
            ViewBag.ShowData = abc;
            ModelState.Clear();
            return View(new Voucher());
        }
    }
}
