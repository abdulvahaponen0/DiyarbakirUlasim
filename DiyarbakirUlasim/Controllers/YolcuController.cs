using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;
namespace DiyarbakirUlasim.Controllers
{
    public class YolcuController : Controller
    {
        private readonly IYolcuLoginBusiness _yolcuLoginBusiness;
        public YolcuController(IYolcuLoginBusiness yolcuLoginBusiness)
        {
            _yolcuLoginBusiness = yolcuLoginBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult YolcuEkle() { 
           return View();
        }  
        //Yolcu ekleme metodu
        [HttpPost]
        public IActionResult YolcuEkle(Yolcu yolcu) {
            if (ModelState.IsValid)
            {
                _yolcuLoginBusiness.KayitOl(yolcu);
                return RedirectToAction("Listele");
            }
            return View(yolcu);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //Yolcu için giriş kontrolü Controller'i
        [HttpPost]
        public IActionResult Login(Yolcu yolcu)
        {
                bool isLoginTrue = _yolcuLoginBusiness.Login(yolcu);
                if (isLoginTrue)
                {
                    int yolcuId=_yolcuLoginBusiness.sessionId(yolcu.Sifre,yolcu.TelefonNumarasi);
                    HttpContext.Session.SetInt32("yolcuId", yolcuId);

                return RedirectToAction("Index","Home");
                }
            //ViewBag.Session = HttpContext.Session.GetInt32("yolcuId");
            ViewBag.Error = "Telefon numarası veya şifre yanlış";
            return View();
        }
        public IActionResult Hosgeldin()
        {
            return View();
        }
        //Listeme metodu
        public IActionResult Listele() {
            var yolcular = _yolcuLoginBusiness.TumYolcular();
            return View(yolcular);
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Profil() {
            int? yolcuSessionId = HttpContext.Session.GetInt32("yolcuId");
            if(yolcuSessionId == null)
            {
                return RedirectToAction("Login","Yolcu");
            }
            var profilYolcu = _yolcuLoginBusiness.Profil(yolcuSessionId.Value);
           return View(profilYolcu);
        }
    }
}
