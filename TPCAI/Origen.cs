using System;
using System.Collections.Generic;
using System.IO;
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

        static internal List<Origen> TodosLosOrigenes = new List<Origen>();

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
        public Origen() { } // constructor vacio

        //Metodos:

        public static string MostrarOrigen(bool retiroDomicilio, bool entregaSucursal, int codigoDeRegionNacional, int codigoDeProvincia,
            int codigoDeLocalidad, string direccion, int nroSucursal)
        {
            string salida = null;

            // Busca la region nacional por el codigo y devuelve el nombre de la region nacional
            RegionNacional region = RegionNacional.BuscarRegionNacional(codigoDeRegionNacional); // me devuelve toda la linea, pero yo solo quiero el nombre
            string rn = region.NombreDeRegionNacional; // le asigno el nombre a una variable que es la que voy a mostrar

            // Busca la provincis por el codigo y devuelve el nombre de la provincia
            Provincia provincia = Provincia.BuscarProvincia(codigoDeProvincia);
            string nombreProvincia = provincia.NombreDeProvincia;

            // Busca la localidad por el codigo y devuelve el nombre de la localidad
            Localidad localidad = Localidad.BuscarLocalidad(codigoDeLocalidad);
            string nombreLocalidad = localidad.NombreDeLocalidad;

            // se ejecuta si el rb de entrega en sucursal esta seleccionado
            if (entregaSucursal == true)
            {
                // Busca la sucursal por el codigo y devuelve la direccion de la sucursal
                Sucursal sucursal = Sucursal.BuscarSucursal(nroSucursal);
                string direccionSucursal = sucursal.Direccion;
                salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + direccionSucursal;        
            }

            // se ejecuta si el rb de retiro en domicilio esta seleccionado
            if (retiroDomicilio == true)
            {
                salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + direccion;
            }

            return salida; 
 
        }

        internal static void CargarOrigenOrdenesExistentes()
        //Saca los origenes existentes en OrigenOrdenes y los mete en la lista TodosLosOrigenes
        {
            // Formato del archivo:
            // NumeroOrden|EsretiroEnDomicilio|EsEntregaEnSucursal|CodRegionNacional|CodProvincia|CodLocalidad|Direccion|NroSucursal

            //Primero vacío la lista, por las dudas.
             TodosLosOrigenes.Clear();

            //recorro linea por linea del archivo, y voy agregando a la lista de solicitudes existentes. 
            var archivoOrigen = new StreamReader("OrigenOrdenes.txt");
            while (!archivoOrigen.EndOfStream)
            {
                string proximaLinea = archivoOrigen.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var origenExistente = new Origen();
                origenExistente.NumeroDeOrden = int.Parse(datosSeparados[0]);
                origenExistente.EsRetiroEnDomicilio = bool.Parse(datosSeparados[1]);
                origenExistente.EsEntregaEnSucursal = bool.Parse(datosSeparados[2]);
                origenExistente.CodigoDeRegionNacional = int.Parse(datosSeparados[3]);
                origenExistente.CodigoDeProvincia = int.Parse(datosSeparados[4]);
                origenExistente.CodigoDeLocalidad = int.Parse(datosSeparados[5]);
                origenExistente.Direccion = datosSeparados[6];
                origenExistente.NroSucursal = int.Parse(datosSeparados[7]);

                //Agrego el origen a la lista.
                Origen.TodosLosOrigenes.Add(origenExistente);
            }
        }

        internal static void GrabarOrigen()
        {
            //Grabo los origenes desde la lista TodosLosOrigenes en memoria al archivo.


            StreamWriter writer = File.CreateText("OrigenOrdenes.txt");

            //Formato del archivo: NumeroOrden|EsretiroEnDomicilio|EsEntregaEnSucursal|CodRegionNacional|CodProvincia|CodLocalidad|Direccion|NroSucursal

            foreach (Origen origenOrden in TodosLosOrigenes)
            {

                string linea = origenOrden.NumeroDeOrden.ToString() + "|" 
                    + origenOrden.EsRetiroEnDomicilio.ToString() + "|" 
                    + origenOrden.EsEntregaEnSucursal.ToString() + "|" 
                    + origenOrden.CodigoDeRegionNacional.ToString() + "|" 
                    + origenOrden.CodigoDeProvincia.ToString() + "|" 
                    + origenOrden.CodigoDeLocalidad.ToString() + "|"
                    + origenOrden.Direccion + "|" 
                    + origenOrden.NroSucursal.ToString();


                writer.WriteLine(linea);
            }
            writer.Close();
        }

        internal static Origen GrabarNuevoOrigen(int numOrden, bool retiroDomicilio, bool entregaSucursal, int codRegNac, int codProvincia,
            int codLoc, string direccion, int nroSucursal)
        {
            //el nuevo origen se agrega a la lista 
            var nuevoOrigen = new Origen(numOrden, retiroDomicilio, entregaSucursal, codRegNac, codProvincia, codLoc, direccion, nroSucursal);

            TodosLosOrigenes.Add(nuevoOrigen);

            return nuevoOrigen;

        }

        /*  private RegionNacional BuscarRegionNacional(int codigoRegNac)
          {
              return RegionNacional.LstRegionesNacionales.Find(regionNacional => regionNacional.CodigoDeRegionNacional == codigoRegNac);

          }*/

        /*private Provincia BuscarProvincia(int codigoProvincia)
        {
            return Provincia.TodasLasProvincias.Find(provincia => provincia.CodigoDeProvincia == codigoProvincia);
        }
        */
        /*private Localidad BuscarLocalidad(int codigoLocalidad)
        {
            return Localidad.LstLocalidades.Find(localidad => localidad.CodigoDeLocalidad == codigoLocalidad);
        }*/

        /* private Sucursal BuscarSucursal(int codigoSucursal)
         {
             return Sucursal.TodasLasSucursales.Find(sucursal => sucursal.NroSucursal == codigoSucursal);

         }*/

    }
}
