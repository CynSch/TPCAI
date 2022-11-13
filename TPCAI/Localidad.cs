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
            var lst2 = new Localidad(2, "Lomas De Zamora", 1);
            var lst3 = new Localidad(3, "La Matanza", 1);
            var lst4 = new Localidad(4, "Tres De Febrero", 1);
            var lst5 = new Localidad(5, "Vicente Lopez", 1);
            var lst6 = new Localidad(6, "Merlo", 1);
            var lst7 = new Localidad(7, "Malvinas Argentinas", 1);
            var lst8 = new Localidad(8, "La Puerta", 1);
            var lst9 = new Localidad(9, "CABA", 2);
            var lst10 = new Localidad(10, "Belen", 3);
            var lst11 = new Localidad(11, "Campo Largo", 4);
            var lst12 = new Localidad(12, "Trelew", 5);
            var lst13 = new Localidad(13, "Villa Carlos Paz", 6);
            var lst14 = new Localidad(14, "Concepcion", 7);
            var lst15 = new Localidad(15, "Colon", 8);
            var lst16 = new Localidad(16, "El Colorado", 9);
            var lst17 = new Localidad(17, "Purmamarca", 10);
            var lst18 = new Localidad(18, "Ceballos", 11);
            var lst19 = new Localidad(19, "Ulapes", 12);
            var lst20 = new Localidad(20, "Pareditas", 13);
            var lst21 = new Localidad(21, "Laharrague", 14);
            var lst22 = new Localidad(22, "Villa Pehuenia", 15);
            var lst23 = new Localidad(23, "El Bolson", 16);
            var lst24 = new Localidad(24, "Cachi", 17);
            var lst25 = new Localidad(25, "Rivadavia", 18);
            var lst26 = new Localidad(26, "Bella Vista", 19);

            listaACargar.Add(lst1);
            listaACargar.Add(lst2);
            listaACargar.Add(lst3);
            listaACargar.Add(lst4);
            listaACargar.Add(lst5);
            listaACargar.Add(lst6);
            listaACargar.Add(lst7);        
            listaACargar.Add(lst8);        
            listaACargar.Add(lst9);       
            listaACargar.Add(lst10);
            listaACargar.Add(lst11);
            listaACargar.Add(lst12);
            listaACargar.Add(lst13);
            listaACargar.Add(lst14);
            listaACargar.Add(lst15);
            listaACargar.Add(lst16);
            listaACargar.Add(lst17);
            listaACargar.Add(lst18);
            listaACargar.Add(lst19);
            listaACargar.Add(lst20);
            listaACargar.Add(lst21);
            listaACargar.Add(lst22);
            listaACargar.Add(lst23);
            listaACargar.Add(lst24);
            listaACargar.Add(lst25);
            listaACargar.Add(lst26);


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
