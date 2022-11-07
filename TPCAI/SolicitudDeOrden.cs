using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class SolicitudDeOrden
    {
        //Constructor - comentado, porque no me deja sino ir armando el objeto linea por linea. 
        /*public SolicitudDeOrden(int numeroDeOrden, int iDDeServicio, ClienteCorporativo clienteCorporativo, Destino destino, bool esUrgente, int codigoDeEstado)
        {
            NumeroDeOrden = numeroDeOrden;
            IDDeServicio = iDDeServicio;
            ClienteCorporativo = clienteCorporativo;
            Destino = destino;
            EsUrgente = esUrgente;
            CodigoDeEstado = codigoDeEstado;
        }*/

        //Propiedades
        public int NumeroDeOrden { get; private set; }
        public int IDDeServicio { get; set; }
        public int CUITCliente { get; set; }
        public string Destino { get; set; }
        public bool EsUrgente { get; set; }
        public int CodigoDeEstado { get; set; }
        static internal List<SolicitudDeOrden> SolicitudesExistentes { get; set; }

        //Métodos
        internal static void CargarEstados()
        //Saca los estados disponibles del archivo "Solicitudes.txt" y los mete en la lista SolicitudesExistentes
        //El archivo de solicitudes va a tener tooooodas las solicitudes realizadas, para todos los clientes existentes. 
        {
            /*El archivo tiene el formato:
            "num_de_orden|id_servicio|cuit_cliente|destino|bool_urgente_o_no|cod_de_estado"*/
            var archivoSolicitudes = new StreamReader("Solicitudes.txt");
            while (!archivoSolicitudes.EndOfStream)
            {
                string proximaLinea = archivoSolicitudes.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var solicitud = new SolicitudDeOrden();
                solicitud.NumeroDeOrden = int.Parse(datosSeparados[0]);
                solicitud.IDDeServicio = int.Parse(datosSeparados[1]);
                solicitud.CUITCliente = int.Parse(datosSeparados[2]);
                solicitud.Destino=



            }
        }

        public static void GenerarNumeroDeOrden()
        {
            //1. revisa el archivo de solicitudes
            //2. se fija cuál es el último número 
            //3. le suma 1 a ese número
            //4. le asigna el número a la propiedad con set privado "NumeroDeOrden"
        }

        public static void BuscarOrdenDeServicio(int NumDeOrdenABuscar)
        {
            //VER MI PARCIAL CON AREVALO PLA
            //1. Recorre el archivo de solicitudes
            //2. Busca el NumDeOrdenABuscar
            //3. Si lo encuentra, devuelve número de orden, fecha, importe, destino y estado de la orden. 
        }

        public static void ListarOrdenesPendientesDeFacturacion(int cuit_cliente)
        {
            //1. Recorre el archivo de solicitudes
            //2. identifica las líneas que corresponden al cuit de cliente ingresado 
            //3. para cada orden del cliente, revisa si existe una factura asociada. 
            //4. para las órdenes que no tienen factura asociada, devuelve:
            //   número de orden, importe, fecha y destino. 
        }

        public static void MostrarEstadoDeOrden(int NumDeOrdenABuscar)
        {
            //1. Busca él número de orden ingresado en el archivo de órdenes.
            //2. Valida que sea él mismo el cliente de dicha orden, por seguridad. 
            //3. Revisa el codigo de estado de la orden en cuestión 
            //4. Busca en el archivo de estados, a qué corresponde el código de la orden. 
            //5. Devuelve la descripción del estado de la orden. 
        }

        internal static void GrabarNuevaSolicitud()
        //Este método se tiene que ejecutar cuando hacemos click en "confirmar" la solicitud
        {

        }
    }
}
