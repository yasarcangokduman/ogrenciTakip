using Microsoft.AspNetCore.Mvc;

namespace ogrenciTakip.Controllers
{
    public class KullanıcıController : Controller
    {
        [HttpPost]
        public IActionResult Ekle()
        {
            if (ModelState.IsValid == true)
            {
                return Content("Doğrulama işlemi başarılı.");
            }
            else
            {
                return Content("Doğrulama işlemi başarısız.");
            }
        }
    }
}
