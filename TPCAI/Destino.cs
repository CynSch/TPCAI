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
        public Destino() { }
        //Propiedades

        public int NumeroDeOrden { get; set; }
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

        private Destino BuscarDestino(int nroOrden)
        {
            return DestinosExistentes.Find(d => d.NumeroDeOrden == nroOrden);
        }

        public static string MostrarDestino(bool nacional, bool internacional, bool entregaDomicilio, bool entregaSucursal, int codigoDeRegionMundial,
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

                    salida = rn + "," + nombreProvincia + "," + nombreLocalidad + "," + direccion;

                }
                
            }
            return salida;

        }
        internal static void CargarDestinoExistentes()
        //Saca los destinos existentes en DestinoOrdenes y los mete en la lista TodosLosDestinos
        {
            // Formato del archivo:
            // NumeroOrden|EsInternacional|EsNacional|EsEntregaEnDomicilio|EsEntregaEnSucursal|CodigoDeRegionMundial|CodigoDePais|
            // CodRegionNacional|CodProvincia|CodLocalidad|Direccion|NroSucursal

            //Primero vacío la lista, por las dudas.
            DestinosExistentes.Clear();

            //recorro linea por linea del archivo, y voy agregando a la lista de destinos existentes. 
            var archivoDestino = new StreamReader("DestinoOrdenes.txt");
            while (!archivoDestino.EndOfStream)
            {
                string proximaLinea = archivoDestino.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var destinoExistente = new Destino();
                destinoExistente.NumeroDeOrden = int.Parse(datosSeparados[0]);
                destinoExistente.EsInternacional = bool.Parse(datosSeparados[1]);
                destinoExistente.EsNacional = bool.Parse(datosSeparados[2]);
                destinoExistente.EntregaEnDomicilio = bool.Parse(datosSeparados[3]);
                destinoExistente.EntregaEnSucursal = bool.Parse(datosSeparados[4]);
                destinoExistente.CodigoDeRegionMundial = int.Parse(datosSeparados[5]);
                destinoExistente.CodigoDePais = int.Parse(datosSeparados[6]);
                destinoExistente.CodigoDeRegionNacional = int.Parse(datosSeparados[7]);
                destinoExistente.CodigoDeProvincia = int.Parse(datosSeparados[8]);
                destinoExistente.CodigoDeLocalidad = int.Parse(datosSeparados[9]);
                destinoExistente.Direccion = datosSeparados[10];
                destinoExistente.NroSucursal = int.Parse(datosSeparados[11]);

                //Agrego el destino a la lista.
                Destino.DestinosExistentes.Add(destinoExistente);
            }
        }

        internal static void GrabarDestino()
        {
            //Grabo los destinos desde la lista TodosLosdestinos en memoria al archivo.

            StreamWriter writer = File.CreateText("DestinoOrdenes.txt");

            foreach (Destino destinoOrden in DestinosExistentes)
            {

                string linea = destinoOrden.NumeroDeOrden.ToString() + "|" +
                                 destinoOrden.EsInternacional.ToString() + "|" +
                                 destinoOrden.EsNacional.ToString() + "|" +
                                 destinoOrden.EntregaEnDomicilio.ToString() + "|" +
                                 destinoOrden.EntregaEnSucursal.ToString() + "|" +
                                 destinoOrden.CodigoDeRegionMundial.ToString() + "|" +
                                 destinoOrden.CodigoDePais.ToString() + "|" +
                                 destinoOrden.CodigoDeRegionNacional.ToString() + "|" +
                                 destinoOrden.CodigoDeProvincia.ToString() + "|" +
                                 destinoOrden.CodigoDeLocalidad.ToString() + "|" +
                                 destinoOrden.Direccion + "|" +
                                 destinoOrden.NroSucursal.ToString();

                writer.WriteLine(linea);
            }
            writer.Close();
        }

        internal static Destino GrabarNuevoDestino(int numOrden, bool esInt, bool esNac, bool entregaEnDomicilio, bool entregaEnSucursal, int codRegMun, int codPais, int codRegNac, int codProvincia,
            int codLoc, string direccion, int nroSucursal)
        {
            //el nuevo destino se agrega a la lista 
            var nuevoDestino = new Destino(numOrden, esInt, esNac, entregaEnDomicilio, entregaEnSucursal, codRegMun, codPais, codRegNac, codProvincia, codLoc, direccion, nroSucursal);

            DestinosExistentes.Add(nuevoDestino);

            return nuevoDestino;

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
