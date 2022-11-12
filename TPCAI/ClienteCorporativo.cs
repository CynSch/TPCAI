using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    internal class ClienteCorporativo
    {
        public ClienteCorporativo(string nombreCliente, long cuit, string contraseña, int telefono,double saldo,bool esMoroso)
        {
            this.NombreCliente = nombreCliente;
            this.CUIT = cuit;
            this.Contraseña = contraseña;
            this.Telefono = telefono;
            this.Saldo = saldo;
            this.EsMoroso = esMoroso;
        }



        public string NombreCliente { get; set; }

        public long CUIT { get; set; }

        public string Contraseña { get; set; }

        public int Telefono { get; set; }

        public double Saldo { get; set; }

        public bool EsMoroso { get; set; }


      
        public static List<ClienteCorporativo> LstClientesCorporativos { get;}
        public static ClienteCorporativo ClienteActual;


        public void CalcularSaldo(double sumador)
        {
            this.Saldo = this.Saldo + sumador;
        }

        public double MostrarSaldo()
        {
            return this.Saldo;
        }

        public static bool BuscarClienteCorporativo(long cuit)
        //Requiere que antes de usar este cargada la lista
        {
            foreach(var clienteCorporativo in LstClientesCorporativos)
            {
                if(clienteCorporativo.CUIT == cuit)
                {
                    ClienteCorporativo.ClienteActual = clienteCorporativo;
                    return true;
                }
            }
            
            return false;
        }


        public static void CargarCLientes()
        {
            //Cargo los clientes desde el archivo a la lista LstClientesCorporativos para que esten en memoria
            var archivoClientes = new StreamReader("ClientesCorporativos.txt");
            while (!archivoClientes.EndOfStream)
            {
                string proximaLinea = archivoClientes.ReadLine();


                string[] datosSeparados = proximaLinea.Split('|');

                var ClienteCorporativo = new ClienteCorporativo(
                    datosSeparados[0],                  //Nombre
                    long.Parse(datosSeparados[1]),       //CUIT
                    datosSeparados[2],                  //Contraseña
                    int.Parse(datosSeparados[3]),       //telefono
                    double.Parse(datosSeparados[4]),    //Saldo
                    bool.Parse(datosSeparados[5])       //Esmoroso
                    ); 
               
                LstClientesCorporativos.Add(ClienteCorporativo);

            }
        }


    }

  /*  public decimal MostrarSaldoCuenta()
    {
        return this.CuentaAsignada.Saldo;
    }*/

    


}
