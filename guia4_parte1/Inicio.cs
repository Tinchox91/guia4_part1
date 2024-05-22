using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4_parte1
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();

            Boolean salir = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Ingrese numero segun opcion deseada...");
                Console.WriteLine("1.Numeros correlativos de 1 hasta el ingresado");
                Console.WriteLine("2.Carga y suma de 10 valores");
                Console.WriteLine("3.Fabrica de perfiles");
                Console.WriteLine("4.Notas de alumnos");
                Console.WriteLine("5.Altura de personas");
                Console.WriteLine("6.Lectura de sueldos");
                Console.WriteLine("7.Terminos de la serie");
                Console.WriteLine("8.Multiplos de 8 ");
                Console.WriteLine("9.Lista de valores");
                Console.WriteLine("10.Pares e impares");
                Console.WriteLine("11.Salir");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: ejercicios.numerosCorrelativos(); Console.Clear(); break;
                    case 2: ejercicios.sumaValores() ; Console.Clear(); break;
                    case 3: ejercicios.perfiles() ; Console.Clear(); break;
                    case 4: ejercicios.notas() ; Console.Clear(); break;
                    case 5: ejercicios.alturaPromedio(); Console.Clear(); break;
                    case 6: ejercicios.lecturaSueldos() ; Console.Clear(); break;
                    case 7: ejercicios.terminosDeLaSerie(); Console.Clear(); break;
                    case 8: ejercicios.multiposDeOcho() ; Console.Clear(); break;
                    case 9: ; Console.Clear(); break;
                    case 10: ejercicios.numerosPares() ; Console.Clear(); break;
                    case 11: salir = true; break;
                    default: Console.Clear(); Console.WriteLine("numero erroneo!"); break;
                }
            } while (!salir);
        
        }
    }
    }

