using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPCAI
{
    internal class Factura
    {

        //Propiedades

        public int NroFactura { get; private set; }
        public decimal Monto { get; set; }
        public DateTime FechaFactura { get; set; }

        public bool EstaPaga { get; set; }
        public long CUIT { get; set; }
        public List<SolicitudDeOrden> OrdenesAsociadas = new List<SolicitudDeOrden>();
    
        static public List<Factura> FacturasExistentes = new List<Factura>();
    
        //Métodos
        internal static void ListarFacturas() //Lista las sucursales del txt
        {
            //lee las facturas del txt

            var archivoFacturas = new StreamReader("Facturas.txt");
            while (!archivoFacturas.EndOfStream)

            {
                string proximaLinea = archivoFacturas.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var factura = new Factura();
                factura.NroFactura = int.Parse(datosSeparados[0]);
                factura.Monto = decimal.Parse(datosSeparados[1]);
                factura.FechaFactura = DateTime.Parse(datosSeparados[2]);
               // factura.EstaPaga parse a bool.
                factura.CUIT = long.Parse(datosSeparados[4]);

                //agrego a lista
                Factura.FacturasExistentes.Add(factura);

            }
        }

        internal static void GrabarFacturasEnArchivo()
        {
            //Actualiza archivo

            StreamWriter writer = File.CreateText("Facturas.txt");

            foreach (Factura f in FacturasExistentes)
            {

                string linea = f.NroFactura + "|"
                    + f.Monto + "|"
                    + f.FechaFactura + "|" + f.EstaPaga + "|"
                    + f.CUIT;
                writer.WriteLine(linea);
            }
            writer.Close();
        }


        internal static void CrearArchivo()
        {
            //Creo una lista para guardar las facturas
            List<Factura> FacturasACargar = new List<Factura>();


            //Creo objetos 
            var e1 = new Factura();
            e1.NroFactura = 6000;
            e1.Monto = 3500;
            e1.FechaFactura = new DateTime(2022,1,1);
            e1.EstaPaga = true;
            e1.CUIT = 27420744817;

            var e2 = new Factura();
            e2.NroFactura = 6001;
            e2.Monto = 4200;
            e2.FechaFactura = new DateTime(2022,1,5);
            e2.EstaPaga = true;
            e2.CUIT = 27430742117;

            var e3 = new Factura();
            e3.NroFactura = 6002;
            e3.Monto = 5250;
            e3.FechaFactura = new DateTime(2022, 1, 5);
            e3.EstaPaga = false;
            e3.CUIT = 27420744817;

            var e4 = new Factura();
            e4.NroFactura = 6003;
            e4.Monto = 8250;
            e4.FechaFactura = new DateTime(2022, 1, 7);
            e4.EstaPaga = true;
            e4.CUIT = 27430742117;

            var e5 = new Factura();
            e5.NroFactura = 6004;
            e5.Monto = 11250;
            e5.FechaFactura = new DateTime(2022, 1, 29);
            e5.EstaPaga = true;
            e5.CUIT = 27430742117;


            var e6 = new Factura();
            e6.NroFactura = 6005;
            e6.Monto = 14250;
            e6.FechaFactura = new DateTime(2022, 2, 3);
            e6.EstaPaga = false;
            e6.CUIT = 27430742117;

            var e7 = new Factura();
            e7.NroFactura = 6006;
            e7.Monto = 123000;
            e7.FechaFactura = new DateTime(2022, 2, 4);
            e7.EstaPaga = true;
            e7.CUIT = 27420744817;

            var e8 = new Factura();
            e8.NroFactura = 6007;
            e8.Monto = 24300;
            e8.FechaFactura = new DateTime(2022, 5, 8);
            e8.EstaPaga = true;
            e8.CUIT = 27420744817;

            var e9 = new Factura();
            e9.NroFactura = 6008;
            e9.Monto = 81000;
            e9.FechaFactura = new DateTime(2022, 6, 1);
            e9.EstaPaga = false;
            e9.CUIT = 27430742117;

            var e10 = new Factura();
            e10.NroFactura = 6009;
            e10.Monto = 350;
            e10.FechaFactura = new DateTime(2022, 6, 7);
            e10.EstaPaga = false;
            e10.CUIT = 23949330290;

            var e11 = new Factura();
            e11.NroFactura = 6010;
            e11.Monto = 2000;
            e11.FechaFactura = new DateTime(2022, 6, 8);
            e11.EstaPaga = false;
            e11.CUIT = 27430742117;

            var e12 = new Factura();
            e12.NroFactura = 6011;
            e12.Monto = 3000;
            e12.FechaFactura = new DateTime(2022, 6, 9);
            e12.EstaPaga = true;
            e12.CUIT = 23949330290;

            var e13 = new Factura();
            e13.NroFactura = 6031;
            e13.Monto = 45000;
            e13.FechaFactura = new DateTime(2022, 7, 8);
            e13.EstaPaga = true;
            e13.CUIT = 27430742117;

            var e14 = new Factura();
            e14.NroFactura = 6032;
            e14.Monto = 10;
            e14.FechaFactura = new DateTime(2022, 8, 8);
            e14.EstaPaga = false;
            e14.CUIT = 23949330290;

            var e15 = new Factura();
            e15.NroFactura = 6033;
            e15.Monto = 10;
            e15.FechaFactura = new DateTime(2022, 10, 10);
            e15.EstaPaga = true;
            e15.CUIT = 27430742117;


            var e16 = new Factura();
            e16.NroFactura = 6034;
            e16.Monto = 22009;
            e16.FechaFactura = new DateTime(2022, 11, 10);
            e16.EstaPaga = true;
            e16.CUIT = 23949330290;


            var e17 = new Factura();
            e17.NroFactura = 6035;
            e17.Monto = 4590;
            e17.FechaFactura = new DateTime(2022, 11, 11);
            e17.EstaPaga = true;
            e17.CUIT = 23949330290;


            //Agrego las facturas en la lista
            FacturasACargar.Add(e1);
            FacturasACargar.Add(e2);
            FacturasACargar.Add(e3);
            FacturasACargar.Add(e4);
            FacturasACargar.Add(e5);
            FacturasACargar.Add(e6);
            FacturasACargar.Add(e7);
            FacturasACargar.Add(e8);
            FacturasACargar.Add(e9);
            FacturasACargar.Add(e10);
            FacturasACargar.Add(e11);
            FacturasACargar.Add(e12);
            FacturasACargar.Add(e13);
            FacturasACargar.Add(e14);
            FacturasACargar.Add(e15);
            FacturasACargar.Add(e16);
            FacturasACargar.Add(e17);


            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText("Facturas.txt");
            foreach (Factura e in FacturasACargar)
            {

                string linea = e.NroFactura + "|" + e.Monto + "|" + e.FechaFactura + "|" + e.EstaPaga + "|" + e.CUIT;
                writer.WriteLine(linea);
            }
            writer.Close();
        }
    }
    }
