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
        public DateTime Fecha { get; set; }
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
            var archivoSolicitudes = new StreamReader($@"{Environment.CurrentDirectory}\Solicitudes.txt");
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
            }
            archivoSolicitudes.Close();
        }

        public static int GenerarNumeroDeOrden()
        {
            //1. revisa la lista de solicitudes
            //2. Busca el número de orden mayor
            //3. le suma 1 a ese número
            int NumeroGenerado = 0;
            int UltimoNumeroDeOrden = 0;

            foreach (SolicitudDeOrden sol in SolicitudesExistentes)
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

        internal static SolicitudDeOrden GrabarNuevaSolicitud(long cUITCliente, bool esUrgente, DateTime fecha, decimal importe)
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

            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Solicitudes.txt");

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

        internal static void CrearArchivo()
        {
            //Creo una lista para guardar las solicitudes
            List<SolicitudDeOrden> solicitudesACargar = new List<SolicitudDeOrden>();

            //YYYY, MM, DD
            //Creo objetos "solicitud"
            var sol1 = new SolicitudDeOrden();
            sol1.NumeroDeOrden = 100;
            sol1.CUITCliente = 27420744817;
            sol1.EsUrgente = false;
            sol1.Fecha = new DateTime(2021, 5, 1);
            sol1.Importe = 500;
            sol1.CodigoDeEstado = 1;
            sol1.NumeroDeFactura = 0;

            var sol2 = new SolicitudDeOrden();
            sol2.NumeroDeOrden = 101;
            sol2.CUITCliente = 27430742117;
            sol2.EsUrgente = true;
            sol2.Fecha = new DateTime(2022, 6, 2);
            sol2.Importe = 2000;
            sol2.CodigoDeEstado = 2;
            sol2.NumeroDeFactura = 6010;

            var sol3 = new SolicitudDeOrden();
            sol3.NumeroDeOrden = 102;
            sol3.CUITCliente = 27430742117;
            sol3.EsUrgente = true;
            sol3.Fecha = new DateTime(2022, 6, 7);
            sol3.Importe = 3000;
            sol3.CodigoDeEstado = 3;
            sol3.NumeroDeFactura = 6011;

            var sol4 = new SolicitudDeOrden();
            sol4.NumeroDeOrden = 103;
            sol4.CUITCliente = 27455742129;
            sol4.EsUrgente = false;
            sol4.Fecha = new DateTime(2022, 10, 11);
            sol4.Importe = 45000;
            sol4.CodigoDeEstado = 4;
            sol4.NumeroDeFactura = 6031;

            var sol5 = new SolicitudDeOrden();
            sol5.NumeroDeOrden = 104;
            sol5.CUITCliente = 27430742117;
            sol5.EsUrgente = true;
            sol5.Fecha = new DateTime(2022, 6, 7);
            sol5.Importe = 22009;
            sol5.CodigoDeEstado = 5;
            sol5.NumeroDeFactura = 6030;

            var sol6 = new SolicitudDeOrden();
            sol6.NumeroDeOrden = 105;
            sol6.CUITCliente = 23949330290;
            sol6.EsUrgente = false;
            sol6.Fecha = new DateTime(2022, 12, 11);
            sol6.Importe = 1111;
            sol6.CodigoDeEstado = 1;
            sol6.NumeroDeFactura = 0;

            var sol7 = new SolicitudDeOrden();
            sol7.NumeroDeOrden = 106;
            sol7.CUITCliente = 23949330290;
            sol7.EsUrgente = false;
            sol7.Fecha = new DateTime(2022, 12, 11);
            sol7.Importe = 10;
            sol7.CodigoDeEstado = 2;
            sol7.NumeroDeFactura = 6032;

            var sol8 = new SolicitudDeOrden();
            sol8.NumeroDeOrden = 107;
            sol8.CUITCliente = 23949330290;
            sol8.EsUrgente = false;
            sol8.Fecha = new DateTime(2022, 12, 11);
            sol8.Importe = 10;
            sol8.CodigoDeEstado = 3;
            sol8.NumeroDeFactura = 6033;

            var sol9 = new SolicitudDeOrden();
            sol9.NumeroDeOrden = 108;
            sol9.CUITCliente = 27430742117;
            sol9.EsUrgente = true;
            sol9.Fecha = new DateTime(2022, 6, 7);
            sol9.Importe = 22009;
            sol9.CodigoDeEstado = 4;
            sol9.NumeroDeFactura = 6034;

            var sol10 = new SolicitudDeOrden();
            sol10.NumeroDeOrden = 109;
            sol10.CUITCliente = 27430742117;
            sol10.EsUrgente = true;
            sol10.Fecha = new DateTime(2022, 6, 7);
            sol10.Importe = 4590;
            sol10.CodigoDeEstado = 5;
            sol10.NumeroDeFactura = 6035;

            var sol11 = new SolicitudDeOrden();
            sol11.NumeroDeOrden = 110;
            sol11.CUITCliente = 27430742117;
            sol11.EsUrgente = true;
            sol11.Fecha = new DateTime(2022, 6, 7);
            sol11.Importe = 33900;
            sol11.CodigoDeEstado = 1;
            sol11.NumeroDeFactura = 0;

            //Agrego las solicitudes en la lista
            solicitudesACargar.Add(sol1);
            solicitudesACargar.Add(sol2);
            solicitudesACargar.Add(sol3);
            solicitudesACargar.Add(sol4);
            solicitudesACargar.Add(sol5);
            solicitudesACargar.Add(sol6);
            solicitudesACargar.Add(sol7);
            solicitudesACargar.Add(sol8);
            solicitudesACargar.Add(sol9);
            solicitudesACargar.Add(sol10);
            solicitudesACargar.Add(sol11);

            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\Solicitudes.txt");
            foreach (SolicitudDeOrden sol in solicitudesACargar)
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
    }
}

