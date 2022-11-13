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

        static internal List<Pais> TodosLosPaises = new List<Pais>();


        //Métodos
        internal static void ListarPaises() //Lista los paises del txt
        {
            //lee los paises del txt

            var archivoPaises = new StreamReader($@"{Environment.CurrentDirectory}\Paises.txt");
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

            archivoPaises.Close();

        }

        internal static int BuscarCodigoRegionXPais(int codigopais)
        {
            int codigoregion = 0;
            foreach (Pais pais in TodosLosPaises)
            {
                if (pais.CodigoDePais == codigopais)
                {
                    codigoregion = pais.CodigoDeRegionMundial;
                }
            }
            return codigoregion;
        }



        public static Pais BuscarPais(int codigoPais)
        {
            return Pais.TodosLosPaises.Find(pais => pais.CodigoDePais == codigoPais);
        }

        internal static void GrabarPaisesEnArchivo()
        {
            //Actualiza archivo

            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Paises.txt");

            foreach (Pais p in TodosLosPaises)
            {
                //cod pais, nombre pais, cod region mundial
                string linea = p.CodigoDePais + "|"
                    + p.NombreDePais + "|"
                    + p.CodigoDeRegionMundial;
                writer.WriteLine(linea);
            }
            writer.Close();
        }

        internal static void CrearArchivo()
        {
            //Creo una lista para guardar las facturas
            List<Pais> PaisesACargar = new List<Pais>();


            //Creo objetos 
            var e1 = new Pais();
            e1.CodigoDePais = 1;
            e1.NombreDePais = "Brasil";
            e1.CodigoDeRegionMundial = 1;

            var e2 = new Pais();
            e2.CodigoDePais = 2;
            e2.NombreDePais = "Bolivia";
            e2.CodigoDeRegionMundial = 1;

            var e3 = new Pais();
            e3.CodigoDePais = 3;
            e3.NombreDePais = "Chile";
            e3.CodigoDeRegionMundial = 1;

            var e4 = new Pais();
            e4.CodigoDePais = 4;
            e4.NombreDePais = "Paraguay";
            e4.CodigoDeRegionMundial = 1;

            var e5 = new Pais();
            e5.CodigoDePais = 5;
            e5.NombreDePais = "Uruguay";
            e5.CodigoDeRegionMundial = 1;

            var e6 = new Pais();
            e6.CodigoDePais = 6;
            e6.NombreDePais = "Colombia";
            e6.CodigoDeRegionMundial = 2;

            var e7 = new Pais();
            e7.CodigoDePais = 7;
            e7.NombreDePais = "Costa Rica";
            e7.CodigoDeRegionMundial = 2;

            var e8 = new Pais();
            e8.CodigoDePais = 8;
            e8.NombreDePais = "Venezuela";
            e8.CodigoDeRegionMundial = 2;

            var e9 = new Pais();
            e9.CodigoDePais = 9;
            e9.NombreDePais = "Canada";
            e9.CodigoDeRegionMundial = 3;

            var e10 = new Pais();
            e10.CodigoDePais = 10;
            e10.NombreDePais = "Estados Unidos";
            e10.CodigoDeRegionMundial = 3;

            var e11 = new Pais();
            e11.CodigoDePais = 11;
            e11.NombreDePais = "Mexico";
            e11.CodigoDeRegionMundial = 3;

            var e12 = new Pais();
            e12.CodigoDePais = 12;
            e12.NombreDePais = "Belgica";
            e12.CodigoDeRegionMundial = 4;

            var e13 = new Pais();
            e13.CodigoDePais = 13;
            e13.NombreDePais = "Bielorrusia";
            e13.CodigoDeRegionMundial = 4;

            var e14 = new Pais();
            e14.CodigoDePais = 14;
            e14.NombreDePais = "Israel";
            e14.CodigoDeRegionMundial = 5;

            var e15 = new Pais();
            e15.CodigoDePais = 15;
            e15.NombreDePais = "Japón";
            e15.CodigoDeRegionMundial = 5;

            var e16 = new Pais();
            e16.CodigoDePais = 16;
            e16.NombreDePais = "Jordania";
            e16.CodigoDeRegionMundial = 5;


            //Agrego los paises en la lista
            PaisesACargar.Add(e1);
            PaisesACargar.Add(e2);
            PaisesACargar.Add(e3);
            PaisesACargar.Add(e4);
            PaisesACargar.Add(e5);
            PaisesACargar.Add(e6);
            PaisesACargar.Add(e7);
            PaisesACargar.Add(e8);
            PaisesACargar.Add(e9);
            PaisesACargar.Add(e10);
            PaisesACargar.Add(e11);
            PaisesACargar.Add(e12);
            PaisesACargar.Add(e13);
            PaisesACargar.Add(e14);
            PaisesACargar.Add(e15);
            PaisesACargar.Add(e16);



            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Paises.txt");
            foreach (Pais e in PaisesACargar)
            {

                string linea = e.CodigoDePais + "|" + e.NombreDePais + "|" + e.CodigoDeRegionMundial;
                writer.WriteLine(linea);
            }
            writer.Close();
        }
    }
}
