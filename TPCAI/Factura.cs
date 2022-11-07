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
        public ClienteCorporativo ClienteCorporativo { get; set; }
        public int CUIT { get; set; }
        static internal List<SolicitudDeOrden> OrdenesAsociadas { get; set; }

        //SOY MELU!
        //AGREGUÉ UNA LISTA DE FACTURAS. EN EL MÉTODO LISTAR FACTURAS,
        //FUI AGREGANDO CADA LÍNEA DEL ARCHIVO A ESTA LISTA CREADA.> 
       //También agregué el atributo "CUIT" como para ver rápidamente de qué cliente es la factura. 
        static public List<Factura> FacturasExistentes { get; set; }
        //

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
               // factura.ClienteCorporativo = datosSeparados[3]; VER FLOR

                Factura.FacturasExistentes.Add(factura);

            }
        }
}
    }
