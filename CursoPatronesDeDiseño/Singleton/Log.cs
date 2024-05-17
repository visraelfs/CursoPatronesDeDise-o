using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPatronesDeDiseño.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        public static Log Instansce
        {
            get
            {
                return _instance;
            }
        }

        private Log() { }

        public void Save (String message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

    }
}
