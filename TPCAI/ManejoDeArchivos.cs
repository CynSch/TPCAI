using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal static class ManejoDeArchivos
    {
        public static void CargarArchivos()
        {
            //Llama a los metodos que cargan desde archivos txt a listas

            ArchivoTarifas.CargarTarifario();
            Factura.ListarFacturas();
            //Agregar metodos
        }
        public static void ActualizarArchivos()
        {
            //Llama a los metodos que sobreescriben los txt con las listas actualizadas
            
        }
        
        public static void CrearArchivos()
        {
            //Llama a los metodos que crean los archivos txt por primera vez con los datos hardcodeados
            ArchivoTarifas.GrabarArchivo();
        }
    }
}
