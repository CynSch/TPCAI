using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Localidad
    {
        public Localidad(int codigoDeLocalidad, string nombreDeLocalidad)
        {
            CodigoDeLocalidad = codigoDeLocalidad;
            NombreDeLocalidad = nombreDeLocalidad;
        }
        public int CodigoDeLocalidad { get; set; }
        public string NombreDeLocalidad { get; set; }

        public static void ListarLocalidad()
        {
            //Devuelve Lista de Localidades.
        }

    }
}
