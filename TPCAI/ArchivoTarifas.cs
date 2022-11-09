using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPCAI
{
    internal static class ArchivoTarifas
    {
        //Maneja los archivos de Tarifa, Rango de Precio y TipoPrecio     

        internal static void GrabarArchivo()
        {
            //2 archivos (tarifa y rango de pesos)
            // tarifa = RangoDePesos|RecargoUrgente|RecargoRetiroEnPuerta|RegargoEntregaEnPuerta
            //RangoDePesos = PesoMinKg|PesoMaxKg|Precios


            //Grabo la tarifa desde la lista TarifaActual en memoria al archivo
            StreamWriter writertarifa = File.CreateText("Tarifa.txt");

            // tarifa = RangoDePesos|RecargoUrgente|RecargoRetiroEnPuerta|RegargoEntregaEnPuerta
            string lineatarifa = "";
            Tarifa tarifa = new Tarifa();
            lineatarifa = tarifa.RecargoUrgente + "|" + tarifa.RecargoRetiroEnPuerta +
              "|" + tarifa.RecargoEntregaEnPuerta;
            writertarifa.WriteLine(lineatarifa);
            writertarifa.Close();

            //Grabo el rango desde la lista Rangos en memoria al archivo

            StreamWriter writerrango = File.CreateText("RangoDePeso.txt");

            //PesoMinKg|PesoMaxKg|Precios
            string linearangos = "";
            foreach (RangoDePeso rango in RangoDePeso.Rangos)
            {
                linearangos = linearangos + (rango.PesoMinKg.ToString() + "|" + rango.PesoMaxKg.ToString() + "|");
                foreach (var precio in rango.PreciosxDistancia)
                {
                    linearangos = linearangos + (precio.Value.ToString() + "|");
                }
            }
            writerrango.WriteLine(linearangos);
            writerrango.Close();
        }

        internal static void CargarTarifario()
        {
            //Cargo el rango de peso desde el archivo a memoria
            StreamReader reader = new StreamReader("RangoDePeso.txt");
            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //PesoMinKg|PesoMaxKg|Precios

                string[] datos = linea.Split('|');
                RangoDePeso rango = new RangoDePeso(decimal.Parse(datos[0]), decimal.Parse(datos[1]),
                    new Dictionary<TipoPrecio, decimal>
                    {
                        [TipoPrecio.Local] = decimal.Parse(datos[2]),
                        [TipoPrecio.Provincial] = decimal.Parse(datos[3]),
                        [TipoPrecio.Regional] = decimal.Parse(datos[4]),
                        [TipoPrecio.Nacional] = decimal.Parse(datos[5]),
                        [TipoPrecio.Paises_limitrofes] = decimal.Parse(datos[6]),
                        [TipoPrecio.America_Latina] = decimal.Parse(datos[7]),
                        [TipoPrecio.America_del_Norte] = decimal.Parse(datos[8]),
                        [TipoPrecio.Europa] = decimal.Parse(datos[9]),
                        [TipoPrecio.Asia] = decimal.Parse(datos[10]),
                    });
                RangoDePeso.Rangos.Add(rango);
            }

            //Cargo la tarifa desde el archivo a memoria
            var datostarifa = File.ReadLines("Tarifa.txt").First().Split('|');

            //RecargoUrgente|RecargoRetiroEnPuerta|RegargoEntregaEnPuerta
            Tarifa tarifa = new Tarifa()
            {
                RangoDePesos = new Dictionary<decimal, RangoDePeso>
                {
                    [0.5M] = RangoDePeso.BuscarRangoPorMaximo(0.5M),
                    [10M] = RangoDePeso.BuscarRangoPorMaximo(10M),
                    [20M] = RangoDePeso.BuscarRangoPorMaximo(20M),
                    [30M] = RangoDePeso.BuscarRangoPorMaximo(30M)
                },
                RecargoUrgente = decimal.Parse(datostarifa[0]),
                RecargoRetiroEnPuerta = decimal.Parse(datostarifa[1]),
                RecargoEntregaEnPuerta = decimal.Parse(datostarifa[2])
            };
            Tarifa.Tarifario.Add(tarifa);
        }
    }
}
