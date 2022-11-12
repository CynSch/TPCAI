using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class EstadoDeOrden
    {
        //Propiedades
        public int CodigoDeEstado { get; set; }
        public string Descripcion { get; set; }
        static internal List<EstadoDeOrden> EstadosDisponibles = new List<EstadoDeOrden>();

        //Métodos
        internal static void CrearArchivo()
        {
            //Creo una lista para guardar las solicitudes
            List<EstadoDeOrden> EstadosACargar = new List<EstadoDeOrden>();

            //YYYY, MM, DD
            //Creo objetos "solicitud"
            var e1 = new EstadoDeOrden();
            e1.CodigoDeEstado = 1;
            e1.Descripcion = "Creado";

            var e2 = new EstadoDeOrden();
            e2.CodigoDeEstado = 2;
            e2.Descripcion = "Admision";

            var e3 = new EstadoDeOrden();
            e3.CodigoDeEstado = 3;
            e3.Descripcion = "En camino";

            var e4 = new EstadoDeOrden();
            e4.CodigoDeEstado = 4;
            e4.Descripcion = "En entrega";

            var e5 = new EstadoDeOrden();
            e5.CodigoDeEstado = 5;
            e5.Descripcion = "Entregado";

            //Agrego las solicitudes en la lista
            EstadosACargar.Add(e1);
            EstadosACargar.Add(e2);
            EstadosACargar.Add(e3);
            EstadosACargar.Add(e4);
            EstadosACargar.Add(e5);

            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText("Estados.txt");
            foreach (EstadoDeOrden e in EstadosACargar)
            {
                //numOrden|CUIT|EsUrgente|Fecha|importe|cod_estado|nroFactura"
                string linea = e.CodigoDeEstado + "|" + e.Descripcion;
                writer.WriteLine(linea);
            }
            writer.Close();
        }
        internal static void CargarEstados()
        //Saca los estados disponibles del archivo "Estados.txt" y los mete en la lista EstadosDisponibles
        {
            //El archivo tiene el formato: "1|Creado"
            var archivoEstados = new StreamReader("Estados.txt");
            while (!archivoEstados.EndOfStream)
            {
                string proximaLinea = archivoEstados.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var estado = new EstadoDeOrden();
                estado.CodigoDeEstado = int.Parse(datosSeparados[0]);
                estado.Descripcion = datosSeparados[1];

                //Agrego el estado a la lista de Estados Disponibles
                EstadoDeOrden.EstadosDisponibles.Add(estado);
            }
        }
    }
}
