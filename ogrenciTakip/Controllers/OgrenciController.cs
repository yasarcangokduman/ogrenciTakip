using Microsoft.AspNetCore.Mvc;
using ogrenciTakip.Models;

namespace ogrenciTakip.Controllers
{
    public class OgrenciController : Controller
    {
        static List<OgrenciModel> ogrenciler = new List<OgrenciModel>();
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult kayit(OgrenciModel ogrenci) {
            if (ogrenci.ono<1) 
            {
                return Content("Öğrenci numarası 1den küçük olamaz");
            }
            else if (string.IsNullOrEmpty(ogrenci.isim))
            {
                return Content("Öğrenci İsmi Boş Bırakılamaz");
            }
            else if (string.IsNullOrEmpty(ogrenci.soyIsim))
            {
                return Content("Öğrenci soyismi boş bırakılamaz");
            }
            else if (string.IsNullOrEmpty(ogrenci.sinif))
            {
                return Content("Öğrenci Sınıfı Boş Bırakılamaz");
            }
            else
            {
                ogrenciler.Add(ogrenci);
                return RedirectToAction("Index");
            }
        }
            

      
        public IActionResult Listele(OgrenciModel ogrenci) {
           
            return View(ogrenciler);
        }
    }
}
