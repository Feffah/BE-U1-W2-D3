using Microsoft.AspNetCore.Mvc;
using BE_U1_W2_D3.ViewModels;

namespace BE_U1_W2_D3.Controllers
{
    public class AcquistaBigliettiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titolo = "Acquista Biglietti";
            return View();
        }
    }
}
