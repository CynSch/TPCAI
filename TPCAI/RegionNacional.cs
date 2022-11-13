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
        public int CodigoDeRegionNacional { get; set; }
        public string NombreDeRegionNacional { get; set; }

        public List<Provincia> Provincias { get; set; }
        static internal List<RegionNacional> LstRegionesNacionales = new List<RegionNacional>();

        public static void ListarRegiones()
        {
            //Cargo las regiones nacionales desde el archivo a la lista RegionesNacionales para que esten en memoria
            var archivoRegionNacional = new StreamReader($@"{Environment.CurrentDirectory}\RegionesNacionales.txt");
            while (!archivoRegionNacional.EndOfStream)
            {
                string proximaLinea = archivoRegionNacional.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                var regionNacional = new RegionNacional(int.Parse(datosSeparados[0]),datosSeparados[1]);
                
                RegionNacional.LstRegionesNacionales.Add(regionNacional);


            }
        }
        internal static void CrearArchivo()
        {
            List<RegionNacional> listaACargar = new List<RegionNacional>();

            var lst1 = new RegionNacional(1, "NoroesteArgentino");
            var lst2 = new RegionNacional(2, "NoresteArgentino");
            var lst3 = new RegionNacional(3, "Cuyo");
            var lst4 = new RegionNacional(4, "Centro");
            var lst5 = new RegionNacional(5, "Patagonia");

            listaACargar.Add(lst1);
            listaACargar.Add(lst2);
            listaACargar.Add(lst3);
            listaACargar.Add(lst4);
            listaACargar.Add(lst5);

            StreamWriter writerRegionNacional = File.CreateText($@"{Environment.CurrentDirectory}\RegionesNacionales.txt");

            foreach (RegionNacional rn in listaACargar)
            {
                string lineaRegionMundial = rn.CodigoDeRegionNacional + "|"
                    + rn.NombreDeRegionNacional;

                writerRegionNacional.WriteLine(lineaRegionMundial);
            }

            writerRegionNacional.Close();



        }

        public static RegionNacional BuscarRegionNacional(int codigoRegNac)
        {
            return RegionNacional.LstRegionesNacionales.Find(regionNacional => regionNacional.CodigoDeRegionNacional == codigoRegNac);

        }
    }
}
