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
            // Application.Run(new Form_LogIn ());
            Provincia provincia = new Provincia(1, "BuenosAires", 4);
            Provincia provincia2 = new Provincia(2, "CABA", 4);
            Provincia provincia3 = new Provincia(3, "Catamarca", 1);
            Provincia provincia4 = new Provincia(4, "Chaco", 2);
            Provincia.GrabarProvincias();
            RangoDePeso.CrearRangosIniciales();
            Tarifa tarifa = new Tarifa();
            ArchivoTarifas.GrabarArchivo();
        }
    }
}
