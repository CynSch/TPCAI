using System;
using System.Collections.Generic;
using System.IO;
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

        public Localidad() { }

        public int CodigoDeLocalidad { get; set; }
        public string NombreDeLocalidad { get; set; }
        static internal List<Localidad> LstLocalidades { get; set; }

        public static void ListarLocalidad()
        {
            //Cargo las Localidades desde el archivo a la lista Localidades para que esten en memoria
            var archivoRegionNacional = new StreamReader("Localidades.txt");
            while (!archivoRegionNacional.EndOfStream)
            {
                string proximaLinea = archivoRegionNacional.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                Localidad localidad = new Localidad();
                localidad.CodigoDeLocalidad = int.Parse(datosSeparados[0]);
                localidad.NombreDeLocalidad = datosSeparados[1];

                Localidad.LstLocaldiades.Add(localidad);


            }
        }

    }
}
