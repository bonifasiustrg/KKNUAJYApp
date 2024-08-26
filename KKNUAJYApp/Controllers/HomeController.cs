using KKNUAJYApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KKNUAJYApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Informasi()
        {
            return View();
        }

        public IActionResult Pendaftaran()
        {
            return View();
        }
        public IActionResult KendaraanKel()
        {
            return View();
        }
        public IActionResult Blanko()
        {
            return View();
        }
        public IActionResult PenilaianKel()
        {
            return View();
        }
        public IActionResult TugasKelompok()
        {
            return View();
        }
        public IActionResult TugasKelompokContent()
        {
            return View();
        }
        public IActionResult TugasIndividuContent()
        {
            return View();
        }
        public IActionResult TugasIndividu()
        {
            return View();
        }
        public IActionResult DataKelompok()
        {
            return View();
        }
        public IActionResult Profile()
        {
            TempData["message"] = "Login sukses";
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult FormPendaftaran()
        {
            return View();
        }
        public IActionResult DashboardAsdos()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
