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

        public ClienteCorporativo() { }

        public string NombreCliente { get; set; }

        public long CUIT { get; set; }

        public string Contraseña { get; set; }

        public int Telefono { get; set; }

        public double Saldo { get; set; }

        public bool EsMoroso { get; set; }


      
        public static List<ClienteCorporativo> LstClientesCorporativos = new List<ClienteCorporativo>();

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
                    double.Parse(datosSeparados[4]),   //Saldo
                    bool.Parse(datosSeparados[5])       //Esmoroso
                    ); 
               
                LstClientesCorporativos.Add(ClienteCorporativo);

            }
        }

        internal static void CrearArchivo()
        {
            //Creo una lista para guardar las solicitudes
            List<ClienteCorporativo> ClientesACargar = new List<ClienteCorporativo>();

            var cli1 = new ClienteCorporativo();
            cli1.NombreCliente = "Julieta Gutierrez";
            cli1.CUIT = 27420744817;
            cli1.Contraseña = "1234";
            cli1.Telefono = 114441111;
            cli1.Saldo = -500;
            cli1.EsMoroso = false;

            var cli2 = new ClienteCorporativo();
            cli2.NombreCliente = "Ruben Randazzo";
            cli2.CUIT = 23949330290;
            cli2.Contraseña = "1234";
            cli2.Telefono = 114442222;
            cli2.Saldo = -80000;
            cli2.EsMoroso = true;

            var cli3 = new ClienteCorporativo();
            cli3.NombreCliente = "Belen Perez";
            cli3.CUIT = 27430742117;
            cli3.Contraseña = "1234";
            cli3.Telefono = 114443333;
            cli3.Saldo = -5500;
            cli3.EsMoroso = false;

            var cli4 = new ClienteCorporativo();
            cli4.NombreCliente = "Andres Panitsch";
            cli4.CUIT = 20111111111;
            cli4.Contraseña = "1234";
            cli4.Telefono = 114444444;
            cli4.Saldo = 0;
            cli4.EsMoroso = false;

            //Agrego las solicitudes en la lista
            ClientesACargar.Add(cli1);
            ClientesACargar.Add(cli2);
            ClientesACargar.Add(cli3);
            ClientesACargar.Add(cli4);
            

            //Paso cada item de la lista al archivo
            StreamWriter writer = File.CreateText("ClientesCorporativos.txt");
            foreach (ClienteCorporativo cli in ClientesACargar)
            {
                
                string linea = cli.NombreCliente + "|"
                    + cli.CUIT + "|"
                    + cli.Contraseña + "|" 
                    + cli.Telefono + "|"
                    + cli.Saldo + "|" 
                    + cli.EsMoroso + "|";

                writer.WriteLine(linea);
            }
            writer.Close();
        }


    }

  /*  public decimal MostrarSaldoCuenta()
    {
        return this.CuentaAsignada.Saldo;
    }*/

    


}
