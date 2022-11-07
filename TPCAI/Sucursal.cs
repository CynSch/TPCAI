using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPCAI
{
    internal class Sucursal
    {
        //Propiedades
        public int NroSucursal { get; private set; }
        public RegionNacional RegionNacional { get; set; }
        public string Direccion { get; set; }

        static internal List<Sucursal> TodasLasSucursales { get; set; }


        //Métodos
        internal static void ListarSucursales() //Lista las sucursales del txt
        {
            //lee las sucursales del txt

            var archivoSucursal = new StreamReader("Sucursal.txt");
            while (!archivoSucursal.EndOfStream)

            {
                string proximaLinea = archivoSucursal.ReadLine();
                string[] datosSeparados = proximaLinea.Split('|');

                var sucursal = new Sucursal();
                sucursal.NroSucursal = int.Parse(datosSeparados[0]);
                //sucursal.RegionNacional = datosSeparados[1]; VER FLOR
                sucursal.Direccion = datosSeparados[2];
            }


        }
    }
}
