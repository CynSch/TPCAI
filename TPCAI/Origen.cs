using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Origen
    {

        // Propiedades

        public int NumeroDeOrden { get; set; }
        //

        public bool EsRetiroEnDomicilio { get; set; }  // true si el rb esta seleccionado, false si no lo esta
        public bool EsEntregaEnSucursal { get; set; } // true si el rb esta seleccionado, false si no lo esta
        public int CodigoDeRegionNacional { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }
        public string Direccion { get; set; }
        public int NroSucursal { get; set; }


        // constructor lleno
        public Origen(int numDeOrden, bool retiroEnDomicilio, bool entregaEnSucursal, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
            NumeroDeOrden = numDeOrden;
            EsRetiroEnDomicilio = retiroEnDomicilio; 
            EsEntregaEnSucursal = entregaEnSucursal; 
            CodigoDeRegionNacional = codigoDeRegionNacional;
            CodigoDeProvincia = codigoDeProvincia;
            CodigoDeLocalidad = codigoDeLocalidad;
            Direccion = direccion;
            NroSucursal = nroSucursal;

        }

        //Metodos:


       public void MostrarOrigen()
       {
   
            string origen = StringOrigen(EsRetiroEnDomicilio, EsEntregaEnSucursal);

       }

       private string StringOrigen(bool retiroDomicilio, bool entregaSucursal)
        {
            string salida = null;
            RegionNacional nombreRegionNacional = this.BuscarRegionNacional(CodigoDeRegionNacional);
            Provincia nombreProvincia = this.BuscarProvincia(CodigoDeProvincia);
            Localidad nombreLocalidad = this.BuscarLocalidad(CodigoDeLocalidad);

            if (retiroDomicilio == false)
            {
                Sucursal nombreSucursal = BuscarSucursal(NroSucursal);

                salida = string.Format(nombreRegionNacional.ToString(), nombreProvincia,
                                        nombreLocalidad, nombreSucursal);
                
            }

            if (entregaSucursal == false)
            {

               return salida = String.Format(nombreRegionNacional.ToString(), nombreProvincia,
                                       nombreLocalidad, this.Direccion.ToString());

                
            }

            return salida; 
 
        }
         
        
        private RegionNacional BuscarRegionNacional(int codigoRegNac)
        {
            return RegionNacional.LstRegionesNacionales.Find(regionNacional => regionNacional.CodigoDeRegionNacional == codigoRegNac);

        }

        private Provincia BuscarProvincia(int codigoProvincia)
        {
            return Provincia.TodasLasProvincias.Find(provincia => provincia.CodigoDeProvincia == codigoProvincia);
        }

        private Localidad BuscarLocalidad(int codigoLocalidad)
        {
            return Localidad.LstLocaldiades.Find(localidad => localidad.CodigoDeLocalidad == codigoLocalidad);
        }

        private Sucursal BuscarSucursal(int codigoSucursal)
        {
            return Sucursal.TodasLasSucursales.Find(sucursal => sucursal.NroSucursal == codigoSucursal);

        }

    }
}
