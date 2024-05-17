using Microsoft.AspNetCore.Mvc;
using Tools.Ganancias;

namespace PatronesDeDiseñoASP.Controllers
{
    public class DetalleDeProductoController : Controller
    {
        public IActionResult Index(decimal total)
        {

            //Fabricas
            FactoryGananciaLocal fGananciaLocal = new FactoryGananciaLocal(0.20m);
            FactoryGananciaExtranjera fGananciaExtranjera = new FactoryGananciaExtranjera(0.30m, 20);

            //Productos
            var gananciaLocal = fGananciaLocal.GetGanancia();
            var gananciaExtranjera = fGananciaExtranjera.GetGanancia();

            ViewBag.totalLocal = total + gananciaLocal.Ganancia(total);
            ViewBag.totalExtranhera = total + gananciaExtranjera.Ganancia(total);

            return View();
        }
    }
}
