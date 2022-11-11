﻿using System;
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
        public Localidad Localidad { get; set; }
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
                sucursal.Localidad.CodigoDeLocalidad = int.Parse(datosSeparados[1]);
                sucursal.Direccion = datosSeparados[2];

                //agrego a lista
                Sucursal.TodasLasSucursales.Add(sucursal);
            }
        }
        public static List<Sucursal> ListarSucursalesAsociadas(int codigoDeProvincia, int codigoDeLocalidad)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            return sucursales;
        }
    }
}
