using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
   public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Agregar validacion de si existe txt en la carpeta bin/Debug entonces no corre el crear archivo.
            string[] directories = new string[50];
            directories = Directory.GetDirectories($@"{Environment.CurrentDirectory}\Debug");
            if (directories.Length == 0)
            {
                ManejoDeArchivos.CrearArchivos();
                ManejoDeArchivos.CargarArchivos();
            }
            else
            {
                ManejoDeArchivos.CargarArchivos();
            }
            Application.Run(new Form_LogIn());
        }
    }
}
