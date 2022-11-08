using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Destino
    {

       /* public Destino(int numDeOrden, bool esnacional, bool esInternacional, bool entregaEnDomicilio, bool entregaEnSucursal, int codigoDeRegionMundial, string codigoDePais, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
            NumeroDeOrden = numDeOrden;
            Esnacional = esnacional;
            EsInternacional = esInternacional;
            EntregaEnDomicilio = entregaEnDomicilio;
            EntregaEnSucursal = entregaEnSucursal;
            CodigoDeRegionMundial = codigoDeRegionMundial;
            CodigoDePais = codigoDePais;
            CodigoDeRegionNacional = codigoDeRegionNacional;
            CodigoDeProvincia = codigoDeProvincia;
            CodigoDeLocalidad = codigoDeLocalidad;
            Direccion = direccion;
            NroSucursal = nroSucursal;

        }*/
        //Propiedades

        //SOY MELU! AVISO QUE AGREGUÉ LA PROPIEDAD "NumeroDeOrden" PARA PODER LINKEAR EL DESTINO
        //CON UNA ORDEN PARTICULAR. TAMBIÉN LO METÍ EN EL CONSTRUCTOR
        public int NumeroDeOrden { get; set; }
        //
        public bool Esnacional { get; set; }
        public bool EsInternacional { get; set; }
        public bool EntregaEnDomicilio { get; set; }
        public bool EntregaEnSucursal { get; set; }
        public int CodigoDeRegionMundial { get; set; }
        public string CodigoDePais { get; set; }
        public int CodigoDeRegionNacional { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }
        public string Direccion { get; set; }
        public int NroSucursal { get; set; }
        static public List<Destino> DestinosExistentes { get; set; }

        //Metodos

        public static void MostrarDestino()
        {
            //Completar la muestra del destino
            //Devuelve el Destino.
            var archivoDestino = new StreamReader("Destinos.txt");
            while (!archivoDestino.EndOfStream)

            {
                string proximaLinea = archivoDestino.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var destino = new Destino();
                destino. = int.Parse(datosSeparados[0]);
                destino. = decimal.Parse(datosSeparados[1]);
                destino. = .Parse(datosSeparados[2]);
                

                Destino.DestinosExistentes.Add(destino);

            }
        }
    
    }
}
