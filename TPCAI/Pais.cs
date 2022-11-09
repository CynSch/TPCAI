using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Pais
    {


        //Propiedades
        public int CodigoDePais { get; private set; }
        public string NombreDePais { get; set; }
        public int CodigoDeRegionMundial { get; set; }

        static internal List<Pais> TodosLosPaises { get; set; }


        //Métodos
        internal static void ListarPaises() //Lista los paises del txt
        {
            //lee los paises del txt
         
            var archivoPaises = new StreamReader("Paises.txt");
            while (!archivoPaises.EndOfStream)

            {
                string proximaLinea = archivoPaises.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var pais = new Pais();
                pais.CodigoDePais = int.Parse(datosSeparados[0]);
                pais.NombreDePais = datosSeparados[1];
                pais.CodigoDeRegionMundial = int.Parse(datosSeparados[2]);

                //agrego a lista
                Pais.TodosLosPaises.Add(pais);
            }

        }

        internal static int BuscarCodigoRegionXPais(int codigopais)
        {
            int codigoregion = 0;
            foreach (Pais pais in TodosLosPaises)
            {
                if(pais.CodigoDePais == codigopais)
                {
                    codigoregion = pais.CodigoDeRegionMundial;
                }
            }
            return codigoregion;
        }

        //Falta metodo de carga desde archivo
    }
}
