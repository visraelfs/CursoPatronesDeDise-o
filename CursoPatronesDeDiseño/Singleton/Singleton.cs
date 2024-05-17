using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPatronesDeDiseño.Singleton
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instansce
        {
            get
            {
                return _instance;
            }
        }

        private Singleton() { }
    }
}
