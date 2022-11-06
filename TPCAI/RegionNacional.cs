using System;
using System.Collections.Generic;
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

        public static void ListarRegiones()
        {
            //Muestra las Regiones.
        }
    }
}
