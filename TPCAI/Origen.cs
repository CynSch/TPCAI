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

        public string MostrarOrigen(bool retiroDomicilio, bool entregaSucursal)
        {
            string salida = null;

            // Busca la region nacional por el codigo y devuelve el nombre de la region nacional
            RegionNacional region = this.BuscarRegionNacional(CodigoDeRegionNacional); // me devuelve toda la linea, pero yo solo quiero el nombre
            string rn = region.NombreDeRegionNacional; // le asigno el nombre a una variable que es la que voy a mostrar

            // Busca la provincis por el codigo y devuelve el nombre de la provincia
            Provincia provincia = this.BuscarProvincia(CodigoDeProvincia);
            string nombreProvincia = provincia.NombreDeProvincia;

            // Busca la localidad por el codigo y devuelve el nombre de la localidad
            Localidad localidad = this.BuscarLocalidad(CodigoDeLocalidad);
            string nombreLocalidad = localidad.NombreDeLocalidad;


            // se ejecuta si el rb de entrega en sucursal esta seleccionado
            if (entregaSucursal == true)
            {
                // Busca la sucursal por el codigo y devuelve la direccion de la sucursal
                Sucursal sucursal = BuscarSucursal(NroSucursal);
                string direccionSucursal = sucursal.Direccion;

                salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + direccionSucursal;
                
            }

            // se ejecuta si el rb de retiro en domicilio esta seleccionado
            if (retiroDomicilio == true)
            {

                salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + this.Direccion;
   
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
            return Localidad.LstLocalidades.Find(localidad => localidad.CodigoDeLocalidad == codigoLocalidad);
        }

        private Sucursal BuscarSucursal(int codigoSucursal)
        {
            return Sucursal.TodasLasSucursales.Find(sucursal => sucursal.NroSucursal == codigoSucursal);

        }

    }
}
