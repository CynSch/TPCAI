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
        public Servicio() { }



        public int NumeroDeOrden { get; set; }

        public int IDDeServicio { get; set; }

        public bool EsEncomienda { get; set; }

        public bool EsCorrespondencia { get; set; }

        public decimal Ancho { get; set; }  

        public decimal Largo { get; set; }  

        public decimal Alto { get; set; }  

        public decimal Peso { get; set; }



        public static List<Servicio> LstServicios = new List<Servicio>();


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

            StreamWriter writer = File.CreateText("Servicios.txt");

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

        internal static void CrearArchivo ()
        {
            //Creo una lista para guardar las solicitudes
            List<Servicio> ServiciosACargar = new List<Servicio>();

            var ser1 = new Servicio();
            ser1.NumeroDeOrden = 100;
            ser1.IDDeServicio = 100;
            ser1.EsEncomienda = false;
            ser1.EsCorrespondencia = true;
            ser1.Ancho = 0;
            ser1.Largo = 0;
            ser1.Alto = 0;
            ser1.Peso = 0;


            var ser2 = new Servicio();
            ser2.NumeroDeOrden = 101;
            ser2.IDDeServicio = 101;
            ser2.EsEncomienda = false;
            ser2.EsCorrespondencia = true;
            ser2.Ancho = 0;
            ser2.Largo = 0;
            ser2.Alto = 0;
            ser2.Peso = 0;

            var ser3 = new Servicio();
            ser3.NumeroDeOrden = 102;
            ser3.IDDeServicio = 102;
            ser3.EsEncomienda = false;
            ser3.EsCorrespondencia = true;
            ser3.Ancho = 0;
            ser3.Largo = 0;
            ser3.Alto = 0;
            ser3.Peso = 0;

            var ser4 = new Servicio();
            ser4.NumeroDeOrden = 103;
            ser4.IDDeServicio = 103;
            ser4.EsEncomienda = true;
            ser4.EsCorrespondencia = false;
            ser4.Ancho = 100;
            ser4.Largo = 150;
            ser4.Alto = 550;
            ser4.Peso = 15.4M;

            var ser5 = new Servicio();
            ser5.NumeroDeOrden = 104;
            ser5.IDDeServicio = 104;
            ser5.EsEncomienda = true;
            ser5.EsCorrespondencia = false;
            ser5.Ancho = 233;
            ser5.Largo = 240;
            ser5.Alto = 200;
            ser5.Peso = 5.8M;

            var ser6 = new Servicio();
            ser6.NumeroDeOrden = 105;
            ser6.IDDeServicio = 105;
            ser6.EsEncomienda = true;
            ser6.EsCorrespondencia = false;
            ser6.Ancho = 554;
            ser6.Largo = 588;
            ser6.Alto = 300;
            ser6.Peso = 7.6M;

            var ser7 = new Servicio();
            ser7.NumeroDeOrden = 106;
            ser7.IDDeServicio = 106;
            ser7.EsEncomienda = false;
            ser7.EsCorrespondencia = true;
            ser7.Ancho = 0;
            ser7.Largo = 0;
            ser7.Alto = 0;
            ser7.Peso = 0;

            var ser8 = new Servicio();
            ser8.NumeroDeOrden = 107;
            ser8.IDDeServicio = 107;
            ser8.EsEncomienda = false;
            ser8.EsCorrespondencia = true;
            ser8.Ancho = 0;
            ser8.Largo = 0;
            ser8.Alto = 0;
            ser8.Peso = 0;   
            
            var ser9 = new Servicio();
            ser9.NumeroDeOrden = 108;
            ser9.IDDeServicio = 108;
            ser9.EsEncomienda = false;
            ser9.EsCorrespondencia = true;
            ser9.Ancho = 0;
            ser9.Largo = 0;
            ser9.Alto = 0;
            ser9.Peso = 0;
                
            var ser10 = new Servicio();
            ser10.NumeroDeOrden = 109;
            ser10.IDDeServicio = 109;
            ser10.EsEncomienda = true;
            ser10.EsCorrespondencia = false;
            ser10.Ancho = 345;
            ser10.Largo = 111;
            ser10.Alto = 242;
            ser10.Peso = 4.4M;

            var ser11 = new Servicio();
            ser11.NumeroDeOrden = 110;
            ser11.IDDeServicio = 110;
            ser11.EsEncomienda = true;
            ser11.EsCorrespondencia = false;
            ser11.Ancho = 113;
            ser11.Largo = 233;
            ser11.Alto = 544;
            ser11.Peso = 10.4M;

            //Agrego las solicitudes en la lista
            ServiciosACargar.Add(ser1);
            ServiciosACargar.Add(ser2);
            ServiciosACargar.Add(ser3);
            ServiciosACargar.Add(ser4);
            ServiciosACargar.Add(ser5);
            ServiciosACargar.Add(ser6);
            ServiciosACargar.Add(ser7);
            ServiciosACargar.Add(ser8);
            ServiciosACargar.Add(ser9);
            ServiciosACargar.Add(ser10);
            ServiciosACargar.Add(ser11);

            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText("Servicios.txt");
            foreach (Servicio ser in ServiciosACargar)
            {
                
                string linea = 
                    ser.NumeroDeOrden + "|"
                    + ser.IDDeServicio + "|" 
                    + ser.EsEncomienda + "|"
                    + ser.EsCorrespondencia + "|" 
                    + ser.Ancho + "|"
                    + ser.Largo + "|"
                    + ser.Alto + "|"
                    + ser.Peso + "|";

                writer.WriteLine(linea);
            }
            writer.Close();
        }

            
        //SOY MELU NO TE OLVIDES DE ARMARME EL MÉTODO
        //GrabarNuevoServicio()
    }
}
