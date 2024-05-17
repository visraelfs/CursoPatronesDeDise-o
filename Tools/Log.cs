using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public sealed class Log
    {
        private  static Log _instance = null;
        private string _path;

        private static object _protect = new object();

        public static Log GetInstance(string path)
        {

            //La sección lock, bloquea el uso de la variable _protect de que un hilo ejecute esta sección al mismo tiempo con otro
            //Es decir si no estuviese esta sección, dos hilos entrarían al mismo tiempo, _instance estaría en null y generaría 2 instancias
            // con Lock evitamos la duplicidad y solo generará una instancia, que es el proposito de Singleton
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }

        private Log(string path) 
        { 
            _path = path;
        }

        public void Save(String message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
