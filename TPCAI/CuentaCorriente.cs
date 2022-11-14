using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class CuentaCorriente
    {
        public ClienteCorporativo ClienteAsignado { get; set; }

        public decimal Saldo { get; set; }

        public bool EsMoroso { get; set; }

        public static List<CuentaCorriente> Cuentas { get;}



        public void CalcularSaldo(int sumador)
        {
            this.Saldo = this.Saldo + sumador;
        }


        /*public static List<CuentaCorriente> ListarCLientesMorosos()
        {
            List<CuentaCorriente> morosos = new List<CuentaCorriente>();

            foreach (var c in Cuentas)
            {
                if (c)
                {
                    morosos.Add(c);
                }
            }

            return morosos;
        }*/
    }
}
