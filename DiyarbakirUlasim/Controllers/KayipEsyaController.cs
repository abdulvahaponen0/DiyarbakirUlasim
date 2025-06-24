using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace DiyarbakirUlasim.Controllers
{
    public class KayipEsyaController : Controller
    {
        private readonly IKayipEsyaBusiness _kayipEsyaBusiness;
        public KayipEsyaController(IKayipEsyaBusiness kayipEsyaBusiness)
        {
                _kayipEsyaBusiness = kayipEsyaBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(KayipEsya kayipEsya) { 
            _kayipEsyaBusiness.ekle(kayipEsya);
          return RedirectToAction("Index","Home");
        }
    }
}
