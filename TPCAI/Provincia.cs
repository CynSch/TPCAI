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

        static internal List<Provincia> TodasLasProvincias { get; set; }

        internal List<Provincia> ListarProvincias(int codigoregion)
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
            using StreamReader reader = new StreamReader("Provincia.txt");

            while(!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //Codigo|Nombre|CodigoDeRegionNacional|ListLocalidadesAsociadas

                string[] datos = linea.Split('|');
                Provincia provincia = new Provincia();
                provincia.CodigoDeProvincia = int.Parse(datos[0]);
                provincia.NombreDeProvincia = datos[1];
                provincia.CodigoDeRegionNacional = int.Parse(datos[2]);
                
                //Usa metodo de Localidades donde busca por codigo de provincia.
                provincia.LocalidadesAsociadas = Localidad.ListarLocalidadesAsociadas(provincia.CodigoDeProvincia);
                Provincia.TodasLasProvincias.Add(provincia);
            }
        }

        internal static void GrabarProvincias()
        {
            //Grabo las provincias desde la lista TodasLasProvincias en memoria al archivo en caso de que se haya agregado una Provincia

            //SOLO USAR SI SE AGREGÓ UNA PROVINCIA O SE MODIFICÓ EL DATO DE ALGUNA PRE-EXISTENTE

            StreamWriter writer = File.CreateText("Provincia.txt");

            //Codigo|Nombre|CodigoDeRegionNacional|ListLocalidadesAsociadas

            foreach (Provincia provincia in TodasLasProvincias)
            {
                string linea = provincia.CodigoDeProvincia.ToString() + "|"
                    + provincia.NombreDeProvincia + "|"
                    + provincia.CodigoDeRegionNacional.ToString();
                writer.WriteLine(linea);
            }

        }

        //CONSTRUCTOR
        public Provincia(int codigoDeProvincia, string nombreDeProvincia, int codigoDeRegionNacional)
        {
            CodigoDeProvincia = codigoDeProvincia;
            NombreDeProvincia = nombreDeProvincia;
            CodigoDeRegionNacional = codigoDeRegionNacional;
            LocalidadesAsociadas = Localidad.ListarLocalidadesAsociadas((codigoDeProvincia));
        }
    }
}
