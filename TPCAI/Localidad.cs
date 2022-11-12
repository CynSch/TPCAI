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
        public Localidad(int codigoDeLocalidad, string nombreDeLocalidad, int codigoprovincia)
        {
            CodigoDeLocalidad = codigoDeLocalidad;
            NombreDeLocalidad = nombreDeLocalidad;
            CodigoDeProvincia = codigoprovincia;
        }

        public int CodigoDeLocalidad { get; set; }
        public string NombreDeLocalidad { get; set; }
        public int CodigoDeProvincia { get; set; }
        static internal List<Localidad> LstLocalidades = new List<Localidad>();

        public static void ListarLocalidad()
        {
            //Cargo las Localidades desde el archivo a la lista Localidades para que esten en memoria
            var archivoRegionNacional = new StreamReader("Localidades.txt");
            while (!archivoRegionNacional.EndOfStream)
            {
                string proximaLinea = archivoRegionNacional.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                Localidad localidad = new Localidad(int.Parse(datosSeparados[0]), datosSeparados[1], int.Parse(datosSeparados[2]));

                Localidad.LstLocalidades.Add(localidad);
            }
        }
        

        public static int BuscarProvinciaXLocalidad(int codigolocalidad)
        {
            //Busco el codigo de una provincia sabiendo la localidad ya seleccioanda.

            int codigoprovinciabuscado = 0;
            foreach (Localidad localidad in LstLocalidades)
            {
                if (localidad.CodigoDeLocalidad == codigolocalidad)
                {
                    codigoprovinciabuscado = localidad.CodigoDeProvincia;
                }
            }
            return codigoprovinciabuscado;
        }
        public static List <Localidad> ListarLocalidadesAsociadas(int codigoDeProvincia)
        {
            List<Localidad> lista = new List<Localidad>();
           
            lista = LstLocalidades.FindAll(L => L.CodigoDeProvincia == codigoDeProvincia);
            
            return lista; 
        }


        public static Localidad BuscarLocalidad(int codigoLocalidad)
        {
            return Localidad.LstLocalidades.Find(localidad => localidad.CodigoDeLocalidad == codigoLocalidad);
        }

    }
}
