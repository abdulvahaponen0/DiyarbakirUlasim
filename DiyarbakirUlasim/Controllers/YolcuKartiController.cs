using Business;
using Microsoft.AspNetCore.Mvc;

namespace DiyarbakirUlasim.Controllers
{
    public class YolcuKarti : Controller
    {
        private readonly IKartBusiness _kartBusiness;
        public YolcuKarti(IKartBusiness kartBusiness)
        {
            _kartBusiness = kartBusiness;
        }
        public IActionResult KartDetay()
        {
            int? yolcuSessionId = HttpContext.Session.GetInt32("yolcuId");

            if (yolcuSessionId == null)
            {
                return RedirectToAction("Index", "Home"); // örnek: giriş ekranına yönlendir
            }

            var kartDetay = _kartBusiness.kartDetay(yolcuSessionId.Value);
            return View(kartDetay);
        }
    }
}
