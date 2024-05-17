using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class FactoryGananciaExtranjera : FactoryGanancia
    {

        private decimal _porcentaje;
        private decimal _extra;

        public FactoryGananciaExtranjera(decimal porcentaje, decimal extra)
        {
            _porcentaje = porcentaje;
            _extra = extra;
        }

        public override IGanancia GetGanancia()
        {
            return new GananciaExtranjera(_porcentaje, _extra);
        }
    }
}
