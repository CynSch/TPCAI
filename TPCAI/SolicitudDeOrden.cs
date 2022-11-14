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
            sol1.Importe = 9650;
            sol1.CodigoDeEstado = 7;
            sol1.NumeroDeFactura = 6000;

            var sol2 = new SolicitudDeOrden();
            sol2.NumeroDeOrden = 101;
            sol2.CUITCliente = 27430742117;
            sol2.EsUrgente = true;
            sol2.Fecha = new DateTime(2022, 6, 2);
            sol2.Importe = 1425;
            sol2.CodigoDeEstado = 7;
            sol2.NumeroDeFactura = 6001;

            var sol3 = new SolicitudDeOrden();
            sol3.NumeroDeOrden = 102;
            sol3.CUITCliente = 27430742117;
            sol3.EsUrgente = true;
            sol3.Fecha = new DateTime(2022, 6, 7);
            sol3.Importe = 4925;
            sol3.CodigoDeEstado = 7;
            sol3.NumeroDeFactura = 6001;

            var sol4 = new SolicitudDeOrden();
            sol4.NumeroDeOrden = 103;
            sol4.CUITCliente = 20111111111;
            sol4.EsUrgente = false;
            sol4.Fecha = new DateTime(2022, 6, 7);
            sol4.Importe = 28440;
            sol4.CodigoDeEstado = 7;
            sol4.NumeroDeFactura = 6005;

            var sol5 = new SolicitudDeOrden();
            sol5.NumeroDeOrden = 104;
            sol5.CUITCliente = 20111111111;
            sol5.EsUrgente = true;
            sol5.Fecha = new DateTime(2022, 7, 7);
            sol5.Importe = 78500;
            sol5.CodigoDeEstado = 7;
            sol5.NumeroDeFactura = 6004;

            var sol6 = new SolicitudDeOrden();
            sol6.NumeroDeOrden = 105;
            sol6.CUITCliente = 27420744817;
            sol6.EsUrgente = false;
            sol6.Fecha = new DateTime(2022, 7, 24);
            sol6.Importe = 11000;
            sol6.CodigoDeEstado = 6;
            sol6.NumeroDeFactura = 0;

            var sol7 = new SolicitudDeOrden();
            sol7.NumeroDeOrden = 106;
            sol7.CUITCliente = 27430742117;
            sol7.EsUrgente = false;
            sol7.Fecha = new DateTime(2022, 9, 11);
            sol7.Importe = 4250;
            sol7.CodigoDeEstado = 3;
            sol7.NumeroDeFactura = 0;

            var sol8 = new SolicitudDeOrden();
            sol8.NumeroDeOrden = 107;
            sol8.CUITCliente = 20111111111;
            sol8.EsUrgente = false;
            sol8.Fecha = new DateTime(2022, 9, 11);
            sol8.Importe = 750;
            sol8.CodigoDeEstado = 2;
            sol8.NumeroDeFactura = 0;

            var sol9 = new SolicitudDeOrden();
            sol9.NumeroDeOrden = 108;
            sol9.CUITCliente = 23949330290;
            sol9.EsUrgente = true;
            sol9.Fecha = new DateTime(2022, 10, 2);
            sol9.Importe = 13725;
            sol9.CodigoDeEstado = 7;
            sol9.NumeroDeFactura = 6006;

            var sol10 = new SolicitudDeOrden();
            sol10.NumeroDeOrden = 109;
            sol10.CUITCliente = 27430742117;
            sol10.EsUrgente = true;
            sol10.Fecha = new DateTime(2022, 10, 11);
            sol10.Importe = 142500;
            sol10.CodigoDeEstado = 2;
            sol10.NumeroDeFactura = 0;

            var sol11 = new SolicitudDeOrden();
            sol11.NumeroDeOrden = 110;
            sol11.CUITCliente = 27430742117;
            sol11.EsUrgente = true;
            sol11.Fecha = new DateTime(2022, 10, 16);
            sol11.Importe = 46160;
            sol11.CodigoDeEstado = 4;
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

