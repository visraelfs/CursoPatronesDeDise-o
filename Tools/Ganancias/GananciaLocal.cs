using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class GananciaLocal : IGanancia
    {

        private decimal _porcentaje;

        public GananciaLocal(decimal procentaje)
        {
            _porcentaje = procentaje;
        }

        public decimal Ganancia(decimal cantidad)
        {
            return cantidad * _porcentaje;
        }
    }
}
