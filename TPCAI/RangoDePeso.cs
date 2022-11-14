using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class RangoDePeso
    {
        internal decimal PesoMinKg { get; set; }
        internal decimal PesoMaxKg { get; set; }
        internal Dictionary<TipoPrecio, decimal> PreciosxDistancia { get; set; }

        internal static List<RangoDePeso> Rangos = new List<RangoDePeso>();

        internal static RangoDePeso BuscarRangoPorMaximo(decimal max)
        {
            foreach (var rangoDePeso in Rangos)
            {
                if (rangoDePeso.PesoMaxKg == max)
                {
                    return rangoDePeso;
                }
            }
            return null;
        }

        public RangoDePeso(decimal pesoMinKg, decimal pesoMaxKg, Dictionary<TipoPrecio, decimal> preciosxDistancia)
        {
            PesoMinKg = pesoMinKg;
            PesoMaxKg = pesoMaxKg;
            PreciosxDistancia = preciosxDistancia;
        }

        public static string ListarRangos()
        {
            string linea = "";
            foreach (RangoDePeso rango in Rangos)
            {
                linea = linea + (rango.PesoMinKg.ToString() + "|" + rango.PesoMaxKg.ToString());
                foreach (var precio in rango.PreciosxDistancia)
                {
                    linea = linea + ("|" + precio.Value.ToString());
                }
                linea = linea + "\n";
            }
            return linea;
        }
        public RangoDePeso()
        {
        }

        internal static void CrearRangosIniciales()
        {
            //Solo le utilizó la primera vez para crear el txt con la data correcta
            RangoDePeso rango1 = new RangoDePeso(0M, 0.5M, new Dictionary<TipoPrecio, decimal>
            {
                [TipoPrecio.Local] = 350M,
                [TipoPrecio.Provincial] = 550M,
                [TipoPrecio.Regional] = 750M,
                [TipoPrecio.Nacional] = 950M,
                [TipoPrecio.Paises_limitrofes] = 1620M,
                [TipoPrecio.America_Latina] = 2900M,
                [TipoPrecio.America_del_Norte] = 5400M,
                [TipoPrecio.Europa] = 8200M,
                [TipoPrecio.Asia] = 12000M,
            });
            RangoDePeso rango2 = new RangoDePeso(0.5M, 10M, new Dictionary<TipoPrecio, decimal>
            {
                [TipoPrecio.Local] = 3500M,
                [TipoPrecio.Provincial] = 5500M,
                [TipoPrecio.Regional] = 7500M,
                [TipoPrecio.Nacional] = 9500M,
                [TipoPrecio.Paises_limitrofes] = 16200M,
                [TipoPrecio.America_Latina] = 29000M,
                [TipoPrecio.America_del_Norte] = 54000M,
                [TipoPrecio.Europa] = 82000M,
                [TipoPrecio.Asia] = 120000M,
            });
            RangoDePeso rango3 = new RangoDePeso(10M, 20M, new Dictionary<TipoPrecio, decimal>
            {
                [TipoPrecio.Local] = 4200M,
                [TipoPrecio.Provincial] = 6600M,
                [TipoPrecio.Regional] = 9000M,
                [TipoPrecio.Nacional] = 11400M,
                [TipoPrecio.Paises_limitrofes] = 19440M,
                [TipoPrecio.America_Latina] = 34800M,
                [TipoPrecio.America_del_Norte] = 648000M,
                [TipoPrecio.Europa] = 98400M,
                [TipoPrecio.Asia] = 144000M,
            });
            RangoDePeso rango4 = new RangoDePeso(20M, 30M, new Dictionary<TipoPrecio, decimal>
            {
                [TipoPrecio.Local] = 5250M,
                [TipoPrecio.Provincial] = 8250M,
                [TipoPrecio.Regional] = 11250M,
                [TipoPrecio.Nacional] = 14250M,
                [TipoPrecio.Paises_limitrofes] = 24300M,
                [TipoPrecio.America_Latina] = 43500M,
                [TipoPrecio.America_del_Norte] = 81000M,
                [TipoPrecio.Europa] = 123000M,
                [TipoPrecio.Asia] = 180000M
            });
            Rangos.Add(rango1);
            Rangos.Add(rango2);
            Rangos.Add(rango3);
            Rangos.Add(rango4);

        }
    }
}
