using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

             if (Directory.GetFiles($@"{Environment.CurrentDirectory}").Length <= 3)
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
        //NO MODIFICAR
    }
}
