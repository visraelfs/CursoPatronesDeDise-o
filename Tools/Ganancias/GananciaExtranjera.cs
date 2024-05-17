using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class GananciaExtranjera : IGanancia
    {
        private decimal _porcentaje;
        private decimal _extra;

        public GananciaExtranjera(decimal porcentaje, decimal extra)
        {
            _porcentaje = porcentaje;
            _extra = extra;
        }

        public decimal Ganancia(decimal amount)
        {
            return (amount * _porcentaje) + _extra;
        }
    }
}
