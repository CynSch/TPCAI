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
            EsNacional = esnacional;
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
        public bool EsNacional { get; set; }
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

        
        public string MostrarDestino(bool nacional, bool internacional, bool entregaDomicilio, bool entregaSucursal, int codigoDeRegionMundial,
            int codigoPais, int codigoRegionNacional, int codigoProvincia, int CodigoLocalidad, string direccion, int nroSucursal)
        {
            string salida = null;

            RegionNacional regionN = RegionNacional.BuscarRegionNacional(codigoRegionNacional);
            string rn = regionN.NombreDeRegionNacional;


            Provincia provincia = Provincia.BuscarProvincia(codigoProvincia);
            string nombreProvincia = provincia.NombreDeProvincia;

            Localidad localidad = Localidad.BuscarLocalidad(CodigoLocalidad);
            string nombreLocalidad = localidad.NombreDeLocalidad;
            
            //Se ejecuta si el rb de internacional esta seleccionado
            if (internacional == true)
            {
                RegionMundial regionM = RegionMundial.BuscarRegionMundial(codigoDeRegionMundial);
                string rm = regionM.NombreDeRegionMundial;

                Pais pais = Pais.BuscarPais(codigoPais);
                string nombrePais = pais.NombreDePais;

                salida = rm + "," + nombrePais + direccion;
            }
            //Se ejecuta si el rb de nacional esta seleccionado
            if (nacional == true)
            {
                // se ejecuta si el rb de entrega en sucursal esta seleccionado
                if (entregaSucursal == true)
                {
                    // Busca la sucursal por el codigo y devuelve la direccion de la sucursal
                    Sucursal sucursal = Sucursal.BuscarSucursal(nroSucursal);
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

        //SOY MELU NO TE OLVIDES DE ARMARME EL MÉTODO
        //GrabarNuevoDestino()
        internal static Destino GrabarNuevoDestino()
        {
            throw new NotImplementedException();
        }

        /* private RegionNacional BuscarRegionNacional(int codigoRegNac)
         {
             return RegionNacional.LstRegionesNacionales.Find(regionNacional => regionNacional.CodigoDeRegionNacional == codigoRegNac);

         }*/

        /* private Provincia BuscarProvincia(int codigoProvincia)
         {
             return Provincia.TodasLasProvincias.Find(provincia => provincia.CodigoDeProvincia == codigoProvincia);
         }*/

        /* private Localidad BuscarLocalidad(int codigoLocalidad)
         {
             return Localidad.LstLocalidades.Find(localidad => localidad.CodigoDeLocalidad == codigoLocalidad);
         }*/

        /* private Sucursal BuscarSucursal(int codigoSucursal)
         {
             return Sucursal.TodasLasSucursales.Find(sucursal => sucursal.NroSucursal == codigoSucursal);

         }*/
        /*private RegionMundial BuscarRegionMundial(int codigoRegionMundial)
        {
            return RegionMundial.LstRegionesMundiales.Find(regionMundial => regionMundial.CodigoDeRegionMundial == codigoRegionMundial);
        }*/
        /* private Pais BuscarPais(int codigoPais)
         {
             return Pais.TodosLosPaises.Find(pais => pais.CodigoDePais == codigoPais);
         }*/
    }
}
