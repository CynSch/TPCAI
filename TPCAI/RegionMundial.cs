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

       // public  List<Pais> PaisesAsociados { get; set; }

        public List<RegionMundial> LstRegionesMundiales { get; set; }

        //construtor
        public RegionMundial(int codigoDeRegionMundial, string nombreDeRegionMundial)
        {
            CodigoDeRegionMundial = codigoDeRegionMundial;
            NombreDeRegionMundial = nombreDeRegionMundial;
           // PaisesAsociados = Pais.
        }

        //constructor vacio
        public RegionMundial() { }
     
        // Metodos
        public void CargarRegionesMundiales()
        {
            //Cargo las regiones mundiales desde el archivo a la lista RegionesMundiales para que esten en memoria
            var archivoRegionMundial = new StreamReader("RegionesMundiales.txt");
            while (!archivoRegionMundial.EndOfStream)
            {
                string proximaLinea = archivoRegionMundial.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                var regionMundial = new RegionMundial(int.Parse(datosSeparados[0]), datosSeparados[1]); //con el constructor
               
                LstRegionesMundiales.Add(regionMundial);

            }
        }
 

    }
}
