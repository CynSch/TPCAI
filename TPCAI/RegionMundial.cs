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

        static internal List<RegionMundial> LstRegionesMundiales = new List<RegionMundial>();

        //construtor
        public RegionMundial(int codigoDeRegionMundial, string nombreDeRegionMundial)
        {
            CodigoDeRegionMundial = codigoDeRegionMundial;
            NombreDeRegionMundial = nombreDeRegionMundial;
        }

        //constructor vacio
        public RegionMundial() { }
     
        // Metodos
        public void CargarRegionesMundiales()
        {
            //Cargo las regiones mundiales desde el archivo a la lista RegionesMundiales para que esten en memoria
            var archivoRegionMundial = new StreamReader($@"{Environment.CurrentDirectory}\RegionesMundiales.txt");
            while (!archivoRegionMundial.EndOfStream)
            {
                string proximaLinea = archivoRegionMundial.ReadLine();

                //Codigo|Nombre

                string[] datosSeparados = proximaLinea.Split('|');
                var regionMundial = new RegionMundial(int.Parse(datosSeparados[0]), datosSeparados[1]); //con el constructor

                LstRegionesMundiales.Add(regionMundial);

            }

            archivoRegionMundial.Close();
        }

        internal static void CrearArchivo()
        {
            List<RegionMundial> listaACargar = new List<RegionMundial>();

            var lst1 = new RegionMundial(1, "Paises Limitrofes");
            var lst2 = new RegionMundial(2, "Resto America Latina");
            var lst3 = new RegionMundial(3, "America Del Norte");
            var lst4 = new RegionMundial(4, "Europa");
            var lst5 = new RegionMundial(5, "Asia");

            listaACargar.Add(lst1);
            listaACargar.Add(lst2);
            listaACargar.Add(lst3);
            listaACargar.Add(lst4);
            listaACargar.Add(lst5);

            StreamWriter writerRegionMundial = File.CreateText($@"{Environment.CurrentDirectory}\RegionesMundiales.txt");

            foreach (RegionMundial rm in listaACargar)
            {
                string lineaRegionMundial = rm.CodigoDeRegionMundial + "|"
                    + rm.NombreDeRegionMundial;

                writerRegionMundial.WriteLine(lineaRegionMundial);
            }

            writerRegionMundial.Close();



        }

        public static RegionMundial BuscarRegionMundial(int codigoRegionMundial)
        {
            return RegionMundial.LstRegionesMundiales.Find(regionMundial => regionMundial.CodigoDeRegionMundial == codigoRegionMundial);
        }


    }
}
