using FormulárioTeste.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.Controllers
{
    public class PrateleiraController : Controller
    {
        PreteleiraViewModel model;
        public IActionResult Index()
        {
            model = new PreteleiraViewModel();
            model.id = 10;
            return View(model);
        }


        public IActionResult GravaDados(PreteleiraViewModel model)
        {
            return View("Index",model);

        }
    }
}
