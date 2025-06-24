using Business;
using Microsoft.AspNetCore.Mvc;

namespace DiyarbakirUlasim.Controllers
{
    public class HatlarController : Controller
    {
        private readonly IHatlarBusiness _hatlarBusiness;
        public HatlarController(IHatlarBusiness hatlarBusiness)
        {
            _hatlarBusiness = hatlarBusiness;
        }
        public IActionResult Index()
        {
            var hatlar = _hatlarBusiness.HatlarListele();
            return View(hatlar);
        }
    }
}
