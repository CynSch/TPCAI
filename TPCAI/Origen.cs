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

        //SOY MELU! AVISO QUE AGREGUÉ LA PROPIEDAD "NumeroDeOrden" PARA PODER LINKEAR EL ORIGEN
        //CON UNA ORDEN PARTICULAR. TAMBIÉN LO METÍ EN EL CONSTRUCTOR
        public int NumeroDeOrden { get; set; }
        //

        public bool EsRetiroEnDomicilio { get; set; }
        public bool EsEntregaEnSucursal { get; set; }
        public int CodigoDeRegionMundial { get; set; }
        public string CodigoDePais { get; set; }
        public int CodigoDeRegionNacional { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }
        public string Direccion { get; set; }
        public int NroSucursal { get; set; }


        // constructor lleno
        public Origen(int numDeOrden, bool retiroEnDomicilio, bool entregaEnSucursal, int codigoDeRegionMundial, string codigoDePais, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
            NumeroDeOrden = numDeOrden;
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
