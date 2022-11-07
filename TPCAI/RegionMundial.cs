using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class RegionMundial
    {
        // propiedades 
        public int CodigoDeRegionMundial { get; set; }
        public string NombreDeRegionMundial { get; set; }
        public  List<Pais> PaisesAsociados { get; set; }

        static private List<RegionMundial> LstRegionesMundiales { get; set; }

        //construtor
        public RegionMundial(int codigoDeRegionMundial, string nombreDeRegionMundial)
        {
            CodigoDeRegionMundial = codigoDeRegionMundial;
            NombreDeRegionMundial = nombreDeRegionMundial;
           // PaisesAsociados = Pais.
        }
     
        // Metodos
        public void ListarRegiones()
        {
            //Cargo las regiones mundiales desde el archivo a la lista RegionesMundiales para que esten en memoria
            var archivoRegionMundial = new StreamReader("TextFile1.txt");
            while (!archivoRegionMundial.EndOfStream)
            {
                string proximaLinea = archivoRegionMundial.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                RegionMundial regionMundial = new RegionMundial();
                regionMundial.CodigoDeRegionMundial = int.Parse(datosSeparados[0]);
                regionMundial.NombreDeRegionMundial = datosSeparados[1];

                RegionMundial.LstRegionesMundiales.Add(regionMundial);
              

            }
        }

    }
}
