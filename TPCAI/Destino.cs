using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Destino
    {

        public Destino(int numDeOrden, bool esnacional, bool esInternacional, bool entregaEnDomicilio, bool entregaEnSucursal, int codigoDeRegionMundial, int codigoDePais, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
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

        }
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
        public int CodigoDePais { get; set; }
        public int CodigoDeRegionNacional { get; set; }
        public int CodigoDeProvincia { get; set; }
        public int CodigoDeLocalidad { get; set; }
        public string Direccion { get; set; }
        public int NroSucursal { get; set; }
        static public List<Destino> DestinosExistentes { get; set; }
        

        //Metodos

        public void MostrarDestino()
        {
            //Completar la muestra del destino
            //Devuelve el Destino.
            string destino = StringDestino(Esnacional,EsInternacional,EntregaEnDomicilio, EntregaEnSucursal);
        }

        private string StringDestino(bool nacional, bool internacional, bool entregaDomicilio, bool entregaSucursal)
        {
            string salida = null;

            RegionNacional regionN = this.BuscarRegionNacional(CodigoDeRegionNacional);
            string rn = regionN.NombreDeRegionNacional;

            RegionMundial regionM = this.BuscarRegionMundial(CodigoDeRegionMundial);
            string rm = regionM.NombreDeRegionMundial;


            Provincia provincia = this.BuscarProvincia(CodigoDeProvincia);
            string nombreProvincia = provincia.NombreDeProvincia;


            Localidad localidad = this.BuscarLocalidad(CodigoDeLocalidad);
            string nombreLocalidad = localidad.NombreDeLocalidad;

            Pais pais = this.BuscarPais(CodigoDePais);
            string nombrePais = pais.NombreDePais;
            
            //Se ejecuta si el rb de internacional esta seleccionado
            if (internacional == true)
            {
                salida = rm + "," + pais + this.Direccion;
            }
            //Se ejecuta si el rb de nacional esta seleccionado
            if (nacional == true)
            {
                // se ejecuta si el rb de entrega en sucursal esta seleccionado
                if (entregaSucursal == true)
                {
                    // Busca la sucursal por el codigo y devuelve la direccion de la sucursal
                    Sucursal sucursal = BuscarSucursal(NroSucursal);
                    string direccionSucursal = sucursal.Direccion;

                    salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + direccionSucursal;

                }

                // se ejecuta si el rb de retiro en domicilio esta seleccionado
                if (entregaDomicilio == true)
                {

                    salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + this.Direccion;

                }
                
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
        private RegionMundial BuscarRegionMundial(int codigoRegionMundial)
        {
            return RegionMundial.LstRegionesMundiales.Find(regionMundial => regionMundial.CodigoDeRegionMundial == codigoRegionMundial);
        }
        private Pais BuscarPais(int codigoPais)
        {
            return Pais.TodosLosPaises.Find(pais => pais.CodigoDePais == codigoPais);
        }
    }
}
