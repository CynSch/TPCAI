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
            SolicitudDeOrden.CargarSolicitudesExistentes();
            Destino.CargarDestinoExistentes();
            Origen.CargarOrigenOrdenesExistentes();
            EstadoDeOrden.CargarEstados();
            RegionMundial.CargarRegionesMundiales();
            ClienteCorporativo.CargarCLientes();
            Servicio.CargarServicios();
            RegionNacional.ListarRegiones();
            Localidad.ListarLocalidad();
            Provincia.CargarProvincias();
            Sucursal.ListarSucursales();
            Pais.ListarPaises();
        }
        public static void ActualizarArchivos()
        {
            //Llama a los metodos que sobreescriben los txt con las listas actualizadas
            SolicitudDeOrden.GrabarSolicitudesEnArchivo();
            Factura.GrabarFacturasEnArchivo();
            Pais.GrabarPaisesEnArchivo();
            Sucursal.GrabarSucursalEnArchivo();
            Destino.GrabarDestino();
            Servicio.GrabarNuevoServicioEnArchivo();
            Origen.GrabarOrigen();
            ArchivoTarifas.GrabarArchivo();
            Provincia.GrabarProvincias();
        }

        public static void CrearArchivos()
        {
            //Llama a los metodos que crean los archivos txt por primera vez con los datos hardcodeados
            RangoDePeso.CrearRangosIniciales();
            Tarifa.CrearArchivo();
            ArchivoTarifas.GrabarArchivo();
            SolicitudDeOrden.CrearArchivo();
            EstadoDeOrden.CrearArchivo();
            RegionMundial.CrearArchivo();
            ClienteCorporativo.CrearArchivo();
            Localidad.CrearArchivo();
            RegionNacional.CrearArchivo();
            Destino.CrearArchivo();
            Origen.CrearArchivo();
            Servicio.CrearArchivo();
            Sucursal.CrearArchivo();
            Factura.CrearArchivo();
            Pais.CrearArchivo();
            Provincia.CrearArchivo();
        }
    }
}
