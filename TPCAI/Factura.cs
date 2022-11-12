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

        internal static void GrabarSolicitudesEnArchivo()
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
    }
    }
