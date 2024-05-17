using Microsoft.AspNetCore.Mvc;
using Tools.Ganancias;

namespace PatronesDeDiseñoASP.Controllers
{
    public class DetalleDeProductoController : Controller
    {

        private FactoryGanancia _factoryGananciaLocal;
        private FactoryGanancia _factoryGananciaExtranjera;

        public DetalleDeProductoController(FactoryGananciaLocal factoryGananciaLocal, FactoryGananciaExtranjera factoryGananciaExtranjera)
        {
            _factoryGananciaLocal = factoryGananciaLocal;
            _factoryGananciaExtranjera = factoryGananciaExtranjera;
        }

        public IActionResult Index(decimal total)
        {

            //Fabricas
            
            //FactoryGananciaExtranjera fGananciaExtranjera = new FactoryGananciaExtranjera(0.30m, 20);

            //Productos
            var gananciaLocal = _factoryGananciaLocal.GetGanancia();
            var gananciaExtranjera = _factoryGananciaExtranjera.GetGanancia();

            ViewBag.totalLocal = total + gananciaLocal.Ganancia(total);
            ViewBag.totalExtranhera = total + gananciaExtranjera.Ganancia(total);

            return View();
        }
    }
}
