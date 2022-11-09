using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Servicio
    {
        public int NumeroDeOrden { get; set; }

        public int IDDeServicio { get; set; }

        public bool EsEncomienda { get; set; }

        public bool EsCorrespondencia { get; set; }

        public decimal Ancho { get; set; }  

        public decimal Largo { get; set; }  

        public decimal Alto { get; set; }  

        public decimal Peso { get; set; }  
    }
}
