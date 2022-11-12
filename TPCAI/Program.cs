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
            /*if ( //si existe txt en la carpeta bin/Debug
                )
            {
                ManejoDeArchivos.CargarArchivos();
            }
            else
            {
                ManejoDeArchivos.CrearArchivos();
                ManejoDeArchivos.CargarArchivos();
            }
            //Abrir login.....
            ManejoDeArchivos.ActualizarArchivos();
            */
            //Application.Run(Form_solicitud_servicio);
            
            Application.Run(new Form_LogIn());
        }
    }
}
