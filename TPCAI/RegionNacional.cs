using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class RegionNacional
    {
        public RegionNacional(int codigoDeRegionNacional, string nombreDeRegionNacional)
        {
            CodigoDeRegionNacional = codigoDeRegionNacional;
            NombreDeRegionNacional = nombreDeRegionNacional;

        }
        //constructor vacio
        public RegionNacional () { }

        public int CodigoDeRegionNacional { get; set; }
        public string NombreDeRegionNacional { get; set; }

        public List<Provincia> Provincias { get; set; }
        static internal List<RegionNacional> LstRegionesNacionales { get; set; }

        public static void ListarRegiones()
        {
            //Cargo las regiones nacionales desde el archivo a la lista RegionesNacionales para que esten en memoria
            var archivoRegionNacional = new StreamReader("RegionesNacionales.txt");
            while (!archivoRegionNacional.EndOfStream)
            {
                string proximaLinea = archivoRegionNacional.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                var regionNacional = new RegionNacional();
                regionNacional.CodigoDeRegionNacional = int.Parse(datosSeparados[0]);
                regionNacional.NombreDeRegionNacional = datosSeparados[1];

                RegionNacional.LstRegionesNacionales.Add(regionNacional);


            }
        }
    }
}
