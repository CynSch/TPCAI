using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class ClienteCorporativo
    {
        public string NombreCliente { get; set; }

        public int Telefono { get; set; }

        public int CUIT { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }

        private CuentaCorriente CuentaAsignada { get; set}
    }

    public decimal MostrarSaldoCuenta()
    {
        return this.CuentaAsignada.Saldo;
    }
}
