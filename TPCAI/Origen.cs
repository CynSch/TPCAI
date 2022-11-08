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

        public bool EsRetiroEnDomicilio { get; set; }  // supone que el radiobutton de retiro en domicilio esta seleccionado
        public bool EsEntregaEnSucursal { get; set; } // supone que el radiobutton de entrega en sucursal esta seleccionado
        public int CodigoDeRegionNacional { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }
        public string Direccion { get; set; }
        public int NroSucursal { get; set; }


        // constructor lleno
        public Origen(int numDeOrden, bool retiroEnDomicilio, bool entregaEnSucursal, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
            NumeroDeOrden = numDeOrden;
            EsRetiroEnDomicilio = retiroEnDomicilio; // supone que el radiobutton de retiro en domicilio esta seleccionado
            EsEntregaEnSucursal = entregaEnSucursal; // supone que el radiobutton de entrega en sucursal esta seleccionado
            CodigoDeRegionNacional = codigoDeRegionNacional;
            CodigoDeProvincia = codigoDeProvincia;
            CodigoDeLocalidad = codigoDeLocalidad;
            Direccion = direccion;
            NroSucursal = nroSucursal;

        }

        //Metodos:


       public void MostrarOrigen()
       {
   
            string origen = StringOrigen();
            
     

       }

       private string StringOrigen()
        {
            string salida;
            Provincia nombreProvincia = this.BuscarProvincia();

            if (EsRetiroEnDomicilio == false)
            {
                salida = string.Format(this.CodigoDeRegionNacional.ToString(), nombreProvincia,
                                        this.CodigoDeLocalidad.ToString(), this.NroSucursal.ToString());

            }

            if (EsEntregaEnSucursal == false)
            {
                salida = String.Format(this.CodigoDeRegionNacional.ToString(), nombreProvincia,
                                        this.CodigoDeLocalidad.ToString(), this.Direccion.ToString());
            }

            return salida;

        }
         
        
        private RegionNacional BuscarRegionNacional()
        {
            return RegionNacional.LstRegionesNacionales.Find(regionNacional => regionNacional.CodigoDeRegionNacional == CodigoDeRegionNacional);

        }

        private Provincia BuscarProvincia()
        {
            return Provincia.TodasLasProvincias.Find(provincia => provincia.CodigoDeProvincia == CodigoDeProvincia);
        }

        private Localidad BuscarLocalidad()
        {

        }
    }
}
