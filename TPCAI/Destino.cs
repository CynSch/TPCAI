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

        public Destino(int numDeOrden, bool esInternacional, bool esnacional, bool entregaEnDomicilio, bool entregaEnSucursal, int codigoDeRegionMundial, int codigoDePais, int codigoDeRegionNacional, int codigoDeProvincia, int codigoDeLocalidad, string direccion, int nroSucursal)
        {
            NumeroDeOrden = numDeOrden;
            EsInternacional = esInternacional;
            EsNacional = esnacional;
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
        static public List<Destino> DestinosExistentes = new List<Destino>();


        //Metodos

        internal static Destino BuscarDestino(int nroOrden)
        {
            return DestinosExistentes.Find(d => d.NumeroDeOrden == nroOrden);
        }

        public static string MostrarDestino(bool nacional, bool internacional, bool entregaDomicilio, bool entregaSucursal, int codigoDeRegionMundial,
            int codigoPais, int codigoRegionNacional, int codigoProvincia, int CodigoLocalidad, string direccion, int nroSucursal)
        {
            string salida = "";
            
            //Se ejecuta si el rb de internacional esta seleccionado
            if (internacional)
            {
                Pais pais = Pais.BuscarPais(codigoPais);
                string nombrePais = pais.NombreDePais;

                salida = nombrePais + ", " + direccion;
            }
            //Se ejecuta si el rb de nacional esta seleccionado
            else if (nacional)
            {
                RegionNacional regionN = RegionNacional.BuscarRegionNacional(codigoRegionNacional);
                string rn = regionN.NombreDeRegionNacional;


                Provincia provincia = Provincia.BuscarProvincia(codigoProvincia);
                string nombreProvincia = provincia.NombreDeProvincia;

                Localidad localidad = Localidad.BuscarLocalidad(CodigoLocalidad);
                string nombreLocalidad = localidad.NombreDeLocalidad;

                // se ejecuta si el rb de entrega en sucursal esta seleccionado
                if (entregaSucursal == true)
                {
                    // Busca la sucursal por el codigo y devuelve la direccion de la sucursal
                    Sucursal sucursal = Sucursal.BuscarSucursal(nroSucursal);
                    string direccionSucursal = sucursal.Direccion;

                    salida = rn + "," + nombreProvincia + "," + nombreLocalidad + ", sucursal " + nroSucursal + " - " + direccionSucursal;

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
            var archivoDestino = new StreamReader($@"{Environment.CurrentDirectory}\DestinoOrdenes.txt");
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
                //Puede ser null
                if (datosSeparados[5] != "")
                {
                    destinoExistente.CodigoDeRegionMundial = int.Parse(datosSeparados[5]);
                }
                else
                {
                    destinoExistente.CodigoDeRegionMundial = 0;
                }
                //Puede ser null
                if (datosSeparados[6] != "")
                {
                    destinoExistente.CodigoDePais = int.Parse(datosSeparados[6]);
                }
                else
                {
                    destinoExistente.CodigoDePais= 0;
                }
                //Puede ser null
                if (datosSeparados[7] != "")
                {
                    destinoExistente.CodigoDeRegionNacional = int.Parse(datosSeparados[7]);
                }
                else
                {
                    destinoExistente.CodigoDeRegionNacional = 0;
                }
                //Puede ser null
                if (datosSeparados[8] != "")
                {
                    destinoExistente.CodigoDeProvincia = int.Parse(datosSeparados[8]);
                }
                else
                {
                    destinoExistente.CodigoDeProvincia = 0;
                }
                //Puede ser null
                if (datosSeparados[9] != "")
                {
                    destinoExistente.CodigoDeLocalidad = int.Parse(datosSeparados[9]);
                }
                else
                {
                    destinoExistente.CodigoDeLocalidad = 0;
                }
                destinoExistente.Direccion = datosSeparados[10];
                //Puede ser null
                if (datosSeparados[11] != "")
                {
                    destinoExistente.NroSucursal = int.Parse(datosSeparados[11]);
                }
                else
                {
                    destinoExistente.NroSucursal = 0;
                }
                //Agrego el destino a la lista.
                Destino.DestinosExistentes.Add(destinoExistente);
            }
            archivoDestino.Close();
        }

        internal static void GrabarDestino()
        {
            //Grabo los destinos desde la lista TodosLosdestinos en memoria al archivo.

            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\DestinoOrdenes.txt");

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
            Destino nuevoDestino = new Destino(numOrden, esInt, esNac, entregaEnDomicilio, entregaEnSucursal, codRegMun, codPais, codRegNac, codProvincia, codLoc, direccion, nroSucursal);

            DestinosExistentes.Add(nuevoDestino);

            return nuevoDestino;

        }
        internal static void CrearArchivo()
        {

            List<Destino> listaACargar = new List<Destino>();

            var lst1 = new Destino(100, true, false, false, false, 2, 11, 0, 0, 0, "Granada 23, Cancún", 0);
            var lst3 = new Destino(102, false, true, false, true,0,0, 4, 6, 46, "", 5);
            var lst4 = new Destino(103, true, false, false, false, 1, 1, 0, 0,0, "Engenheiro Roberto Freire 3800, Ponta Negra", 0);
            var lst2 = new Destino(101, false, true, false, true, 0, 0, 1, 3, 31, "", 4);
            var lst5 = new Destino(104, true, false, false, false, 3, 21, 0,0, 0, "Magnolia St 2801, Oakland", 0);
            var lst6 = new Destino(105, false, true, false, true, 0, 0, 4, 1, 1, "", 1);
            var lst7 = new Destino(106, false, true, false, true, 0, 0, 0, 1, 8, "", 2);
            var lst8 = new Destino(107, false, true, false, true, 0, 0, 0, 17, 51, "", 3);
            var lst9 = new Destino(108, true, false, false, false, 4, 32, 0, 0, 0, "Av.Clays 20, Bruxelles", 0);
            var lst10 = new Destino(109, true, false, false, false, 5, 91, 0, 0, 0, "Dostai 17, Jerusalem", 0);
            var lst11 = new Destino(110, true, false, false, false, 1, 3, 0, 0, 0, "Martín Rivas 596, Peru", 0);

            listaACargar.Add(lst1);
            listaACargar.Add(lst2);
            listaACargar.Add(lst3);
            listaACargar.Add(lst4);
            listaACargar.Add(lst5);
            listaACargar.Add(lst6);
            listaACargar.Add(lst7);
            listaACargar.Add(lst8);
            listaACargar.Add(lst9);
            listaACargar.Add(lst10);
            listaACargar.Add(lst11);


            StreamWriter writerDestino = File.CreateText($@"{Environment.CurrentDirectory}\DestinoOrdenes.txt");

            foreach (Destino d in listaACargar)
            {
                string lineaDestino = d.NumeroDeOrden + "|" +
                                        d.EsInternacional + "|" +
                                        d.EsNacional + "|" +
                                        d.EntregaEnDomicilio + "|" +
                                        d.EntregaEnSucursal + "|" +
                                        d.CodigoDeRegionMundial + "|" +
                                        d.CodigoDePais + "|" +
                                        d.CodigoDeRegionNacional + "|" +
                                        d.CodigoDeProvincia + "|" +
                                        d.CodigoDeLocalidad + "|" +
                                        d.Direccion + "|" +
                                        d.NroSucursal;

                writerDestino.WriteLine(lineaDestino);
            }

            writerDestino.Close(); 
        }
    }
}
