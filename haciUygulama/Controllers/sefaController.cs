using Microsoft.AspNetCore.Mvc;

namespace haciUygulama.Controllers
{
    public class sefaController : Controller
    {
        public IActionResult Sefa()
        {
            return View();
        }
        [Route("sefa/Sefa/{id}/{ad}")]
        public string Liste(int id, string ad)
        {
            return $"Parametreden gelen id={id}, ad={ad}";
        }
    }

}
