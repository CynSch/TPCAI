using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using StreamWriter writer = File.CreateText("Tarifa.txt");

            // tarifa = RangoDePesos|RecargoUrgente|RecargoRetiroEnPuerta|RegargoEntregaEnPuerta

            foreach (Tarifa tarifa in Tarifa.TarifaActual)
            {   string linea = tarifa.RangoDePesos.ToString() + "|"
                    + tarifa.RecargoUrgente.ToString() + "|"
                    + tarifa.RecargoRetiroEnPuerta.ToString() + "|"
                    + tarifa.RecargoEntregaEnPuerta.ToString();
                writer.WriteLine(linea);
            }
            //Grabo el rango desde la lista Rangos en memoria al archivo
            using StreamWriter writer = File.CreateText("RangoDePeso.txt");

            //PesoMinKg|PesoMaxKg|Precios
            foreach (RangoDePeso rango in RangoDePeso.Rangos)
            {
                string linea = rango.PesoMinKg.ToString() + "|"
                    + rango.PesoMaxKg.ToString() + "|"
                    + rango.PreciosxDistancia.ToString();
                writer.WriteLine(linea);
            }
            //No estoy muy segura de como se graban los diccionarios
        }
        internal static void CargarTarifario()
        {
            //Cargo el rango de peso desde el archivo a memoria
            foreach (var linea in File.ReadLines("RangoDePeso.txt"))

            //PesoMinKg|PesoMaxKg|Precios
            {
                string[] datos = linea.Split('|');
                RangoDePeso rango = new RangoDePeso()
                {
                    PesoMinKg = decimal.Parse(datos[0], CultureInfo.InvariantCulture),
                    PesoMaxKg = decimal.Parse(datos[1], CultureInfo.InvariantCulture),
                    PreciosxDistancia = new Dictionary<TipoPrecio, decimal>
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
                    }
                };
                RangoDePeso.Rangos.Add(rango);
            }

            //Cargo la tarifa desde el archivo a memoria
            var datostarifa = File.ReadLines("Tarifa.txt").First().Split("|");

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
                RecargoUrgente = decimal.Parse(datostarifa[0], CultureInfo.InvariantCulture),
                RecargoRetiroEnPuerta = decimal.Parse(datostarifa[1], CultureInfo.InvariantCulture),
                RecargoEntregaEnPuerta = decimal.Parse(datostarifa[2], CultureInfo.InvariantCulture)
            };

            Tarifa.TarifaActual.Add(tarifa);
        }
    }
}
