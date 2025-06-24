using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace DiyarbakirUlasim.Controllers
{
    public class HareketSaatleriController : Controller
    {
        YolcuDbContext _yolcuDbContext;
        public HareketSaatleriController(YolcuDbContext yolcuDbContext)
        {
            _yolcuDbContext = yolcuDbContext;
        }
        public IActionResult Index(int id)
        {
            //var hareketSaatleri = _yolcuDbContext.hatlars.FirstOrDefault(x => x.Id == id).hareketSaatleri.ToList();
            var hareketSaatleri = _yolcuDbContext.hatlars
    .Where(x => x.Id == id)
    .SelectMany(x => x.hareketSaatleri)
    .ToList();

            return View(hareketSaatleri);
        }
    }
}
