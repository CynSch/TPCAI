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

            //recorro linea por linea del archivo, y voy agregando a la lista de solicitudes existentes. 
            var archivoOrigen = new StreamReader($@"{Environment.CurrentDirectory}\OrigenOrdenes.txt");
            while (!archivoOrigen.EndOfStream)
            {
                string proximaLinea = archivoOrigen.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var origenExistente = new Origen();
                origenExistente.NumeroDeOrden = int.Parse(datosSeparados[0]);
                origenExistente.EsRetiroEnDomicilio = bool.Parse(datosSeparados[1]);
                origenExistente.EsEntregaEnSucursal = bool.Parse(datosSeparados[2]);
                //origenExistente.CodigoDeRegionNacional = int.Parse(datosSeparados[3]);
                //origenExistente.CodigoDeProvincia = int.Parse(datosSeparados[4]);
                //origenExistente.CodigoDeLocalidad = int.Parse(datosSeparados[5]);
                origenExistente.Direccion = datosSeparados[6];
                //origenExistente.NroSucursal = int.Parse(datosSeparados[7]);
                //Puede ser null
                if (datosSeparados[3] != "")
                {
                    origenExistente.CodigoDeRegionNacional = int.Parse(datosSeparados[3]);
                }
                else
                {
                    origenExistente.CodigoDeRegionNacional = 0;
                }
                //Puede ser null
                if (datosSeparados[4] != "")
                {
                    origenExistente.CodigoDeProvincia = int.Parse(datosSeparados[4]);
                }
                else
                {
                    origenExistente.CodigoDeProvincia = 0;
                }
                //Puede ser null
                if (datosSeparados[5] != "")
                {
                    origenExistente.CodigoDeLocalidad = int.Parse(datosSeparados[5]);
                }
                else
                {
                    origenExistente.CodigoDeLocalidad = 0;
                }
                //Puede ser null
                if (datosSeparados[7] != "")
                {
                    origenExistente.NroSucursal = int.Parse(datosSeparados[7]);
                }
                else
                {
                    origenExistente.NroSucursal = 0;
                }
                //Agrego el origen a la lista.
                Origen.TodosLosOrigenes.Add(origenExistente);
            }
            archivoOrigen.Close();

        }

        internal static void GrabarOrigen()
        {
            //Grabo los origenes desde la lista TodosLosOrigenes en memoria al archivo.


            StreamWriter writer = File.CreateText($@"{Environment.CurrentDirectory}\OrigenOrdenes.txt");

            //Formato del archivo: NumeroOrden|EsretiroEnDomicilio|EsEntregaEnSucursal|CodRegionNacional|CodProvincia|CodLocalidad|Direccion|NroSucursal

            foreach (Origen origenOrden in TodosLosOrigenes)
            {
                string linea = origenOrden.NumeroDeOrden + "|" 
                    + origenOrden.EsRetiroEnDomicilio + "|" 
                    + origenOrden.EsEntregaEnSucursal + "|" 
                    + origenOrden.CodigoDeRegionNacional + "|" 
                    + origenOrden.CodigoDeProvincia + "|" 
                    + origenOrden.CodigoDeLocalidad + "|"
                    + origenOrden.Direccion + "|" 
                    + origenOrden.NroSucursal;

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

        internal static void CrearArchivo()
        {

            List<Origen> lstcargar = new List<Origen>();

            var lst1 = new Origen(100, true, false, 4, 1, 2, "Av 25 de Mayo 613", 0);
            var lst2 = new Origen(101, false, true, 4, 6, 46, "", 5);
            var lst3 = new Origen(102, true, false, 1, 24, 53, "Lavalle 2270 ", 0);
            var lst4 = new Origen(103, false, true, 4, 1, 8, "", 2);
            var lst5 = new Origen(104, false, true, 1, 17, 51, "", 3);
            var lst6 = new Origen(105, true, false, 2, 4, 40, "Chiclana 26 ", 0);
            var lst7 = new Origen(106, true, false, 1, 24, 53, "Benjamín Matienzo 2041", 0);
            var lst8 = new Origen(107, false, true, 1, 17, 51, "", 3);
            var lst9 = new Origen(108, false, true, 1, 3, 31, "", 4);
            var lst10 = new Origen(109, false, true, 4, 1, 1, "", 1);
            var lst11 = new Origen(110, true, false, 4, 1, 26, "Sarmiento 2689", 0);

            lstcargar.Add(lst1);
            lstcargar.Add(lst2);
            lstcargar.Add(lst3);
            lstcargar.Add(lst4);
            lstcargar.Add(lst5);
            lstcargar.Add(lst6);
            lstcargar.Add(lst7);
            lstcargar.Add(lst8);
            lstcargar.Add(lst9);
            lstcargar.Add(lst10);
            lstcargar.Add(lst11);


            StreamWriter writerorigen = File.CreateText($@"{Environment.CurrentDirectory}\OrigenOrdenes.txt");

            foreach (Origen or in lstcargar)
            {
                string lineaorigen = or.NumeroDeOrden + "|"
                        + or.EsRetiroEnDomicilio + "|"
                        + or.EsEntregaEnSucursal + "|"
                        + or.CodigoDeRegionNacional + "|"
                        + or.CodigoDeProvincia + "|"
                        + or.CodigoDeLocalidad + "|"
                        + or.Direccion + "|"
                        + or.NroSucursal;
                writerorigen.WriteLine(lineaorigen);
            }

            writerorigen.Close();
        }

    }
}
