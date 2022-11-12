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
    internal class ClienteCorporativo
    {
        public ClienteCorporativo(string nombreCliente, int cuit, string contraseña, int telefono, decimal saldo,bool esMoroso)
        {
            this.NombreCliente = nombreCliente;
            this.CUIT = cuit;
            this.Contraseña = contraseña;
            this.Telefono = telefono;
            this.Saldo = saldo;
            this.EsMoroso = esMoroso;
        }



        public string NombreCliente { get; set; }

        public int CUIT { get; set; }

        public string Contraseña { get; set; }

        public int Telefono { get; set; }

        public decimal Saldo { get; set; }

        public bool EsMoroso { get; set; }


      
        public static List<ClienteCorporativo> ClientesCorporativos { get;}


        public void CalcularSaldo(int sumador)
        {
            this.Saldo = this.Saldo + sumador;
        }

        public decimal MostrarSaldo()
        {
            return this.Saldo;
        }


        public static void CargarCLientes()
        {
            //Cargo los servicios desde el archivo a la lista Servicios para que esten en memoria
            var archivoClientes = new StreamReader("ClientesCorporativos.txt");
            while (!archivoClientes.EndOfStream)
            {
                string proximaLinea = archivoClientes.ReadLine();


                string[] datosSeparados = proximaLinea.Split('|');

                var ClienteCorporativo = new ClienteCorporativo(
                    datosSeparados[0],                  //Nombre
                    int.Parse(datosSeparados[1]),       //CUIT
                    datosSeparados[2],                  //EsEncomienda
                    int.Parse(datosSeparados[3]),       //EsCorrespondencia
                    decimal.Parse(datosSeparados[4]),   //Ancho
                    bool.Parse(datosSeparados[5])       //Largo
                    ); 
               

            }
        }


    }

  /*  public decimal MostrarSaldoCuenta()
    {
        return this.CuentaAsignada.Saldo;
    }*/

    


}
