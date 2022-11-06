using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Destino
    {

        public Destino(bool esnacional, bool esInternacional, bool entregaEnDomicilio, bool entregaEnSucursal, int codigoDeRegionMundial, string codigoDePais, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
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

        }
        //Propiedades
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

        //Metodos

        public static void MostrarDestino()
        {
            //Completar la muestra del destino
            //Devuelve el Destino.
        }
           
        public static void EntregaYDestinoConsistente()
        {
            //Completar Devuelve un Bool.
            
        }
    

    }
}
