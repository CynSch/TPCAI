using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    internal class Validador
    {
        public static string PedirStringNoVacia(string mensaje)
        {
            string valor;
            string mensajeDeError = "No puede ser vacío";
            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine(mensajeDeError);
                    Console.WriteLine(" ");
                }
            } while (valor == "");
            return valor;
        }
        public static long PedirLong(string mensaje, long min, long max)
        {
            long valor;
            bool valido = false;
            string mensajeDeError = "Debe ingresar un valor entre " + min + " y " + max;

            do
            {
                Console.WriteLine(mensaje);
                if (!long.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensajeDeError);
                }
                else
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine(mensajeDeError);
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);

            return valor;
        }
        public static double PedirDouble(string mensaje, double min, double max)
        {
            double valor;
            bool valido = false;
            string mensajeDeError = "Debe ingresar un valor entre " + min + " y " + max;

            do
            {
                Console.WriteLine(mensaje);
                if (!double.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensajeDeError);
                    Console.WriteLine(" ");
                }
                else
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine(mensajeDeError);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            return valor;
        }

        public static bool ChequearLong(string input, int min, int max)
        {
            long entero;

            if (long.TryParse(input, out entero))
            {
                if(entero < min|| entero > max)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
            
        }




        public static int PedirInt(string mensaje, long min, long max)
        {
            int valor;
            bool valido = false;
            string mensajeDeError = "Debe ingresar un valor entero entre " + min + " y " + max;

            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensajeDeError);
                    Console.WriteLine(" ");
                }
                else
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine(mensajeDeError);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            return valor;
        }
        public static string PedirSoN(string mensaje)
        {
            //Me aseguro de que el usuario ingrese un dato string no vacío, pero además que ingrese alguna de las dos opciones disponibles (s o n), y lo paso a mayúscula para evitar errores
            string seleccion;
            do
            {
                seleccion = PedirStringNoVacia(mensaje).ToUpper();
                if (seleccion != "S" && seleccion != "N")
                {
                    Console.WriteLine("Debe ingresar 'S' o 'N'");
                    Console.WriteLine(" ");
                }
            } while (seleccion != "S" && seleccion != "N");
            return seleccion;
        }
    }
}
