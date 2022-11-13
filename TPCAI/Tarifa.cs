﻿using System;
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

        internal static decimal CalcularImporte(bool esurgente, bool escorrespondencia, decimal Peso, bool esretiroenpuerta, bool esentregaenpuerta
                 , int origencodigolocalidad, int origennrosucursal, bool esdestinonacional, int destinocodigopais, int destinocodigolocalidad)
        {
            //Calcula el importe de la solicitud y lo devuelve
            decimal importe = 0M;
            decimal importebase = 0M;
            decimal precionacional = 0M;
            decimal preciointernacional = 0M;
            decimal recargourgente = 0M;
            decimal recargoentrega = 0M;
            decimal recargoretiro = 0M;
            //1.Determino el peso
            decimal pesolimitecorrespondiente = 0;

            if(Peso > 0M && Peso <= 0.5M)
            {
                pesolimitecorrespondiente = 0.5M;
            }
            if (Peso > 0.5M && Peso <= 10M)
            {
                pesolimitecorrespondiente = 10M;
            }
            if(Peso > 10M && Peso >= 20M)
            {
                pesolimitecorrespondiente = 20M;
            }
            if(Peso > 20M && Peso >= 30M)
            {
                pesolimitecorrespondiente = 20M;
            }
            if (escorrespondencia)
            {
                RangoDePeso rangocorrespondencia = RangoDePeso.BuscarRangoPorMaximo(0.5M);
                //2.Determino la distancia a recorrer:
                if (esdestinonacional == true)
                {
                    //verifico si (origencodigolocalidad = destinocodigolocalidad)
                    if (origencodigolocalidad == destinocodigolocalidad)
                    {
                        // Entonces TipoPrecioLocal
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Local, out precionacional);
                    }
                    //Else verifico si codigo de provincia de la localidad de origen y destino son los mismos
                    else if (Localidad.BuscarProvinciaXLocalidad(origencodigolocalidad) == Localidad.BuscarProvinciaXLocalidad(destinocodigolocalidad))
                    {
                        //Entonces TipoPrecioProvincial
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Provincial, out precionacional);
                    }
                    //Else verifico si codigo de región de localidad origen y destino son los mismos
                    else if (Provincia.BuscarRegionXProvincia(Localidad.BuscarProvinciaXLocalidad(origencodigolocalidad)) == Provincia.BuscarRegionXProvincia(Localidad.BuscarProvinciaXLocalidad(destinocodigolocalidad)))
                    {
                        //Entonces TipoPrecioRegional
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Regional, out precionacional);
                    }
                    else
                    {
                        //Else TipoPrecioNacional
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Nacional, out precionacional);
                    }
                }
                else
                {
                    //Loop del nacional siendo el destino CABA. codigo de provincia de caba es 2
                    if (Localidad.BuscarProvinciaXLocalidad(origencodigolocalidad) == 2)
                    {
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Provincial, out precionacional);
                    }
                    else
                    {
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Regional, out precionacional);
                    }

                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 1)
                    {
                        //TipoPrecio PaisesLimitrofes
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Paises_limitrofes, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 2)
                    {
                        //TipoPrecio America Latina
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.America_Latina, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 3)
                    {
                        //TipoPrecio America del Norte
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.America_del_Norte, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 4)
                    {
                        //TipoPrecio Europa
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Europa, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 5)
                    {
                        //TipoPrecio Asia
                        rangocorrespondencia.PreciosxDistancia.TryGetValue(TipoPrecio.Asia, out preciointernacional);
                    }
                }
            }
            else
            {
                RangoDePeso rango = RangoDePeso.BuscarRangoPorMaximo(pesolimitecorrespondiente);
                //2.Determino la distancia a recorrer:
                if (esdestinonacional == true)
                {
                    //verifico si (origencodigolocalidad = destinocodigolocalidad)
                    if (origencodigolocalidad == destinocodigolocalidad)
                    {
                        // Entonces TipoPrecioLocal
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Local, out precionacional);
                    }
                    //Else verifico si codigo de provincia de la localidad de origen y destino son los mismos
                    else if (Localidad.BuscarProvinciaXLocalidad(origencodigolocalidad) == Localidad.BuscarProvinciaXLocalidad(destinocodigolocalidad))
                    {
                        //Entonces TipoPrecioProvincial
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Provincial, out precionacional);
                    }
                    //Else verifico si codigo de región de localidad origen y destino son los mismos
                    else if (Provincia.BuscarRegionXProvincia(Localidad.BuscarProvinciaXLocalidad(origencodigolocalidad)) == Provincia.BuscarRegionXProvincia(Localidad.BuscarProvinciaXLocalidad(destinocodigolocalidad)))
                    {
                        //Entonces TipoPrecioRegional
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Regional, out precionacional);
                    }
                    else
                    {
                        //Else TipoPrecioNacional
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Nacional, out precionacional);
                    }
                }
                else
                {
                    //Loop del nacional siendo el destino CABA. codigo de provincia de caba es 2
                    if (Localidad.BuscarProvinciaXLocalidad(origencodigolocalidad) == 2)
                    {
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Provincial, out precionacional);
                    }
                    else
                    {
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Regional, out precionacional);
                    }

                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 1)
                    {
                        //TipoPrecio PaisesLimitrofes
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Paises_limitrofes, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 2)
                    {
                        //TipoPrecio America Latina
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.America_Latina, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 3)
                    {
                        //TipoPrecio America del Norte
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.America_del_Norte, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 4)
                    {
                        //TipoPrecio Europa
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Europa, out preciointernacional);
                    }
                    if (Pais.BuscarCodigoRegionXPais(destinocodigopais) == 5)
                    {
                        //TipoPrecio Asia
                        rango.PreciosxDistancia.TryGetValue(TipoPrecio.Asia, out preciointernacional);
                    }
                    // + TipoPrecio según codigoregiónmundial
                }
            }
            //3. Con punto 1 y 2 determino importe base.
            importebase = precionacional + preciointernacional;
            //4. Si esurgente = true, entonces recargourgente = importe base * 0.5 while (recargourgente < 15000)
            if(esurgente == true)
            {
                if ((importebase / 2) > 15000)
                {
                    recargourgente = 15000M;
                }
                else
                {
                    recargourgente = importebase / 2;
                }
            }
            //5. Si esretiroendomicilio= true, entonces recargoretiroenpuerta = 3500
            if (esretiroenpuerta == true)
            {
                recargoretiro = 3500M;
            }
            //6. Si esentregaendomicilio = true, entonces recargoentregaenpuerta = 1500
            if (esentregaenpuerta == true)
            {
                recargoentrega = 1500M;
            }
            //7. Calulo importe final = importe base + recargos
            importe = importebase + recargourgente + recargoentrega + recargoretiro;
            return importe;
        }    

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
