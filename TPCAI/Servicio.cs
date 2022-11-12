using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    internal class Servicio
    {
        public Servicio(int numeroDeOrden, bool esEncomienda, bool esCorrespondencia ,decimal ancho, decimal largo, decimal alto, decimal peso)
        {
            
            this.IDDeServicio = LstServicios.Count + 1;
            this.NumeroDeOrden = numeroDeOrden;
            this.EsEncomienda = esEncomienda;
            this.EsCorrespondencia = esCorrespondencia;
            this.Alto = alto;
            this.Ancho = ancho;   
            this.Largo = largo;  
            this.Peso = peso;

        }
        public Servicio(int numeroDeOrden,int idDeServicio, bool esEncomienda, bool esCorrespondencia ,decimal ancho, decimal largo, decimal alto, decimal peso)
        {
            
            
            this.NumeroDeOrden = numeroDeOrden;
            this.IDDeServicio = idDeServicio;   
            this.EsEncomienda = esEncomienda;
            this.EsCorrespondencia = esCorrespondencia;
            this.Alto = alto;
            this.Ancho = ancho;   
            this.Largo = largo;  
            this.Peso = peso;

        }



        public int NumeroDeOrden { get; set; }

        public int IDDeServicio { get; set; }

        public bool EsEncomienda { get; set; }

        public bool EsCorrespondencia { get; set; }

        public decimal Ancho { get; set; }  

        public decimal Largo { get; set; }  

        public decimal Alto { get; set; }  

        public decimal Peso { get; set; }



        public static List<Servicio> LstServicios { get; set; }


        public static void CargarServicios()
        {
            //Cargo los servicios desde el archivo a la lista Servicios para que esten en memoria
            var archivoServicios = new StreamReader("Servicios.txt");
            while (!archivoServicios.EndOfStream)
            {
                string proximaLinea = archivoServicios.ReadLine();


                string[] datosSeparados = proximaLinea.Split('|');
                var Servicio = new Servicio(
                    int.Parse(datosSeparados[0]),       //Numero de orden
                    int.Parse(datosSeparados[1]),       //IDDeServicio
                    bool.Parse(datosSeparados[2]),      //EsEncomienda
                    bool.Parse(datosSeparados[3]),      //EsCorrespondencia
                    decimal.Parse(datosSeparados[4]),   //Ancho
                    decimal.Parse(datosSeparados[5]),   //Largo
                    decimal.Parse(datosSeparados[6]),   //Alto
                    decimal.Parse(datosSeparados[7])    //Peso
                    );
               
                LstServicios.Add(Servicio);

            }
        }

        internal static Servicio GrabarNuevoServicio(int numeroDeOrden, bool esEncomienda, bool esCorrespondencia ,decimal ancho, decimal largo, decimal alto, decimal peso)
        {
            var nuevoServicio = new Servicio(numeroDeOrden, esEncomienda,  esCorrespondencia , ancho,  largo,  alto,  peso);

            LstServicios.Add(nuevoServicio);

            return nuevoServicio;
        }


        internal static void GrabarNuevoServicioEnArchivo()
        {

            StreamWriter writer = File.CreateText("Solicitudes.txt");

            foreach(var servicio in LstServicios)
            {
                string linea = 
                    servicio.NumeroDeOrden.ToString() + "|"         //Numero de orden
                    + servicio.IDDeServicio.ToString() + "|"        //IDDeServicio
                    + servicio.EsEncomienda.ToString() + "|"        //EsEncomienda
                    + servicio.EsCorrespondencia.ToString() + "|"   //EsCorrespondencia
                    + servicio.Ancho.ToString() + "|"               //Ancho
                    + servicio.Largo.ToString() + "|"               //Largo
                    + servicio.Alto.ToString() + "|"                //Alto
                    + servicio.Peso.ToString();                     //Peso

                writer.WriteLine(linea);

            }

            
            writer.Close();
        }

            
        //SOY MELU NO TE OLVIDES DE ARMARME EL MÉTODO
        //GrabarNuevoServicio()
    }
}
