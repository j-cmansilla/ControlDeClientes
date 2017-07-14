using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeClientes
{
    public class ControlDeFichas
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

        public String[] agregarFichas(Ficha ficha)
        {
            String[] datos = new String[1];
            datos[0] = ficha.nombre + "," + ficha.telefono1 + "," + ficha.telefono2 + "," + ficha.telefono3 + "," + ficha.direccion + "," + ficha.anotaciones + "," + ficha.observaciones + "," + ficha.fechas + "," + ficha.deuda+","+ficha.ID.ToString();
            return datos;
        }

        public String[] retornarDatos()
        {
            String[] datosDeVuelta = File.ReadAllLines(ruta + nombreArchivo);
            return datosDeVuelta;
        }

        public bool editarFicha(Ficha ficha)
        {
            String[] datos = retornarDatos();
            String[] datosEditados = new String[datos.Length];
            for (int i = 0; i < datos.Length; i++)
            {
                String[] data = datos[i].Split(',');
                if (data[9] == ficha.ID)
                {
                    datosEditados[i] = agregarFichas(ficha)[0];
                }
                else
                {
                    datosEditados[i] = datos[i];
                }
            }
            File.WriteAllLines(ruta + nombreArchivo, datosEditados);
            return true;
        }

        public List<String> buscarDatos(String criterioDeBusqueda) {
            List<String> listaDeDatos = new List<String>();
            String[] datos = File.ReadAllLines(ruta+nombreArchivo);
            for (int i = 0; i < datos.Length; i++)
            {
                String[] words = datos[i].Split(',');
                if (criterioDeBusqueda == words[0] || criterioDeBusqueda == words[1] || criterioDeBusqueda == words[2] || criterioDeBusqueda == words[3] || criterioDeBusqueda == words[4])
                {
                    listaDeDatos.Add(datos[i]);
                }
            }
            return listaDeDatos;
        }

        public void agregarFicha(Ficha ficha)
        {
            if (!File.Exists(ruta+nombreArchivo))
            {
                initialize();
                File.WriteAllLines(ruta+nombreArchivo, agregarFichas(ficha));
            }
            else
            {
                String[] datosDeVuelta = File.ReadAllLines(ruta+nombreArchivo);
                String[] nuevosDatos = new String[datosDeVuelta.Length+1];
                for (int i = 0; i < nuevosDatos.Length; i++)
                {
                    if (i==datosDeVuelta.Length)
                    {
                        nuevosDatos[i] = agregarFichas(ficha)[0];
                    }
                    else
                    {
                        nuevosDatos[i] = datosDeVuelta[i];
                    }
                }
                File.WriteAllLines(ruta+nombreArchivo, nuevosDatos);
            }
        }
    }
}
