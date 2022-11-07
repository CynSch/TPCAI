using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Origen
    {

        // Propiedades

        public bool EsRetiroEnDomicilio { get; set; }
        public bool EsEntregaEnSucursal { get; set; }
        public int CodigoDeRegionMundial { get; set; }
        public string CodigoDePais { get; set; }
        public int CodigoDeRegionNacional { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }
        public string Direccion { get; set; }
        public int NroSucursal { get; set; }

        //Constructor vacio
        public Origen(){ }

        // constructor lleno
        public Origen( bool retiroEnDomicilio, bool entregaEnSucursal, int codigoDeRegionMundial, string codigoDePais, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
           
            EsRetiroEnDomicilio = retiroEnDomicilio;
            EsEntregaEnSucursal = entregaEnSucursal;
            CodigoDeRegionMundial = codigoDeRegionMundial;
            CodigoDePais = codigoDePais;
            CodigoDeRegionNacional = codigoDeRegionNacional;
            CodigoDeProvincia = codigoDeProvincia;
            CodigoDeLocalidad = codigoDeLocalidad;
            Direccion = direccion;
            NroSucursal = nroSucursal;

        }

        //Metodos:

        public void MostrarOrigen()
        {
            // Devuelve el origen 
            
        }

        public void EntregaYRetiroConsistente()
        {
            //Devuelve un bool
        }

            
    }
}
