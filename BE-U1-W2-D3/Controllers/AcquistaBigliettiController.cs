using Microsoft.AspNetCore.Mvc;
using BE_U1_W2_D3.ViewModels;
using BE_U1_W2_D3.Models;

namespace BE_U1_W2_D3.Controllers
{
    public class AcquistaBigliettiController : Controller
    {

        public static List<Biglietto> ListaSale { get; set; } = new List<Biglietto>()
        {
            new Biglietto() {

            Id = 1,
            EmessoIl = DateTime.Now,
            },
            };
        public IActionResult Index()
        {
            ViewBag.Titolo = "Acquista Biglietti";
            ListaBigliettiViewModel listaBigliettiViewModel = new ListaBigliettiViewModel();
            listaBigliettiViewModel.Biglietti = ListaSale;
            return View(listaBigliettiViewModel);
        }
    }
}
