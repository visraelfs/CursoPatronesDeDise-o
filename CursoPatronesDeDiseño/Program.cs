using CursoPatronesDeDiseño.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPatronesDeDiseño
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Singleton
            var log = Singleton.Log.Instansce;

            log.Save("a");
            log.Save("b");

            //Factory

            SalesFactory storeSaleFactory = new StoreSaleFactory(10);
            SalesFactory internetSaleFactory = new InternetSaleFactory(5);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);

            Console.ReadKey();

        }
    }
}
