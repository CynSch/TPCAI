using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class CuentaCorrienteServiciosFacturados : Form
    {
        public CuentaCorrienteServiciosFacturados()
        {
            InitializeComponent();
        }

        public void MostrarDatos(string idfacturaseleccionada)
        {
            TxtFactura.Text = idfacturaseleccionada;

            foreach (SolicitudDeOrden orden in SolicitudDeOrden.SolicitudesExistentes)
            {
                if (orden.CUITCliente == ClienteCorporativo.ClienteActual.CUIT)
                {
                    if (orden.NumeroDeFactura == int.Parse(idfacturaseleccionada))
                    {
                        ListViewItem ordenN = new ListViewItem(orden.NumeroDeOrden.ToString()); //nro
                        ordenN.SubItems.Add(orden.Fecha.ToString()); //fecha
                        if (Destino.BuscarDestino(orden.NumeroDeOrden).EntregaEnDomicilio == true)
                        {
                            ordenN.SubItems.Add(Destino.BuscarDestino(orden.NumeroDeOrden).Direccion); //destino
                        }
                        else
                        {
                            ordenN.SubItems.Add(Destino.BuscarDestino(orden.NumeroDeOrden).NroSucursal.ToString()); //Sucursal
                        }
                        ordenN.SubItems.Add(orden.Importe.ToString());  //monto
                        lvordenesxfactura.Items.Add(ordenN);
                    }
                }
            }
            lvordenesxfactura.Sorting = SortOrder.Ascending;

            decimal importefactura = 0;
            foreach (Factura factura in Factura.FacturasExistentes)
            {
                if (factura.NroFactura == int.Parse(idfacturaseleccionada))
                {
                    importefactura = factura.Monto;
                }
            }
            TxtImporteTotal.Text = importefactura.ToString(); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            
        }

        private void lvordenesxfactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
