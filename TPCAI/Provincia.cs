using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPCAI
{
    internal class Provincia
    {
        internal int CodigoDeProvincia { get; set; }
        internal string NombreDeProvincia { get; set; }
        internal int CodigoDeRegionNacional { get; set; }    
        internal List<Localidad> LocalidadesAsociadas { get; set; }

        static internal List<Provincia> TodasLasProvincias = new List<Provincia>();

        static internal List<Provincia> lstcargar { get; set; }

        internal List<Provincia> ListarProvinciasxRegion(int codigoregion)
        {
            //Creo una lista de las provincias asociadas a una región

            List<Provincia> ProvinciasAsociadas = new List<Provincia>();

            foreach (Provincia provincia in TodasLasProvincias)
            {
                if (this.CodigoDeRegionNacional == codigoregion)
                {
                    ProvinciasAsociadas.Add(provincia);
                    continue;
                }
                continue;
            }
            return ProvinciasAsociadas;
        }

        internal static void CargarProvincias()
        {
            //Cargo las provincias desde el archivo a la lista TodasLasProvincias para que esten en memoria
            StreamReader reader = new StreamReader($@"{Environment.CurrentDirectory}\Provincias.txt");
            if(TodasLasProvincias.Count > 0)
            {
                TodasLasProvincias.Clear();
            }

            while(!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //Codigo|Nombre|CodigoDeRegionNacional|ListLocalidadesAsociadas

                string[] datos = linea.Split('|');
                Provincia provincia = new Provincia(int.Parse(datos[0]),datos[1],int.Parse(datos[2]));
                provincia.LocalidadesAsociadas = new List<Localidad>();
                provincia.LocalidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provincia.CodigoDeProvincia);
                TodasLasProvincias.Add(provincia);
            }
            reader.Close();
        }

        internal static void GrabarProvincias()
        {
            //Grabo las provincias desde la lista TodasLasProvincias en memoria al archivo en caso de que se haya agregado una Provincia

            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Provincias.txt");

            //Codigo|Nombre|CodigoDeRegionNacional|ListLocalidadesAsociadas

            foreach (Provincia provincia in TodasLasProvincias)
            {
                string linea = provincia.CodigoDeProvincia.ToString() + "|"
                    + provincia.NombreDeProvincia + "|"
                    + provincia.CodigoDeRegionNacional.ToString();
                writer.WriteLine(linea);
            }
            writer.Close();

        }

        internal static void CrearArchivo()
        {
            List<Provincia> lstcargar = new List<Provincia>();
            //Cargo por primera vez las provincias
            Provincia provincia = new Provincia(1, "Buenos Aires", 4);
            Provincia provincia2 = new Provincia(2, "CABA", 4);
            Provincia provincia3 = new Provincia(3, "Catamarca", 1);
            Provincia provincia4 = new Provincia(4, "Chaco", 2);
            Provincia provincia5 = new Provincia(5, "Chubut", 5);
            Provincia provincia6 = new Provincia(6, "Cordoba", 4);
            Provincia provincia7 = new Provincia(7, "Corrientes", 2);
            Provincia provincia8 = new Provincia(8, "Entre Rios", 4);
            Provincia provincia9 = new Provincia(9, "Formosa", 2);
            Provincia provincia10 = new Provincia(10, "Jujuy", 1);
            Provincia provincia11 = new Provincia(11, "La Pampa", 5);
            Provincia provincia12 = new Provincia(12, "La Rioja", 3);
            Provincia provincia13 = new Provincia(13, "Mendoza", 3);
            Provincia provincia14 = new Provincia(14, "Misiones", 2);
            Provincia provincia15 = new Provincia(15, "Neuquen", 5);
            Provincia provincia16 = new Provincia(16, "Rio Negro", 5);
            Provincia provincia17 = new Provincia(17, "Salta", 1);
            Provincia provincia18 = new Provincia(18, "San Juan", 3);
            Provincia provincia19 = new Provincia(19, "San Luis", 3);

            lstcargar.Add(provincia);
            lstcargar.Add(provincia2);
            lstcargar.Add(provincia3);
            lstcargar.Add(provincia4);
            lstcargar.Add(provincia5);
            lstcargar.Add(provincia6);
            lstcargar.Add(provincia7);
            lstcargar.Add(provincia8);
            lstcargar.Add(provincia9);
            lstcargar.Add(provincia10);
            lstcargar.Add(provincia11);
            lstcargar.Add(provincia12);
            lstcargar.Add(provincia13);
            lstcargar.Add(provincia14);
            lstcargar.Add(provincia15);
            lstcargar.Add(provincia16);
            lstcargar.Add(provincia17);
            lstcargar.Add(provincia18);
            lstcargar.Add(provincia19);


            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Provincias.txt");
            foreach (Provincia prov in lstcargar)
            {
                string linea =  prov.CodigoDeProvincia+ "|" + prov.NombreDeProvincia+ "|"
                    + prov.CodigoDeRegionNacional;

                writer.WriteLine(linea);
            }
            writer.Close();
        }

        //CONSTRUCTOR
        public Provincia(int codigoDeProvincia, string nombreDeProvincia, int codigoDeRegionNacional)
        {
            CodigoDeProvincia = codigoDeProvincia;
            NombreDeProvincia = nombreDeProvincia;
            CodigoDeRegionNacional = codigoDeRegionNacional;
        }

        public static int BuscarRegionXProvincia(int codigoprovincia)
        {
            //Busco el codigo de una region sabiendo la provincia ya seleccionada.

            int codigoregionbuscado = 0;
            foreach (Provincia provincia in TodasLasProvincias)
            {
                if (provincia.CodigoDeProvincia == codigoprovincia)
                {
                    codigoregionbuscado = provincia.CodigoDeRegionNacional;
                }
            }
            return codigoregionbuscado;
        }

        public static string ListarProvincias()
        {
            string linea = "";
            foreach (Provincia provincia in TodasLasProvincias)
            {
                linea = linea + "Codigo De Provincia" + provincia.CodigoDeProvincia + " - " + provincia.NombreDeProvincia + "\n";
            }
            return linea;
        }


        public static Provincia BuscarProvincia(int codigoProvincia)
        {
            return Provincia.TodasLasProvincias.Find(provincia => provincia.CodigoDeProvincia == codigoProvincia);
        }


    }
}
