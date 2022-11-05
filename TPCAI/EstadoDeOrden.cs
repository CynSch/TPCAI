using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class EstadoDeOrden
    {
        //Propiedades
        public int Codigo_De_Estado { get; set; }
        public string Descripcion { get; set; }

        //Métodos
        internal static void CargarEstados() //Saca los estados disponibles del archivo "Estados.txt"
        {
            //El archivo tiene el formato: "1|Creado"
            var archivoEstados = new StreamReader("Estados.txt");
            while (!archivoEstados.EndOfStream)
            {
                string proximaLinea = archivoEstados.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var estado = new EstadoDeOrden();
                estado.Codigo_De_Estado = int.Parse(datosSeparados[0]);
                estado.Descripcion = datosSeparados[1];
            }
        }
    }
}
