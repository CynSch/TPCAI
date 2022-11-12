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

            var prov1 = new Provincia(1,"Cordoba",10);
            var prov2 = new Provincia(2, "Salta", 11);
            var prov3 = new Provincia(3, "Tucuman", 12);

            var loc1 = new Localidad(1, "Localidad de Cordoba 1",1);
            var loc2 = new Localidad(2, "Localidad de Cordoba 2", 1);
            var loc3 = new Localidad(3, "Localidad de Salta", 2);
            var loc4 = new Localidad(4, "Localidad de Tucuman", 3);

            var suc1 = new Sucursal();
            suc1.Direccion="Sucursal de Cordoba";
            suc1.CodigoDeLocalidad = 1;
            suc1.CodigoDeProvincia = 1;

            var suc2 = new Sucursal();
            suc2.Direccion = "Sucursal de Salta";
            suc2.CodigoDeLocalidad = 3;
            suc2.CodigoDeProvincia = 2;

            var suc3 = new Sucursal();
            suc3.Direccion = "Sucursal de Tucuman";
            suc3.CodigoDeLocalidad = 4;
            suc3.CodigoDeProvincia = 3;

            var p1 = new Pais();
            p1.NombreDePais = "España";
            var p2 = new Pais();
            p2.NombreDePais = "Italia";

            Pais.TodosLosPaises.Add(p1);
            Pais.TodosLosPaises.Add(p2);
            
            Sucursal.TodasLasSucursales.Add(suc1);
            Sucursal.TodasLasSucursales.Add(suc2);
            Sucursal.TodasLasSucursales.Add(suc3);

            Provincia.TodasLasProvincias.Add(prov1);
            Provincia.TodasLasProvincias.Add(prov2);
            Provincia.TodasLasProvincias.Add(prov3);

            Localidad.LstLocalidades.Add(loc1);
            Localidad.LstLocalidades.Add(loc2);
            Localidad.LstLocalidades.Add(loc3);
            Localidad.LstLocalidades.Add(loc4);

            //ClienteCorporativo.CargarCLientes();
            //Application.Run(new Form_LogIn());

            Application.Run(new Form_solicitud_servicio());
        }
    }
}
