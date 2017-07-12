using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeClientes
{
    class ControlDeFichas
    {
        private const String ruta = @"C:/DataBase/";
        private const String nombreArchivo = "db.csv";
        public bool cargarFicha()
        {
            return false;
        }

        public void initialize()
        {
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
        }
        public bool agregarFicha(Ficha ficha)
        {
            if (!File.Exists(ruta+nombreArchivo))
            {
                initialize();
            }
            return false;
        }
    }
}
