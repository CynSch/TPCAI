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

        internal static List<Tarifa> TarifaActual { get; set; }

        //Llamar en program la primera vez que se abre el programa.
        internal void NuevaTarifa(Dictionary<decimal, RangoDePeso> rangoDePesos, int recargoUrgente, int recargoRetiroEnPuerta, int recargoEntregaEnPuerta)
        {
            Tarifa tarifa = new Tarifa();
            this.RangoDePesos = rangoDePesos;
            this.RecargoUrgente = recargoUrgente;
            this.RecargoRetiroEnPuerta = recargoRetiroEnPuerta;
            this.RecargoEntregaEnPuerta = recargoEntregaEnPuerta;

            //Borro la tarifa preexistente y actualizo la lista con la nueva tarifa para poder luego grabar la lista en archivo
            TarifaActual.Clear();
            TarifaActual.Add(tarifa);
        }
       
        internal void CrearTarifaInicial()
        {
            //Correrla una vez para que cree el primer archivo de tarifas. Correrla una vez que el problema con el StreamWriter se arregle

            Tarifa tarifa = new Tarifa();
            this.RangoDePesos = new Dictionary<decimal, RangoDePeso>
            {
                [0.5M] = new RangoDePeso
                {
                    PesoMinKg = 0M,
                    PesoMaxKg = 0.5M,
                    PreciosxDistancia = new Dictionary<TipoPrecio, decimal>
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
                    }
                },
                [10M] = new RangoDePeso
                {
                    PesoMinKg = 0.5M,
                    PesoMaxKg = 10M,
                    PreciosxDistancia = new Dictionary<TipoPrecio, decimal>
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
                    }
                },
                [20M] = new RangoDePeso
                {
                    PesoMinKg = 10M,
                    PesoMaxKg = 20M,
                    PreciosxDistancia = new Dictionary<TipoPrecio, decimal>
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
                    }
                },
                [30M] = new RangoDePeso
                {
                    PesoMinKg = 20M,
                    PesoMaxKg = 30M,
                    PreciosxDistancia = new Dictionary<TipoPrecio, decimal>
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
                    }
                }
            };
            this.RecargoUrgente = 0.5M; //con un tope de 15000
            this.RecargoRetiroEnPuerta = 3500M;
            this.RecargoEntregaEnPuerta = 1500M;

            //Agrego la tarifa a la lista para poder despues grabar la lista a archivo
            TarifaActual.Add(tarifa);
        }

        internal static decimal CalcularImporte(bool esurgente, bool escorrespondencia, decimal Peso, bool esretiroenpuerta, bool esentregaenpuerta
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
        }

        //No es necesario un metodo mostrar tarifa (cuando deberia ser nombrado mostrar importe) ya que el Calcular Importe devuelve un decimal.
    }
}
