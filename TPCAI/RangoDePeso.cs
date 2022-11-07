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

        internal static List<RangoDePeso> Rangos { get; set; }

        internal static RangoDePeso BuscarRangoPorMaximo(decimal max)
        {
            foreach (var rangoDePeso in Rangos)
            {
                if (rangoDePeso.PesoMaxKg == max)
                    return rangoDePeso;
            }
        }
    }
}
