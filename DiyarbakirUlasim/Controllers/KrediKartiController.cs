using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace DiyarbakirUlasim.Controllers
{
    public class KrediKartiController : Controller
    {
        private readonly IKrediKArtiIslemleriBusiness _krediKartiIslemleri;
        public KrediKartiController(IKrediKArtiIslemleriBusiness krediKArtiIslemleriBusiness)
        {
            _krediKartiIslemleri=krediKArtiIslemleriBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Yolcunun hesabına bakiye ekler 
        [HttpGet]
        public IActionResult BakiyeEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BakiyeEkle(KrediKarti krediKarti) {
            int? yolcuSessionId = HttpContext.Session.GetInt32("yolcuId");
            if (yolcuSessionId.HasValue)
            {
                krediKarti.YolcuId = yolcuSessionId;
                _krediKartiIslemleri.BakiyeEkle(krediKarti); // Servis katmanı
                return RedirectToAction("Profil", "Yolcu");
            }

            // Session yoksa kullanıcı giriş yapmamıştır
            return RedirectToAction("Login", "Yolcu");
        }
    }
}
