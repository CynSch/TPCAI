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
            var archivoRegionNacional = new StreamReader($@"{Environment.CurrentDirectory}Localidades.txt");
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
            var lst2 = new Localidad(2, "Lanus", 1);
            var lst3 = new Localidad(3, "Lomas De Zamora", 1);
            var lst4 = new Localidad(4, "La Matanza", 1);
            var lst5 = new Localidad(5, "Moron", 1);
            var lst6 = new Localidad(6, "Tres De Febrero", 1);
            var lst7 = new Localidad(7, "San Martin", 1);
            var lst8 = new Localidad(8, "Vicente Lopez", 1);
            var lst9 = new Localidad(9, "San Isidro", 1);
            var lst10 = new Localidad(10, "Quilmes", 1);
            var lst11 = new Localidad(11, "Berazategui", 1);
            var lst12 = new Localidad(12, "Florencio Varela", 1);
            var lst13 = new Localidad(13, "Almirante Brown", 1);
            var lst14 = new Localidad(14, "Esteban Echeverria", 1);
            var lst15 = new Localidad(15, "Ezeiza", 1);
            var lst16 = new Localidad(16, "Moreno", 1);
            var lst17 = new Localidad(17, "Merlo", 1);
            var lst18 = new Localidad(18, "Hurlingham", 1);
            var lst19 = new Localidad(19, "Ituzaingo", 1);
            var lst20 = new Localidad(20, "Tigre", 1);
            var lst21 = new Localidad(21, "San Fernando", 1);
            var lst22 = new Localidad(22, "Jose C Paz", 1);
            var lst23 = new Localidad(23, "San Miguel", 1);
            var lst24 = new Localidad(24, "Malvinas Argentinas", 1);
            var lst25 = new Localidad(25, "San Vicente", 1);
            var lst26 = new Localidad(26, "Presidente Peron", 1);
            var lst27 = new Localidad(27, "Marcos Paz", 1);
            var lst28 = new Localidad(28, "Gral. Rodriguez", 1);
            var lst29 = new Localidad(29, "Escobar", 1);
            var lst30 = new Localidad(30, "Pilar", 1);
            var lst31 = new Localidad(31, "La Puerta", 1);
            var lst32 = new Localidad(32, "Huaycama", 3);
            var lst33 = new Localidad(33, "Colpes", 3);
            var lst34 = new Localidad(34, "Isla Larga", 3);
            var lst35 = new Localidad(35, "Banda Norte", 3);
            var lst36 = new Localidad(36, "Banda Sud", 3);
            var lst37 = new Localidad(37, "Los Varela", 3);
            var lst38 = new Localidad(38, "Los Castillos", 3);
            var lst39 = new Localidad(39, "Campo Largo", 3);
            var lst40 = new Localidad(40, "Charata", 4);
            var lst41 = new Localidad(41, "Coronel Du Graty", 4);
            var lst42 = new Localidad(42, "Las Palmas", 4);
            var lst43 = new Localidad(43, "Machagai", 4);
            var lst44 = new Localidad(44, "Rio Ceballos", 4);
            var lst45 = new Localidad(45, "Cosquin", 6);
            var lst46 = new Localidad(46, "Villa Carlos Paz", 6);
            var lst47 = new Localidad(47, "La Puerta", 6);
            var lst48 = new Localidad(48, "Ciudad de Cordoba", 6);
            var lst49 = new Localidad(49, "Coronel Moldes", 6);
            var lst50 = new Localidad(50, "Angastaco", 17);
            var lst51 = new Localidad(51, "Cachi", 17);
            var lst52 = new Localidad(52, "Cafayate", 17);
            var lst53 = new Localidad(53, "Concepcion", 17);
            var lst54 = new Localidad(54, "Graneros", 24);
            var lst55 = new Localidad(55, "Alderetes", 24);



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
            listaACargar.Add(lst27);
            listaACargar.Add(lst28);
            listaACargar.Add(lst29);
            listaACargar.Add(lst30);
            listaACargar.Add(lst31);
            listaACargar.Add(lst32);
            listaACargar.Add(lst33);
            listaACargar.Add(lst34);
            listaACargar.Add(lst35);
            listaACargar.Add(lst36);
            listaACargar.Add(lst37);
            listaACargar.Add(lst38);
            listaACargar.Add(lst39);
            listaACargar.Add(lst40);
            listaACargar.Add(lst41);
            listaACargar.Add(lst42);
            listaACargar.Add(lst43);
            listaACargar.Add(lst44);
            listaACargar.Add(lst45);
            listaACargar.Add(lst46);
            listaACargar.Add(lst47);
            listaACargar.Add(lst48);
            listaACargar.Add(lst49);
            listaACargar.Add(lst50);
            listaACargar.Add(lst51);
            listaACargar.Add(lst52);
            listaACargar.Add(lst53);
            listaACargar.Add(lst54);
            listaACargar.Add(lst55);



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
