using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPCAI
{
    internal class Sucursal
    {
        //Propiedades
        public int NroSucursal { get; private set; }
        public Localidad Localidad { get; set; }
        public string Direccion { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }

        static internal List<Sucursal> TodasLasSucursales = new List<Sucursal>();


        //Métodos
        internal static void ListarSucursales() //Lista las sucursales del txt
        {
            //lee las sucursales del txt

            var archivoSucursal = new StreamReader($@"{Environment.CurrentDirectory}\Sucursales.txt");
            if (TodasLasSucursales.Count > 0)
            {
                TodasLasSucursales.Clear();
            }

            while (!archivoSucursal.EndOfStream)

            {
                string proximaLinea = archivoSucursal.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var sucursal = new Sucursal();
                sucursal.NroSucursal = int.Parse(datosSeparados[0]);
                sucursal.CodigoDeLocalidad = int.Parse(datosSeparados[1]);
                sucursal.Direccion = datosSeparados[2];

                //agrego a lista
                Sucursal.TodasLasSucursales.Add(sucursal);
            }
            archivoSucursal.Close();
        }
        public static List<Sucursal> ListarSucursalesAsociadas(int codigoDeProvincia, int codigoDeLocalidad)
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            foreach (Sucursal sucursal in sucursales)
            {
                if (sucursal.CodigoDeProvincia == codigoDeProvincia && sucursal.CodigoDeLocalidad == codigoDeLocalidad)
                {
                    sucursales.Add(sucursal);
                }
            }

            return sucursales;
        }

        public static Sucursal BuscarSucursal(int codigoSucursal)
        {
            return Sucursal.TodasLasSucursales.Find(sucursal => sucursal.NroSucursal == codigoSucursal);

        }

        public static string BuscarDireccion(int codigoSucursal)
        {
            string direccion = "";

            foreach (Sucursal suc in TodasLasSucursales)
            {
                if(suc.NroSucursal == codigoSucursal)
                {
                    direccion = suc.Direccion;
                    break;
                }
            }
            return direccion;
        }

        internal static void GrabarSucursalEnArchivo()
        {
            //Actualiza archivo

            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Sucursales.txt");

            foreach (Sucursal s in TodasLasSucursales)
            {

                string linea = s.NroSucursal + "|"
                    + s.CodigoDeLocalidad + "|"
                    + s.Direccion;
                writer.WriteLine(linea);
            }
            writer.Close();
        }

        internal static void CrearArchivo()
        {
            //Creo una lista para guardar las facturas
            List<Sucursal> SucursalesACargar = new List<Sucursal>();


            //Creo objetos 
            var e1 = new Sucursal();
            e1.NroSucursal = 1;
            e1.CodigoDeLocalidad = 1;
            e1.Direccion = "Estanislao Zeballos 2356";

            var e2 = new Sucursal();
            e2.NroSucursal = 2;
            e2.CodigoDeLocalidad = 2;
            e2.Direccion = "Monroe 4402";

            var e3 = new Sucursal();
            e3.NroSucursal = 3;
            e3.CodigoDeLocalidad = 3;
            e3.Direccion = "Oliden 110";

            var e4 = new Sucursal();
            e4.NroSucursal = 4;
            e4.CodigoDeLocalidad = 4;
            e4.Direccion = "Gral Belgrano 1900";

            var e5 = new Sucursal();
            e5.NroSucursal = 5;
            e5.CodigoDeLocalidad = 5;
            e5.Direccion = "Benjamín Zorrilla 2291";

            var e6 = new Sucursal();
            e6.NroSucursal = 6;
            e6.CodigoDeLocalidad = 6;
            e6.Direccion = "Manuel Estrada 880";

            var e7 = new Sucursal();
            e7.NroSucursal = 7;
            e7.CodigoDeLocalidad = 7;
            e7.Direccion = "Coronado 1890";

            var e8 = new Sucursal();
            e8.NroSucursal = 8;
            e8.CodigoDeLocalidad = 8;
            e8.Direccion = "Av. Maipú 1890";

            var e9 = new Sucursal();
            e9.NroSucursal = 9;
            e9.CodigoDeLocalidad = 9;
            e9.Direccion = "Miller 203";

            var e10 = new Sucursal();
            e10.NroSucursal = 10;
            e10.CodigoDeLocalidad = 10;
            e10.Direccion = "2 de Mayo 4023";

            var e11 = new Sucursal();
            e11.NroSucursal = 11;
            e11.CodigoDeLocalidad = 11;
            e11.Direccion = "Riobamba 903";

            var e12 = new Sucursal();
            e12.NroSucursal = 12;
            e12.CodigoDeLocalidad = 12;
            e12.Direccion = "Pergamino 103";

            var e13 = new Sucursal();
            e13.NroSucursal = 13;
            e13.CodigoDeLocalidad = 13;
            e13.Direccion = "Oyuela 876";

            var e14 = new Sucursal();
            e14.NroSucursal = 14;
            e14.CodigoDeLocalidad = 14;
            e14.Direccion = "Calle 20 777";

            var e15 = new Sucursal();
            e15.NroSucursal = 15;
            e15.CodigoDeLocalidad = 15;
            e15.Direccion = "Nicolas Avellaneda 32";

            var e16 = new Sucursal();
            e16.NroSucursal = 16;
            e16.CodigoDeLocalidad = 16;
            e16.Direccion = "Jose Hernandez 1408";

            var e17 = new Sucursal();
            e17.NroSucursal = 17;
            e17.CodigoDeLocalidad = 17;
            e17.Direccion = "Matienzo 670";

            var e18 = new Sucursal();
            e18.NroSucursal = 18;
            e18.CodigoDeLocalidad = 18;
            e18.Direccion = "Juan C Vera 6582";

            var e19 = new Sucursal();
            e19.NroSucursal = 19;
            e19.CodigoDeLocalidad = 19;
            e19.Direccion = "Condor II 427";

            var e20 = new Sucursal();
            e20.NroSucursal = 20;
            e20.CodigoDeLocalidad = 20;
            e20.Direccion = "Las Orquideas 1225";

            var e21 = new Sucursal();
            e21.NroSucursal = 21;
            e21.CodigoDeLocalidad = 21;
            e21.Direccion = "Roma 3842";
            
            var e22 = new Sucursal();
            e22.NroSucursal = 22;
            e22.CodigoDeLocalidad = 22;
            e22.Direccion = "C. M. Garcia 715";

            var e23 = new Sucursal();
            e23.NroSucursal = 23;
            e23.CodigoDeLocalidad = 23;
            e23.Direccion = "Corso 624";

            var e24 = new Sucursal();
            e24.NroSucursal = 24;
            e24.CodigoDeLocalidad = 24;
            e24.Direccion = "Libertad 8900";

            var e25 = new Sucursal();
            e25.NroSucursal = 25;
            e25.CodigoDeLocalidad = 25;
            e25.Direccion = "Gral Urquiza 1290";

            var e26 = new Sucursal();
            e26.NroSucursal = 26;
            e26.CodigoDeLocalidad = 26;
            e26.Direccion = "C. Los Colonos 512";

            //Agrego los paises en la lista
            SucursalesACargar.Add(e1);
            SucursalesACargar.Add(e2);
            SucursalesACargar.Add(e3);
            SucursalesACargar.Add(e4);
            SucursalesACargar.Add(e5);
            SucursalesACargar.Add(e6);
            SucursalesACargar.Add(e7);
            SucursalesACargar.Add(e8);
            SucursalesACargar.Add(e9);
            SucursalesACargar.Add(e10);
            SucursalesACargar.Add(e11);
            SucursalesACargar.Add(e12);
            SucursalesACargar.Add(e13);
            SucursalesACargar.Add(e14);
            SucursalesACargar.Add(e15);
            SucursalesACargar.Add(e16);
            SucursalesACargar.Add(e17);
            SucursalesACargar.Add(e18);
            SucursalesACargar.Add(e19);
            SucursalesACargar.Add(e20);
            SucursalesACargar.Add(e21);
            SucursalesACargar.Add(e22);
            SucursalesACargar.Add(e23);
            SucursalesACargar.Add(e24);
            SucursalesACargar.Add(e25);
            SucursalesACargar.Add(e26);

            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Sucursales.txt");
            foreach (Sucursal e in SucursalesACargar)
            {

                string linea = e.NroSucursal + "|" + e.CodigoDeLocalidad + "|" + e.Direccion;
                writer.WriteLine(linea);
            }
            writer.Close();
        }
    }
}

