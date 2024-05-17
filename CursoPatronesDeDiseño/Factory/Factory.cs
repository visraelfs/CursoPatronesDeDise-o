using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPatronesDeDiseño.Factory
{

    // Creator: Es el que da 
    public abstract class SalesFactory
    {
        public abstract ISale GetSale();
    }


    //Concrete Creator
    public class StoreSaleFactory : SalesFactory
    {

        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    public class InternetSaleFactory : SalesFactory
    {

        private decimal _descuento;

        public InternetSaleFactory(decimal descuento)
        {
            _descuento = descuento;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_descuento);
        }
    }

    //Producto Concreto
    public class StoreSale : ISale
    {

        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de {total + _extra}");
        }
    }

    public class InternetSale : ISale
    {

        private decimal _descuento;

        public InternetSale(decimal descuento)
        {
            _descuento = descuento;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en Internet tiene un total de {total + _descuento}");
        }
    }

    //Product
    public interface ISale
    {
        void Sell(decimal total);
    }
}
