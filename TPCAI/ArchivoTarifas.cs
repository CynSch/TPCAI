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
            StreamWriter writertarifa = File.CreateText($@"{Environment.CurrentDirectory}\Tarifa.txt");

            // tarifa = RangoDePesos|RecargoUrgente|RecargoRetiroEnPuerta|RegargoEntregaEnPuerta
            string lineatarifa = "";
            Tarifa tarifa = new Tarifa(Tarifa.BuscarTarifa().RecargoUrgente, Tarifa.BuscarTarifa().MaximoRecargoUrgente, Tarifa.BuscarTarifa().RecargoRetiroEnPuerta, Tarifa.BuscarTarifa().RecargoEntregaEnPuerta);
            lineatarifa = tarifa.RecargoUrgente + "|" + tarifa.MaximoRecargoUrgente + '|' + tarifa.RecargoRetiroEnPuerta +
              "|" + tarifa.RecargoEntregaEnPuerta;
            writertarifa.WriteLine(lineatarifa);
            writertarifa.Close();

            //Grabo el rango desde la lista Rangos en memoria al archivo

            StreamWriter writerrango = File.CreateText($@"{Environment.CurrentDirectory}\RangoDePeso.txt");

            //PesoMinKg|PesoMaxKg|Precios
            string linearangos = "";
            foreach (RangoDePeso rango in RangoDePeso.Rangos)
            {
                linearangos = (rango.PesoMinKg.ToString() + "|" + rango.PesoMaxKg.ToString());
                foreach (var precio in rango.PreciosxDistancia)
                {
                    linearangos = linearangos + ("|" + precio.Value.ToString());
                }
                writerrango.WriteLine(linearangos);
            }
            writerrango.Close();
        }

        internal static void CargarTarifario()
        {
            //Cargo el rango de peso desde el archivo a memoria
            StreamReader reader = new StreamReader($@"{Environment.CurrentDirectory}\RangoDePeso.txt");
            if(RangoDePeso.Rangos.Count > 0)
            {
                RangoDePeso.Rangos.Clear();
            }

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
            reader.Close();

            //Cargo la tarifa desde el archivo a memoria
            var datostarifa = File.ReadLines($@"{Environment.CurrentDirectory}\Tarifa.txt").First().Split('|');

            if (Tarifa.Tarifario.Count > 0)
            {
                Tarifa.Tarifario.Clear();
            }
            //RecargoUrgente|RecargoRetiroEnPuerta|RegargoEntregaEnPuerta
            Tarifa tarifa = new Tarifa(decimal.Parse(datostarifa[0]), decimal.Parse(datostarifa[1]), decimal.Parse(datostarifa[2]),decimal.Parse(datostarifa[3]))
            {
                RangoDePesos = new Dictionary<decimal, RangoDePeso>
                {
                    [0.5M] = RangoDePeso.BuscarRangoPorMaximo(0.5M),
                    [10M] = RangoDePeso.BuscarRangoPorMaximo(10M),
                    [20M] = RangoDePeso.BuscarRangoPorMaximo(20M),
                    [30M] = RangoDePeso.BuscarRangoPorMaximo(30M)
                }
            };
            Tarifa.Tarifario.Add(tarifa);
        }
    }
}
