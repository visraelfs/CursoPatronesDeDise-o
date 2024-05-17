using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class FactoryGananciaLocal : FactoryGanancia
    {
        private decimal _porcentaje;

        public FactoryGananciaLocal(decimal porcentaje)
        {
            _porcentaje = porcentaje;
        }

        public override IGanancia GetGanancia()
        {
            return new GananciaLocal(_porcentaje);
        }
    }
}
