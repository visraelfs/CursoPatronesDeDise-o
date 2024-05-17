using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PatronesDeDiseñoASP.Configuration;
using PatronesDeDiseñoASP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace PatronesDeDiseñoASP.Controllers
{
    public class HomeController : Controller
    {

        //Obtenemos la configuracion
        private readonly IOptions<MyConfig> _config;
        


        //Inicializa la 
        public HomeController(IOptions<MyConfig> config)
        {
            _config = config;
        }

        public IActionResult Index()
        {

            // _config.Value.Pathlog Obtiene el valor del json appsettings.json
            Log.GetInstance(_config.Value.Pathlog).Save("Entro a Index");
            return View();
        }

        public IActionResult Privacy()
        {
            // _config.Value.Pathlog Obtiene el valor del json appsettings.json
            Log.GetInstance(_config.Value.Pathlog).Save("Entro a Index");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
