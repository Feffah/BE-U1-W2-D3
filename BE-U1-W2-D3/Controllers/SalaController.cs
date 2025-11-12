using BE_U1_W2_D3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using BE_U1_W2_D3.ViewModels;

namespace BE_U1_W2_D3.Controllers
{
    public class SalaController : Controller
    {
        public static List<Sala> ListaSale { get; set; } = new List<Sala>()
        {
            new Sala()
            {
                Id = 1,
                Name = "Sala Nord",
                NumeroPosti = 120
            }
            ,

            new Sala()
             {
                Id = 1,
                Name = "Sala Est",
                NumeroPosti = 120
            }
            ,

            new Sala()
             {
                Id = 1,
                Name = "Sala Sud",
                NumeroPosti = 120
            }

        };
        public IActionResult Index()
        {
            ViewBag.Titolo = "Sale Disponibili";

            ListaSaleViewModel listaSaleViewModel = new ListaSaleViewModel();
            listaSaleViewModel.Sales = ListaSale;
            return View(listaSaleViewModel);
        }
    }
}
