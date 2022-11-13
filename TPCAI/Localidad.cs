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
        public Localidad() { }

        public int CodigoDeLocalidad { get; set; }
        public string NombreDeLocalidad { get; set; }
        public int CodigoDeProvincia { get; set; }
        static internal List<Localidad> LstLocalidades = new List<Localidad>();

        public static void ListarLocalidad()
        {
            //Cargo las Localidades desde el archivo a la lista Localidades para que esten en memoria
            var archivoRegionNacional = new StreamReader($@"{Environment.CurrentDirectory}\Localidades.txt");
            while (!archivoRegionNacional.EndOfStream)
            {
                string proximaLinea = archivoRegionNacional.ReadLine();

                //Codigo|Nombre|CodigoProv

                string[] datosSeparados = proximaLinea.Split('|');
                Localidad localidad = new Localidad(int.Parse(datosSeparados[0]), datosSeparados[1], int.Parse(datosSeparados[2]));

                Localidad.LstLocalidades.Add(localidad);
            }
        }

        internal static void CrearArchivo()
        {
            List<Localidad> listaACargar = new List<Localidad>();

            var lst1 = new Localidad(1, "Avellaneda", 1);
            var lst3 = new Localidad(3, "Lomas De Zamora", 1);
            var lst4 = new Localidad(4, "La Matanza", 1);
            var lst6 = new Localidad(6, "Tres De Febrero", 1);
            var lst8 = new Localidad(8, "Vicente Lopez", 1);
            var lst17 = new Localidad(17, "Merlo", 1);
            var lst24 = new Localidad(24, "Malvinas Argentinas", 1);
            var lst31 = new Localidad(31, "La Puerta", 1);
            var lst46 = new Localidad(46, "Villa Carlos Paz", 6);
            var lst51 = new Localidad(51, "Cachi", 17);




            listaACargar.Add(lst1);
            listaACargar.Add(lst3);
            listaACargar.Add(lst4);
            listaACargar.Add(lst6);
            listaACargar.Add(lst8);
            listaACargar.Add(lst17);
            listaACargar.Add(lst24);        
            listaACargar.Add(lst31);        
            listaACargar.Add(lst46);       
            listaACargar.Add(lst51);



            StreamWriter writerLocalidad = File.CreateText($@"{Environment.CurrentDirectory}\Localidades.txt");

            foreach (Localidad loc in listaACargar)
            {
                string lineaRegionMundial = loc.CodigoDeLocalidad + "|"
                    + loc.NombreDeLocalidad + "|" + loc.CodigoDeProvincia;

                writerLocalidad.WriteLine(lineaRegionMundial);
            }

            writerLocalidad.Close();



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
