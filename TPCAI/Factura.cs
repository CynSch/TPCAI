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

            var archivoFacturas = new StreamReader($@"{Environment.CurrentDirectory}\Facturas.txt");
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

            archivoFacturas.Close();
        }

        internal static void GrabarFacturasEnArchivo()
        {
            //Actualiza archivo

            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Facturas.txt");

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



            var e1 = new Factura();
            e1.NroFactura = 6000;
            e1.Monto = 9650;
            e1.FechaFactura = new DateTime(2022, 6, 1);
            e1.EstaPaga = true;
            e1.CUIT = 27420744817;

            var e2 = new Factura();
            e2.NroFactura = 6001;
            e2.Monto = 6350;
            e2.FechaFactura = new DateTime(2022, 7, 2);
            e2.EstaPaga = false;
            e2.CUIT = 27430742117;

            var e3 = new Factura();
            e3.NroFactura = 6002;
            e3.Monto = 5250;
            e3.FechaFactura = new DateTime(2022, 7, 2);
            e3.EstaPaga = true;
            e3.CUIT = 27420744817;

            var e4 = new Factura();
            e4.NroFactura = 6003;
            e4.Monto = 8250;
            e4.FechaFactura = new DateTime(2022, 1, 7);
            e4.EstaPaga = false;
            e4.CUIT = 27430742117;

            var e5 = new Factura();
            e5.NroFactura = 6004;
            e5.Monto = 28440;
            e5.FechaFactura = new DateTime(2022, 7, 3);
            e5.EstaPaga = true;
            e5.CUIT = 20111111111;

            var e6 = new Factura();
            e6.NroFactura = 6005;
            e6.Monto = 78500;
            e6.FechaFactura = new DateTime(2022, 8, 3);
            e6.EstaPaga = false;
            e6.CUIT = 23949330290;

            var e7 = new Factura();
            e7.NroFactura = 6006;
            e7.Monto = 13725;
            e7.FechaFactura = new DateTime(2022, 11, 1);
            e7.EstaPaga = false;
            e7.CUIT = 23949330290;

            //Agrego en la lista
            FacturasACargar.Add(e1);
            FacturasACargar.Add(e2);
            FacturasACargar.Add(e3);
            FacturasACargar.Add(e4);
            FacturasACargar.Add(e5);
            FacturasACargar.Add(e6);
            FacturasACargar.Add(e7);

            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Facturas.txt");
            foreach (Factura e in FacturasACargar)
            {
                //numOrden|CUIT|EsUrgente|Fecha|importe|cod_estado|nroFactura"
                string linea = e.NroFactura + "|" + e.Monto + "|" + e.FechaFactura + "|" + e.EstaPaga + "|" + e.CUIT;
                writer.WriteLine(linea);
            }
            writer.Close();
        }
    }

}
