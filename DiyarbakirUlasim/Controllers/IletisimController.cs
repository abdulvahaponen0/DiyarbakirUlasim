using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace DiyarbakirUlasim.Controllers
{
    public class IletisimController : Controller
    {
        private readonly IIletisimBusiness _iiletisimBusiness;
        private readonly IYolcuLoginBusiness _yolcuLoginBusiness;
        public IletisimController(IIletisimBusiness iiletisimBusines,IYolcuLoginBusiness yolcuLoginBusiness)
        {
            _iiletisimBusiness = iiletisimBusines;  
            _yolcuLoginBusiness = yolcuLoginBusiness;   
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            int? yolcuSessionId = HttpContext.Session.GetInt32("yolcuId");
            if (yolcuSessionId == null)
            {
                return RedirectToAction("Index","Home");
            }
            var yolcuBilgileri = _yolcuLoginBusiness.Profil(yolcuSessionId.Value);
            var iletisim = new Iletisim();
            iletisim.AdSoyad = yolcuBilgileri.Ad;
            iletisim.Email = yolcuBilgileri.EMail;
            iletisim.TelefonNumarasi = yolcuBilgileri.TelefonNumarasi;
            return View(iletisim);
        }
        [HttpPost]
        public IActionResult Ekle(Iletisim ıletisim) {
            if (!ModelState.IsValid)
            {
                return View(ıletisim);
            }
            int? yolcuSessionId = HttpContext.Session.GetInt32("yolcuId");
            var guncellenecekVeri =_yolcuLoginBusiness.Profil(yolcuSessionId.Value);
            if(guncellenecekVeri == null)
            {
                return NotFound();
            }
            guncellenecekVeri.Ad = ıletisim.AdSoyad;
            guncellenecekVeri.EMail = ıletisim.Email;
            guncellenecekVeri.TelefonNumarasi = ıletisim.TelefonNumarasi;
            try
            {
                _iiletisimBusiness.ekle(ıletisim);
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: "+ex.ToString());
            }
            return RedirectToAction("MesajAlindi");
            //return View();
        }
        [HttpGet]
        public IActionResult MesajAlindi() {
            return View();
        }
        [HttpGet]
        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}
