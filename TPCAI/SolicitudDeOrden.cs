using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    internal class SolicitudDeOrden
    {
        //Constructor

        //Propiedades
        public int NumeroDeOrden { get; private set; }
        public int IDDeServicio { get; set; }
        public long CUITCliente { get; set; }
        public bool EsUrgente { get; set; }
        public int CodigoDeEstado { get; set; }
        public DateTime Fecha { get; private set; }
        public decimal Importe { get; set; }
        public int NumeroDeFactura { get; set; }

        static internal List<SolicitudDeOrden> SolicitudesExistentes = new List<SolicitudDeOrden>();

        //Métodos
        internal static void CargarSolicitudesExistentes()
        //Saca los estados disponibles del archivo "Solicitudes.txt" y los mete en la lista SolicitudesExistentes
        {
            //El archivo tiene el formato:
            //numOrden|CUIT|EsUrgente|Fecha|importe|cod_estado|nroFactura"

            //Primero vacío la lista, por las dudas.
            if (SolicitudesExistentes.Count > 0)
            {
                SolicitudesExistentes.Clear();
            }

            //reocrro linea por linea del archivo, y voy agregando a la lista de solicitudes existentes. 
            var archivoSolicitudes = new StreamReader("Solicitudes.txt");
            while (!archivoSolicitudes.EndOfStream)
            {
                string proximaLinea = archivoSolicitudes.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var solicitud = new SolicitudDeOrden();
                solicitud.NumeroDeOrden = int.Parse(datosSeparados[0]);
                solicitud.CUITCliente = long.Parse(datosSeparados[1]);
                solicitud.EsUrgente = bool.Parse(datosSeparados[2]);
                solicitud.Fecha = DateTime.Parse(datosSeparados[3]);
                solicitud.Importe = decimal.Parse(datosSeparados[4]);
                solicitud.CodigoDeEstado = int.Parse(datosSeparados[5]);
                solicitud.NumeroDeFactura = int.Parse(datosSeparados[6]);

                //Agrego la solicitud a la lista.
                SolicitudDeOrden.SolicitudesExistentes.Add(solicitud);

                archivoSolicitudes.Close();
            }
        }

        public static int GenerarNumeroDeOrden()
        {
            //1. revisa la lista de solicitudes
            //2. Busca el número de orden mayor
            //3. le suma 1 a ese número
            int NumeroGenerado = 0;
            int UltimoNumeroDeOrden = 0;

            foreach(SolicitudDeOrden sol in SolicitudesExistentes)
            {
                if (sol.NumeroDeOrden > UltimoNumeroDeOrden)
                {
                    UltimoNumeroDeOrden = sol.NumeroDeOrden;
                }
            }
            NumeroGenerado = UltimoNumeroDeOrden + 1;
            return NumeroGenerado;
        }

        public static SolicitudDeOrden BuscarOrdenDeServicio(int NumDeOrdenABuscar)
        {
            return SolicitudesExistentes.Find(solicitud => solicitud.NumeroDeOrden == NumDeOrdenABuscar);
        }

        public static List<SolicitudDeOrden> ListarOrdenesPendientesDeFacturacion(long cuit_cliente)
        //Devuelve una lista de órdenes pendientes de facturación
        {
            //Creo una lista vacía que sirva para almacenar las órdenes pendientes de facturacion de un cliente
            List<SolicitudDeOrden> OrdenesPendientesDeFacturacion = new List<SolicitudDeOrden>();

            //Pongo en la lista aquellas órdenes del cliente que tienen factura=0
            foreach (SolicitudDeOrden sol in SolicitudesExistentes)
            {
                if (sol.CUITCliente == cuit_cliente && sol.NumeroDeFactura == 0)
                {
                    OrdenesPendientesDeFacturacion.Add(sol);
                }
            }

            return OrdenesPendientesDeFacturacion;
        }
        public static string BuscarEstadoDeOrden(int NumDeOrdenABuscar)
        //Devuelve una string con el estado de la orden. 
        {
            //Creo un bool para ver si existe la orden que se quiere buscar. 
            int codEstadoDeLaOrden = 0;
            string EstadoDeLaOrden = "";
            bool ordenExiste = false;
            //SolicitudDeOrden ordenEncontrada;

            do
            {
                foreach (SolicitudDeOrden sol in SolicitudesExistentes)
                {
                    if (sol.NumeroDeOrden == NumDeOrdenABuscar)
                    {
                        ordenExiste = true;
                        codEstadoDeLaOrden = sol.CodigoDeEstado;
                    }
                }
                if (ordenExiste == false)
                {
                    MessageBox.Show("La orden no existe. Inténtelo nuevamente");
                }
            } while (!ordenExiste);

            if (ordenExiste)
            {
                //Busca en la lista de estados, a cuál corresponde el código del estado de la orden. 
                foreach (EstadoDeOrden estado in EstadoDeOrden.EstadosDisponibles)
                {
                    if (estado.CodigoDeEstado == codEstadoDeLaOrden)
                    {
                        EstadoDeLaOrden = estado.Descripcion;
                    }
                }
            }

            return EstadoDeLaOrden;
        }

        internal static SolicitudDeOrden GrabarNuevaSolicitud(long cUITCliente,bool esUrgente,DateTime fecha,decimal importe)
        //Este método se tiene que ejecutar cuando hacemos click en "confirmar" la solicitud
        //La nueva solicitud se agrega a la lista SolicitudesExistentes
        {
            var nuevaSolicitud = new SolicitudDeOrden();

            nuevaSolicitud.NumeroDeOrden = GenerarNumeroDeOrden();
            nuevaSolicitud.CUITCliente = cUITCliente; //Hay que ver cómo averiguarlo. 
            nuevaSolicitud.EsUrgente = esUrgente;
            nuevaSolicitud.Fecha = fecha;
            nuevaSolicitud.Importe = importe; //El método calcular lo llama el form. 
            nuevaSolicitud.CodigoDeEstado = 1; //Por default, arranca en el estado 1.
            nuevaSolicitud.NumeroDeFactura = 0; //cuando se crea, todavía no está facturado. 

            SolicitudesExistentes.Add(nuevaSolicitud);

            return nuevaSolicitud;
         }

        internal static void GrabarSolicitudesEnArchivo()
        {
            //Grabo las solicitudes desde la lista SolicitudesExistentes en memoria al archivo en caso de que se haya agregado una Solicitud

            StreamWriter writer = File.CreateText("Solicitudes.txt");

            foreach (SolicitudDeOrden sol in SolicitudesExistentes)
            {
                //numOrden|CUIT|EsUrgente|Fecha|importe|cod_estado|nroFactura"
                string linea = sol.NumeroDeOrden + "|"
                    + sol.CUITCliente + "|"
                    + sol.EsUrgente + "|" + sol.Fecha + "|"
                    + sol.Importe + "|" + sol.CodigoDeEstado + "|" + sol.NumeroDeFactura;
                writer.WriteLine(linea);
            }
            writer.Close();
        }
        public List<SolicitudDeOrden> BuscarOrdenesAsociadasAFactura(int num_factura)
        {
            List<SolicitudDeOrden> ordenesAsociadas = new List<SolicitudDeOrden>();

            foreach (SolicitudDeOrden sol in SolicitudesExistentes)
            {
                if (sol.NumeroDeFactura == num_factura)
                {
                    ordenesAsociadas.Add(sol);
                }
            }
            return ordenesAsociadas;
        }
    }
}

