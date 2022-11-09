using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Tarifa
    {
        internal Dictionary<decimal, RangoDePeso> RangoDePesos { get; set; }
        //llave del diccionario va a ser el peso maximo
        internal decimal RecargoUrgente { get; set; }
        internal decimal RecargoRetiroEnPuerta { get; set; }
        internal decimal RecargoEntregaEnPuerta { get; set; }

        internal static List<Tarifa> Tarifario = new List<Tarifa>();

        public Tarifa()
        {
            // Usado para grabar.

            RangoDePesos = new Dictionary<decimal, RangoDePeso>
            {
                [0.5M] = RangoDePeso.BuscarRangoPorMaximo(0.5M),
                [10M] = RangoDePeso.BuscarRangoPorMaximo(10M),
                [20M] = RangoDePeso.BuscarRangoPorMaximo(20M),
                [30M] = RangoDePeso.BuscarRangoPorMaximo(0.5M)
            };
            RecargoUrgente = 0.5M; //con un tope de 15000
            RecargoRetiroEnPuerta = 3500M;
            RecargoEntregaEnPuerta = 1500M;
        }

        /*     internal static decimal CalcularImporte(bool esurgente, bool escorrespondencia, decimal Peso, bool esretiroenpuerta, bool esentregaenpuerta
                 , int origencodigolocalidad, int origennrosucursal, bool esdestinonacional, int destinocodigopais, int destinocodigolocalidad)
             {
                 //1.Determino el peso
                 //2.Determino la distancia a recorrer:
                     //Si esdestinonacional = true
                           //verifico si (origencodigolocalidad = destinocodigolocalidad)
                                 // Entonces TipoPrecioLocal
                                 //Else verifico si codigo de provincia de la localidad de origen y destino son los mismos
                                      //Entonces TipoPrecioProvincial
                                      //Else verifico si codigo de región de localidad orgine y destino son los mismos
                                          //Entonces TipoPrecioRegional
                                          //Else TipoPrecioNacional
                     //Si esdestinonacional = false
                         //Loop del nacional siendo el destino CABA
                         // + TipoPrecio según codigoregiónmundial
                 //3. Con punto 1 y 2 determino importe base.
                 //4. Si esurgente = true, entonces recargourgente = importe base * 0.5 while (recargourgente < 15000)
                 //5. Si esretiroendomicilio= true, entonces recargoretiroenpuerta = 3500
                 //6. Si esentregaendomicilio = true, entonces recargoretiroenpuerta = 1500
                 //7. Calulo importe final = importe base + recargos
             }    */

        /*  internal static string MostrarTarifa()
          {

              string lineatarifa = "";
              Tarifa tarifa = new Tarifa();
              string linearangos = "";
              string linea = "";
              foreach (var rango in tarifa.RangoDePesos)
              {
                  linearangos = linearangos + ("|" + rango.Key + "|") ;
                  foreach (var peso in tarifa.RangoDePesos.Values)
                  {
                      //da error aca
                      linearangos = linearangos + (peso.PesoMinKg + "|" + peso.PesoMaxKg + "|");
                      foreach (var precio in peso.PreciosxDistancia)
                      {
                          linearangos = linearangos + (";" + precio.Value);
                      }
                  }
              }
              lineatarifa = "|" + tarifa.RecargoUrgente + "|" + tarifa.RecargoRetiroEnPuerta +
                "|" + tarifa.RecargoEntregaEnPuerta;
              linea = linearangos + lineatarifa;
              return linea;
          }
        */
    }
}
