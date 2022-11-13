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

            //AGREGAR LAS FALTANTES


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

