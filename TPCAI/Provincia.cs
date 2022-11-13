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

            while(!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //Codigo|Nombre|CodigoDeRegionNacional|ListLocalidadesAsociadas

                string[] datos = linea.Split('|');
                Provincia provincia = new Provincia(int.Parse(datos[0]),datos[1],int.Parse(datos[2]));
                provincia.LocalidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provincia.CodigoDeProvincia);
               
                //Usa metodo de Localidades donde busca por codigo de provincia.
              //  provincia.LocalidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provincia.CodigoDeProvincia);
                Provincia.TodasLasProvincias.Add(provincia);
            }
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

            Provincia.TodasLasProvincias.Add(provincia);
            Provincia.TodasLasProvincias.Add(provincia2);
            Provincia.TodasLasProvincias.Add(provincia3);
            Provincia.TodasLasProvincias.Add(provincia4);
            Provincia.TodasLasProvincias.Add(provincia5);
            Provincia.TodasLasProvincias.Add(provincia6);
            Provincia.TodasLasProvincias.Add(provincia7);
            Provincia.TodasLasProvincias.Add(provincia8);
            Provincia.TodasLasProvincias.Add(provincia9);
            Provincia.TodasLasProvincias.Add(provincia10);
            Provincia.TodasLasProvincias.Add(provincia11);
            Provincia.TodasLasProvincias.Add(provincia12);
            Provincia.TodasLasProvincias.Add(provincia13);
            Provincia.TodasLasProvincias.Add(provincia14);
            Provincia.TodasLasProvincias.Add(provincia15);
            Provincia.TodasLasProvincias.Add(provincia16);
            Provincia.TodasLasProvincias.Add(provincia17);
            Provincia.TodasLasProvincias.Add(provincia18);
            Provincia.TodasLasProvincias.Add(provincia19);


            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Provincias.txt");
            foreach (Provincia prov in TodasLasProvincias)
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
            LocalidadesAsociadas = Localidad.ListarLocalidadesAsociadas((codigoDeProvincia));
            TodasLasProvincias.Add(this);
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
