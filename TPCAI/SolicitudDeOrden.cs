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
        public string Origen { get; set; }
        public string Destino { get; set; }
        public bool EsUrgente { get; set; }
        public int CodigoDeEstado { get; set; }
        public DateTime Fecha { get; private set; }
        public decimal Importe { get; set; }
        static internal List<SolicitudDeOrden> SolicitudesExistentes { get; set; }

        //Métodos
        internal static void CargarSolicitudesExistentes()
        //Saca los estados disponibles del archivo "Solicitudes.txt" y los mete en la lista SolicitudesExistentes
        //El archivo de solicitudes va a tener tooooodas las solicitudes realizadas, para todos los clientes existentes. 
        {
            /*El archivo tiene el formato:
            "num_de_orden|id_servicio|cuit_cliente|origen|destino|bool_urgente_o_no|cod_de_estado"*/

            //Primero vacío la lista, por las dudas.
            SolicitudesExistentes.Clear();

            //reocrro linea por linea del archivo, y voy agregando a la lista de solicitudes existentes. 
            var archivoSolicitudes = new StreamReader("Solicitudes.txt");
            while (!archivoSolicitudes.EndOfStream)
            {
                string proximaLinea = archivoSolicitudes.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var solicitud = new SolicitudDeOrden();
                solicitud.NumeroDeOrden = int.Parse(datosSeparados[0]);
                solicitud.IDDeServicio = int.Parse(datosSeparados[1]);
                solicitud.CUITCliente = int.Parse(datosSeparados[2]);
                solicitud.Origen = datosSeparados[3];                
                solicitud.Destino = datosSeparados[4];
                solicitud.EsUrgente = bool.Parse(datosSeparados[5]);
                solicitud.CodigoDeEstado = int.Parse(datosSeparados[6]);

                SolicitudDeOrden.SolicitudesExistentes.Add(solicitud);
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

        public static void BuscarYMostrarOrdenDeServicio()
        {
            //ALTERNATIVA: El método podría devolver el objeto de solicitud, y desde la UI
            //llamamos a los distintos atributos del objeto. 
            int NumDeOrdenABuscar;
            bool encontrado = false;
            do
            {
                NumDeOrdenABuscar = Validador.PedirInt("Ingrese el número de orden a buscar",1,666666);
                //Chequear la clase validador para que en vez de writeline escriba en el form. 

                //Hasta encontrar la orden, recorre las solicitudes existenes. 
                //Si se encuentra, devuelve número de orden, fecha, importe, destino y estado de la orden. 
                foreach (SolicitudDeOrden sol in SolicitudesExistentes)
                {
                    if (sol.NumeroDeOrden == NumDeOrdenABuscar)
                    {
                        encontrado = true;
                        //MOSTRAR DATOS EN PANTALLA
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("no encontrado");
                    //devolver mensaje de que no se encontró la orden
                }
            } while (!encontrado);
        }
        //Falta linkear el rdo con la UI

        public static void ListarOrdenesPendientesDeFacturacion(int cuit_cliente)
        {
            //Creo una lista vacía que sirva para almacenar las órdenes pendientes de facturacion de un cliente
            List<SolicitudDeOrden> OrdenesPendientesDeFacturacion = new List<SolicitudDeOrden>();

            //Agrego a la lista todas las solicitudes del cliente
            foreach (SolicitudDeOrden sol in SolicitudesExistentes)
            {
                if (sol.CUITCliente == cuit_cliente)
                {
                    OrdenesPendientesDeFacturacion.Add(sol);
                }
            }

            //Saco de la lista las ordenes que tienen factura asociada
            //Para cada orden, hay que chequear que exista una factura con la orden incluida 
            foreach (SolicitudDeOrden sol in OrdenesPendientesDeFacturacion)
            {
                foreach (Factura fact in Factura.FacturasExistentes)
                {
                    if (fact.OrdenesAsociadas.Contains(sol))
                    {
                        OrdenesPendientesDeFacturacion.Remove(sol);
                    }
                }
            }

            foreach (SolicitudDeOrden ordenPendienteDeFacturacion in OrdenesPendientesDeFacturacion)
            {
                //Mostrar en pantalla número de orden, importe, fecha y destino. 
            }

        }
        //Falta linkear el rdo con la UI
        public static void MostrarEstadoDeOrden(int NumDeOrdenABuscar)
        {
            //Creo un bool para ver si existe la orden que se quiere buscar. 
            int codEstadoDeLaOrden = 0;
            string EstadoDeLaOrden = 0;
            bool ordenEncontrada = false;
            do
            {
                foreach (SolicitudDeOrden sol in SolicitudesExistentes)
                {
                    if (sol.NumeroDeOrden == NumDeOrdenABuscar)
                    {
                        ordenEncontrada = true;

                        //Guarda el codigo de estado de la orden en cuestión 
                        codEstadoDeLaOrden = sol.CodigoDeEstado;
                    }
                }
                if (ordenEncontrada == false)
                {
                    //Mostrar mensaje de error - orden inexistente. 
                }
            } while (ordenEncontrada == false);

            if (ordenEncontrada == true)
            {
                //Busca en la lista de estados, a cuál corresponde el código del estado de la orden. 
                foreach (EstadoDeOrden estado in EstadoDeOrden.EstadosDisponibles)
                {
                    if (estado.CodigoDeEstado == codEstadoDeLaOrden)
                    {
                        EstadoDeLaOrden = estado.Descripcion;
                    }
                }
                //Mostrar numero de orden, fecha, importe, destino y estado.  
            }
        }
        //Falta linkear el rdo con la UI

        internal static void GrabarNuevaSolicitud()
        //Este método se tiene que ejecutar cuando hacemos click en "confirmar" la solicitud
        //La nueva solicitud se tiene que agregar a la lista SolicitudesExistentes!!
        {
            var nuevaSolicitud = new SolicitudDeOrden();
            nuevaSolicitud.NumeroDeOrden = GenerarNumeroDeOrden();

            /*nuevaSolicitud.IDDeServicio = //linkear con el radio button seleccionado. 
             if (se seleccionó el radio button de correspondencia)
                  {
                      IDDeServicio = 1
                  }
             else
                  {
                      IDDeServicio = 2
                  }
                  
            nuevaSolicitud.CUITCliente = //linkear con el cliente que está logueado. */

            //CREAR INSTANCIA DE ORIGEN
            //var origen_solicitud = new Origen(); 
            //Para que funcione el constructor, hay que ir linkeando cada selección del usuario con los parámetro que te pide
            //nuevaSolicitud.Origen = origen_solicitud;

            //CREAR INSTANCIA DE DESTINO
            //var destino_solicitud = new Destino();
            //Para que funcione el constructor, hay que ir linkeando cada selección del usuario con los parámetro que te pide
            //nuevaSolicitud.Destino = destino_solicitud;

            //linkear urgencia con la selección del checkbox.
            /*if (checkbox seleccionado)
                {
                    nuevaSolicitud.EsUrgente = true;
                }
                else
                {
                    nuevaSolicitud.EsUrgente = false;
                }*/

            nuevaSolicitud.CodigoDeEstado = 1;

            SolicitudesExistentes.Add(nuevaSolicitud);
         }
        
    
    }
    }

